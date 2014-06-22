// Guids.cs
// MUST match guids.h
using System;

namespace Lost.WebLink
{
    static class GuidList
    {
        public const string guidWebLinkPkgString = "9289174b-849b-4cd7-bef4-36dc84e256bc";
        public const string guidWebLinkCmdSetString = "237b8fcf-afbc-4ea4-ba10-5561e1fb4c9e";
        public const string guidWebLinkEditorFactoryString = "8718dbd3-cbbd-4b24-a07a-8ab9de23ba8d";

        public static readonly Guid guidWebLinkCmdSet = new Guid(guidWebLinkCmdSetString);
        public static readonly Guid guidWebLinkEditorFactory = new Guid(guidWebLinkEditorFactoryString);
    };
}