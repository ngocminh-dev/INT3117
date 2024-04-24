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

namespace T18
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the T18Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("3b710448-4f5c-4489-8e9f-bc628fcfbfc1")]
    public partial class T18Repository : RepoGenBaseFolder
    {
        static T18Repository instance = new T18Repository();
        T18RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        T18RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder _logindropboxpersonalmicrosofte;

        /// <summary>
        /// Gets the singleton class instance representing the T18Repository element repository.
        /// </summary>
        [RepositoryFolder("3b710448-4f5c-4489-8e9f-bc628fcfbfc1")]
        public static T18Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public T18Repository() 
            : base("T18Repository", "/", null, 0, false, "3b710448-4f5c-4489-8e9f-bc628fcfbfc1", ".\\RepositoryImages\\T18Repository3b710448.rximgres")
        {
            _applicationundertest = new T18RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _logindropboxpersonalmicrosofte = new T18RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("3b710448-4f5c-4489-8e9f-bc628fcfbfc1")]
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
        [RepositoryFolder("37a4bcaf-deb3-4316-b276-f5a2bcaf4fe5")]
        public virtual T18RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The LoginDropboxPersonalMicrosoftE folder.
        /// </summary>
        [RepositoryFolder("d2396632-88f1-447c-8a21-5bca42306a64")]
        public virtual T18RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder LoginDropboxPersonalMicrosoftE
        {
            get { return _logindropboxpersonalmicrosofte; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class T18RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("37a4bcaf-deb3-4316-b276-f5a2bcaf4fe5")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.dropbox.com']", parentFolder, 30000, null, false, "37a4bcaf-deb3-4316-b276-f5a2bcaf4fe5", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("37a4bcaf-deb3-4316-b276-f5a2bcaf4fe5")]
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
            [RepositoryItemInfo("37a4bcaf-deb3-4316-b276-f5a2bcaf4fe5")]
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
        [RepositoryFolder("d2396632-88f1-447c-8a21-5bca42306a64")]
        public partial class LoginDropboxPersonalMicrosoftEAppFolder : RepoGenBaseFolder
        {
            T18RepositoryFolders.LoginOrRegisterPageContentFolder _loginorregisterpagecontent;
            RepoItemInfo _continueInfo;

            /// <summary>
            /// Creates a new LoginDropboxPersonalMicrosoftE  folder.
            /// </summary>
            public LoginDropboxPersonalMicrosoftEAppFolder(RepoGenBaseFolder parentFolder) :
                    base("LoginDropboxPersonalMicrosoftE", "/form[@title>'Login - Dropbox - Personal']", parentFolder, 30000, null, true, "d2396632-88f1-447c-8a21-5bca42306a64", "")
            {
                _loginorregisterpagecontent = new T18RepositoryFolders.LoginOrRegisterPageContentFolder(this);
                _continueInfo = new RepoItemInfo(this, "Continue", "container[@name>'Login - Dropbox - Microsoft']//container[@classname='BrowserView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@orientation='None' and @iscontentelement='True']/?/?/container/text[@name='Login - Dropbox']/?/?/container[@automationid='root']/container[@automationid='page-content']/container[@automationid='login-or-register-page-content']//button[@name='Continue']/?/?/text[@name='Continue']", "", 30000, null, "dec2eecd-96b4-45bd-8e7e-212eb73def4b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d2396632-88f1-447c-8a21-5bca42306a64")]
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
            [RepositoryItemInfo("d2396632-88f1-447c-8a21-5bca42306a64")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Continue item.
            /// </summary>
            [RepositoryItem("dec2eecd-96b4-45bd-8e7e-212eb73def4b")]
            public virtual Ranorex.Text Continue
            {
                get
                {
                    return _continueInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Continue item info.
            /// </summary>
            [RepositoryItemInfo("dec2eecd-96b4-45bd-8e7e-212eb73def4b")]
            public virtual RepoItemInfo ContinueInfo
            {
                get
                {
                    return _continueInfo;
                }
            }

            /// <summary>
            /// The LoginOrRegisterPageContent folder.
            /// </summary>
            [RepositoryFolder("f1af0e60-ed63-4c2f-9107-b62aa4ec566d")]
            public virtual T18RepositoryFolders.LoginOrRegisterPageContentFolder LoginOrRegisterPageContent
            {
                get { return _loginorregisterpagecontent; }
            }
        }

        /// <summary>
        /// The LoginOrRegisterPageContentFolder folder.
        /// </summary>
        [RepositoryFolder("f1af0e60-ed63-4c2f-9107-b62aa4ec566d")]
        public partial class LoginOrRegisterPageContentFolder : RepoGenBaseFolder
        {
            RepoItemInfo _rememberme21094937621880594Info;
            RepoItemInfo _loginpassword9476259452408424Info;
            RepoItemInfo _susiemail0007283273273606117Info;
            RepoItemInfo _loginInfo;
            RepoItemInfo _invalidemailorpasswordInfo;

            /// <summary>
            /// Creates a new LoginOrRegisterPageContent  folder.
            /// </summary>
            public LoginOrRegisterPageContentFolder(RepoGenBaseFolder parentFolder) :
                    base("LoginOrRegisterPageContent", "container[@name>'Login - Dropbox - Microsoft']//container[@classname='BrowserView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']//container/text[@name='Login - Dropbox']/?/?/container[@automationid='root']/container[@automationid='page-content']/container[@automationid='login-or-register-page-content']", parentFolder, 30000, null, false, "f1af0e60-ed63-4c2f-9107-b62aa4ec566d", "")
            {
                _rememberme21094937621880594Info = new RepoItemInfo(this, "RememberMe21094937621880594", ".//checkbox[@automationid~'remember_me']", "", 30000, null, "eba9be1d-154a-4a8b-bbdf-c7478d5db77b");
                _loginpassword9476259452408424Info = new RepoItemInfo(this, "LoginPassword9476259452408424", ".//container[@classname='_field-input-wrapper_4srl7_50']/text[@automationid~'login_password']", "", 30000, null, "82f382ac-c2d2-4748-8b88-f0e7a8555bcc");
                _susiemail0007283273273606117Info = new RepoItemInfo(this, "SusiEmail0007283273273606117", ".//container[@classname='_field-input-wrapper_4srl7_50']/text[@automationid~'susi_email']", "", 30000, null, "9c531d26-7137-4a28-b58b-c08086b91164");
                _loginInfo = new RepoItemInfo(this, "LogIn", ".//button[@name='Log in']/?/?/text[@name='Log in']", "", 30000, null, "746328da-c00f-44b3-bb4a-3f86971138ea");
                _invalidemailorpasswordInfo = new RepoItemInfo(this, "InvalidEmailOrPassword", ".//container/text[@name='Invalid email or password']", "", 30000, null, "1c0e4050-7e08-47f7-8ba7-aae54da1727a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f1af0e60-ed63-4c2f-9107-b62aa4ec566d")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f1af0e60-ed63-4c2f-9107-b62aa4ec566d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RememberMe21094937621880594 item.
            /// </summary>
            [RepositoryItem("eba9be1d-154a-4a8b-bbdf-c7478d5db77b")]
            public virtual Ranorex.CheckBox RememberMe21094937621880594
            {
                get
                {
                    return _rememberme21094937621880594Info.CreateAdapter<Ranorex.CheckBox>(true);
                }
            }

            /// <summary>
            /// The RememberMe21094937621880594 item info.
            /// </summary>
            [RepositoryItemInfo("eba9be1d-154a-4a8b-bbdf-c7478d5db77b")]
            public virtual RepoItemInfo RememberMe21094937621880594Info
            {
                get
                {
                    return _rememberme21094937621880594Info;
                }
            }

            /// <summary>
            /// The LoginPassword9476259452408424 item.
            /// </summary>
            [RepositoryItem("82f382ac-c2d2-4748-8b88-f0e7a8555bcc")]
            public virtual Ranorex.Text LoginPassword9476259452408424
            {
                get
                {
                    return _loginpassword9476259452408424Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LoginPassword9476259452408424 item info.
            /// </summary>
            [RepositoryItemInfo("82f382ac-c2d2-4748-8b88-f0e7a8555bcc")]
            public virtual RepoItemInfo LoginPassword9476259452408424Info
            {
                get
                {
                    return _loginpassword9476259452408424Info;
                }
            }

            /// <summary>
            /// The SusiEmail0007283273273606117 item.
            /// </summary>
            [RepositoryItem("9c531d26-7137-4a28-b58b-c08086b91164")]
            public virtual Ranorex.Text SusiEmail0007283273273606117
            {
                get
                {
                    return _susiemail0007283273273606117Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SusiEmail0007283273273606117 item info.
            /// </summary>
            [RepositoryItemInfo("9c531d26-7137-4a28-b58b-c08086b91164")]
            public virtual RepoItemInfo SusiEmail0007283273273606117Info
            {
                get
                {
                    return _susiemail0007283273273606117Info;
                }
            }

            /// <summary>
            /// The LogIn item.
            /// </summary>
            [RepositoryItem("746328da-c00f-44b3-bb4a-3f86971138ea")]
            public virtual Ranorex.Text LogIn
            {
                get
                {
                    return _loginInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LogIn item info.
            /// </summary>
            [RepositoryItemInfo("746328da-c00f-44b3-bb4a-3f86971138ea")]
            public virtual RepoItemInfo LogInInfo
            {
                get
                {
                    return _loginInfo;
                }
            }

            /// <summary>
            /// The InvalidEmailOrPassword item.
            /// </summary>
            [RepositoryItem("1c0e4050-7e08-47f7-8ba7-aae54da1727a")]
            public virtual Ranorex.Text InvalidEmailOrPassword
            {
                get
                {
                    return _invalidemailorpasswordInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The InvalidEmailOrPassword item info.
            /// </summary>
            [RepositoryItemInfo("1c0e4050-7e08-47f7-8ba7-aae54da1727a")]
            public virtual RepoItemInfo InvalidEmailOrPasswordInfo
            {
                get
                {
                    return _invalidemailorpasswordInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}