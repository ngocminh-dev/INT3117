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

namespace T8
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PasswordRequire recording.
    /// </summary>
    [TestModule("75d8bea5-1e8e-4bc8-b962-434a01a04da7", ModuleType.Recording, 1)]
    public partial class PasswordRequire : ITestModule
    {
        /// <summary>
        /// Holds an instance of the T8Repository repository.
        /// </summary>
        public static T8Repository repo = T8Repository.Instance;

        static PasswordRequire instance = new PasswordRequire();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PasswordRequire()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PasswordRequire Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.SusiEmail2945891388041464' at 58;31.", repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.SusiEmail2945891388041464Info, new RecordItemIndex(0));
            repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.SusiEmail2945891388041464.Click("58;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'aduconchoxuytbg@gmail.com' with focus on 'RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.SusiEmail2945891388041464'.", repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.SusiEmail2945891388041464Info, new RecordItemIndex(1));
            repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.SusiEmail2945891388041464.PressKeys("aduconchoxuytbg@gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.Continue' at 18;10.", repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.ContinueInfo, new RecordItemIndex(2));
            repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.Continue.Click("18;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.AgreeAndSignUp' at 78;12.", repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.AgreeAndSignUpInfo, new RecordItemIndex(3));
            repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.AgreeAndSignUp.Click("78;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Please enter a password') on item 'RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.PleaseEnterAPassword'.", repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.PleaseEnterAPasswordInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.RegisterDropboxPersonalMicrosof.SidebarContentsSplitView.PleaseEnterAPasswordInfo, "Text", "Please enter a password");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
