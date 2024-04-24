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

namespace T4._
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the T4_2Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("a0d21317-8ebb-4bed-9e29-66a9ed47224d")]
    public partial class T4_2Repository : RepoGenBaseFolder
    {
        static T4_2Repository instance = new T4_2Repository();
        T4_2RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        T4_2RepositoryFolders.FilesDropboxPersonalMicrosoftEAppFolder _filesdropboxpersonalmicrosofte;
        T4_2RepositoryFolders.OpenAppFolder _open;

        /// <summary>
        /// Gets the singleton class instance representing the T4_2Repository element repository.
        /// </summary>
        [RepositoryFolder("a0d21317-8ebb-4bed-9e29-66a9ed47224d")]
        public static T4_2Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public T4_2Repository() 
            : base("T4_2Repository", "/", null, 0, false, "a0d21317-8ebb-4bed-9e29-66a9ed47224d", ".\\RepositoryImages\\T4_2Repositorya0d21317.rximgres")
        {
            _applicationundertest = new T4_2RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _filesdropboxpersonalmicrosofte = new T4_2RepositoryFolders.FilesDropboxPersonalMicrosoftEAppFolder(this);
            _open = new T4_2RepositoryFolders.OpenAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a0d21317-8ebb-4bed-9e29-66a9ed47224d")]
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
        [RepositoryFolder("efb1e215-49a1-4703-b6d1-7823be4f81bd")]
        public virtual T4_2RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The FilesDropboxPersonalMicrosoftE folder.
        /// </summary>
        [RepositoryFolder("7328e002-1bae-415d-9591-dfd258de37bf")]
        public virtual T4_2RepositoryFolders.FilesDropboxPersonalMicrosoftEAppFolder FilesDropboxPersonalMicrosoftE
        {
            get { return _filesdropboxpersonalmicrosofte; }
        }

        /// <summary>
        /// The Open folder.
        /// </summary>
        [RepositoryFolder("bb4e7144-e7ef-4c54-8cec-2a135162bac8")]
        public virtual T4_2RepositoryFolders.OpenAppFolder Open
        {
            get { return _open; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class T4_2RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("efb1e215-49a1-4703-b6d1-7823be4f81bd")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.dropbox.com']", parentFolder, 30000, null, false, "efb1e215-49a1-4703-b6d1-7823be4f81bd", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("efb1e215-49a1-4703-b6d1-7823be4f81bd")]
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
            [RepositoryItemInfo("efb1e215-49a1-4703-b6d1-7823be4f81bd")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The FilesDropboxPersonalMicrosoftEAppFolder folder.
        /// </summary>
        [RepositoryFolder("7328e002-1bae-415d-9591-dfd258de37bf")]
        public partial class FilesDropboxPersonalMicrosoftEAppFolder : RepoGenBaseFolder
        {
            T4_2RepositoryFolders.SidebarContentsSplitViewFolder _sidebarcontentssplitview;

            /// <summary>
            /// Creates a new FilesDropboxPersonalMicrosoftE  folder.
            /// </summary>
            public FilesDropboxPersonalMicrosoftEAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FilesDropboxPersonalMicrosoftE", "/form[@title>'Files - Dropbox - Personal']", parentFolder, 30000, null, true, "7328e002-1bae-415d-9591-dfd258de37bf", "")
            {
                _sidebarcontentssplitview = new T4_2RepositoryFolders.SidebarContentsSplitViewFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7328e002-1bae-415d-9591-dfd258de37bf")]
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
            [RepositoryItemInfo("7328e002-1bae-415d-9591-dfd258de37bf")]
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
            [RepositoryFolder("9240e62b-37e9-4a82-88c6-26900cd6fa0d")]
            public virtual T4_2RepositoryFolders.SidebarContentsSplitViewFolder SidebarContentsSplitView
            {
                get { return _sidebarcontentssplitview; }
            }
        }

        /// <summary>
        /// The SidebarContentsSplitViewFolder folder.
        /// </summary>
        [RepositoryFolder("9240e62b-37e9-4a82-88c6-26900cd6fa0d")]
        public partial class SidebarContentsSplitViewFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fileInfo;
            RepoItemInfo _uploadordropInfo;
            RepoItemInfo _uploadedtoInfo;

            /// <summary>
            /// Creates a new SidebarContentsSplitView  folder.
            /// </summary>
            public SidebarContentsSplitViewFolder(RepoGenBaseFolder parentFolder) :
                    base("SidebarContentsSplitView", "container[@name>'Files - Dropbox - Microsoft']//container[@classname='BrowserView']/container[@classname='SidebarContentsSplitView']", parentFolder, 30000, null, false, "9240e62b-37e9-4a82-88c6-26900cd6fa0d", "")
            {
                _fileInfo = new RepoItemInfo(this, "File", "container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']/container[@classname='SidebarContentsSplitView']//container/text[@name='Files - Dropbox']/container[@classname='global-header--portaled']/container[@classname='dig-Layer']//menuitem[@name='File']", "", 30000, null, "791f53e1-a021-4f63-aded-9df5c9c10795");
                _uploadordropInfo = new RepoItemInfo(this, "UploadOrDrop", "container[@classname='SidebarContentsSplitView']/?/?/container[@classname='SidebarContentsSplitView']/container[@orientation='None' and @iscontentelement='True']/?/?/container/text[@name='Files - Dropbox']/container[@classname='global-header--portaled']/container[@automationid='maestro-portal']/container[@automationid='maestro-content-portal']//container[@classname='_browseActionBarWrapper_12ja8_4 _actionBarWrapper_cxckl_9 _actionBarWrapperIntersectionOnly_cxckl_36']//button[@name='Upload or Drop']", "", 30000, null, "656e1cae-ead5-4419-9574-1d4aeee5c06c");
                _uploadedtoInfo = new RepoItemInfo(this, "UploadedTo", "container[@classname='SidebarContentsSplitView']/?/?/container[@classname='SidebarContentsSplitView']//container[@automationid>'']/text[@name='Files - Dropbox']/container[@classname='global-header--portaled']/container[5]/?/?/container[@classname='_bottom-drawer-body_1a7qa_56']//text[@name='Uploaded to']", "", 30000, null, "bfd6cb88-5601-4a9e-a940-72a393be9ff2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9240e62b-37e9-4a82-88c6-26900cd6fa0d")]
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
            [RepositoryItemInfo("9240e62b-37e9-4a82-88c6-26900cd6fa0d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The File item.
            /// </summary>
            [RepositoryItem("791f53e1-a021-4f63-aded-9df5c9c10795")]
            public virtual Ranorex.MenuItem File
            {
                get
                {
                    return _fileInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The File item info.
            /// </summary>
            [RepositoryItemInfo("791f53e1-a021-4f63-aded-9df5c9c10795")]
            public virtual RepoItemInfo FileInfo
            {
                get
                {
                    return _fileInfo;
                }
            }

            /// <summary>
            /// The UploadOrDrop item.
            /// </summary>
            [RepositoryItem("656e1cae-ead5-4419-9574-1d4aeee5c06c")]
            public virtual Ranorex.Button UploadOrDrop
            {
                get
                {
                    return _uploadordropInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The UploadOrDrop item info.
            /// </summary>
            [RepositoryItemInfo("656e1cae-ead5-4419-9574-1d4aeee5c06c")]
            public virtual RepoItemInfo UploadOrDropInfo
            {
                get
                {
                    return _uploadordropInfo;
                }
            }

            /// <summary>
            /// The UploadedTo item.
            /// </summary>
            [RepositoryItem("bfd6cb88-5601-4a9e-a940-72a393be9ff2")]
            public virtual Ranorex.Text UploadedTo
            {
                get
                {
                    return _uploadedtoInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The UploadedTo item info.
            /// </summary>
            [RepositoryItemInfo("bfd6cb88-5601-4a9e-a940-72a393be9ff2")]
            public virtual RepoItemInfo UploadedToInfo
            {
                get
                {
                    return _uploadedtoInfo;
                }
            }
        }

        /// <summary>
        /// The OpenAppFolder folder.
        /// </summary>
        [RepositoryFolder("bb4e7144-e7ef-4c54-8cec-2a135162bac8")]
        public partial class OpenAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _tree100Info;
            RepoItemInfo _buttonopenInfo;
            RepoItemInfo _listitem2Info;

            /// <summary>
            /// Creates a new Open  folder.
            /// </summary>
            public OpenAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Open", "/form[@title='Open']", parentFolder, 30000, null, true, "bb4e7144-e7ef-4c54-8cec-2a135162bac8", "")
            {
                _tree100Info = new RepoItemInfo(this, "Tree100", "element[@class='DUIViewWndClassName']/container/element[1]/?/?/tree[@controlid='100']/?/?/treeitem[@text='Desktop']", ".//tree[@controlid='100']/treeitem[@text='Desktop']/treeitem[@text='Desktop']", 30000, null, "0477cf29-c245-4700-9ee8-f7cb9dca67f8");
                _buttonopenInfo = new RepoItemInfo(this, "ButtonOpen", "button[@text='&Open']", "button[@text='&Open']", 30000, null, "98fceae1-4617-42e0-95e1-539975716f3d");
                _listitem2Info = new RepoItemInfo(this, "ListItem2", "element[@class='DUIViewWndClassName']//container[@caption='ShellView']/?/?/listitem[@uiautomationvaluevalue='2102357 - Nguyen Doan Ngoc Minh']/text[@automationid='System.ItemNameDisplay' and @uiautomationvaluevalue='2102357 - Nguyen Doan Ngoc Minh']", ".//listitem[@automationid='2']/text[@automationid='System.ItemNameDisplay']", 30000, null, "def3edbc-c59f-46e6-b1ba-14e2f1d3971b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bb4e7144-e7ef-4c54-8cec-2a135162bac8")]
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
            [RepositoryItemInfo("bb4e7144-e7ef-4c54-8cec-2a135162bac8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Tree100 item.
            /// </summary>
            [RepositoryItem("0477cf29-c245-4700-9ee8-f7cb9dca67f8")]
            public virtual Ranorex.TreeItem Tree100
            {
                get
                {
                    return _tree100Info.CreateAdapter<Ranorex.TreeItem>(true);
                }
            }

            /// <summary>
            /// The Tree100 item info.
            /// </summary>
            [RepositoryItemInfo("0477cf29-c245-4700-9ee8-f7cb9dca67f8")]
            public virtual RepoItemInfo Tree100Info
            {
                get
                {
                    return _tree100Info;
                }
            }

            /// <summary>
            /// The ButtonOpen item.
            /// </summary>
            [RepositoryItem("98fceae1-4617-42e0-95e1-539975716f3d")]
            public virtual Ranorex.Button ButtonOpen
            {
                get
                {
                    return _buttonopenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOpen item info.
            /// </summary>
            [RepositoryItemInfo("98fceae1-4617-42e0-95e1-539975716f3d")]
            public virtual RepoItemInfo ButtonOpenInfo
            {
                get
                {
                    return _buttonopenInfo;
                }
            }

            /// <summary>
            /// The ListItem2 item.
            /// </summary>
            [RepositoryItem("def3edbc-c59f-46e6-b1ba-14e2f1d3971b")]
            public virtual Ranorex.Text ListItem2
            {
                get
                {
                    return _listitem2Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The ListItem2 item info.
            /// </summary>
            [RepositoryItemInfo("def3edbc-c59f-46e6-b1ba-14e2f1d3971b")]
            public virtual RepoItemInfo ListItem2Info
            {
                get
                {
                    return _listitem2Info;
                }
            }
        }

    }
#pragma warning restore 0436
}