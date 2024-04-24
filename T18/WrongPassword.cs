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

namespace T18
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The WrongPassword recording.
    /// </summary>
    [TestModule("bc1cbb13-3d64-4ea7-82e9-dbacade53786", ModuleType.Recording, 1)]
    public partial class WrongPassword : ITestModule
    {
        /// <summary>
        /// Holds an instance of the T18Repository repository.
        /// </summary>
        public static T18Repository repo = T18Repository.Instance;

        static WrongPassword instance = new WrongPassword();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WrongPassword()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WrongPassword Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail0007283273273606117' at 105;24.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail0007283273273606117Info, new RecordItemIndex(0));
            repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail0007283273273606117.Click("105;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'aduconchoxuytbg123@gmail.com' with focus on 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail0007283273273606117'.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail0007283273273606117Info, new RecordItemIndex(1));
            repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail0007283273273606117.PressKeys("aduconchoxuytbg123@gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.Continue' at 34;14.", repo.LoginDropboxPersonalMicrosoftE.ContinueInfo, new RecordItemIndex(2));
            repo.LoginDropboxPersonalMicrosoftE.Continue.Click("34;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.RememberMe21094937621880594' at 14;13.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.RememberMe21094937621880594Info, new RecordItemIndex(3));
            repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.RememberMe21094937621880594.Click("14;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LoginPassword9476259452408424' at 44;27.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LoginPassword9476259452408424Info, new RecordItemIndex(4));
            repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LoginPassword9476259452408424.Click("44;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'hehehe' with focus on 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LoginPassword9476259452408424'.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LoginPassword9476259452408424Info, new RecordItemIndex(5));
            repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LoginPassword9476259452408424.PressKeys("hehehe");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LogIn' at 22;10.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LogInInfo, new RecordItemIndex(6));
            repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.LogIn.Click("22;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Invalid email or password') on item 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.InvalidEmailOrPassword'.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.InvalidEmailOrPasswordInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.InvalidEmailOrPasswordInfo, "Text", "Invalid email or password");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
