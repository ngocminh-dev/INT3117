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

namespace T7
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the T7Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("bbe44d9e-f611-440c-8fc6-2baab7fb867f")]
    public partial class T7Repository : RepoGenBaseFolder
    {
        static T7Repository instance = new T7Repository();
        T7RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        T7RepositoryFolders.RegisterDropboxPersonalMicrosofAppFolder _registerdropboxpersonalmicrosof;
        T7RepositoryFolders.SignInWithAppleIDPersonalMicroAppFolder _signinwithappleidpersonalmicro;

        /// <summary>
        /// Gets the singleton class instance representing the T7Repository element repository.
        /// </summary>
        [RepositoryFolder("bbe44d9e-f611-440c-8fc6-2baab7fb867f")]
        public static T7Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public T7Repository() 
            : base("T7Repository", "/", null, 0, false, "bbe44d9e-f611-440c-8fc6-2baab7fb867f", ".\\RepositoryImages\\T7Repositorybbe44d9e.rximgres")
        {
            _applicationundertest = new T7RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _registerdropboxpersonalmicrosof = new T7RepositoryFolders.RegisterDropboxPersonalMicrosofAppFolder(this);
            _signinwithappleidpersonalmicro = new T7RepositoryFolders.SignInWithAppleIDPersonalMicroAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("bbe44d9e-f611-440c-8fc6-2baab7fb867f")]
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
        [RepositoryFolder("47adacf9-db03-485e-9f89-4ff1997c933e")]
        public virtual T7RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The RegisterDropboxPersonalMicrosof folder.
        /// </summary>
        [RepositoryFolder("031f97fa-a9af-4a9e-a9c2-1c6e7bdcf08b")]
        public virtual T7RepositoryFolders.RegisterDropboxPersonalMicrosofAppFolder RegisterDropboxPersonalMicrosof
        {
            get { return _registerdropboxpersonalmicrosof; }
        }

        /// <summary>
        /// The SignInWithAppleIDPersonalMicro folder.
        /// </summary>
        [RepositoryFolder("33485f1c-7cb6-469d-9c5f-9d902537556b")]
        public virtual T7RepositoryFolders.SignInWithAppleIDPersonalMicroAppFolder SignInWithAppleIDPersonalMicro
        {
            get { return _signinwithappleidpersonalmicro; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class T7RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("47adacf9-db03-485e-9f89-4ff1997c933e")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.dropbox.com']", parentFolder, 30000, null, false, "47adacf9-db03-485e-9f89-4ff1997c933e", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("47adacf9-db03-485e-9f89-4ff1997c933e")]
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
            [RepositoryItemInfo("47adacf9-db03-485e-9f89-4ff1997c933e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The RegisterDropboxPersonalMicrosofAppFolder folder.
        /// </summary>
        [RepositoryFolder("031f97fa-a9af-4a9e-a9c2-1c6e7bdcf08b")]
        public partial class RegisterDropboxPersonalMicrosofAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _continuewithappleInfo;

            /// <summary>
            /// Creates a new RegisterDropboxPersonalMicrosof  folder.
            /// </summary>
            public RegisterDropboxPersonalMicrosofAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RegisterDropboxPersonalMicrosof", "/form[@title>'Register - Dropbox - Personal']", parentFolder, 30000, null, true, "031f97fa-a9af-4a9e-a9c2-1c6e7bdcf08b", "")
            {
                _continuewithappleInfo = new RepoItemInfo(this, "ContinueWithApple", "container[@name>'Register - Dropbox - Microsoft']//container[@classname='BrowserView']/container[@classname='SidebarContentsSplitView']//container/text[@name='Register - Dropbox']/?/?/container[@automationid='root']/container[@automationid='page-content']/container[@automationid='login-or-register-page-content']/?/?/button[@name='Continue with Apple']", "", 30000, null, "26616112-82b6-4541-82d1-c3d8dfaf2492");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("031f97fa-a9af-4a9e-a9c2-1c6e7bdcf08b")]
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
            [RepositoryItemInfo("031f97fa-a9af-4a9e-a9c2-1c6e7bdcf08b")]
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
            [RepositoryItem("26616112-82b6-4541-82d1-c3d8dfaf2492")]
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
            [RepositoryItemInfo("26616112-82b6-4541-82d1-c3d8dfaf2492")]
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
        [RepositoryFolder("33485f1c-7cb6-469d-9c5f-9d902537556b")]
        public partial class SignInWithAppleIDPersonalMicroAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _useyourappleidtosignintodropboxInfo;

            /// <summary>
            /// Creates a new SignInWithAppleIDPersonalMicro  folder.
            /// </summary>
            public SignInWithAppleIDPersonalMicroAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SignInWithAppleIDPersonalMicro", "/form[@title>'Sign in with Apple ID - Personal']", parentFolder, 30000, null, true, "33485f1c-7cb6-469d-9c5f-9d902537556b", "")
            {
                _useyourappleidtosignintodropboxInfo = new RepoItemInfo(this, "UseYourAppleIDToSignInToDropbox", "container[@name>'Sign in with Apple ID - Microsoft']//container/?/?/container[@classname='tk-body']/container[@automationid='content']/container[@automationid='signin']//container[@automationid='step']/container[@automationid='stepEl']/container[@automationid='signin']/text[@name>'Use your Apple ID to sign']/text[@name>'Use your Apple ID to sign']", "", 30000, null, "fe072800-9f01-4b73-a303-2469996946d0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("33485f1c-7cb6-469d-9c5f-9d902537556b")]
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
            [RepositoryItemInfo("33485f1c-7cb6-469d-9c5f-9d902537556b")]
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
            [RepositoryItem("fe072800-9f01-4b73-a303-2469996946d0")]
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
            [RepositoryItemInfo("fe072800-9f01-4b73-a303-2469996946d0")]
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
