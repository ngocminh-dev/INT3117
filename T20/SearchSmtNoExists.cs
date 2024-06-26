﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace T20
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SearchSmtNoExists recording.
    /// </summary>
    [TestModule("7f5a57f6-0700-4f34-bfd9-98433f9499ca", ModuleType.Recording, 1)]
    public partial class SearchSmtNoExists : ITestModule
    {
        /// <summary>
        /// Holds an instance of the T20Repository repository.
        /// </summary>
        public static T20Repository repo = T20Repository.Instance;

        static SearchSmtNoExists instance = new SearchSmtNoExists();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchSmtNoExists()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchSmtNoExists Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FilesDropboxPersonalMicrosoftE.SearchInFolderDropbox' at 50;9.", repo.FilesDropboxPersonalMicrosoftE.SearchInFolderDropboxInfo, new RecordItemIndex(0));
            repo.FilesDropboxPersonalMicrosoftE.SearchInFolderDropbox.Click("50;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SearchResultsDropboxPersonalMi.SearchInFolderDropbox' at 55;13.", repo.SearchResultsDropboxPersonalMi.SearchInFolderDropboxInfo, new RecordItemIndex(1));
            repo.SearchResultsDropboxPersonalMi.SearchInFolderDropbox.Click("55;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'xyz' with focus on 'SearchResultsDropboxPersonalMi.SearchInFolderDropbox'.", repo.SearchResultsDropboxPersonalMi.SearchInFolderDropboxInfo, new RecordItemIndex(2));
            repo.SearchResultsDropboxPersonalMi.SearchInFolderDropbox.PressKeys("xyz");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SearchResultsDropboxPersonalMi.SearchInFolderDropbox'.", repo.SearchResultsDropboxPersonalMi.SearchInFolderDropboxInfo, new RecordItemIndex(3));
            repo.SearchResultsDropboxPersonalMi.SearchInFolderDropbox.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='No results found') on item 'SearchResultsDropboxPersonalMi.NoResultsFound'.", repo.SearchResultsDropboxPersonalMi.NoResultsFoundInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.SearchResultsDropboxPersonalMi.NoResultsFoundInfo, "Text", "No results found");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
