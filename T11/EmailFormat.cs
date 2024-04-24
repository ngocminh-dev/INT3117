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

namespace T11
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EmailFormat recording.
    /// </summary>
    [TestModule("51fcba89-dee7-44e9-a7a3-f4019484f685", ModuleType.Recording, 1)]
    public partial class EmailFormat : ITestModule
    {
        /// <summary>
        /// Holds an instance of the T11Repository repository.
        /// </summary>
        public static T11Repository repo = T11Repository.Instance;

        static EmailFormat instance = new EmailFormat();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EmailFormat()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EmailFormat Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail7963721265662178' at 81;26.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail7963721265662178Info, new RecordItemIndex(0));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail7963721265662178.Click("81;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ajskdgjsdgajsk2@@ashdsa.com' with focus on 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail7963721265662178'.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail7963721265662178Info, new RecordItemIndex(1));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.SusiEmail7963721265662178.PressKeys("ajskdgjsdgajsk2@@ashdsa.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.Continue' at 24;11.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.ContinueInfo, new RecordItemIndex(2));
            repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.Continue.Click("24;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.AnEmailAddressMustContainASingleA'.", repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.AnEmailAddressMustContainASingleAInfo, new RecordItemIndex(3));
            Validate.Exists(repo.LoginDropboxPersonalMicrosoftE.SidebarContentsSplitView.AnEmailAddressMustContainASingleAInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
