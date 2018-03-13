namespace DRP.Find_Changeset_By_Comment
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.ContainingCommentText = new System.Windows.Forms.TextBox();
            this.ContainingCommentLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ByUserText = new System.Windows.Forms.TextBox();
            this.ByUserLabel = new System.Windows.Forms.Label();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.ContainingFileLabel = new System.Windows.Forms.Label();
            this.ContainingFileText = new System.Windows.Forms.TextBox();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.useRegularExpressions = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelFindButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.ChangesetsAndFiles = new System.Windows.Forms.TabControl();
            this.ChangesetList = new System.Windows.Forms.TabPage();
            this.ResultsList = new System.Windows.Forms.ListView();
            this.ChangesetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OwnerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileList = new System.Windows.Forms.TabPage();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.FindChangesetsWorker = new System.ComponentModel.BackgroundWorker();
            this.OptionsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ChangesetsAndFiles.SuspendLayout();
            this.ChangesetList.SuspendLayout();
            this.FileList.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainingCommentText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ContainingCommentText, 2);
            this.ContainingCommentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainingCommentText.Location = new System.Drawing.Point(3, 123);
            this.ContainingCommentText.Name = "ContainingCommentText";
            this.ContainingCommentText.Size = new System.Drawing.Size(684, 20);
            this.ContainingCommentText.TabIndex = 9;
            // 
            // ContainingCommentLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ContainingCommentLabel, 2);
            this.ContainingCommentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainingCommentLabel.Location = new System.Drawing.Point(3, 96);
            this.ContainingCommentLabel.Name = "ContainingCommentLabel";
            this.ContainingCommentLabel.Size = new System.Drawing.Size(684, 24);
            this.ContainingCommentLabel.TabIndex = 8;
            this.ContainingCommentLabel.Text = "Containing comment:";
            this.ContainingCommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(617, 430);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(98, 29);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ByUserText
            // 
            this.ByUserText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ByUserText.Location = new System.Drawing.Point(348, 27);
            this.ByUserText.Name = "ByUserText";
            this.ByUserText.Size = new System.Drawing.Size(339, 20);
            this.ByUserText.TabIndex = 3;
            // 
            // ByUserLabel
            // 
            this.ByUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ByUserLabel.Location = new System.Drawing.Point(348, 0);
            this.ByUserLabel.Name = "ByUserLabel";
            this.ByUserLabel.Size = new System.Drawing.Size(339, 24);
            this.ByUserLabel.TabIndex = 2;
            this.ByUserLabel.Text = "By user:";
            this.ByUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.OptionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(703, 202);
            this.OptionsGroupBox.TabIndex = 0;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Find options";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ToDatePicker, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ToDateLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FromDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ContainingCommentText, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ContainingFileLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ByUserLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContainingCommentLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ContainingFileText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ByUserText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FromDatePicker, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.useRegularExpressions, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Checked = false;
            this.ToDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToDatePicker.Location = new System.Drawing.Point(348, 75);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.ShowCheckBox = true;
            this.ToDatePicker.Size = new System.Drawing.Size(339, 20);
            this.ToDatePicker.TabIndex = 7;
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToDateLabel.Location = new System.Drawing.Point(348, 48);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(339, 24);
            this.ToDateLabel.TabIndex = 6;
            this.ToDateLabel.Text = "To date:";
            this.ToDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromDateLabel.Location = new System.Drawing.Point(3, 48);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(339, 24);
            this.FromDateLabel.TabIndex = 4;
            this.FromDateLabel.Text = "From date:";
            this.FromDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContainingFileLabel
            // 
            this.ContainingFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainingFileLabel.Location = new System.Drawing.Point(3, 0);
            this.ContainingFileLabel.Name = "ContainingFileLabel";
            this.ContainingFileLabel.Size = new System.Drawing.Size(339, 24);
            this.ContainingFileLabel.TabIndex = 0;
            this.ContainingFileLabel.Text = "Containing file:";
            this.ContainingFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContainingFileText
            // 
            this.ContainingFileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainingFileText.Location = new System.Drawing.Point(3, 27);
            this.ContainingFileText.Name = "ContainingFileText";
            this.ContainingFileText.Size = new System.Drawing.Size(339, 20);
            this.ContainingFileText.TabIndex = 1;
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromDatePicker.Location = new System.Drawing.Point(3, 75);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.ShowCheckBox = true;
            this.FromDatePicker.Size = new System.Drawing.Size(339, 20);
            this.FromDatePicker.TabIndex = 5;
            // 
            // useRegularExpressions
            // 
            this.useRegularExpressions.AutoSize = true;
            this.useRegularExpressions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useRegularExpressions.Location = new System.Drawing.Point(3, 147);
            this.useRegularExpressions.Name = "useRegularExpressions";
            this.useRegularExpressions.Size = new System.Drawing.Size(339, 26);
            this.useRegularExpressions.TabIndex = 10;
            this.useRegularExpressions.Text = "Use regular expressions";
            this.useRegularExpressions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelFindButton);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(345, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 32);
            this.panel1.TabIndex = 11;
            // 
            // CancelFindButton
            // 
            this.CancelFindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelFindButton.Location = new System.Drawing.Point(140, 2);
            this.CancelFindButton.Name = "CancelFindButton";
            this.CancelFindButton.Size = new System.Drawing.Size(98, 26);
            this.CancelFindButton.TabIndex = 15;
            this.CancelFindButton.Text = "C&ancel";
            this.CancelFindButton.UseVisualStyleBackColor = true;
            this.CancelFindButton.Click += new System.EventHandler(this.CancelFindButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.Location = new System.Drawing.Point(244, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(98, 26);
            this.FindButton.TabIndex = 14;
            this.FindButton.Text = "&Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ChangesetsAndFiles
            // 
            this.ChangesetsAndFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangesetsAndFiles.Controls.Add(this.ChangesetList);
            this.ChangesetsAndFiles.Controls.Add(this.FileList);
            this.ChangesetsAndFiles.Location = new System.Drawing.Point(12, 220);
            this.ChangesetsAndFiles.Name = "ChangesetsAndFiles";
            this.ChangesetsAndFiles.SelectedIndex = 0;
            this.ChangesetsAndFiles.Size = new System.Drawing.Size(703, 204);
            this.ChangesetsAndFiles.TabIndex = 1;
            // 
            // ChangesetList
            // 
            this.ChangesetList.Controls.Add(this.ResultsList);
            this.ChangesetList.Location = new System.Drawing.Point(4, 22);
            this.ChangesetList.Name = "ChangesetList";
            this.ChangesetList.Padding = new System.Windows.Forms.Padding(3);
            this.ChangesetList.Size = new System.Drawing.Size(695, 178);
            this.ChangesetList.TabIndex = 0;
            this.ChangesetList.Text = "Changesets";
            this.ChangesetList.UseVisualStyleBackColor = true;
            // 
            // ResultsList
            // 
            this.ResultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChangesetColumn,
            this.OwnerColumn,
            this.DateColumn,
            this.CommentColumn});
            this.ResultsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsList.FullRowSelect = true;
            this.ResultsList.Location = new System.Drawing.Point(3, 3);
            this.ResultsList.Name = "ResultsList";
            this.ResultsList.Size = new System.Drawing.Size(689, 172);
            this.ResultsList.TabIndex = 3;
            this.ResultsList.UseCompatibleStateImageBehavior = false;
            this.ResultsList.View = System.Windows.Forms.View.Details;
            this.ResultsList.DoubleClick += new System.EventHandler(this.ResultsList_DoubleClick);
            this.ResultsList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ResultsList_KeyUp);
            // 
            // ChangesetColumn
            // 
            this.ChangesetColumn.Text = "Changeset";
            this.ChangesetColumn.Width = 80;
            // 
            // OwnerColumn
            // 
            this.OwnerColumn.Text = "Owner";
            this.OwnerColumn.Width = 120;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.Width = 90;
            // 
            // CommentColumn
            // 
            this.CommentColumn.Text = "Comment";
            this.CommentColumn.Width = 390;
            // 
            // FileList
            // 
            this.FileList.Controls.Add(this.FilesList);
            this.FileList.Location = new System.Drawing.Point(4, 22);
            this.FileList.Name = "FileList";
            this.FileList.Padding = new System.Windows.Forms.Padding(3);
            this.FileList.Size = new System.Drawing.Size(695, 178);
            this.FileList.TabIndex = 1;
            this.FileList.Text = "Files";
            this.FileList.UseVisualStyleBackColor = true;
            // 
            // FilesList
            // 
            this.FilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesList.FormattingEnabled = true;
            this.FilesList.Location = new System.Drawing.Point(3, 3);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(689, 172);
            this.FilesList.Sorted = true;
            this.FilesList.TabIndex = 0;
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyButton.Location = new System.Drawing.Point(12, 430);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(98, 29);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "&Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // FindChangesetsWorker
            // 
            this.FindChangesetsWorker.WorkerReportsProgress = true;
            this.FindChangesetsWorker.WorkerSupportsCancellation = true;
            this.FindChangesetsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FindChangesetsWorker_DoWork);
            this.FindChangesetsWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.FindChangesetsWorker_ProgressChanged);
            this.FindChangesetsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FindChangesetsWorker_RunWorkerCompleted);
            // 
            // FindForm
            // 
            this.AcceptButton = this.FindButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(727, 471);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ChangesetsAndFiles);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OptionsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Changeset By Comment";
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.OptionsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ChangesetsAndFiles.ResumeLayout(false);
            this.ChangesetList.ResumeLayout(false);
            this.FileList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ContainingCommentText;
        private System.Windows.Forms.Label ContainingCommentLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox ByUserText;
        private System.Windows.Forms.Label ByUserLabel;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.TextBox ContainingFileText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label ContainingFileLabel;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.CheckBox useRegularExpressions;
        private System.Windows.Forms.TabControl ChangesetsAndFiles;
        private System.Windows.Forms.TabPage ChangesetList;
        private System.Windows.Forms.ListView ResultsList;
        private System.Windows.Forms.ColumnHeader ChangesetColumn;
        private System.Windows.Forms.ColumnHeader OwnerColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader CommentColumn;
        private System.Windows.Forms.TabPage FileList;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.Button CopyButton;
        private System.ComponentModel.BackgroundWorker FindChangesetsWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelFindButton;
        private System.Windows.Forms.Button FindButton;
    }
}