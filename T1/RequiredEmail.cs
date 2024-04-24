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

namespace T1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RequiredEmail recording.
    /// </summary>
    [TestModule("c4f27ac0-93ee-4621-8ea1-81c897aeffce", ModuleType.Recording, 1)]
    public partial class RequiredEmail : ITestModule
    {
        /// <summary>
        /// Holds an instance of the T1Repository repository.
        /// </summary>
        public static T1Repository repo = T1Repository.Instance;

        static RequiredEmail instance = new RequiredEmail();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RequiredEmail()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RequiredEmail Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RegisterDropboxPersonalMicrosof.Continue' at 29;15.", repo.RegisterDropboxPersonalMicrosof.ContinueInfo, new RecordItemIndex(0));
            repo.RegisterDropboxPersonalMicrosof.Continue.Click("29;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Please enter an email address') on item 'RegisterDropboxPersonalMicrosof.PleaseEnterAnEmailAddress'.", repo.RegisterDropboxPersonalMicrosof.PleaseEnterAnEmailAddressInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.RegisterDropboxPersonalMicrosof.PleaseEnterAnEmailAddressInfo, "Text", "Please enter an email address");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}