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

namespace Test13
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RemoveSpace recording.
    /// </summary>
    [TestModule("fe271144-79ad-48fd-a711-e1ef8bcda9f2", ModuleType.Recording, 1)]
    public partial class RemoveSpace : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test13Repository repository.
        /// </summary>
        public static Test13Repository repo = Test13Repository.Instance;

        static RemoveSpace instance = new RemoveSpace();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RemoveSpace()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RemoveSpace Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail6693943736291585' at 37;33.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail6693943736291585Info, new RecordItemIndex(0));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail6693943736291585.Click("37;33");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '                   aduconchoxuytbg123@gmail.com                                ' with focus on 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail6693943736291585'.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail6693943736291585Info, new RecordItemIndex(1));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail6693943736291585.PressKeys("                   aduconchoxuytbg123@gmail.com                                ");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.Continue' at 37;13.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.ContinueInfo, new RecordItemIndex(2));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.Continue.Click("37;13");
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