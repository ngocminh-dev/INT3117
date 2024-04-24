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

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Username recording.
    /// </summary>
    [TestModule("dc41649b-ad1d-4da4-9768-557f5764cb58", ModuleType.Recording, 1)]
    public partial class Username : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static Username instance = new Username();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Username()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Username Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail9930172465765765' at 128;22.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail9930172465765765Info, new RecordItemIndex(0));
            repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail9930172465765765.Click("128;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'aduconchoxuytbg123@gmail.com' with focus on 'LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail9930172465765765'.", repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail9930172465765765Info, new RecordItemIndex(1));
            repo.LoginDropboxPersonalMicrosoftE.LoginOrRegisterPageContent.SusiEmail9930172465765765.PressKeys("aduconchoxuytbg123@gmail.com");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}