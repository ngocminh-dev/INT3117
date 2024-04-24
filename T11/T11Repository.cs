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

namespace T11
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the T11Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("e0444a16-1bc9-4edc-8ce8-0fcd45636f2e")]
    public partial class T11Repository : RepoGenBaseFolder
    {
        static T11Repository instance = new T11Repository();
        T11RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        T11RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder _logindropboxpersonalmicrosofte;

        /// <summary>
        /// Gets the singleton class instance representing the T11Repository element repository.
        /// </summary>
        [RepositoryFolder("e0444a16-1bc9-4edc-8ce8-0fcd45636f2e")]
        public static T11Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public T11Repository() 
            : base("T11Repository", "/", null, 0, false, "e0444a16-1bc9-4edc-8ce8-0fcd45636f2e", ".\\RepositoryImages\\T11Repositorye0444a16.rximgres")
        {
            _applicationundertest = new T11RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _logindropboxpersonalmicrosofte = new T11RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e0444a16-1bc9-4edc-8ce8-0fcd45636f2e")]
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
        [RepositoryFolder("faa321c1-60cc-4e2a-8d4f-00b2df4c8d5e")]
        public virtual T11RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The LoginDropboxPersonalMicrosoftE folder.
        /// </summary>
        [RepositoryFolder("b23dd2ef-e496-423a-9aff-682dd24b3b1a")]
        public virtual T11RepositoryFolders.LoginDropboxPersonalMicrosoftEAppFolder LoginDropboxPersonalMicrosoftE
        {
            get { return _logindropboxpersonalmicrosofte; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class T11RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("faa321c1-60cc-4e2a-8d4f-00b2df4c8d5e")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.dropbox.com']", parentFolder, 30000, null, false, "faa321c1-60cc-4e2a-8d4f-00b2df4c8d5e", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("faa321c1-60cc-4e2a-8d4f-00b2df4c8d5e")]
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
            [RepositoryItemInfo("faa321c1-60cc-4e2a-8d4f-00b2df4c8d5e")]
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
        [RepositoryFolder("b23dd2ef-e496-423a-9aff-682dd24b3b1a")]
        public partial class LoginDropboxPersonalMicrosoftEAppFolder : RepoGenBaseFolder
        {
            T11RepositoryFolders.SidebarContentsSplitViewFolder _sidebarcontentssplitview;

            /// <summary>
            /// Creates a new LoginDropboxPersonalMicrosoftE  folder.
            /// </summary>
            public LoginDropboxPersonalMicrosoftEAppFolder(RepoGenBaseFolder parentFolder) :
                    base("LoginDropboxPersonalMicrosoftE", "/form[@title>'Login - Dropbox - Personal']", parentFolder, 30000, null, true, "b23dd2ef-e496-423a-9aff-682dd24b3b1a", "")
            {
                _sidebarcontentssplitview = new T11RepositoryFolders.SidebarContentsSplitViewFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b23dd2ef-e496-423a-9aff-682dd24b3b1a")]
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
            [RepositoryItemInfo("b23dd2ef-e496-423a-9aff-682dd24b3b1a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SidebarContentsSplitView folder.
            /// </summary>
            [RepositoryFolder("43c4d784-277c-441b-9d96-e7f194cfbc2a")]
            public virtual T11RepositoryFolders.SidebarContentsSplitViewFolder SidebarContentsSplitView
            {
                get { return _sidebarcontentssplitview; }
            }
        }

        /// <summary>
        /// The SidebarContentsSplitViewFolder folder.
        /// </summary>
        [RepositoryFolder("43c4d784-277c-441b-9d96-e7f194cfbc2a")]
        public partial class SidebarContentsSplitViewFolder : RepoGenBaseFolder
        {
            RepoItemInfo _anemailaddressmustcontainasingleaInfo;
            RepoItemInfo _susiemail7963721265662178Info;
            RepoItemInfo _continueInfo;

            /// <summary>
            /// Creates a new SidebarContentsSplitView  folder.
            /// </summary>
            public SidebarContentsSplitViewFolder(RepoGenBaseFolder parentFolder) :
                    base("SidebarContentsSplitView", "container[@name>'Login - Dropbox - Microsoft']//container[@classname='BrowserView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']", parentFolder, 30000, null, false, "43c4d784-277c-441b-9d96-e7f194cfbc2a", "")
            {
                _anemailaddressmustcontainasingleaInfo = new RepoItemInfo(this, "AnEmailAddressMustContainASingleA", ".//container/text[@name='Login - Dropbox']/?/?/container[@automationid='root']/container[@automationid='page-content']/container[@automationid='login-or-register-page-content']//container/text[@name>'']", "", 30000, null, "52adeeee-3944-4446-b8df-90796cfb5bd9");
                _susiemail7963721265662178Info = new RepoItemInfo(this, "SusiEmail7963721265662178", ".//container/text[@name='Login - Dropbox']/?/?/container[@automationid='root']/container[@automationid='page-content']/container[@automationid='login-or-register-page-content']//container[@classname='_field-input-wrapper_4srl7_50']/text[@automationid~'susi_email']", "", 30000, null, "c4130c15-322d-4d5b-a985-415de5a33704");
                _continueInfo = new RepoItemInfo(this, "Continue", "container[@classname='SplitWindowContainerView']/?/?/container/text[@name='Login - Dropbox']/?/?/container[@automationid='root']/container[@automationid='page-content']/container[@automationid='login-or-register-page-content']//button[@name='Continue']/?/?/text[@name='Continue']", "", 30000, null, "4c50796b-c5a7-44a2-ac38-8e239474dbe4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("43c4d784-277c-441b-9d96-e7f194cfbc2a")]
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
            [RepositoryItemInfo("43c4d784-277c-441b-9d96-e7f194cfbc2a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AnEmailAddressMustContainASingleA item.
            /// </summary>
            [RepositoryItem("52adeeee-3944-4446-b8df-90796cfb5bd9")]
            public virtual Ranorex.Text AnEmailAddressMustContainASingleA
            {
                get
                {
                    return _anemailaddressmustcontainasingleaInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AnEmailAddressMustContainASingleA item info.
            /// </summary>
            [RepositoryItemInfo("52adeeee-3944-4446-b8df-90796cfb5bd9")]
            public virtual RepoItemInfo AnEmailAddressMustContainASingleAInfo
            {
                get
                {
                    return _anemailaddressmustcontainasingleaInfo;
                }
            }

            /// <summary>
            /// The SusiEmail7963721265662178 item.
            /// </summary>
            [RepositoryItem("c4130c15-322d-4d5b-a985-415de5a33704")]
            public virtual Ranorex.Text SusiEmail7963721265662178
            {
                get
                {
                    return _susiemail7963721265662178Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SusiEmail7963721265662178 item info.
            /// </summary>
            [RepositoryItemInfo("c4130c15-322d-4d5b-a985-415de5a33704")]
            public virtual RepoItemInfo SusiEmail7963721265662178Info
            {
                get
                {
                    return _susiemail7963721265662178Info;
                }
            }

            /// <summary>
            /// The Continue item.
            /// </summary>
            [RepositoryItem("4c50796b-c5a7-44a2-ac38-8e239474dbe4")]
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
            [RepositoryItemInfo("4c50796b-c5a7-44a2-ac38-8e239474dbe4")]
            public virtual RepoItemInfo ContinueInfo
            {
                get
                {
                    return _continueInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
