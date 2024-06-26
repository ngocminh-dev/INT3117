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

namespace T14
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EmailExists recording.
    /// </summary>
    [TestModule("3731ae30-5f3e-4222-b70a-a0a38b7d13a1", ModuleType.Recording, 1)]
    public partial class EmailExists : ITestModule
    {
        /// <summary>
        /// Holds an instance of the T14Repository repository.
        /// </summary>
        public static T14Repository repo = T14Repository.Instance;

        static EmailExists instance = new EmailExists();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EmailExists()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EmailExists Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail06620637371151306' at 117;21.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail06620637371151306Info, new RecordItemIndex(0));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail06620637371151306.Click("117;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'aduconchoxuytbg123{RShiftKey down}@{RShiftKey up}gmail.com' with focus on 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail06620637371151306'.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail06620637371151306Info, new RecordItemIndex(1));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail06620637371151306.PressKeys("aduconchoxuytbg123{RShiftKey down}@{RShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.Continue' at 39;10.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.ContinueInfo, new RecordItemIndex(2));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.Continue.Click("39;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Welcome back') on item 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.WelcomeBack'.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.WelcomeBackInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.WelcomeBackInfo, "Text", "Welcome back");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
