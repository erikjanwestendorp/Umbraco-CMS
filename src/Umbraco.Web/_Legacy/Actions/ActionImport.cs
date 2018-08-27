﻿namespace Umbraco.Web._Legacy.Actions
{
    /// <summary>
    /// This action is invoked when importing a document type
    /// </summary>
    public class ActionImport : IAction
    {
        //create singleton
#pragma warning disable 612,618
        private static readonly ActionImport m_instance = new ActionImport();
#pragma warning restore 612,618

        public static ActionImport Instance
        {
            get { return m_instance; }
        }

        #region IAction Members

        public char Letter
        {
            get
            {
                return '8';
            }
        }

        public string JsFunctionName
        {
            get
            {
                return "";
            }
        }

        public string JsSource
        {
            get
            {
                return null;
            }
        }

        public string Alias
        {
            get
            {
                return "importDocumentType";
            }
        }

        public string Icon
        {
            get
            {
                return "page-up";
            }
        }

        public bool ShowInNotifier
        {
            get
            {
                return false;
            }
        }
        public bool CanBePermissionAssigned
        {
            get
            {
                return false;
            }
        }

        #endregion
    }
}
