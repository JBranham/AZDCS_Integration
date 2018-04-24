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

namespace AZDS_VSTS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the AZDS_VSTSRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("188e596b-8e1d-4ad4-b6da-af78bc02a84c")]
    public partial class AZDS_VSTSRepository : RepoGenBaseFolder
    {
        static AZDS_VSTSRepository instance = new AZDS_VSTSRepository();
        AZDS_VSTSRepositoryFolders.RanorexVIPDatabaseTestWebApplicatioAppFolder _ranorexvipdatabasetestwebapplicatio;

        /// <summary>
        /// Gets the singleton class instance representing the AZDS_VSTSRepository element repository.
        /// </summary>
        [RepositoryFolder("188e596b-8e1d-4ad4-b6da-af78bc02a84c")]
        public static AZDS_VSTSRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AZDS_VSTSRepository() 
            : base("AZDS_VSTSRepository", "/", null, 0, false, "188e596b-8e1d-4ad4-b6da-af78bc02a84c", ".\\RepositoryImages\\AZDS_VSTSRepository188e596b.rximgres")
        {
            _ranorexvipdatabasetestwebapplicatio = new AZDS_VSTSRepositoryFolders.RanorexVIPDatabaseTestWebApplicatioAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("188e596b-8e1d-4ad4-b6da-af78bc02a84c")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RanorexVIPDatabaseTestWebApplicatio folder.
        /// </summary>
        [RepositoryFolder("89488c0d-5084-4481-b250-10147c305653")]
        public virtual AZDS_VSTSRepositoryFolders.RanorexVIPDatabaseTestWebApplicatioAppFolder RanorexVIPDatabaseTestWebApplicatio
        {
            get { return _ranorexvipdatabasetestwebapplicatio; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class AZDS_VSTSRepositoryFolders
    {
        /// <summary>
        /// The RanorexVIPDatabaseTestWebApplicatioAppFolder folder.
        /// </summary>
        [RepositoryFolder("89488c0d-5084-4481-b250-10147c305653")]
        public partial class RanorexVIPDatabaseTestWebApplicatioAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _musicInfo;
            RepoItemInfo _genderInfo;
            RepoItemInfo _inputtagaddInfo;
            RepoItemInfo _countInfo;
            RepoItemInfo _clearInfo;

            /// <summary>
            /// Creates a new RanorexVIPDatabaseTestWebApplicatio  folder.
            /// </summary>
            public RanorexVIPDatabaseTestWebApplicatioAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RanorexVIPDatabaseTestWebApplicatio", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "89488c0d-5084-4481-b250-10147c305653", "")
            {
                _firstnameInfo = new RepoItemInfo(this, "FirstName", ".//input[#'FirstName']", 30000, null, "5ee8e2b6-9889-49a3-8f8b-08afbe0c21b0");
                _lastnameInfo = new RepoItemInfo(this, "LastName", ".//input[#'LastName']", 30000, null, "fdf52878-9f39-4dec-8259-df0432edcfd4");
                _musicInfo = new RepoItemInfo(this, "Music", ".//select[#'Category']/option[@value='Music']", 30000, null, "eaf3d75c-bd73-460a-8262-a3bdfca8e76d");
                _genderInfo = new RepoItemInfo(this, "Gender", ".//td[#'gender']/table//input[@name='Gender' and @type='radio' and @value='male']", 30000, null, "a9ddf925-caa0-4bce-84c5-521ad7eac8a7");
                _inputtagaddInfo = new RepoItemInfo(this, "InputTagAdd", ".//input[#'Add']", 30000, null, "02f6bb0c-2020-460c-977a-a84508b5b3be");
                _countInfo = new RepoItemInfo(this, "Count", ".//td[#'count']", 30000, null, "5c854de2-ddaf-4802-a135-b346ff573c3e");
                _clearInfo = new RepoItemInfo(this, "Clear", ".//input[#'Clear']", 30000, null, "7ebc3435-4a8d-4907-b468-49e6917cedc0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("89488c0d-5084-4481-b250-10147c305653")]
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
            [RepositoryItemInfo("89488c0d-5084-4481-b250-10147c305653")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("5ee8e2b6-9889-49a3-8f8b-08afbe0c21b0")]
            public virtual Ranorex.InputTag FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("5ee8e2b6-9889-49a3-8f8b-08afbe0c21b0")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The LastName item.
            /// </summary>
            [RepositoryItem("fdf52878-9f39-4dec-8259-df0432edcfd4")]
            public virtual Ranorex.InputTag LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("fdf52878-9f39-4dec-8259-df0432edcfd4")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The Music item.
            /// </summary>
            [RepositoryItem("eaf3d75c-bd73-460a-8262-a3bdfca8e76d")]
            public virtual Ranorex.OptionTag Music
            {
                get
                {
                    return _musicInfo.CreateAdapter<Ranorex.OptionTag>(true);
                }
            }

            /// <summary>
            /// The Music item info.
            /// </summary>
            [RepositoryItemInfo("eaf3d75c-bd73-460a-8262-a3bdfca8e76d")]
            public virtual RepoItemInfo MusicInfo
            {
                get
                {
                    return _musicInfo;
                }
            }

            /// <summary>
            /// The Gender item.
            /// </summary>
            [RepositoryItem("a9ddf925-caa0-4bce-84c5-521ad7eac8a7")]
            public virtual Ranorex.InputTag Gender
            {
                get
                {
                    return _genderInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Gender item info.
            /// </summary>
            [RepositoryItemInfo("a9ddf925-caa0-4bce-84c5-521ad7eac8a7")]
            public virtual RepoItemInfo GenderInfo
            {
                get
                {
                    return _genderInfo;
                }
            }

            /// <summary>
            /// The InputTagAdd item.
            /// </summary>
            [RepositoryItem("02f6bb0c-2020-460c-977a-a84508b5b3be")]
            public virtual Ranorex.InputTag InputTagAdd
            {
                get
                {
                    return _inputtagaddInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagAdd item info.
            /// </summary>
            [RepositoryItemInfo("02f6bb0c-2020-460c-977a-a84508b5b3be")]
            public virtual RepoItemInfo InputTagAddInfo
            {
                get
                {
                    return _inputtagaddInfo;
                }
            }

            /// <summary>
            /// The Count item.
            /// </summary>
            [RepositoryItem("5c854de2-ddaf-4802-a135-b346ff573c3e")]
            public virtual Ranorex.TdTag Count
            {
                get
                {
                    return _countInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The Count item info.
            /// </summary>
            [RepositoryItemInfo("5c854de2-ddaf-4802-a135-b346ff573c3e")]
            public virtual RepoItemInfo CountInfo
            {
                get
                {
                    return _countInfo;
                }
            }

            /// <summary>
            /// The Clear item.
            /// </summary>
            [RepositoryItem("7ebc3435-4a8d-4907-b468-49e6917cedc0")]
            public virtual Ranorex.InputTag Clear
            {
                get
                {
                    return _clearInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Clear item info.
            /// </summary>
            [RepositoryItemInfo("7ebc3435-4a8d-4907-b468-49e6917cedc0")]
            public virtual RepoItemInfo ClearInfo
            {
                get
                {
                    return _clearInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}