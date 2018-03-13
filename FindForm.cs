namespace DRP.Find_Changeset_By_Comment
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using EnvDTE80;
    using Microsoft.TeamFoundation.VersionControl.Client;
    using Microsoft.VisualStudio.Shell.Interop;
    using Microsoft.VisualStudio.TeamFoundation.VersionControl;

    public partial class FindForm : Form
    {
        /// <summary>
        /// The search criteria
        /// </summary>
        private SearchCriteria searchCriteria = new SearchCriteria();

        /// <summary>
        /// The version control server which will be used to find history
        /// </summary>
        private VersionControlServer versionControlServer = null;

        /// <summary>
        /// The version control ext
        /// </summary>
        private VersionControlExt versionControlExt = null;

        /// <summary>
        /// The list of changesets returned from the search
        /// </summary>
        private List<Changeset> changes = new List<Changeset>();

        /// <summary>
        /// The list of affected files
        /// </summary>
        private List<string> files = new List<string>();

        /// <summary>
        /// The UI shell interface
        /// </summary>
        public IVsUIShell UiShell = null;

        /// <summary>
        /// The main automation object
        /// </summary>
        public DTE2 AutomationObject = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FindForm"/> class.
        /// </summary>
        public FindForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindForm"/> class.
        /// </summary>
        /// <param name="automationObject">The automation object.</param>
        public FindForm(DTE2 automationObject) : this()
        {
            this.AutomationObject = automationObject;
            this.versionControlExt = (VersionControlExt)this.AutomationObject.GetObject("Microsoft.VisualStudio.TeamFoundation.VersionControl.VersionControlExt");
            this.versionControlServer = this.versionControlExt.Explorer.Workspace.VersionControlServer;
            this.ContainingFileText.Text = this.versionControlExt.Explorer.CurrentFolderItem.SourceServerPath;
            this.FromDatePicker.Value = DateTime.Now - new TimeSpan(28, 0, 0, 0);
            this.ToDatePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Handles the Click event of the FindButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            // Check that we have a folder to search
            if (string.IsNullOrWhiteSpace(this.ContainingFileText.Text))
            {
                MessageBox.Show("Please specify a source control folder to search", "Find Changeset By Comment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Check that we have a valid regular expression
            if (this.useRegularExpressions.Checked && !string.IsNullOrWhiteSpace(this.ContainingCommentText.Text))
            {
                try
                {
                    Regex rx = new Regex(this.ContainingCommentText.Text);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please specify a valid regular expression", "Find Changeset By Comment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            this.searchCriteria.SearchFile = this.ContainingFileText.Text.Trim();
            this.searchCriteria.SearchUser = this.ByUserText.Text;
            this.searchCriteria.FromDateVersion = this.FromDatePicker.Checked ? new DateVersionSpec(this.FromDatePicker.Value) : null;
            this.searchCriteria.ToDateVersion = this.ToDatePicker.Checked ? new DateVersionSpec(this.ToDatePicker.Value) : null;
            this.searchCriteria.SearchComment = this.ContainingCommentText.Text;
            this.searchCriteria.UseRegex = this.useRegularExpressions.Checked;
            this.ResultsList.Items.Clear();
            this.FilesList.Items.Clear();
            this.FindButton.Enabled = false;
            this.FindChangesetsWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Handles the Click event of the CloseButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the DoubleClick event of the ResultsList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ResultsList_DoubleClick(object sender, EventArgs e)
        {
            if (this.ResultsList.SelectedItems.Count == 0)
            {
                return;
            }

            foreach (Changeset changeset in this.changes)
            {
                if (changeset.ChangesetId.ToString() == this.ResultsList.SelectedItems[0].Text)
                {
                    this.versionControlExt.ViewChangesetDetails(changeset.ChangesetId);
                    break;
                }
            }
        }

        /// <summary>
        /// Handles the Load event of the FindForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FindForm_Load(object sender, EventArgs e)
        {
            // Do any initiailization here
        }

        /// <summary>
        /// Handles the Click event of the CopyButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CopyButton_Click(object sender, EventArgs e)
        {
            StringBuilder clipboardText = new StringBuilder();
            if (this.ChangesetsAndFiles.SelectedTab == this.ChangesetList)
            {
                // Copy list of changesets
                foreach (Changeset changeset in this.changes)
                {
                    clipboardText.AppendLine(string.Format("{0}\t{1}\t{2}\t{3}", changeset.ChangesetId, changeset.Owner, changeset.CreationDate, changeset.Comment));
                }
            }
            else
            {
                // Copy list of files
                foreach (string listItem in this.FilesList.Items)
                {
                    clipboardText.AppendLine(listItem);
                }
            }

            if (clipboardText != null)
            {
                Clipboard.SetText(clipboardText.ToString());
            }
            else
            {
                MessageBox.Show("No results to copy.", "Find Changeset By Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the DoWork event of the FindChangesetsWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
        private void FindChangesetsWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Start looking for changesets
            e.Result = this.FindChangesetsByComment(bw, this.searchCriteria);

            // If the operation was canceled by the user, 
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the FindChangesetsWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void FindChangesetsWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled", "Find Changeset By Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                // Check for zero things found
                if (this.changes.Count == 0)
                {
                    MessageBox.Show("No changesets found matching the search criteria", "Find Changeset By Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.FindButton.Enabled = true;
        }

        /// <summary>
        /// Finds the changesets by comment.
        /// </summary>
        /// <param name="bw">The background worker.</param>
        /// <param name="sc">The search criteria.</param>
        /// <returns>An error code</returns>
        private int FindChangesetsByComment(BackgroundWorker bw, SearchCriteria sc)
        {
            this.changes.Clear();
            this.files.Clear();
            try
            {
                IEnumerable changesets = this.versionControlServer.QueryHistory(
                    sc.SearchFile,
                    VersionSpec.Latest,
                    0,
                    RecursionType.Full,
                    string.IsNullOrWhiteSpace(sc.SearchUser) ? null : sc.SearchUser,
                    sc.FromDateVersion,
                    sc.ToDateVersion,
                    Int32.MaxValue,
                    true,
                    false);
                foreach (Changeset changeset in changesets)
                {
                    if (bw.CancellationPending)
                    {
                        break;
                    }

                    if (string.IsNullOrWhiteSpace(sc.SearchComment) ||
                        (!sc.UseRegex && changeset.Comment.IndexOf(sc.SearchComment.Trim(), StringComparison.CurrentCultureIgnoreCase) != -1) ||
                        (sc.UseRegex && Regex.IsMatch(changeset.Comment, sc.SearchComment)))
                    {
                        this.changes.Add(changeset);
                        bw.ReportProgress(0, changeset);
                        foreach (Change change in changeset.Changes)
                        {
                            if (!this.files.Contains(change.Item.ServerItem))
                            {
                                this.files.Add(change.Item.ServerItem);
                                bw.ReportProgress(0, change.Item.ServerItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Changeset By Comment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }

            return 0;
        }

        /// <summary>
        /// Handles the Click event of the CancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CancelFindButton_Click(object sender, EventArgs e)
        {
            if (this.FindChangesetsWorker.IsBusy)
            {
                this.FindChangesetsWorker.CancelAsync();
            }
        }

        /// <summary>
        /// Handles the ProgressChanged event of the FindChangesetsWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.ProgressChangedEventArgs"/> instance containing the event data.</param>
        private void FindChangesetsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is Changeset)
            {
                Changeset changeset = e.UserState as Changeset;
                this.ResultsList.Items.Add(new ListViewItem(new string[] { changeset.ChangesetId.ToString(), changeset.Owner, changeset.CreationDate.ToString(), changeset.Comment }));
            }
            else
            {
                string file = e.UserState as string;
                this.FilesList.Items.Add(file);
            }
        }

        /// <summary>
        /// The search criteria for finding changesets
        /// </summary>
        private class SearchCriteria
        {
            /// <summary>
            /// Gets or sets the file/folder to search
            /// </summary>
            public string SearchFile
            {
                get;
                set;
            }

            /// <summary>
            /// Gets or sets the user who made the change
            /// </summary>
            public string SearchUser
            {
                get;
                set;
            }

            /// <summary>
            /// Gets or sets the start date
            /// </summary>
            public DateVersionSpec FromDateVersion
            {
                get;
                set;
            }

            /// <summary>
            /// Gets or sets the end date
            /// </summary>
            public DateVersionSpec ToDateVersion
            {
                get;
                set;
            }

            /// <summary>
            /// Gets or sets the comment that we're searching for
            /// </summary>
            public string SearchComment
            {
                get;
                set;
            }

            /// <summary>
            /// Gets or sets a value indicating whether we are using regular expressions
            /// </summary>
            public bool UseRegex
            {
                get;
                set;
            }
        }

        /// <summary>
        /// Handles the KeyUp event of the ResultsList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        private void ResultsList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                this.ResultsList_DoubleClick(sender, null);
            }
        }
    }
}
