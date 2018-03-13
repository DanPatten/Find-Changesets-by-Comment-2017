// Guids.cs
// MUST match guids.h
using System;

namespace DRP.Find_Changeset_By_Comment
{
    static class GuidList
    {
        public const string guidFind_Changeset_By_CommentPkgString = "25ac1559-f44d-4bce-96f5-c72e64641553";
        public const string guidFind_Changeset_By_CommentCmdSetString = "534a73b3-154d-449a-8737-54ddb29e1ff1";

        public static readonly Guid guidFind_Changeset_By_CommentCmdSet = new Guid(guidFind_Changeset_By_CommentCmdSetString);
    };
}