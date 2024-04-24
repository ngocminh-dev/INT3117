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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace T17
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the T17Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("038f7f96-fa4f-4df2-a07d-a7dc7844dc55")]
    public partial class T17Repository : RepoGenBaseFolder
    {
        static T17Repository instance = new T17Repository();
        T17RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        T17RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder _logindropboxpersonalmicrosofte;
        T17RepositoryFolders.SignInWithAppleIDPersonalMicroAppFolder _signinwithappleidpersonalmicro;

        /// <summary>
        /// Gets the singleton class instance representing the T17Repository element repository.
        /// </summary>
        [RepositoryFolder("038f7f96-fa4f-4df2-a07d-a7dc7844dc55")]
        public static T17Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public T17Repository() 
            : base("T17Repository", "/", null, 0, false, "038f7f96-fa4f-4df2-a07d-a7dc7844dc55", ".\\RepositoryImages\\T17Repository038f7f96.rximgres")
        {
            _applicationundertest = new T17RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _logindropboxpersonalmicrosofte = new T17RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder(this);
            _signinwithappleidpersonalmicro = new T17RepositoryFolders.SignInWithAppleIDPersonalMicroAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("038f7f96-fa4f-4df2-a07d-a7dc7844dc55")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("d2cd6ec7-95c8-468f-9612-5b7ec8133dcb")]
        public virtual T17RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The LoginDropboxPersonalMicrosoftE folder.
        /// </summary>
        [RepositoryFolder("abf77bd2-982f-404c-be22-38beab3c7794")]
        public virtual T17RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder LoginDropboxPersonalMicrosoftE
        {
            get { return _logindropboxpersonalmicrosofte; }
        }

        /// <summary>
        /// The SignInWithAppleIDPersonalMicro folder.
        /// </summary>
        [RepositoryFolder("76c3e27b-f3eb-4d7b-b620-a4739cf67590")]
        public virtual T17RepositoryFolders.SignInWithAppleIDPersonalMicroAppFolder SignInWithAppleIDPersonalMicro
        {
            get { return _signinwithappleidpersonalmicro; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class T17RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("d2cd6ec7-95c8-468f-9612-5b7ec8133dcb")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.dropbox.com']", parentFolder, 30000, null, false, "d2cd6ec7-95c8-468f-9612-5b7ec8133dcb", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d2cd6ec7-95c8-468f-9612-5b7ec8133dcb")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d2cd6ec7-95c8-468f-9612-5b7ec8133dcb")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The LoginDropboxPersonalMicrosoftEAppFolder folder.
        /// </summary>
        [RepositoryFolder("abf77bd2-982f-404c-be22-38beab3c7794")]
        public partial class LoginDropboxPersonalMicrosoftEAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _continuewithappleInfo;

            /// <summary>
            /// Creates a new LoginDropboxPersonalMicrosoftE  folder.
            /// </summary>
            public LoginDropboxPersonalMicrosoftEAppFolder(RepoGenBaseFolder parentFolder) :
                    base("LoginDropboxPersonalMicrosoftE", "/form[@title>'Login - Dropbox - Personal']", parentFolder, 30000, null, true, "abf77bd2-982f-404c-be22-38beab3c7794", "")
            {
                _continuewithappleInfo = new RepoItemInfo(this, "ContinueWithApple", "container[@name>'Login - Dropbox - Microsoft']//container[@classname='BrowserView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']//container/text[@name='Login - Dropbox']/?/?/container[@automationid='root']/container[@automationid='page-content']/container[@automationid='login-or-register-page-content']//button[@name='Continue with Apple']", "", 30000, null, "e60b4894-0b15-452b-8b78-6a42b365c7ec");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("abf77bd2-982f-404c-be22-38beab3c7794")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("abf77bd2-982f-404c-be22-38beab3c7794")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ContinueWithApple item.
            /// </summary>
            [RepositoryItem("e60b4894-0b15-452b-8b78-6a42b365c7ec")]
            public virtual Ranorex.Button ContinueWithApple
            {
                get
                {
                    return _continuewithappleInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ContinueWithApple item info.
            /// </summary>
            [RepositoryItemInfo("e60b4894-0b15-452b-8b78-6a42b365c7ec")]
            public virtual RepoItemInfo ContinueWithAppleInfo
            {
                get
                {
                    return _continuewithappleInfo;
                }
            }
        }

        /// <summary>
        /// The SignInWithAppleIDPersonalMicroAppFolder folder.
        /// </summary>
        [RepositoryFolder("76c3e27b-f3eb-4d7b-b620-a4739cf67590")]
        public partial class SignInWithAppleIDPersonalMicroAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _useyourappleidtosignintodropboxInfo;

            /// <summary>
            /// Creates a new SignInWithAppleIDPersonalMicro  folder.
            /// </summary>
            public SignInWithAppleIDPersonalMicroAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SignInWithAppleIDPersonalMicro", "/form[@title>'Sign in with Apple ID - Personal']", parentFolder, 30000, null, true, "76c3e27b-f3eb-4d7b-b620-a4739cf67590", "")
            {
                _useyourappleidtosignintodropboxInfo = new RepoItemInfo(this, "UseYourAppleIDToSignInToDropbox", "container[@name>'Sign in with Apple ID - Microsoft']//container/?/?/container[@classname='tk-body']/container[@automationid='content']/container[@automationid='signin']//container[@automationid='step']/container[@automationid='stepEl']/container[@automationid='signin']/text[@name>'Use your Apple ID to sign']/text[@name>'Use your Apple ID to sign']", "", 30000, null, "03f53265-aa9c-4d4d-b52f-6638ee0d594f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("76c3e27b-f3eb-4d7b-b620-a4739cf67590")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("76c3e27b-f3eb-4d7b-b620-a4739cf67590")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The UseYourAppleIDToSignInToDropbox item.
            /// </summary>
            [RepositoryItem("03f53265-aa9c-4d4d-b52f-6638ee0d594f")]
            public virtual Ranorex.Text UseYourAppleIDToSignInToDropbox
            {
                get
                {
                    return _useyourappleidtosignintodropboxInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The UseYourAppleIDToSignInToDropbox item info.
            /// </summary>
            [RepositoryItemInfo("03f53265-aa9c-4d4d-b52f-6638ee0d594f")]
            public virtual RepoItemInfo UseYourAppleIDToSignInToDropboxInfo
            {
                get
                {
                    return _useyourappleidtosignintodropboxInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}