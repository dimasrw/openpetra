/* Auto generated with nant generateORM
 * Do not modify this file manually!
 */
/*************************************************************************
 *
 * DO NOT REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * @Authors:
 *       auto generated
 *
 * Copyright 2004-2009 by OM International
 *
 * This file is part of OpenPetra.org.
 *
 * OpenPetra.org is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * OpenPetra.org is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with OpenPetra.org.  If not, see <http://www.gnu.org/licenses/>.
 *
 ************************************************************************/
namespace Ict.Petra.Shared.MPartner.Mailroom.Data.Access
{
    using System;
    using System.Collections.Specialized;
    using System.Data;
    using System.Data.Odbc;
    using Ict.Common;
    using Ict.Common.DB;
    using Ict.Common.Verification;
    using Ict.Common.Data;
    using Ict.Petra.Shared;
    using Ict.Petra.Shared.MPartner.Mailroom.Data;
    using Ict.Petra.Shared.MSysMan.Data;
    using Ict.Petra.Shared.MPartner.Partner.Data;
    using Ict.Petra.Shared.MCommon.Data;

    /// Master file for extracts.  Contains names for the extract id
    public class MExtractMasterAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "MExtractMaster";

        /// original table name in database
        public const string DBTABLENAME = "m_extract_master";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master")
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out MExtractMasterTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out MExtractMasterTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out MExtractMasterTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master WHERE m_extract_id_i = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AExtractId, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AExtractId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AExtractId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractMasterTable AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AExtractId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractMasterTable AData, Int32 AExtractId, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AExtractId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractMasterTable AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AExtractId, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master")
                            + GenerateWhereClause(MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, MExtractMasterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, MExtractMasterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractMasterTable AData, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractMasterTable AData, MExtractMasterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractMasterTable AData, MExtractMasterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractMasterTable AData, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_master", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(Int32 AExtractId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_master WHERE m_extract_id_i = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract_master" + GenerateWhereClause(MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaSUser(DataSet ADataSet, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AUserId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master WHERE m_manual_mod_by_c = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSUser(DataSet AData, String AUserId, TDBTransaction ATransaction)
        {
            LoadViaSUser(AData, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(DataSet AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUser(AData, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(out MExtractMasterTable AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSUser(FillDataSet, AUserId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSUser(out MExtractMasterTable AData, String AUserId, TDBTransaction ATransaction)
        {
            LoadViaSUser(out AData, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(out MExtractMasterTable AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUser(out AData, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet ADataSet, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_m_extract_master", AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master, PUB_s_user WHERE " +
                            "PUB_m_extract_master.m_manual_mod_by_c = PUB_s_user.s_user_id_c")
                            + GenerateWhereClauseLong("PUB_s_user", SUserTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet AData, SUserRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet AData, SUserRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out MExtractMasterTable AData, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSUserTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out MExtractMasterTable AData, SUserRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out MExtractMasterTable AData, SUserRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out MExtractMasterTable AData, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaSUser(String AUserId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AUserId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_master WHERE m_manual_mod_by_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSUserTemplate(SUserRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract_master, PUB_s_user WHERE " +
                "PUB_m_extract_master.m_manual_mod_by_c = PUB_s_user.s_user_id_c" + GenerateWhereClauseLong("PUB_s_user", SUserTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, SUserTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaMExtractType(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master WHERE m_extract_type_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaMExtractType(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaMExtractType(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractType(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractType(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractType(out MExtractMasterTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadViaMExtractType(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaMExtractType(out MExtractMasterTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaMExtractType(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractType(out MExtractMasterTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractType(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractTypeTemplate(DataSet ADataSet, MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_m_extract_master", AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master, PUB_m_extract_type WHERE " +
                            "PUB_m_extract_master.m_extract_type_code_c = PUB_m_extract_type.m_code_c")
                            + GenerateWhereClauseLong("PUB_m_extract_type", MExtractTypeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaMExtractTypeTemplate(DataSet AData, MExtractTypeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaMExtractTypeTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractTypeTemplate(DataSet AData, MExtractTypeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractTypeTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractTypeTemplate(out MExtractMasterTable AData, MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadViaMExtractTypeTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaMExtractTypeTemplate(out MExtractMasterTable AData, MExtractTypeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaMExtractTypeTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractTypeTemplate(out MExtractMasterTable AData, MExtractTypeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractTypeTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractTypeTemplate(out MExtractMasterTable AData, MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractTypeTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaMExtractType(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_master WHERE m_extract_type_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaMExtractTypeTemplate(MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract_master, PUB_m_extract_type WHERE " +
                "PUB_m_extract_master.m_extract_type_code_c = PUB_m_extract_type.m_code_c" + GenerateWhereClauseLong("PUB_m_extract_type", MExtractTypeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, MExtractTypeTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaSGroup(DataSet ADataSet, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AGroupId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(AUnitKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_m_extract_master", AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master, PUB_s_group_extract WHERE " +
                            "PUB_s_group_extract.m_extract_id_i = PUB_m_extract_master.m_extract_id_i AND PUB_s_group_extract.s_group_id_c = ? AND PUB_s_group_extract.s_group_unit_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroup(DataSet AData, String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            LoadViaSGroup(AData, AGroupId, AUnitKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(DataSet AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroup(AData, AGroupId, AUnitKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(out MExtractMasterTable AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroup(FillDataSet, AGroupId, AUnitKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroup(out MExtractMasterTable AData, String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            LoadViaSGroup(out AData, AGroupId, AUnitKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(out MExtractMasterTable AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroup(out AData, AGroupId, AUnitKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet ADataSet, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_m_extract_master", AFieldList, new string[] {
                            "m_extract_id_i"}) + " FROM PUB_m_extract_master, PUB_s_group_extract, PUB_s_group WHERE " +
                            "PUB_s_group_extract.m_extract_id_i = PUB_m_extract_master.m_extract_id_i AND PUB_s_group_extract.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_extract.s_group_unit_key_n = PUB_s_group.s_unit_key_n")
                            + GenerateWhereClauseLong("PUB_s_group", SGroupTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractMasterTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, SGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, SGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out MExtractMasterTable AData, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractMasterTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroupTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out MExtractMasterTable AData, SGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out MExtractMasterTable AData, SGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out MExtractMasterTable AData, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaSGroup(String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AGroupId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(AUnitKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_master, PUB_s_group_extract WHERE " +
                        "PUB_s_group_extract.m_extract_id_i = PUB_m_extract_master.m_extract_id_i AND PUB_s_group_extract.s_group_id_c = ? AND PUB_s_group_extract.s_group_unit_key_n = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSGroupTemplate(SGroupRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract_master, PUB_s_group_extract, PUB_s_group WHERE " +
                        "PUB_s_group_extract.m_extract_id_i = PUB_m_extract_master.m_extract_id_i AND PUB_s_group_extract.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_extract.s_group_unit_key_n = PUB_s_group.s_unit_key_n" +
                        GenerateWhereClauseLong("PUB_s_group_extract", MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, SGroupTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 AExtractId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_m_extract_master WHERE m_extract_id_i = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_m_extract_master" + GenerateWhereClause(MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(MExtractMasterTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        ((MExtractMasterRow)(TheRow)).ExtractId = ((Int32)(DBAccess.GDBAccessObj.GetNextSequenceValue("seq_extract_number", ATransaction)));
                        TTypedDataAccess.InsertRow("m_extract_master", MExtractMasterTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("m_extract_master", MExtractMasterTable.GetColumnStringList(), MExtractMasterTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("m_extract_master", MExtractMasterTable.GetColumnStringList(), MExtractMasterTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table MExtractMaster", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Contains the list of partners in each mailing extract
    public class MExtractAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "MExtract";

        /// original table name in database
        public const string DBTABLENAME = "m_extract";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract")
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out MExtractTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out MExtractTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out MExtractTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 AExtractId, Int64 APartnerKey, Int64 ASiteKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(APartnerKey));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[2].Value = ((object)(ASiteKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract WHERE m_extract_id_i = ? AND p_partner_key_n = ? AND p_site_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AExtractId, Int64 APartnerKey, Int64 ASiteKey, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AExtractId, APartnerKey, ASiteKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AExtractId, Int64 APartnerKey, Int64 ASiteKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AExtractId, APartnerKey, ASiteKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractTable AData, Int32 AExtractId, Int64 APartnerKey, Int64 ASiteKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AExtractId, APartnerKey, ASiteKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractTable AData, Int32 AExtractId, Int64 APartnerKey, Int64 ASiteKey, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AExtractId, APartnerKey, ASiteKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractTable AData, Int32 AExtractId, Int64 APartnerKey, Int64 ASiteKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AExtractId, APartnerKey, ASiteKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, MExtractRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract")
                            + GenerateWhereClause(MExtractTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, MExtractRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, MExtractRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractTable AData, MExtractRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractTable AData, MExtractRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractTable AData, MExtractRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractTable AData, MExtractRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(Int32 AExtractId, Int64 APartnerKey, Int64 ASiteKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(APartnerKey));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[2].Value = ((object)(ASiteKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract WHERE m_extract_id_i = ? AND p_partner_key_n = ? AND p_site_key_n = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(MExtractRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract" + GenerateWhereClause(MExtractTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet ADataSet, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract WHERE m_extract_id_i = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet AData, Int32 AExtractId, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(AData, AExtractId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(AData, AExtractId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out MExtractTable AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadViaMExtractMaster(FillDataSet, AExtractId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out MExtractTable AData, Int32 AExtractId, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(out AData, AExtractId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out MExtractTable AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(out AData, AExtractId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet ADataSet, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_m_extract", AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract, PUB_m_extract_master WHERE " +
                            "PUB_m_extract.m_extract_id_i = PUB_m_extract_master.m_extract_id_i")
                            + GenerateWhereClauseLong("PUB_m_extract_master", MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet AData, MExtractMasterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet AData, MExtractMasterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out MExtractTable AData, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadViaMExtractMasterTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out MExtractTable AData, MExtractMasterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out MExtractTable AData, MExtractMasterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out MExtractTable AData, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaMExtractMaster(Int32 AExtractId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract WHERE m_extract_id_i = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaMExtractMasterTemplate(MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract, PUB_m_extract_master WHERE " +
                "PUB_m_extract.m_extract_id_i = PUB_m_extract_master.m_extract_id_i" + GenerateWhereClauseLong("PUB_m_extract_master", MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, MExtractMasterTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract WHERE p_partner_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out MExtractTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartner(FillDataSet, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartner(out MExtractTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out MExtractTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_m_extract", AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract, PUB_p_partner WHERE " +
                            "PUB_m_extract.p_partner_key_n = PUB_p_partner.p_partner_key_n")
                            + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out MExtractTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out MExtractTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out MExtractTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out MExtractTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartner(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract WHERE p_partner_key_n = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract, PUB_p_partner WHERE " +
                "PUB_m_extract.p_partner_key_n = PUB_p_partner.p_partner_key_n" + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPLocation(DataSet ADataSet, Int64 ASiteKey, Int32 ALocationKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(ASiteKey));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[1].Value = ((object)(ALocationKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract WHERE p_site_key_n = ? AND p_location_key_i = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPLocation(DataSet AData, Int64 ASiteKey, Int32 ALocationKey, TDBTransaction ATransaction)
        {
            LoadViaPLocation(AData, ASiteKey, ALocationKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLocation(DataSet AData, Int64 ASiteKey, Int32 ALocationKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLocation(AData, ASiteKey, ALocationKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLocation(out MExtractTable AData, Int64 ASiteKey, Int32 ALocationKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPLocation(FillDataSet, ASiteKey, ALocationKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPLocation(out MExtractTable AData, Int64 ASiteKey, Int32 ALocationKey, TDBTransaction ATransaction)
        {
            LoadViaPLocation(out AData, ASiteKey, ALocationKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLocation(out MExtractTable AData, Int64 ASiteKey, Int32 ALocationKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLocation(out AData, ASiteKey, ALocationKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLocationTemplate(DataSet ADataSet, PLocationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_m_extract", AFieldList, new string[] {
                            "m_extract_id_i", "p_partner_key_n", "p_site_key_n"}) + " FROM PUB_m_extract, PUB_p_location WHERE " +
                            "PUB_m_extract.p_site_key_n = PUB_p_location.p_site_key_n AND PUB_m_extract.p_location_key_i = PUB_p_location.p_location_key_i")
                            + GenerateWhereClauseLong("PUB_p_location", PLocationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPLocationTemplate(DataSet AData, PLocationRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPLocationTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLocationTemplate(DataSet AData, PLocationRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLocationTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLocationTemplate(out MExtractTable AData, PLocationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPLocationTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPLocationTemplate(out MExtractTable AData, PLocationRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPLocationTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLocationTemplate(out MExtractTable AData, PLocationRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLocationTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLocationTemplate(out MExtractTable AData, PLocationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLocationTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPLocation(Int64 ASiteKey, Int32 ALocationKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(ASiteKey));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[1].Value = ((object)(ALocationKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract WHERE p_site_key_n = ? AND p_location_key_i = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPLocationTemplate(PLocationRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract, PUB_p_location WHERE " +
                "PUB_m_extract.p_site_key_n = PUB_p_location.p_site_key_n AND PUB_m_extract.p_location_key_i = PUB_p_location.p_location_key_i" + GenerateWhereClauseLong("PUB_p_location", PLocationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PLocationTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 AExtractId, Int64 APartnerKey, Int64 ASiteKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(APartnerKey));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[2].Value = ((object)(ASiteKey));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_m_extract WHERE m_extract_id_i = ? AND p_partner_key_n = ? AND p_site_key_n = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(MExtractRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_m_extract" + GenerateWhereClause(MExtractTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(MExtractTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("m_extract", MExtractTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("m_extract", MExtractTable.GetColumnStringList(), MExtractTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("m_extract", MExtractTable.GetColumnStringList(), MExtractTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table MExtract", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Contains a list of extract type which is needed when extracts need to be rerun
    public class MExtractTypeAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "MExtractType";

        /// original table name in database
        public const string DBTABLENAME = "m_extract_type";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_code_c"}) + " FROM PUB_m_extract_type")
                            + GenerateOrderByClause(AOrderBy)), MExtractTypeTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out MExtractTypeTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTypeTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out MExtractTypeTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out MExtractTypeTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_code_c"}) + " FROM PUB_m_extract_type WHERE m_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractTypeTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractTypeTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTypeTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractTypeTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractTypeTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "m_code_c"}) + " FROM PUB_m_extract_type")
                            + GenerateWhereClause(MExtractTypeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractTypeTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, MExtractTypeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, MExtractTypeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractTypeTable AData, MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractTypeTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractTypeTable AData, MExtractTypeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractTypeTable AData, MExtractTypeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractTypeTable AData, MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_type", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_type WHERE m_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract_type" + GenerateWhereClause(MExtractTypeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(ACode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_m_extract_type WHERE m_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(MExtractTypeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_m_extract_type" + GenerateWhereClause(MExtractTypeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(MExtractTypeTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("m_extract_type", MExtractTypeTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("m_extract_type", MExtractTypeTable.GetColumnStringList(), MExtractTypeTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("m_extract_type", MExtractTypeTable.GetColumnStringList(), MExtractTypeTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table MExtractType", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Contains a list of parameters that an extract was run with (so it can be rerun)
    public class MExtractParameterAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "MExtractParameter";

        /// original table name in database
        public const string DBTABLENAME = "m_extract_parameter";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "m_parameter_code_c", "m_value_index_i"}) + " FROM PUB_m_extract_parameter")
                            + GenerateOrderByClause(AOrderBy)), MExtractParameterTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out MExtractParameterTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractParameterTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out MExtractParameterTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out MExtractParameterTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 AExtractId, String AParameterCode, Int32 AValueIndex, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[1].Value = ((object)(AParameterCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[2].Value = ((object)(AValueIndex));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "m_parameter_code_c", "m_value_index_i"}) + " FROM PUB_m_extract_parameter WHERE m_extract_id_i = ? AND m_parameter_code_c = ? AND m_value_index_i = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractParameterTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AExtractId, String AParameterCode, Int32 AValueIndex, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AExtractId, AParameterCode, AValueIndex, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AExtractId, String AParameterCode, Int32 AValueIndex, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AExtractId, AParameterCode, AValueIndex, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractParameterTable AData, Int32 AExtractId, String AParameterCode, Int32 AValueIndex, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractParameterTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AExtractId, AParameterCode, AValueIndex, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractParameterTable AData, Int32 AExtractId, String AParameterCode, Int32 AValueIndex, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AExtractId, AParameterCode, AValueIndex, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out MExtractParameterTable AData, Int32 AExtractId, String AParameterCode, Int32 AValueIndex, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AExtractId, AParameterCode, AValueIndex, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, MExtractParameterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "m_parameter_code_c", "m_value_index_i"}) + " FROM PUB_m_extract_parameter")
                            + GenerateWhereClause(MExtractParameterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractParameterTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, MExtractParameterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, MExtractParameterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractParameterTable AData, MExtractParameterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractParameterTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractParameterTable AData, MExtractParameterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractParameterTable AData, MExtractParameterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out MExtractParameterTable AData, MExtractParameterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_parameter", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(Int32 AExtractId, String AParameterCode, Int32 AValueIndex, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[1].Value = ((object)(AParameterCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[2].Value = ((object)(AValueIndex));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_parameter WHERE m_extract_id_i = ? AND m_parameter_code_c = ? AND m_value_index_i = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(MExtractParameterRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract_parameter" + GenerateWhereClause(MExtractParameterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet ADataSet, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "m_extract_id_i", "m_parameter_code_c", "m_value_index_i"}) + " FROM PUB_m_extract_parameter WHERE m_extract_id_i = ?")
                            + GenerateOrderByClause(AOrderBy)), MExtractParameterTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet AData, Int32 AExtractId, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(AData, AExtractId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(AData, AExtractId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out MExtractParameterTable AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractParameterTable();
            FillDataSet.Tables.Add(AData);
            LoadViaMExtractMaster(FillDataSet, AExtractId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out MExtractParameterTable AData, Int32 AExtractId, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(out AData, AExtractId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out MExtractParameterTable AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(out AData, AExtractId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet ADataSet, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_m_extract_parameter", AFieldList, new string[] {
                            "m_extract_id_i", "m_parameter_code_c", "m_value_index_i"}) + " FROM PUB_m_extract_parameter, PUB_m_extract_master WHERE " +
                            "PUB_m_extract_parameter.m_extract_id_i = PUB_m_extract_master.m_extract_id_i")
                            + GenerateWhereClauseLong("PUB_m_extract_master", MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), MExtractParameterTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet AData, MExtractMasterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet AData, MExtractMasterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out MExtractParameterTable AData, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new MExtractParameterTable();
            FillDataSet.Tables.Add(AData);
            LoadViaMExtractMasterTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out MExtractParameterTable AData, MExtractMasterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out MExtractParameterTable AData, MExtractMasterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out MExtractParameterTable AData, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaMExtractMaster(Int32 AExtractId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_m_extract_parameter WHERE m_extract_id_i = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaMExtractMasterTemplate(MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_m_extract_parameter, PUB_m_extract_master WHERE " +
                "PUB_m_extract_parameter.m_extract_id_i = PUB_m_extract_master.m_extract_id_i" + GenerateWhereClauseLong("PUB_m_extract_master", MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, MExtractMasterTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 AExtractId, String AParameterCode, Int32 AValueIndex, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[1].Value = ((object)(AParameterCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[2].Value = ((object)(AValueIndex));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_m_extract_parameter WHERE m_extract_id_i = ? AND m_parameter_code_c = ? AND m_value_index_i = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(MExtractParameterRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_m_extract_parameter" + GenerateWhereClause(MExtractParameterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(MExtractParameterTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("m_extract_parameter", MExtractParameterTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("m_extract_parameter", MExtractParameterTable.GetColumnStringList(), MExtractParameterTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("m_extract_parameter", MExtractParameterTable.GetColumnStringList(), MExtractParameterTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table MExtractParameter", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Lists mailings that are being tracked.   When entering gifts, the mailing that motivated the gift can be indicated.
    public class PMailingAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PMailing";

        /// original table name in database
        public const string DBTABLENAME = "p_mailing";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_mailing_code_c"}) + " FROM PUB_p_mailing")
                            + GenerateOrderByClause(AOrderBy)), PMailingTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PMailingTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMailingTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PMailingTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PMailingTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(AMailingCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_mailing_code_c"}) + " FROM PUB_p_mailing WHERE p_mailing_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PMailingTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMailingCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMailingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMailingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMailingTable AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMailingTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AMailingCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMailingTable AData, String AMailingCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMailingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMailingTable AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMailingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_mailing_code_c"}) + " FROM PUB_p_mailing")
                            + GenerateWhereClause(PMailingTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PMailingTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PMailingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PMailingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMailingTable AData, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMailingTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMailingTable AData, PMailingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMailingTable AData, PMailingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMailingTable AData, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_mailing", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String AMailingCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(AMailingCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_mailing WHERE p_mailing_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PMailingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_mailing" + GenerateWhereClause(PMailingTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AMailingCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(AMailingCode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_mailing WHERE p_mailing_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PMailingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_mailing" + GenerateWhereClause(PMailingTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PMailingTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_mailing", PMailingTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_mailing", PMailingTable.GetColumnStringList(), PMailingTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_mailing", PMailingTable.GetColumnStringList(), PMailingTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PMailing", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// This table contains the address layouts generally available for the user.
    public class PAddressLayoutCodeAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PAddressLayoutCode";

        /// original table name in database
        public const string DBTABLENAME = "p_address_layout_code";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_address_layout_code")
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutCodeTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddressLayoutCodeTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutCodeTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PAddressLayoutCodeTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddressLayoutCodeTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_address_layout_code WHERE p_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutCodeTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLayoutCodeTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutCodeTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLayoutCodeTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLayoutCodeTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_address_layout_code")
                            + GenerateWhereClause(PAddressLayoutCodeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutCodeTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddressLayoutCodeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddressLayoutCodeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLayoutCodeTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutCodeTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLayoutCodeTable AData, PAddressLayoutCodeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLayoutCodeTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLayoutCodeTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_layout_code", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_layout_code WHERE p_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_address_layout_code" + GenerateWhereClause(PAddressLayoutCodeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaPCountry(DataSet ADataSet, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_p_address_layout_code", AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_address_layout_code, PUB_p_address_layout WHERE " +
                            "PUB_p_address_layout.p_address_layout_code_c = PUB_p_address_layout_code.p_code_c AND PUB_p_address_layout.p_country_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutCodeTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPCountry(DataSet AData, String ACountryCode, TDBTransaction ATransaction)
        {
            LoadViaPCountry(AData, ACountryCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(DataSet AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountry(AData, ACountryCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(out PAddressLayoutCodeTable AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutCodeTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPCountry(FillDataSet, ACountryCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPCountry(out PAddressLayoutCodeTable AData, String ACountryCode, TDBTransaction ATransaction)
        {
            LoadViaPCountry(out AData, ACountryCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(out PAddressLayoutCodeTable AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountry(out AData, ACountryCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet ADataSet, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_address_layout_code", AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_address_layout_code, PUB_p_address_layout, PUB_p_country WHERE " +
                            "PUB_p_address_layout.p_address_layout_code_c = PUB_p_address_layout_code.p_code_c AND PUB_p_address_layout.p_country_code_c = PUB_p_country.p_country_code_c")
                            + GenerateWhereClauseLong("PUB_p_country", PCountryTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutCodeTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet AData, PCountryRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet AData, PCountryRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PAddressLayoutCodeTable AData, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutCodeTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPCountryTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PAddressLayoutCodeTable AData, PCountryRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PAddressLayoutCodeTable AData, PCountryRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PAddressLayoutCodeTable AData, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaPCountry(String ACountryCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_layout_code, PUB_p_address_layout WHERE " +
                        "PUB_p_address_layout.p_address_layout_code_c = PUB_p_address_layout_code.p_code_c AND PUB_p_address_layout.p_country_code_c = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPCountryTemplate(PCountryRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_address_layout_code, PUB_p_address_layout, PUB_p_country WHERE " +
                        "PUB_p_address_layout.p_address_layout_code_c = PUB_p_address_layout_code.p_code_c AND PUB_p_address_layout.p_country_code_c = PUB_p_country.p_country_code_c" +
                        GenerateWhereClauseLong("PUB_p_address_layout", PAddressLayoutCodeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PCountryTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(ACode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_address_layout_code WHERE p_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_address_layout_code" + GenerateWhereClause(PAddressLayoutCodeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PAddressLayoutCodeTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_address_layout_code", PAddressLayoutCodeTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_address_layout_code", PAddressLayoutCodeTable.GetColumnStringList(), PAddressLayoutCodeTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_address_layout_code", PAddressLayoutCodeTable.GetColumnStringList(), PAddressLayoutCodeTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PAddressLayoutCode", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// This table contains the address lines used in laying out an address. Eg a form letter address layout
    public class PAddressLayoutAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PAddressLayout";

        /// original table name in database
        public const string DBTABLENAME = "p_address_layout";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_country_code_c", "p_address_layout_code_c", "p_address_line_number_i", "p_address_line_code_c"}) + " FROM PUB_p_address_layout")
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddressLayoutTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PAddressLayoutTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddressLayoutTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ACountryCode, String AAddressLayoutCode, Int32 AAddressLineNumber, String AAddressLineCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[4];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AAddressLayoutCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[2].Value = ((object)(AAddressLineNumber));
            ParametersArray[3] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[3].Value = ((object)(AAddressLineCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_country_code_c", "p_address_layout_code_c", "p_address_line_number_i", "p_address_line_code_c"}) + " FROM PUB_p_address_layout WHERE p_country_code_c = ? AND p_address_layout_code_c = ? AND p_address_line_number_i = ? AND p_address_line_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACountryCode, String AAddressLayoutCode, Int32 AAddressLineNumber, String AAddressLineCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACountryCode, AAddressLayoutCode, AAddressLineNumber, AAddressLineCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACountryCode, String AAddressLayoutCode, Int32 AAddressLineNumber, String AAddressLineCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACountryCode, AAddressLayoutCode, AAddressLineNumber, AAddressLineCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLayoutTable AData, String ACountryCode, String AAddressLayoutCode, Int32 AAddressLineNumber, String AAddressLineCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ACountryCode, AAddressLayoutCode, AAddressLineNumber, AAddressLineCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLayoutTable AData, String ACountryCode, String AAddressLayoutCode, Int32 AAddressLineNumber, String AAddressLineCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACountryCode, AAddressLayoutCode, AAddressLineNumber, AAddressLineCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLayoutTable AData, String ACountryCode, String AAddressLayoutCode, Int32 AAddressLineNumber, String AAddressLineCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACountryCode, AAddressLayoutCode, AAddressLineNumber, AAddressLineCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PAddressLayoutRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_country_code_c", "p_address_layout_code_c", "p_address_line_number_i", "p_address_line_code_c"}) + " FROM PUB_p_address_layout")
                            + GenerateWhereClause(PAddressLayoutTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddressLayoutRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddressLayoutRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLayoutTable AData, PAddressLayoutRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLayoutTable AData, PAddressLayoutRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLayoutTable AData, PAddressLayoutRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLayoutTable AData, PAddressLayoutRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_layout", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ACountryCode, String AAddressLayoutCode, Int32 AAddressLineNumber, String AAddressLineCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[4];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AAddressLayoutCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[2].Value = ((object)(AAddressLineNumber));
            ParametersArray[3] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[3].Value = ((object)(AAddressLineCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_layout WHERE p_country_code_c = ? AND p_address_layout_code_c = ? AND p_address_line_number_i = ? AND p_address_line_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PAddressLayoutRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_address_layout" + GenerateWhereClause(PAddressLayoutTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPCountry(DataSet ADataSet, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_country_code_c", "p_address_layout_code_c", "p_address_line_number_i", "p_address_line_code_c"}) + " FROM PUB_p_address_layout WHERE p_country_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPCountry(DataSet AData, String ACountryCode, TDBTransaction ATransaction)
        {
            LoadViaPCountry(AData, ACountryCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(DataSet AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountry(AData, ACountryCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(out PAddressLayoutTable AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPCountry(FillDataSet, ACountryCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPCountry(out PAddressLayoutTable AData, String ACountryCode, TDBTransaction ATransaction)
        {
            LoadViaPCountry(out AData, ACountryCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(out PAddressLayoutTable AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountry(out AData, ACountryCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet ADataSet, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_address_layout", AFieldList, new string[] {
                            "p_country_code_c", "p_address_layout_code_c", "p_address_line_number_i", "p_address_line_code_c"}) + " FROM PUB_p_address_layout, PUB_p_country WHERE " +
                            "PUB_p_address_layout.p_country_code_c = PUB_p_country.p_country_code_c")
                            + GenerateWhereClauseLong("PUB_p_country", PCountryTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet AData, PCountryRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet AData, PCountryRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PAddressLayoutTable AData, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPCountryTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PAddressLayoutTable AData, PCountryRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PAddressLayoutTable AData, PCountryRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PAddressLayoutTable AData, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPCountry(String ACountryCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_layout WHERE p_country_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPCountryTemplate(PCountryRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_address_layout, PUB_p_country WHERE " +
                "PUB_p_address_layout.p_country_code_c = PUB_p_country.p_country_code_c" + GenerateWhereClauseLong("PUB_p_country", PCountryTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PCountryTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_country_code_c", "p_address_layout_code_c", "p_address_line_number_i", "p_address_line_code_c"}) + " FROM PUB_p_address_layout WHERE p_address_layout_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCode(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCode(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(out PAddressLayoutTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPAddressLayoutCode(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(out PAddressLayoutTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCode(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(out PAddressLayoutTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCode(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(DataSet ADataSet, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_address_layout", AFieldList, new string[] {
                            "p_country_code_c", "p_address_layout_code_c", "p_address_line_number_i", "p_address_line_code_c"}) + " FROM PUB_p_address_layout, PUB_p_address_layout_code WHERE " +
                            "PUB_p_address_layout.p_address_layout_code_c = PUB_p_address_layout_code.p_code_c")
                            + GenerateWhereClauseLong("PUB_p_address_layout_code", PAddressLayoutCodeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddressLayoutTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(DataSet AData, PAddressLayoutCodeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(DataSet AData, PAddressLayoutCodeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(out PAddressLayoutTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLayoutTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPAddressLayoutCodeTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(out PAddressLayoutTable AData, PAddressLayoutCodeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(out PAddressLayoutTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(out PAddressLayoutTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPAddressLayoutCode(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_layout WHERE p_address_layout_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPAddressLayoutCodeTemplate(PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_address_layout, PUB_p_address_layout_code WHERE " +
                "PUB_p_address_layout.p_address_layout_code_c = PUB_p_address_layout_code.p_code_c" + GenerateWhereClauseLong("PUB_p_address_layout_code", PAddressLayoutCodeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PAddressLayoutCodeTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ACountryCode, String AAddressLayoutCode, Int32 AAddressLineNumber, String AAddressLineCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[4];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AAddressLayoutCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[2].Value = ((object)(AAddressLineNumber));
            ParametersArray[3] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[3].Value = ((object)(AAddressLineCode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_address_layout WHERE p_country_code_c = ? AND p_address_layout_code_c = ? AND p_address_line_number_i = ? AND p_address_line_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PAddressLayoutRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_address_layout" + GenerateWhereClause(PAddressLayoutTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PAddressLayoutTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_address_layout", PAddressLayoutTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_address_layout", PAddressLayoutTable.GetColumnStringList(), PAddressLayoutTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_address_layout", PAddressLayoutTable.GetColumnStringList(), PAddressLayoutTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PAddressLayout", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// This contains the elements which make up an address. Eg Name etc
    public class PAddressElementAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PAddressElement";

        /// original table name in database
        public const string DBTABLENAME = "p_address_element";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_address_element_code_c"}) + " FROM PUB_p_address_element")
                            + GenerateOrderByClause(AOrderBy)), PAddressElementTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddressElementTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressElementTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PAddressElementTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddressElementTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AAddressElementCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AAddressElementCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_address_element_code_c"}) + " FROM PUB_p_address_element WHERE p_address_element_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddressElementTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AAddressElementCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AAddressElementCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AAddressElementCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AAddressElementCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressElementTable AData, String AAddressElementCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressElementTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AAddressElementCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressElementTable AData, String AAddressElementCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AAddressElementCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressElementTable AData, String AAddressElementCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AAddressElementCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_address_element_code_c"}) + " FROM PUB_p_address_element")
                            + GenerateWhereClause(PAddressElementTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddressElementTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddressElementRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddressElementRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressElementTable AData, PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressElementTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressElementTable AData, PAddressElementRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressElementTable AData, PAddressElementRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressElementTable AData, PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_element", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String AAddressElementCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AAddressElementCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_element WHERE p_address_element_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_address_element" + GenerateWhereClause(PAddressElementTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AAddressElementCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AAddressElementCode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_address_element WHERE p_address_element_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_address_element" + GenerateWhereClause(PAddressElementTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PAddressElementTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_address_element", PAddressElementTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_address_element", PAddressElementTable.GetColumnStringList(), PAddressElementTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_address_element", PAddressElementTable.GetColumnStringList(), PAddressElementTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PAddressElement", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// This is an address line which consists of address elements.  Used along with p_address_layout and p_address_element to define layout of an address for different countries.
    public class PAddressLineAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PAddressLine";

        /// original table name in database
        public const string DBTABLENAME = "p_address_line";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_address_line_code_c", "p_address_element_position_i"}) + " FROM PUB_p_address_line")
                            + GenerateOrderByClause(AOrderBy)), PAddressLineTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddressLineTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLineTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PAddressLineTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddressLineTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AAddressLineCode, Int32 AAddressElementPosition, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AAddressLineCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[1].Value = ((object)(AAddressElementPosition));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_address_line_code_c", "p_address_element_position_i"}) + " FROM PUB_p_address_line WHERE p_address_line_code_c = ? AND p_address_element_position_i = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddressLineTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AAddressLineCode, Int32 AAddressElementPosition, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AAddressLineCode, AAddressElementPosition, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AAddressLineCode, Int32 AAddressElementPosition, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AAddressLineCode, AAddressElementPosition, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLineTable AData, String AAddressLineCode, Int32 AAddressElementPosition, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLineTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AAddressLineCode, AAddressElementPosition, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLineTable AData, String AAddressLineCode, Int32 AAddressElementPosition, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AAddressLineCode, AAddressElementPosition, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddressLineTable AData, String AAddressLineCode, Int32 AAddressElementPosition, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AAddressLineCode, AAddressElementPosition, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PAddressLineRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_address_line_code_c", "p_address_element_position_i"}) + " FROM PUB_p_address_line")
                            + GenerateWhereClause(PAddressLineTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddressLineTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddressLineRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddressLineRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLineTable AData, PAddressLineRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLineTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLineTable AData, PAddressLineRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLineTable AData, PAddressLineRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddressLineTable AData, PAddressLineRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_line", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String AAddressLineCode, Int32 AAddressElementPosition, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AAddressLineCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[1].Value = ((object)(AAddressElementPosition));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_line WHERE p_address_line_code_c = ? AND p_address_element_position_i = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PAddressLineRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_address_line" + GenerateWhereClause(PAddressLineTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPAddressElement(DataSet ADataSet, String AAddressElementCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AAddressElementCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_address_line_code_c", "p_address_element_position_i"}) + " FROM PUB_p_address_line WHERE p_address_element_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddressLineTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPAddressElement(DataSet AData, String AAddressElementCode, TDBTransaction ATransaction)
        {
            LoadViaPAddressElement(AData, AAddressElementCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressElement(DataSet AData, String AAddressElementCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressElement(AData, AAddressElementCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressElement(out PAddressLineTable AData, String AAddressElementCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLineTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPAddressElement(FillDataSet, AAddressElementCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPAddressElement(out PAddressLineTable AData, String AAddressElementCode, TDBTransaction ATransaction)
        {
            LoadViaPAddressElement(out AData, AAddressElementCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressElement(out PAddressLineTable AData, String AAddressElementCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressElement(out AData, AAddressElementCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressElementTemplate(DataSet ADataSet, PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_address_line", AFieldList, new string[] {
                            "p_address_line_code_c", "p_address_element_position_i"}) + " FROM PUB_p_address_line, PUB_p_address_element WHERE " +
                            "PUB_p_address_line.p_address_element_code_c = PUB_p_address_element.p_address_element_code_c")
                            + GenerateWhereClauseLong("PUB_p_address_element", PAddressElementTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddressLineTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPAddressElementTemplate(DataSet AData, PAddressElementRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPAddressElementTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressElementTemplate(DataSet AData, PAddressElementRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressElementTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressElementTemplate(out PAddressLineTable AData, PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddressLineTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPAddressElementTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPAddressElementTemplate(out PAddressLineTable AData, PAddressElementRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPAddressElementTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressElementTemplate(out PAddressLineTable AData, PAddressElementRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressElementTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressElementTemplate(out PAddressLineTable AData, PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressElementTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPAddressElement(String AAddressElementCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AAddressElementCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_address_line WHERE p_address_element_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPAddressElementTemplate(PAddressElementRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_address_line, PUB_p_address_element WHERE " +
                "PUB_p_address_line.p_address_element_code_c = PUB_p_address_element.p_address_element_code_c" + GenerateWhereClauseLong("PUB_p_address_element", PAddressElementTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PAddressElementTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AAddressLineCode, Int32 AAddressElementPosition, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AAddressLineCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[1].Value = ((object)(AAddressElementPosition));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_address_line WHERE p_address_line_code_c = ? AND p_address_element_position_i = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PAddressLineRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_address_line" + GenerateWhereClause(PAddressLineTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PAddressLineTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_address_line", PAddressLineTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_address_line", PAddressLineTable.GetColumnStringList(), PAddressLineTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_address_line", PAddressLineTable.GetColumnStringList(), PAddressLineTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PAddressLine", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// This is used to override titles that might be different in the address than that in the letter.
    /// Eg      German     Herr   Herrn
    /// ""Sehr geehrter Herr Starling"" in the letter and ""Herrn Starling"" in the address.
    public class PAddresseeTitleOverrideAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PAddresseeTitleOverride";

        /// original table name in database
        public const string DBTABLENAME = "p_addressee_title_override";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_title_c"}) + " FROM PUB_p_addressee_title_override")
                            + GenerateOrderByClause(AOrderBy)), PAddresseeTitleOverrideTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddresseeTitleOverrideTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddresseeTitleOverrideTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PAddresseeTitleOverrideTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PAddresseeTitleOverrideTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ALanguageCode, String ATitle, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[1].Value = ((object)(ATitle));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_title_c"}) + " FROM PUB_p_addressee_title_override WHERE p_language_code_c = ? AND p_title_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddresseeTitleOverrideTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ALanguageCode, String ATitle, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALanguageCode, ATitle, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ALanguageCode, String ATitle, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALanguageCode, ATitle, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddresseeTitleOverrideTable AData, String ALanguageCode, String ATitle, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddresseeTitleOverrideTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ALanguageCode, ATitle, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddresseeTitleOverrideTable AData, String ALanguageCode, String ATitle, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALanguageCode, ATitle, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PAddresseeTitleOverrideTable AData, String ALanguageCode, String ATitle, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALanguageCode, ATitle, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PAddresseeTitleOverrideRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_title_c"}) + " FROM PUB_p_addressee_title_override")
                            + GenerateWhereClause(PAddresseeTitleOverrideTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddresseeTitleOverrideTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddresseeTitleOverrideRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PAddresseeTitleOverrideRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddresseeTitleOverrideTable AData, PAddresseeTitleOverrideRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddresseeTitleOverrideTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddresseeTitleOverrideTable AData, PAddresseeTitleOverrideRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddresseeTitleOverrideTable AData, PAddresseeTitleOverrideRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PAddresseeTitleOverrideTable AData, PAddresseeTitleOverrideRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_addressee_title_override", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ALanguageCode, String ATitle, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[1].Value = ((object)(ATitle));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_addressee_title_override WHERE p_language_code_c = ? AND p_title_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PAddresseeTitleOverrideRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_addressee_title_override" + GenerateWhereClause(PAddresseeTitleOverrideTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet ADataSet, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_title_c"}) + " FROM PUB_p_addressee_title_override WHERE p_language_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PAddresseeTitleOverrideTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet AData, String ALanguageCode, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(AData, ALanguageCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(AData, ALanguageCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PAddresseeTitleOverrideTable AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddresseeTitleOverrideTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPLanguage(FillDataSet, ALanguageCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PAddresseeTitleOverrideTable AData, String ALanguageCode, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(out AData, ALanguageCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PAddresseeTitleOverrideTable AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(out AData, ALanguageCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet ADataSet, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_addressee_title_override", AFieldList, new string[] {
                            "p_language_code_c", "p_title_c"}) + " FROM PUB_p_addressee_title_override, PUB_p_language WHERE " +
                            "PUB_p_addressee_title_override.p_language_code_c = PUB_p_language.p_language_code_c")
                            + GenerateWhereClauseLong("PUB_p_language", PLanguageTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PAddresseeTitleOverrideTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet AData, PLanguageRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet AData, PLanguageRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PAddresseeTitleOverrideTable AData, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PAddresseeTitleOverrideTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPLanguageTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PAddresseeTitleOverrideTable AData, PLanguageRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PAddresseeTitleOverrideTable AData, PLanguageRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PAddresseeTitleOverrideTable AData, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPLanguage(String ALanguageCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_addressee_title_override WHERE p_language_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPLanguageTemplate(PLanguageRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_addressee_title_override, PUB_p_language WHERE " +
                "PUB_p_addressee_title_override.p_language_code_c = PUB_p_language.p_language_code_c" + GenerateWhereClauseLong("PUB_p_language", PLanguageTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PLanguageTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ALanguageCode, String ATitle, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[1].Value = ((object)(ATitle));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_addressee_title_override WHERE p_language_code_c = ? AND p_title_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PAddresseeTitleOverrideRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_addressee_title_override" + GenerateWhereClause(PAddresseeTitleOverrideTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PAddresseeTitleOverrideTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_addressee_title_override", PAddresseeTitleOverrideTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_addressee_title_override", PAddresseeTitleOverrideTable.GetColumnStringList(), PAddresseeTitleOverrideTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_addressee_title_override", PAddresseeTitleOverrideTable.GetColumnStringList(), PAddresseeTitleOverrideTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PAddresseeTitleOverride", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Specific greetings from a user to a partner
    public class PCustomisedGreetingAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PCustomisedGreeting";

        /// original table name in database
        public const string DBTABLENAME = "p_customised_greeting";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_partner_key_n", "s_user_id_c"}) + " FROM PUB_p_customised_greeting")
                            + GenerateOrderByClause(AOrderBy)), PCustomisedGreetingTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PCustomisedGreetingTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PCustomisedGreetingTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PCustomisedGreetingTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PCustomisedGreetingTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int64 APartnerKey, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[1].Value = ((object)(AUserId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_partner_key_n", "s_user_id_c"}) + " FROM PUB_p_customised_greeting WHERE p_partner_key_n = ? AND s_user_id_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PCustomisedGreetingTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int64 APartnerKey, String AUserId, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, APartnerKey, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int64 APartnerKey, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, APartnerKey, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PCustomisedGreetingTable AData, Int64 APartnerKey, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PCustomisedGreetingTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, APartnerKey, AUserId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PCustomisedGreetingTable AData, Int64 APartnerKey, String AUserId, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, APartnerKey, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PCustomisedGreetingTable AData, Int64 APartnerKey, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, APartnerKey, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PCustomisedGreetingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_partner_key_n", "s_user_id_c"}) + " FROM PUB_p_customised_greeting")
                            + GenerateWhereClause(PCustomisedGreetingTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PCustomisedGreetingTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PCustomisedGreetingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PCustomisedGreetingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PCustomisedGreetingTable AData, PCustomisedGreetingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PCustomisedGreetingTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PCustomisedGreetingTable AData, PCustomisedGreetingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PCustomisedGreetingTable AData, PCustomisedGreetingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PCustomisedGreetingTable AData, PCustomisedGreetingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_customised_greeting", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(Int64 APartnerKey, String AUserId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[1].Value = ((object)(AUserId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_customised_greeting WHERE p_partner_key_n = ? AND s_user_id_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PCustomisedGreetingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_customised_greeting" + GenerateWhereClause(PCustomisedGreetingTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_partner_key_n", "s_user_id_c"}) + " FROM PUB_p_customised_greeting WHERE p_partner_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PCustomisedGreetingTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out PCustomisedGreetingTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PCustomisedGreetingTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartner(FillDataSet, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartner(out PCustomisedGreetingTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out PCustomisedGreetingTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_customised_greeting", AFieldList, new string[] {
                            "p_partner_key_n", "s_user_id_c"}) + " FROM PUB_p_customised_greeting, PUB_p_partner WHERE " +
                            "PUB_p_customised_greeting.p_partner_key_n = PUB_p_partner.p_partner_key_n")
                            + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PCustomisedGreetingTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PCustomisedGreetingTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PCustomisedGreetingTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PCustomisedGreetingTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PCustomisedGreetingTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PCustomisedGreetingTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartner(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_customised_greeting WHERE p_partner_key_n = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_customised_greeting, PUB_p_partner WHERE " +
                "PUB_p_customised_greeting.p_partner_key_n = PUB_p_partner.p_partner_key_n" + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaSUser(DataSet ADataSet, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AUserId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_partner_key_n", "s_user_id_c"}) + " FROM PUB_p_customised_greeting WHERE s_user_id_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PCustomisedGreetingTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSUser(DataSet AData, String AUserId, TDBTransaction ATransaction)
        {
            LoadViaSUser(AData, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(DataSet AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUser(AData, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(out PCustomisedGreetingTable AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PCustomisedGreetingTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSUser(FillDataSet, AUserId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSUser(out PCustomisedGreetingTable AData, String AUserId, TDBTransaction ATransaction)
        {
            LoadViaSUser(out AData, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(out PCustomisedGreetingTable AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUser(out AData, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet ADataSet, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_customised_greeting", AFieldList, new string[] {
                            "p_partner_key_n", "s_user_id_c"}) + " FROM PUB_p_customised_greeting, PUB_s_user WHERE " +
                            "PUB_p_customised_greeting.s_user_id_c = PUB_s_user.s_user_id_c")
                            + GenerateWhereClauseLong("PUB_s_user", SUserTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PCustomisedGreetingTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet AData, SUserRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet AData, SUserRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PCustomisedGreetingTable AData, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PCustomisedGreetingTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSUserTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PCustomisedGreetingTable AData, SUserRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PCustomisedGreetingTable AData, SUserRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PCustomisedGreetingTable AData, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaSUser(String AUserId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AUserId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_customised_greeting WHERE s_user_id_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSUserTemplate(SUserRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_customised_greeting, PUB_s_user WHERE " +
                "PUB_p_customised_greeting.s_user_id_c = PUB_s_user.s_user_id_c" + GenerateWhereClauseLong("PUB_s_user", SUserTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, SUserTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int64 APartnerKey, String AUserId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[1].Value = ((object)(AUserId));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_customised_greeting WHERE p_partner_key_n = ? AND s_user_id_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PCustomisedGreetingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_customised_greeting" + GenerateWhereClause(PCustomisedGreetingTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PCustomisedGreetingTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_customised_greeting", PCustomisedGreetingTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_customised_greeting", PCustomisedGreetingTable.GetColumnStringList(), PCustomisedGreetingTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_customised_greeting", PCustomisedGreetingTable.GetColumnStringList(), PCustomisedGreetingTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PCustomisedGreeting", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Contains the text used in letters
    public class PFormalityAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PFormality";

        /// original table name in database
        public const string DBTABLENAME = "p_formality";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality")
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PFormalityTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PFormalityTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PFormalityTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ALanguageCode, String ACountryCode, String AAddresseeTypeCode, Int32 AFormalityLevel, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[4];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[1].Value = ((object)(ACountryCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[2].Value = ((object)(AAddresseeTypeCode));
            ParametersArray[3] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[3].Value = ((object)(AFormalityLevel));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality WHERE p_language_code_c = ? AND p_country_code_c = ? AND p_addressee_type_code_c = ? AND p_formality_level_i = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ALanguageCode, String ACountryCode, String AAddresseeTypeCode, Int32 AFormalityLevel, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALanguageCode, ACountryCode, AAddresseeTypeCode, AFormalityLevel, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ALanguageCode, String ACountryCode, String AAddresseeTypeCode, Int32 AFormalityLevel, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ALanguageCode, ACountryCode, AAddresseeTypeCode, AFormalityLevel, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormalityTable AData, String ALanguageCode, String ACountryCode, String AAddresseeTypeCode, Int32 AFormalityLevel, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ALanguageCode, ACountryCode, AAddresseeTypeCode, AFormalityLevel, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormalityTable AData, String ALanguageCode, String ACountryCode, String AAddresseeTypeCode, Int32 AFormalityLevel, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALanguageCode, ACountryCode, AAddresseeTypeCode, AFormalityLevel, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormalityTable AData, String ALanguageCode, String ACountryCode, String AAddresseeTypeCode, Int32 AFormalityLevel, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ALanguageCode, ACountryCode, AAddresseeTypeCode, AFormalityLevel, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PFormalityRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality")
                            + GenerateWhereClause(PFormalityTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PFormalityRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PFormalityRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormalityTable AData, PFormalityRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormalityTable AData, PFormalityRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormalityTable AData, PFormalityRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormalityTable AData, PFormalityRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_formality", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ALanguageCode, String ACountryCode, String AAddresseeTypeCode, Int32 AFormalityLevel, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[4];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[1].Value = ((object)(ACountryCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[2].Value = ((object)(AAddresseeTypeCode));
            ParametersArray[3] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[3].Value = ((object)(AFormalityLevel));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_formality WHERE p_language_code_c = ? AND p_country_code_c = ? AND p_addressee_type_code_c = ? AND p_formality_level_i = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PFormalityRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_formality" + GenerateWhereClause(PFormalityTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet ADataSet, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality WHERE p_language_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet AData, String ALanguageCode, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(AData, ALanguageCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(AData, ALanguageCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PFormalityTable AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPLanguage(FillDataSet, ALanguageCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PFormalityTable AData, String ALanguageCode, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(out AData, ALanguageCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PFormalityTable AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(out AData, ALanguageCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet ADataSet, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_formality", AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality, PUB_p_language WHERE " +
                            "PUB_p_formality.p_language_code_c = PUB_p_language.p_language_code_c")
                            + GenerateWhereClauseLong("PUB_p_language", PLanguageTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet AData, PLanguageRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet AData, PLanguageRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PFormalityTable AData, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPLanguageTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PFormalityTable AData, PLanguageRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PFormalityTable AData, PLanguageRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PFormalityTable AData, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPLanguage(String ALanguageCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_formality WHERE p_language_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPLanguageTemplate(PLanguageRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_formality, PUB_p_language WHERE " +
                "PUB_p_formality.p_language_code_c = PUB_p_language.p_language_code_c" + GenerateWhereClauseLong("PUB_p_language", PLanguageTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PLanguageTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPCountry(DataSet ADataSet, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality WHERE p_country_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPCountry(DataSet AData, String ACountryCode, TDBTransaction ATransaction)
        {
            LoadViaPCountry(AData, ACountryCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(DataSet AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountry(AData, ACountryCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(out PFormalityTable AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPCountry(FillDataSet, ACountryCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPCountry(out PFormalityTable AData, String ACountryCode, TDBTransaction ATransaction)
        {
            LoadViaPCountry(out AData, ACountryCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountry(out PFormalityTable AData, String ACountryCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountry(out AData, ACountryCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet ADataSet, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_formality", AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality, PUB_p_country WHERE " +
                            "PUB_p_formality.p_country_code_c = PUB_p_country.p_country_code_c")
                            + GenerateWhereClauseLong("PUB_p_country", PCountryTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet AData, PCountryRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(DataSet AData, PCountryRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PFormalityTable AData, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPCountryTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PFormalityTable AData, PCountryRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PFormalityTable AData, PCountryRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPCountryTemplate(out PFormalityTable AData, PCountryRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPCountryTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPCountry(String ACountryCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[0].Value = ((object)(ACountryCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_formality WHERE p_country_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPCountryTemplate(PCountryRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_formality, PUB_p_country WHERE " +
                "PUB_p_formality.p_country_code_c = PUB_p_country.p_country_code_c" + GenerateWhereClauseLong("PUB_p_country", PCountryTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PCountryTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPAddresseeType(DataSet ADataSet, String AAddresseeTypeCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AAddresseeTypeCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality WHERE p_addressee_type_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPAddresseeType(DataSet AData, String AAddresseeTypeCode, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeType(AData, AAddresseeTypeCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddresseeType(DataSet AData, String AAddresseeTypeCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeType(AData, AAddresseeTypeCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddresseeType(out PFormalityTable AData, String AAddresseeTypeCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPAddresseeType(FillDataSet, AAddresseeTypeCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPAddresseeType(out PFormalityTable AData, String AAddresseeTypeCode, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeType(out AData, AAddresseeTypeCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddresseeType(out PFormalityTable AData, String AAddresseeTypeCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeType(out AData, AAddresseeTypeCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddresseeTypeTemplate(DataSet ADataSet, PAddresseeTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_formality", AFieldList, new string[] {
                            "p_language_code_c", "p_country_code_c", "p_addressee_type_code_c", "p_formality_level_i"}) + " FROM PUB_p_formality, PUB_p_addressee_type WHERE " +
                            "PUB_p_formality.p_addressee_type_code_c = PUB_p_addressee_type.p_addressee_type_code_c")
                            + GenerateWhereClauseLong("PUB_p_addressee_type", PAddresseeTypeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormalityTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPAddresseeTypeTemplate(DataSet AData, PAddresseeTypeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeTypeTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddresseeTypeTemplate(DataSet AData, PAddresseeTypeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeTypeTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddresseeTypeTemplate(out PFormalityTable AData, PAddresseeTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormalityTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPAddresseeTypeTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPAddresseeTypeTemplate(out PFormalityTable AData, PAddresseeTypeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeTypeTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddresseeTypeTemplate(out PFormalityTable AData, PAddresseeTypeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeTypeTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddresseeTypeTemplate(out PFormalityTable AData, PAddresseeTypeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddresseeTypeTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPAddresseeType(String AAddresseeTypeCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AAddresseeTypeCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_formality WHERE p_addressee_type_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPAddresseeTypeTemplate(PAddresseeTypeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_formality, PUB_p_addressee_type WHERE " +
                "PUB_p_formality.p_addressee_type_code_c = PUB_p_addressee_type.p_addressee_type_code_c" + GenerateWhereClauseLong("PUB_p_addressee_type", PAddresseeTypeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PAddresseeTypeTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ALanguageCode, String ACountryCode, String AAddresseeTypeCode, Int32 AFormalityLevel, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[4];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 8);
            ParametersArray[1].Value = ((object)(ACountryCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[2].Value = ((object)(AAddresseeTypeCode));
            ParametersArray[3] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[3].Value = ((object)(AFormalityLevel));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_formality WHERE p_language_code_c = ? AND p_country_code_c = ? AND p_addressee_type_code_c = ? AND p_formality_level_i = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PFormalityRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_formality" + GenerateWhereClause(PFormalityTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PFormalityTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_formality", PFormalityTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_formality", PFormalityTable.GetColumnStringList(), PFormalityTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_formality", PFormalityTable.GetColumnStringList(), PFormalityTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PFormality", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Text for form letters
    public class PFormLetterBodyAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PFormLetterBody";

        /// original table name in database
        public const string DBTABLENAME = "p_form_letter_body";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_body_name_c"}) + " FROM PUB_p_form_letter_body")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterBodyTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterBodyTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterBodyTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterBodyTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterBodyTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ABodyName));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_body_name_c"}) + " FROM PUB_p_form_letter_body WHERE p_body_name_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterBodyTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ABodyName, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ABodyName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ABodyName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterBodyTable AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterBodyTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ABodyName, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterBodyTable AData, String ABodyName, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ABodyName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterBodyTable AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ABodyName, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_body_name_c"}) + " FROM PUB_p_form_letter_body")
                            + GenerateWhereClause(PFormLetterBodyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterBodyTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PFormLetterBodyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PFormLetterBodyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterBodyTable AData, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterBodyTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterBodyTable AData, PFormLetterBodyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterBodyTable AData, PFormLetterBodyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterBodyTable AData, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_body", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ABodyName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ABodyName));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_body WHERE p_body_name_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_body" + GenerateWhereClause(PFormLetterBodyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaSUser(DataSet ADataSet, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AUserId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_body_name_c"}) + " FROM PUB_p_form_letter_body WHERE p_owner_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterBodyTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSUser(DataSet AData, String AUserId, TDBTransaction ATransaction)
        {
            LoadViaSUser(AData, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(DataSet AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUser(AData, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(out PFormLetterBodyTable AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterBodyTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSUser(FillDataSet, AUserId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSUser(out PFormLetterBodyTable AData, String AUserId, TDBTransaction ATransaction)
        {
            LoadViaSUser(out AData, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(out PFormLetterBodyTable AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUser(out AData, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet ADataSet, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_form_letter_body", AFieldList, new string[] {
                            "p_body_name_c"}) + " FROM PUB_p_form_letter_body, PUB_s_user WHERE " +
                            "PUB_p_form_letter_body.p_owner_c = PUB_s_user.s_user_id_c")
                            + GenerateWhereClauseLong("PUB_s_user", SUserTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterBodyTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet AData, SUserRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet AData, SUserRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PFormLetterBodyTable AData, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterBodyTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSUserTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PFormLetterBodyTable AData, SUserRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PFormLetterBodyTable AData, SUserRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PFormLetterBodyTable AData, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaSUser(String AUserId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AUserId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_body WHERE p_owner_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSUserTemplate(SUserRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_body, PUB_s_user WHERE " +
                "PUB_p_form_letter_body.p_owner_c = PUB_s_user.s_user_id_c" + GenerateWhereClauseLong("PUB_s_user", SUserTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, SUserTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ABodyName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ABodyName));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_form_letter_body WHERE p_body_name_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_form_letter_body" + GenerateWhereClause(PFormLetterBodyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PFormLetterBodyTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_form_letter_body", PFormLetterBodyTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_form_letter_body", PFormLetterBodyTable.GetColumnStringList(), PFormLetterBodyTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_form_letter_body", PFormLetterBodyTable.GetColumnStringList(), PFormLetterBodyTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PFormLetterBody", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Configuration info for form letters
    public class PFormLetterDesignAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PFormLetterDesign";

        /// original table name in database
        public const string DBTABLENAME = "p_form_letter_design";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_design_name_c"}) + " FROM PUB_p_form_letter_design")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterDesignTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterDesignTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterDesignTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterDesignTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterDesignTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ADesignName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ADesignName));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_design_name_c"}) + " FROM PUB_p_form_letter_design WHERE p_design_name_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterDesignTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ADesignName, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ADesignName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ADesignName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ADesignName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterDesignTable AData, String ADesignName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterDesignTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ADesignName, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterDesignTable AData, String ADesignName, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ADesignName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterDesignTable AData, String ADesignName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ADesignName, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PFormLetterDesignRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_design_name_c"}) + " FROM PUB_p_form_letter_design")
                            + GenerateWhereClause(PFormLetterDesignTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterDesignTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PFormLetterDesignRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PFormLetterDesignRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterDesignTable AData, PFormLetterDesignRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterDesignTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterDesignTable AData, PFormLetterDesignRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterDesignTable AData, PFormLetterDesignRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterDesignTable AData, PFormLetterDesignRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_design", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ADesignName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ADesignName));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_design WHERE p_design_name_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PFormLetterDesignRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_design" + GenerateWhereClause(PFormLetterDesignTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(DataSet ADataSet, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ABodyName));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_design_name_c"}) + " FROM PUB_p_form_letter_design WHERE p_body_name_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterDesignTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(DataSet AData, String ABodyName, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBody(AData, ABodyName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(DataSet AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBody(AData, ABodyName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(out PFormLetterDesignTable AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterDesignTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPFormLetterBody(FillDataSet, ABodyName, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(out PFormLetterDesignTable AData, String ABodyName, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBody(out AData, ABodyName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(out PFormLetterDesignTable AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBody(out AData, ABodyName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(DataSet ADataSet, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_form_letter_design", AFieldList, new string[] {
                            "p_design_name_c"}) + " FROM PUB_p_form_letter_design, PUB_p_form_letter_body WHERE " +
                            "PUB_p_form_letter_design.p_body_name_c = PUB_p_form_letter_body.p_body_name_c")
                            + GenerateWhereClauseLong("PUB_p_form_letter_body", PFormLetterBodyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterDesignTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(DataSet AData, PFormLetterBodyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(DataSet AData, PFormLetterBodyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(out PFormLetterDesignTable AData, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterDesignTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPFormLetterBodyTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(out PFormLetterDesignTable AData, PFormLetterBodyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(out PFormLetterDesignTable AData, PFormLetterBodyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(out PFormLetterDesignTable AData, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPFormLetterBody(String ABodyName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ABodyName));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_design WHERE p_body_name_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPFormLetterBodyTemplate(PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_design, PUB_p_form_letter_body WHERE " +
                "PUB_p_form_letter_design.p_body_name_c = PUB_p_form_letter_body.p_body_name_c" + GenerateWhereClauseLong("PUB_p_form_letter_body", PFormLetterBodyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PFormLetterBodyTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_design_name_c"}) + " FROM PUB_p_form_letter_design WHERE p_address_layout_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterDesignTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCode(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCode(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(out PFormLetterDesignTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterDesignTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPAddressLayoutCode(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(out PFormLetterDesignTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCode(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCode(out PFormLetterDesignTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCode(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(DataSet ADataSet, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_form_letter_design", AFieldList, new string[] {
                            "p_design_name_c"}) + " FROM PUB_p_form_letter_design, PUB_p_address_layout_code WHERE " +
                            "PUB_p_form_letter_design.p_address_layout_code_c = PUB_p_address_layout_code.p_code_c")
                            + GenerateWhereClauseLong("PUB_p_address_layout_code", PAddressLayoutCodeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterDesignTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(DataSet AData, PAddressLayoutCodeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(DataSet AData, PAddressLayoutCodeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(out PFormLetterDesignTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterDesignTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPAddressLayoutCodeTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(out PFormLetterDesignTable AData, PAddressLayoutCodeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(out PFormLetterDesignTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPAddressLayoutCodeTemplate(out PFormLetterDesignTable AData, PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPAddressLayoutCodeTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPAddressLayoutCode(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_design WHERE p_address_layout_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPAddressLayoutCodeTemplate(PAddressLayoutCodeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_design, PUB_p_address_layout_code WHERE " +
                "PUB_p_form_letter_design.p_address_layout_code_c = PUB_p_address_layout_code.p_code_c" + GenerateWhereClauseLong("PUB_p_address_layout_code", PAddressLayoutCodeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PAddressLayoutCodeTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ADesignName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ADesignName));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_form_letter_design WHERE p_design_name_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PFormLetterDesignRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_form_letter_design" + GenerateWhereClause(PFormLetterDesignTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PFormLetterDesignTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_form_letter_design", PFormLetterDesignTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_form_letter_design", PFormLetterDesignTable.GetColumnStringList(), PFormLetterDesignTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_form_letter_design", PFormLetterDesignTable.GetColumnStringList(), PFormLetterDesignTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PFormLetterDesign", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Insertions for a body of text for a given extract and partner
    public class PFormLetterInsertAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PFormLetterInsert";

        /// original table name in database
        public const string DBTABLENAME = "p_form_letter_insert";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterInsertTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterInsertTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PFormLetterInsertTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 ASequence, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(ASequence));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert WHERE p_sequence_i = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ASequence, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ASequence, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 ASequence, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ASequence, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterInsertTable AData, Int32 ASequence, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ASequence, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterInsertTable AData, Int32 ASequence, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ASequence, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PFormLetterInsertTable AData, Int32 ASequence, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ASequence, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PFormLetterInsertRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert")
                            + GenerateWhereClause(PFormLetterInsertTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PFormLetterInsertRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PFormLetterInsertRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterInsertTable AData, PFormLetterInsertRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterInsertTable AData, PFormLetterInsertRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterInsertTable AData, PFormLetterInsertRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PFormLetterInsertTable AData, PFormLetterInsertRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_insert", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(Int32 ASequence, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(ASequence));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_insert WHERE p_sequence_i = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PFormLetterInsertRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_insert" + GenerateWhereClause(PFormLetterInsertTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(DataSet ADataSet, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ABodyName));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert WHERE p_body_name_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(DataSet AData, String ABodyName, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBody(AData, ABodyName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(DataSet AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBody(AData, ABodyName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(out PFormLetterInsertTable AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPFormLetterBody(FillDataSet, ABodyName, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(out PFormLetterInsertTable AData, String ABodyName, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBody(out AData, ABodyName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBody(out PFormLetterInsertTable AData, String ABodyName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBody(out AData, ABodyName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(DataSet ADataSet, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_form_letter_insert", AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert, PUB_p_form_letter_body WHERE " +
                            "PUB_p_form_letter_insert.p_body_name_c = PUB_p_form_letter_body.p_body_name_c")
                            + GenerateWhereClauseLong("PUB_p_form_letter_body", PFormLetterBodyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(DataSet AData, PFormLetterBodyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(DataSet AData, PFormLetterBodyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(out PFormLetterInsertTable AData, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPFormLetterBodyTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(out PFormLetterInsertTable AData, PFormLetterBodyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(out PFormLetterInsertTable AData, PFormLetterBodyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPFormLetterBodyTemplate(out PFormLetterInsertTable AData, PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPFormLetterBodyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPFormLetterBody(String ABodyName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 40);
            ParametersArray[0].Value = ((object)(ABodyName));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_insert WHERE p_body_name_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPFormLetterBodyTemplate(PFormLetterBodyRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_insert, PUB_p_form_letter_body WHERE " +
                "PUB_p_form_letter_insert.p_body_name_c = PUB_p_form_letter_body.p_body_name_c" + GenerateWhereClauseLong("PUB_p_form_letter_body", PFormLetterBodyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PFormLetterBodyTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert WHERE p_partner_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out PFormLetterInsertTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartner(FillDataSet, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartner(out PFormLetterInsertTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out PFormLetterInsertTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_form_letter_insert", AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert, PUB_p_partner WHERE " +
                            "PUB_p_form_letter_insert.p_partner_key_n = PUB_p_partner.p_partner_key_n")
                            + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PFormLetterInsertTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PFormLetterInsertTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PFormLetterInsertTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PFormLetterInsertTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartner(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_insert WHERE p_partner_key_n = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_insert, PUB_p_partner WHERE " +
                "PUB_p_form_letter_insert.p_partner_key_n = PUB_p_partner.p_partner_key_n" + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet ADataSet, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert WHERE m_extract_id_i = ?")
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet AData, Int32 AExtractId, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(AData, AExtractId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(DataSet AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(AData, AExtractId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out PFormLetterInsertTable AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadViaMExtractMaster(FillDataSet, AExtractId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out PFormLetterInsertTable AData, Int32 AExtractId, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(out AData, AExtractId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMaster(out PFormLetterInsertTable AData, Int32 AExtractId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMaster(out AData, AExtractId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet ADataSet, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_form_letter_insert", AFieldList, new string[] {
                            "p_sequence_i"}) + " FROM PUB_p_form_letter_insert, PUB_m_extract_master WHERE " +
                            "PUB_p_form_letter_insert.m_extract_id_i = PUB_m_extract_master.m_extract_id_i")
                            + GenerateWhereClauseLong("PUB_m_extract_master", MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PFormLetterInsertTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet AData, MExtractMasterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(DataSet AData, MExtractMasterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out PFormLetterInsertTable AData, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PFormLetterInsertTable();
            FillDataSet.Tables.Add(AData);
            LoadViaMExtractMasterTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out PFormLetterInsertTable AData, MExtractMasterRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out PFormLetterInsertTable AData, MExtractMasterRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaMExtractMasterTemplate(out PFormLetterInsertTable AData, MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaMExtractMasterTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaMExtractMaster(Int32 AExtractId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AExtractId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_form_letter_insert WHERE m_extract_id_i = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaMExtractMasterTemplate(MExtractMasterRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_form_letter_insert, PUB_m_extract_master WHERE " +
                "PUB_p_form_letter_insert.m_extract_id_i = PUB_m_extract_master.m_extract_id_i" + GenerateWhereClauseLong("PUB_m_extract_master", MExtractMasterTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, MExtractMasterTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 ASequence, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(ASequence));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_form_letter_insert WHERE p_sequence_i = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PFormLetterInsertRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_form_letter_insert" + GenerateWhereClause(PFormLetterInsertTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PFormLetterInsertTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_form_letter_insert", PFormLetterInsertTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_form_letter_insert", PFormLetterInsertTable.GetColumnStringList(), PFormLetterInsertTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_form_letter_insert", PFormLetterInsertTable.GetColumnStringList(), PFormLetterInsertTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PFormLetterInsert", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Defines the attributes of different label types.  Eg: for address labels.
    public class PLabelAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PLabel";

        /// original table name in database
        public const string DBTABLENAME = "p_label";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_label")
                            + GenerateOrderByClause(AOrderBy)), PLabelTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PLabelTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PLabelTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PLabelTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PLabelTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_label WHERE p_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PLabelTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PLabelTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PLabelTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PLabelTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PLabelTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PLabelRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_label")
                            + GenerateWhereClause(PLabelTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PLabelTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PLabelRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PLabelRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PLabelTable AData, PLabelRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PLabelTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PLabelTable AData, PLabelRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PLabelTable AData, PLabelRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PLabelTable AData, PLabelRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_label", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_label WHERE p_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PLabelRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_label" + GenerateWhereClause(PLabelTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaSForm(DataSet ADataSet, String AFormName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AFormName));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_label WHERE s_form_name_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PLabelTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSForm(DataSet AData, String AFormName, TDBTransaction ATransaction)
        {
            LoadViaSForm(AData, AFormName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSForm(DataSet AData, String AFormName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSForm(AData, AFormName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSForm(out PLabelTable AData, String AFormName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PLabelTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSForm(FillDataSet, AFormName, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSForm(out PLabelTable AData, String AFormName, TDBTransaction ATransaction)
        {
            LoadViaSForm(out AData, AFormName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSForm(out PLabelTable AData, String AFormName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSForm(out AData, AFormName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFormTemplate(DataSet ADataSet, SFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_label", AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_label, PUB_s_form WHERE " +
                            "PUB_p_label.s_form_name_c = PUB_s_form.s_form_name_c")
                            + GenerateWhereClauseLong("PUB_s_form", SFormTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PLabelTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSFormTemplate(DataSet AData, SFormRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSFormTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFormTemplate(DataSet AData, SFormRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFormTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFormTemplate(out PLabelTable AData, SFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PLabelTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSFormTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSFormTemplate(out PLabelTable AData, SFormRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSFormTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFormTemplate(out PLabelTable AData, SFormRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFormTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSFormTemplate(out PLabelTable AData, SFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSFormTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaSForm(String AFormName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AFormName));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_label WHERE s_form_name_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSFormTemplate(SFormRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_label, PUB_s_form WHERE " +
                "PUB_p_label.s_form_name_c = PUB_s_form.s_form_name_c" + GenerateWhereClauseLong("PUB_s_form", SFormTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, SFormTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(ACode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_label WHERE p_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PLabelRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_label" + GenerateWhereClause(PLabelTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PLabelTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_label", PLabelTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_label", PLabelTable.GetColumnStringList(), PLabelTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_label", PLabelTable.GetColumnStringList(), PLabelTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PLabel", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Master record for Mail Merge output creation
    public class PMergeFormAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PMergeForm";

        /// original table name in database
        public const string DBTABLENAME = "p_merge_form";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_merge_form_name_c"}) + " FROM PUB_p_merge_form")
                            + GenerateOrderByClause(AOrderBy)), PMergeFormTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PMergeFormTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMergeFormTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PMergeFormTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PMergeFormTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AMergeFormName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMergeFormName));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_merge_form_name_c"}) + " FROM PUB_p_merge_form WHERE p_merge_form_name_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PMergeFormTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMergeFormName, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMergeFormName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMergeFormName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMergeFormName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMergeFormTable AData, String AMergeFormName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMergeFormTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AMergeFormName, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMergeFormTable AData, String AMergeFormName, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMergeFormName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMergeFormTable AData, String AMergeFormName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMergeFormName, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_merge_form_name_c"}) + " FROM PUB_p_merge_form")
                            + GenerateWhereClause(PMergeFormTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PMergeFormTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PMergeFormRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PMergeFormRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMergeFormTable AData, PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMergeFormTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMergeFormTable AData, PMergeFormRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMergeFormTable AData, PMergeFormRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMergeFormTable AData, PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_merge_form", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String AMergeFormName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMergeFormName));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_merge_form WHERE p_merge_form_name_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_merge_form" + GenerateWhereClause(PMergeFormTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AMergeFormName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMergeFormName));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_merge_form WHERE p_merge_form_name_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_merge_form" + GenerateWhereClause(PMergeFormTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PMergeFormTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_merge_form", PMergeFormTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_merge_form", PMergeFormTable.GetColumnStringList(), PMergeFormTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_merge_form", PMergeFormTable.GetColumnStringList(), PMergeFormTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PMergeForm", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Fields within a Mail Merge Form
    public class PMergeFieldAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PMergeField";

        /// original table name in database
        public const string DBTABLENAME = "p_merge_field";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_merge_form_name_c", "p_merge_field_name_c"}) + " FROM PUB_p_merge_field")
                            + GenerateOrderByClause(AOrderBy)), PMergeFieldTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PMergeFieldTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMergeFieldTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PMergeFieldTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PMergeFieldTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AMergeFormName, String AMergeFieldName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMergeFormName));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AMergeFieldName));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_merge_form_name_c", "p_merge_field_name_c"}) + " FROM PUB_p_merge_field WHERE p_merge_form_name_c = ? AND p_merge_field_name_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PMergeFieldTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMergeFormName, String AMergeFieldName, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMergeFormName, AMergeFieldName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMergeFormName, String AMergeFieldName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMergeFormName, AMergeFieldName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMergeFieldTable AData, String AMergeFormName, String AMergeFieldName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMergeFieldTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AMergeFormName, AMergeFieldName, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMergeFieldTable AData, String AMergeFormName, String AMergeFieldName, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMergeFormName, AMergeFieldName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMergeFieldTable AData, String AMergeFormName, String AMergeFieldName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMergeFormName, AMergeFieldName, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PMergeFieldRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_merge_form_name_c", "p_merge_field_name_c"}) + " FROM PUB_p_merge_field")
                            + GenerateWhereClause(PMergeFieldTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PMergeFieldTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PMergeFieldRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PMergeFieldRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMergeFieldTable AData, PMergeFieldRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMergeFieldTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMergeFieldTable AData, PMergeFieldRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMergeFieldTable AData, PMergeFieldRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMergeFieldTable AData, PMergeFieldRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_merge_field", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String AMergeFormName, String AMergeFieldName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMergeFormName));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AMergeFieldName));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_merge_field WHERE p_merge_form_name_c = ? AND p_merge_field_name_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PMergeFieldRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_merge_field" + GenerateWhereClause(PMergeFieldTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPMergeForm(DataSet ADataSet, String AMergeFormName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMergeFormName));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_merge_form_name_c", "p_merge_field_name_c"}) + " FROM PUB_p_merge_field WHERE p_merge_form_name_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PMergeFieldTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMergeForm(DataSet AData, String AMergeFormName, TDBTransaction ATransaction)
        {
            LoadViaPMergeForm(AData, AMergeFormName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMergeForm(DataSet AData, String AMergeFormName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMergeForm(AData, AMergeFormName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMergeForm(out PMergeFieldTable AData, String AMergeFormName, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMergeFieldTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPMergeForm(FillDataSet, AMergeFormName, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPMergeForm(out PMergeFieldTable AData, String AMergeFormName, TDBTransaction ATransaction)
        {
            LoadViaPMergeForm(out AData, AMergeFormName, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMergeForm(out PMergeFieldTable AData, String AMergeFormName, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMergeForm(out AData, AMergeFormName, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMergeFormTemplate(DataSet ADataSet, PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_merge_field", AFieldList, new string[] {
                            "p_merge_form_name_c", "p_merge_field_name_c"}) + " FROM PUB_p_merge_field, PUB_p_merge_form WHERE " +
                            "PUB_p_merge_field.p_merge_form_name_c = PUB_p_merge_form.p_merge_form_name_c")
                            + GenerateWhereClauseLong("PUB_p_merge_form", PMergeFormTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PMergeFieldTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMergeFormTemplate(DataSet AData, PMergeFormRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMergeFormTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMergeFormTemplate(DataSet AData, PMergeFormRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMergeFormTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMergeFormTemplate(out PMergeFieldTable AData, PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMergeFieldTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPMergeFormTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPMergeFormTemplate(out PMergeFieldTable AData, PMergeFormRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMergeFormTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMergeFormTemplate(out PMergeFieldTable AData, PMergeFormRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMergeFormTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMergeFormTemplate(out PMergeFieldTable AData, PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMergeFormTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPMergeForm(String AMergeFormName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMergeFormName));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_merge_field WHERE p_merge_form_name_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPMergeFormTemplate(PMergeFormRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_merge_field, PUB_p_merge_form WHERE " +
                "PUB_p_merge_field.p_merge_form_name_c = PUB_p_merge_form.p_merge_form_name_c" + GenerateWhereClauseLong("PUB_p_merge_form", PMergeFormTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PMergeFormTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AMergeFormName, String AMergeFieldName, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMergeFormName));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AMergeFieldName));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_merge_field WHERE p_merge_form_name_c = ? AND p_merge_field_name_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PMergeFieldRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_merge_field" + GenerateWhereClause(PMergeFieldTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PMergeFieldTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_merge_field", PMergeFieldTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_merge_field", PMergeFieldTable.GetColumnStringList(), PMergeFieldTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_merge_field", PMergeFieldTable.GetColumnStringList(), PMergeFieldTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PMergeField", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Postcode ranges for each region
    public class PPostcodeRangeAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PPostcodeRange";

        /// original table name in database
        public const string DBTABLENAME = "p_postcode_range";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_range_c"}) + " FROM PUB_p_postcode_range")
                            + GenerateOrderByClause(AOrderBy)), PPostcodeRangeTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPostcodeRangeTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPostcodeRangeTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PPostcodeRangeTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPostcodeRangeTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ARange, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[0].Value = ((object)(ARange));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_range_c"}) + " FROM PUB_p_postcode_range WHERE p_range_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPostcodeRangeTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ARange, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ARange, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ARange, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ARange, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPostcodeRangeTable AData, String ARange, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPostcodeRangeTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ARange, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPostcodeRangeTable AData, String ARange, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ARange, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPostcodeRangeTable AData, String ARange, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ARange, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_range_c"}) + " FROM PUB_p_postcode_range")
                            + GenerateWhereClause(PPostcodeRangeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPostcodeRangeTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPostcodeRangeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPostcodeRangeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPostcodeRangeTable AData, PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPostcodeRangeTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPostcodeRangeTable AData, PPostcodeRangeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPostcodeRangeTable AData, PPostcodeRangeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPostcodeRangeTable AData, PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_postcode_range", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ARange, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[0].Value = ((object)(ARange));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_postcode_range WHERE p_range_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_postcode_range" + GenerateWhereClause(PPostcodeRangeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ARange, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[0].Value = ((object)(ARange));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_postcode_range WHERE p_range_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_postcode_range" + GenerateWhereClause(PPostcodeRangeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PPostcodeRangeTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_postcode_range", PPostcodeRangeTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_postcode_range", PPostcodeRangeTable.GetColumnStringList(), PPostcodeRangeTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_postcode_range", PPostcodeRangeTable.GetColumnStringList(), PPostcodeRangeTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PPostcodeRange", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Postcode regions and the ranges they contain.
    public class PPostcodeRegionAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PPostcodeRegion";

        /// original table name in database
        public const string DBTABLENAME = "p_postcode_region";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_region_c", "p_range_c"}) + " FROM PUB_p_postcode_region")
                            + GenerateOrderByClause(AOrderBy)), PPostcodeRegionTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPostcodeRegionTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPostcodeRegionTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PPostcodeRegionTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPostcodeRegionTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ARegion, String ARange, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[0].Value = ((object)(ARegion));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[1].Value = ((object)(ARange));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_region_c", "p_range_c"}) + " FROM PUB_p_postcode_region WHERE p_region_c = ? AND p_range_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPostcodeRegionTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ARegion, String ARange, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ARegion, ARange, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ARegion, String ARange, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ARegion, ARange, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPostcodeRegionTable AData, String ARegion, String ARange, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPostcodeRegionTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ARegion, ARange, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPostcodeRegionTable AData, String ARegion, String ARange, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ARegion, ARange, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPostcodeRegionTable AData, String ARegion, String ARange, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ARegion, ARange, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PPostcodeRegionRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_region_c", "p_range_c"}) + " FROM PUB_p_postcode_region")
                            + GenerateWhereClause(PPostcodeRegionTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPostcodeRegionTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPostcodeRegionRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPostcodeRegionRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPostcodeRegionTable AData, PPostcodeRegionRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPostcodeRegionTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPostcodeRegionTable AData, PPostcodeRegionRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPostcodeRegionTable AData, PPostcodeRegionRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPostcodeRegionTable AData, PPostcodeRegionRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_postcode_region", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ARegion, String ARange, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[0].Value = ((object)(ARegion));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[1].Value = ((object)(ARange));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_postcode_region WHERE p_region_c = ? AND p_range_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PPostcodeRegionRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_postcode_region" + GenerateWhereClause(PPostcodeRegionTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPPostcodeRange(DataSet ADataSet, String ARange, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[0].Value = ((object)(ARange));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_region_c", "p_range_c"}) + " FROM PUB_p_postcode_region WHERE p_range_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPostcodeRegionTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPostcodeRange(DataSet AData, String ARange, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRange(AData, ARange, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPostcodeRange(DataSet AData, String ARange, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRange(AData, ARange, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPostcodeRange(out PPostcodeRegionTable AData, String ARange, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPostcodeRegionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPostcodeRange(FillDataSet, ARange, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPostcodeRange(out PPostcodeRegionTable AData, String ARange, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRange(out AData, ARange, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPostcodeRange(out PPostcodeRegionTable AData, String ARange, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRange(out AData, ARange, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPostcodeRangeTemplate(DataSet ADataSet, PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_postcode_region", AFieldList, new string[] {
                            "p_region_c", "p_range_c"}) + " FROM PUB_p_postcode_region, PUB_p_postcode_range WHERE " +
                            "PUB_p_postcode_region.p_range_c = PUB_p_postcode_range.p_range_c")
                            + GenerateWhereClauseLong("PUB_p_postcode_range", PPostcodeRangeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPostcodeRegionTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPostcodeRangeTemplate(DataSet AData, PPostcodeRangeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRangeTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPostcodeRangeTemplate(DataSet AData, PPostcodeRangeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRangeTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPostcodeRangeTemplate(out PPostcodeRegionTable AData, PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPostcodeRegionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPostcodeRangeTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPostcodeRangeTemplate(out PPostcodeRegionTable AData, PPostcodeRangeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRangeTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPostcodeRangeTemplate(out PPostcodeRegionTable AData, PPostcodeRangeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRangeTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPostcodeRangeTemplate(out PPostcodeRegionTable AData, PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPostcodeRangeTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPostcodeRange(String ARange, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[0].Value = ((object)(ARange));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_postcode_region WHERE p_range_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPostcodeRangeTemplate(PPostcodeRangeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_postcode_region, PUB_p_postcode_range WHERE " +
                "PUB_p_postcode_region.p_range_c = PUB_p_postcode_range.p_range_c" + GenerateWhereClauseLong("PUB_p_postcode_range", PPostcodeRangeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPostcodeRangeTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ARegion, String ARange, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[0].Value = ((object)(ARegion));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 64);
            ParametersArray[1].Value = ((object)(ARange));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_postcode_region WHERE p_region_c = ? AND p_range_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PPostcodeRegionRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_postcode_region" + GenerateWhereClause(PPostcodeRegionTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PPostcodeRegionTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_postcode_region", PPostcodeRegionTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_postcode_region", PPostcodeRegionTable.GetColumnStringList(), PPostcodeRegionTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_postcode_region", PPostcodeRegionTable.GetColumnStringList(), PPostcodeRegionTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PPostcodeRegion", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Details of a publication
    public class PPublicationAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PPublication";

        /// original table name in database
        public const string DBTABLENAME = "p_publication";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication")
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPublicationTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PPublicationTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPublicationTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication WHERE p_publication_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String APublicationCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, APublicationCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, APublicationCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPublicationTable AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, APublicationCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPublicationTable AData, String APublicationCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, APublicationCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPublicationTable AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, APublicationCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication")
                            + GenerateWhereClause(PPublicationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPublicationRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPublicationRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPublicationTable AData, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPublicationTable AData, PPublicationRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPublicationTable AData, PPublicationRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPublicationTable AData, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String APublicationCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication WHERE p_publication_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PPublicationRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_publication" + GenerateWhereClause(PPublicationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaAFrequency(DataSet ADataSet, String AFrequencyCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AFrequencyCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication WHERE a_frequency_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAFrequency(DataSet AData, String AFrequencyCode, TDBTransaction ATransaction)
        {
            LoadViaAFrequency(AData, AFrequencyCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAFrequency(DataSet AData, String AFrequencyCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAFrequency(AData, AFrequencyCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAFrequency(out PPublicationTable AData, String AFrequencyCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadViaAFrequency(FillDataSet, AFrequencyCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaAFrequency(out PPublicationTable AData, String AFrequencyCode, TDBTransaction ATransaction)
        {
            LoadViaAFrequency(out AData, AFrequencyCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAFrequency(out PPublicationTable AData, String AFrequencyCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAFrequency(out AData, AFrequencyCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAFrequencyTemplate(DataSet ADataSet, AFrequencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_publication", AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication, PUB_a_frequency WHERE " +
                            "PUB_p_publication.a_frequency_code_c = PUB_a_frequency.a_frequency_code_c")
                            + GenerateWhereClauseLong("PUB_a_frequency", AFrequencyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaAFrequencyTemplate(DataSet AData, AFrequencyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAFrequencyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAFrequencyTemplate(DataSet AData, AFrequencyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAFrequencyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAFrequencyTemplate(out PPublicationTable AData, AFrequencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadViaAFrequencyTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaAFrequencyTemplate(out PPublicationTable AData, AFrequencyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaAFrequencyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAFrequencyTemplate(out PPublicationTable AData, AFrequencyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAFrequencyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaAFrequencyTemplate(out PPublicationTable AData, AFrequencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaAFrequencyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaAFrequency(String AFrequencyCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(AFrequencyCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication WHERE a_frequency_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaAFrequencyTemplate(AFrequencyRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_publication, PUB_a_frequency WHERE " +
                "PUB_p_publication.a_frequency_code_c = PUB_a_frequency.a_frequency_code_c" + GenerateWhereClauseLong("PUB_a_frequency", AFrequencyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, AFrequencyTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet ADataSet, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication WHERE p_publication_language_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet AData, String ALanguageCode, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(AData, ALanguageCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(DataSet AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(AData, ALanguageCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PPublicationTable AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPLanguage(FillDataSet, ALanguageCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PPublicationTable AData, String ALanguageCode, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(out AData, ALanguageCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguage(out PPublicationTable AData, String ALanguageCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguage(out AData, ALanguageCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet ADataSet, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_publication", AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication, PUB_p_language WHERE " +
                            "PUB_p_publication.p_publication_language_c = PUB_p_language.p_language_code_c")
                            + GenerateWhereClauseLong("PUB_p_language", PLanguageTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet AData, PLanguageRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(DataSet AData, PLanguageRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PPublicationTable AData, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPLanguageTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PPublicationTable AData, PLanguageRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PPublicationTable AData, PLanguageRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPLanguageTemplate(out PPublicationTable AData, PLanguageRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPLanguageTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPLanguage(String ALanguageCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(ALanguageCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication WHERE p_publication_language_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPLanguageTemplate(PLanguageRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_publication, PUB_p_language WHERE " +
                "PUB_p_publication.p_publication_language_c = PUB_p_language.p_language_code_c" + GenerateWhereClauseLong("PUB_p_language", PLanguageTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PLanguageTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaPPartner(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_p_publication", AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication, PUB_p_subscription WHERE " +
                            "PUB_p_subscription.p_publication_code_c = PUB_p_publication.p_publication_code_c AND PUB_p_subscription.p_partner_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out PPublicationTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartner(FillDataSet, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartner(out PPublicationTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out PPublicationTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_publication", AFieldList, new string[] {
                            "p_publication_code_c"}) + " FROM PUB_p_publication, PUB_p_subscription, PUB_p_partner WHERE " +
                            "PUB_p_subscription.p_publication_code_c = PUB_p_publication.p_publication_code_c AND PUB_p_subscription.p_partner_key_n = PUB_p_partner.p_partner_key_n")
                            + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPublicationTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PPublicationTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PPublicationTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PPublicationTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PPublicationTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaPPartner(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication, PUB_p_subscription WHERE " +
                        "PUB_p_subscription.p_publication_code_c = PUB_p_publication.p_publication_code_c AND PUB_p_subscription.p_partner_key_n = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_publication, PUB_p_subscription, PUB_p_partner WHERE " +
                        "PUB_p_subscription.p_publication_code_c = PUB_p_publication.p_publication_code_c AND PUB_p_subscription.p_partner_key_n = PUB_p_partner.p_partner_key_n" +
                        GenerateWhereClauseLong("PUB_p_subscription", PPublicationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String APublicationCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_publication WHERE p_publication_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PPublicationRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_publication" + GenerateWhereClause(PPublicationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PPublicationTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_publication", PPublicationTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_publication", PPublicationTable.GetColumnStringList(), PPublicationTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_publication", PPublicationTable.GetColumnStringList(), PPublicationTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PPublication", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Cost of a publication
    public class PPublicationCostAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PPublicationCost";

        /// original table name in database
        public const string DBTABLENAME = "p_publication_cost";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_date_effective_d"}) + " FROM PUB_p_publication_cost")
                            + GenerateOrderByClause(AOrderBy)), PPublicationCostTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPublicationCostTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationCostTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PPublicationCostTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPublicationCostTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String APublicationCode, System.DateTime ADateEffective, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Date);
            ParametersArray[1].Value = ((object)(ADateEffective));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_date_effective_d"}) + " FROM PUB_p_publication_cost WHERE p_publication_code_c = ? AND p_date_effective_d = ?")
                            + GenerateOrderByClause(AOrderBy)), PPublicationCostTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String APublicationCode, System.DateTime ADateEffective, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, APublicationCode, ADateEffective, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String APublicationCode, System.DateTime ADateEffective, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, APublicationCode, ADateEffective, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPublicationCostTable AData, String APublicationCode, System.DateTime ADateEffective, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationCostTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, APublicationCode, ADateEffective, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPublicationCostTable AData, String APublicationCode, System.DateTime ADateEffective, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, APublicationCode, ADateEffective, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPublicationCostTable AData, String APublicationCode, System.DateTime ADateEffective, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, APublicationCode, ADateEffective, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PPublicationCostRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_date_effective_d"}) + " FROM PUB_p_publication_cost")
                            + GenerateWhereClause(PPublicationCostTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPublicationCostTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPublicationCostRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPublicationCostRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPublicationCostTable AData, PPublicationCostRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationCostTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPublicationCostTable AData, PPublicationCostRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPublicationCostTable AData, PPublicationCostRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPublicationCostTable AData, PPublicationCostRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication_cost", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String APublicationCode, System.DateTime ADateEffective, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Date);
            ParametersArray[1].Value = ((object)(ADateEffective));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication_cost WHERE p_publication_code_c = ? AND p_date_effective_d = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PPublicationCostRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_publication_cost" + GenerateWhereClause(PPublicationCostTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPPublication(DataSet ADataSet, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_date_effective_d"}) + " FROM PUB_p_publication_cost WHERE p_publication_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPublicationCostTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPublication(DataSet AData, String APublicationCode, TDBTransaction ATransaction)
        {
            LoadViaPPublication(AData, APublicationCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublication(DataSet AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublication(AData, APublicationCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublication(out PPublicationCostTable AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationCostTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPublication(FillDataSet, APublicationCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPublication(out PPublicationCostTable AData, String APublicationCode, TDBTransaction ATransaction)
        {
            LoadViaPPublication(out AData, APublicationCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublication(out PPublicationCostTable AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublication(out AData, APublicationCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(DataSet ADataSet, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_publication_cost", AFieldList, new string[] {
                            "p_publication_code_c", "p_date_effective_d"}) + " FROM PUB_p_publication_cost, PUB_p_publication WHERE " +
                            "PUB_p_publication_cost.p_publication_code_c = PUB_p_publication.p_publication_code_c")
                            + GenerateWhereClauseLong("PUB_p_publication", PPublicationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPublicationCostTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(DataSet AData, PPublicationRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(DataSet AData, PPublicationRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(out PPublicationCostTable AData, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationCostTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPublicationTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(out PPublicationCostTable AData, PPublicationRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(out PPublicationCostTable AData, PPublicationRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(out PPublicationCostTable AData, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPublication(String APublicationCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication_cost WHERE p_publication_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPublicationTemplate(PPublicationRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_publication_cost, PUB_p_publication WHERE " +
                "PUB_p_publication_cost.p_publication_code_c = PUB_p_publication.p_publication_code_c" + GenerateWhereClauseLong("PUB_p_publication", PPublicationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPublicationTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet ADataSet, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(ACurrencyCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_date_effective_d"}) + " FROM PUB_p_publication_cost WHERE p_currency_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPublicationCostTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet AData, String ACurrencyCode, TDBTransaction ATransaction)
        {
            LoadViaACurrency(AData, ACurrencyCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(DataSet AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrency(AData, ACurrencyCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(out PPublicationCostTable AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationCostTable();
            FillDataSet.Tables.Add(AData);
            LoadViaACurrency(FillDataSet, ACurrencyCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaACurrency(out PPublicationCostTable AData, String ACurrencyCode, TDBTransaction ATransaction)
        {
            LoadViaACurrency(out AData, ACurrencyCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrency(out PPublicationCostTable AData, String ACurrencyCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrency(out AData, ACurrencyCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet ADataSet, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_publication_cost", AFieldList, new string[] {
                            "p_publication_code_c", "p_date_effective_d"}) + " FROM PUB_p_publication_cost, PUB_a_currency WHERE " +
                            "PUB_p_publication_cost.p_currency_code_c = PUB_a_currency.a_currency_code_c")
                            + GenerateWhereClauseLong("PUB_a_currency", ACurrencyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPublicationCostTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, ACurrencyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(DataSet AData, ACurrencyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out PPublicationCostTable AData, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPublicationCostTable();
            FillDataSet.Tables.Add(AData);
            LoadViaACurrencyTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out PPublicationCostTable AData, ACurrencyRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out PPublicationCostTable AData, ACurrencyRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaACurrencyTemplate(out PPublicationCostTable AData, ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaACurrencyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaACurrency(String ACurrencyCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(ACurrencyCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_publication_cost WHERE p_currency_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaACurrencyTemplate(ACurrencyRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_publication_cost, PUB_a_currency WHERE " +
                "PUB_p_publication_cost.p_currency_code_c = PUB_a_currency.a_currency_code_c" + GenerateWhereClauseLong("PUB_a_currency", ACurrencyTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, ACurrencyTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String APublicationCode, System.DateTime ADateEffective, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Date);
            ParametersArray[1].Value = ((object)(ADateEffective));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_publication_cost WHERE p_publication_code_c = ? AND p_date_effective_d = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PPublicationCostRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_publication_cost" + GenerateWhereClause(PPublicationCostTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PPublicationCostTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_publication_cost", PPublicationCostTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_publication_cost", PPublicationCostTable.GetColumnStringList(), PPublicationCostTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_publication_cost", PPublicationCostTable.GetColumnStringList(), PPublicationCostTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PPublicationCost", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// List of reasons for giving a subscription
    public class PReasonSubscriptionGivenAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PReasonSubscriptionGiven";

        /// original table name in database
        public const string DBTABLENAME = "p_reason_subscription_given";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_reason_subscription_given")
                            + GenerateOrderByClause(AOrderBy)), PReasonSubscriptionGivenTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PReasonSubscriptionGivenTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PReasonSubscriptionGivenTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PReasonSubscriptionGivenTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PReasonSubscriptionGivenTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_reason_subscription_given WHERE p_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PReasonSubscriptionGivenTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PReasonSubscriptionGivenTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PReasonSubscriptionGivenTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PReasonSubscriptionGivenTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PReasonSubscriptionGivenTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_reason_subscription_given")
                            + GenerateWhereClause(PReasonSubscriptionGivenTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PReasonSubscriptionGivenTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PReasonSubscriptionGivenRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PReasonSubscriptionGivenRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PReasonSubscriptionGivenTable AData, PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PReasonSubscriptionGivenTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PReasonSubscriptionGivenTable AData, PReasonSubscriptionGivenRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PReasonSubscriptionGivenTable AData, PReasonSubscriptionGivenRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PReasonSubscriptionGivenTable AData, PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_reason_subscription_given", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_reason_subscription_given WHERE p_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_reason_subscription_given" + GenerateWhereClause(PReasonSubscriptionGivenTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_reason_subscription_given WHERE p_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_reason_subscription_given" + GenerateWhereClause(PReasonSubscriptionGivenTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PReasonSubscriptionGivenTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_reason_subscription_given", PReasonSubscriptionGivenTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_reason_subscription_given", PReasonSubscriptionGivenTable.GetColumnStringList(), PReasonSubscriptionGivenTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_reason_subscription_given", PReasonSubscriptionGivenTable.GetColumnStringList(), PReasonSubscriptionGivenTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PReasonSubscriptionGiven", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// List of reasons for cancelling a subscription
    public class PReasonSubscriptionCancelledAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PReasonSubscriptionCancelled";

        /// original table name in database
        public const string DBTABLENAME = "p_reason_subscription_cancelled";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_reason_subscription_cancelled")
                            + GenerateOrderByClause(AOrderBy)), PReasonSubscriptionCancelledTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PReasonSubscriptionCancelledTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PReasonSubscriptionCancelledTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PReasonSubscriptionCancelledTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PReasonSubscriptionCancelledTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_reason_subscription_cancelled WHERE p_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PReasonSubscriptionCancelledTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PReasonSubscriptionCancelledTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PReasonSubscriptionCancelledTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PReasonSubscriptionCancelledTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PReasonSubscriptionCancelledTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_code_c"}) + " FROM PUB_p_reason_subscription_cancelled")
                            + GenerateWhereClause(PReasonSubscriptionCancelledTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PReasonSubscriptionCancelledTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PReasonSubscriptionCancelledRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PReasonSubscriptionCancelledTable AData, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PReasonSubscriptionCancelledTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PReasonSubscriptionCancelledTable AData, PReasonSubscriptionCancelledRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PReasonSubscriptionCancelledTable AData, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PReasonSubscriptionCancelledTable AData, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_reason_subscription_cancelled", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_reason_subscription_cancelled WHERE p_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_reason_subscription_cancelled" + GenerateWhereClause(PReasonSubscriptionCancelledTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_reason_subscription_cancelled WHERE p_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_reason_subscription_cancelled" + GenerateWhereClause(PReasonSubscriptionCancelledTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PReasonSubscriptionCancelledTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_reason_subscription_cancelled", PReasonSubscriptionCancelledTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_reason_subscription_cancelled", PReasonSubscriptionCancelledTable.GetColumnStringList(), PReasonSubscriptionCancelledTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_reason_subscription_cancelled", PReasonSubscriptionCancelledTable.GetColumnStringList(), PReasonSubscriptionCancelledTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PReasonSubscriptionCancelled", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Details of which partners receive which publications.
    public class PSubscriptionAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PSubscription";

        /// original table name in database
        public const string DBTABLENAME = "p_subscription";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription")
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PSubscriptionTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PSubscriptionTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PSubscriptionTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String APublicationCode, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription WHERE p_publication_code_c = ? AND p_partner_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String APublicationCode, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, APublicationCode, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String APublicationCode, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, APublicationCode, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PSubscriptionTable AData, String APublicationCode, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, APublicationCode, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PSubscriptionTable AData, String APublicationCode, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, APublicationCode, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PSubscriptionTable AData, String APublicationCode, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, APublicationCode, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PSubscriptionRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription")
                            + GenerateWhereClause(PSubscriptionTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PSubscriptionRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PSubscriptionRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PSubscriptionTable AData, PSubscriptionRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PSubscriptionTable AData, PSubscriptionRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PSubscriptionTable AData, PSubscriptionRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PSubscriptionTable AData, PSubscriptionRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_subscription", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String APublicationCode, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_subscription WHERE p_publication_code_c = ? AND p_partner_key_n = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PSubscriptionRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_subscription" + GenerateWhereClause(PSubscriptionTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPPublication(DataSet ADataSet, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription WHERE p_publication_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPublication(DataSet AData, String APublicationCode, TDBTransaction ATransaction)
        {
            LoadViaPPublication(AData, APublicationCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublication(DataSet AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublication(AData, APublicationCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublication(out PSubscriptionTable AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPublication(FillDataSet, APublicationCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPublication(out PSubscriptionTable AData, String APublicationCode, TDBTransaction ATransaction)
        {
            LoadViaPPublication(out AData, APublicationCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublication(out PSubscriptionTable AData, String APublicationCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublication(out AData, APublicationCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(DataSet ADataSet, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_subscription", AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription, PUB_p_publication WHERE " +
                            "PUB_p_subscription.p_publication_code_c = PUB_p_publication.p_publication_code_c")
                            + GenerateWhereClauseLong("PUB_p_publication", PPublicationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(DataSet AData, PPublicationRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(DataSet AData, PPublicationRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(out PSubscriptionTable AData, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPublicationTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(out PSubscriptionTable AData, PPublicationRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(out PSubscriptionTable AData, PPublicationRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPublicationTemplate(out PSubscriptionTable AData, PPublicationRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPublicationTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPublication(String APublicationCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_subscription WHERE p_publication_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPublicationTemplate(PPublicationRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_subscription, PUB_p_publication WHERE " +
                "PUB_p_subscription.p_publication_code_c = PUB_p_publication.p_publication_code_c" + GenerateWhereClauseLong("PUB_p_publication", PPublicationTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPublicationTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKey(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription WHERE p_partner_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKey(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKey(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKey(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKey(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKey(out PSubscriptionTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerPartnerKey(FillDataSet, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKey(out PSubscriptionTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKey(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKey(out PSubscriptionTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKey(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKeyTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_subscription", AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription, PUB_p_partner WHERE " +
                            "PUB_p_subscription.p_partner_key_n = PUB_p_partner.p_partner_key_n")
                            + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKeyTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKeyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKeyTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKeyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKeyTemplate(out PSubscriptionTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerPartnerKeyTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKeyTemplate(out PSubscriptionTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKeyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKeyTemplate(out PSubscriptionTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKeyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPartnerKeyTemplate(out PSubscriptionTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPartnerKeyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartnerPartnerKey(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_subscription WHERE p_partner_key_n = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerPartnerKeyTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_subscription, PUB_p_partner WHERE " +
                "PUB_p_subscription.p_partner_key_n = PUB_p_partner.p_partner_key_n" + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKey(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription WHERE p_gift_from_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKey(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKey(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKey(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKey(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKey(out PSubscriptionTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerGiftFromKey(FillDataSet, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKey(out PSubscriptionTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKey(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKey(out PSubscriptionTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKey(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKeyTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_subscription", AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription, PUB_p_partner WHERE " +
                            "PUB_p_subscription.p_gift_from_key_n = PUB_p_partner.p_partner_key_n")
                            + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKeyTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKeyTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKeyTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKeyTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKeyTemplate(out PSubscriptionTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerGiftFromKeyTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKeyTemplate(out PSubscriptionTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKeyTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKeyTemplate(out PSubscriptionTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKeyTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerGiftFromKeyTemplate(out PSubscriptionTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerGiftFromKeyTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartnerGiftFromKey(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_subscription WHERE p_gift_from_key_n = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerGiftFromKeyTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_subscription, PUB_p_partner WHERE " +
                "PUB_p_subscription.p_gift_from_key_n = PUB_p_partner.p_partner_key_n" + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGiven(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription WHERE p_reason_subs_given_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGiven(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGiven(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGiven(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGiven(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGiven(out PSubscriptionTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPReasonSubscriptionGiven(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGiven(out PSubscriptionTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGiven(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGiven(out PSubscriptionTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGiven(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGivenTemplate(DataSet ADataSet, PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_subscription", AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription, PUB_p_reason_subscription_given WHERE " +
                            "PUB_p_subscription.p_reason_subs_given_code_c = PUB_p_reason_subscription_given.p_code_c")
                            + GenerateWhereClauseLong("PUB_p_reason_subscription_given", PReasonSubscriptionGivenTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGivenTemplate(DataSet AData, PReasonSubscriptionGivenRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGivenTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGivenTemplate(DataSet AData, PReasonSubscriptionGivenRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGivenTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGivenTemplate(out PSubscriptionTable AData, PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPReasonSubscriptionGivenTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGivenTemplate(out PSubscriptionTable AData, PReasonSubscriptionGivenRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGivenTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGivenTemplate(out PSubscriptionTable AData, PReasonSubscriptionGivenRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGivenTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionGivenTemplate(out PSubscriptionTable AData, PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionGivenTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPReasonSubscriptionGiven(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_subscription WHERE p_reason_subs_given_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPReasonSubscriptionGivenTemplate(PReasonSubscriptionGivenRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_subscription, PUB_p_reason_subscription_given WHERE " +
                "PUB_p_subscription.p_reason_subs_given_code_c = PUB_p_reason_subscription_given.p_code_c" + GenerateWhereClauseLong("PUB_p_reason_subscription_given", PReasonSubscriptionGivenTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PReasonSubscriptionGivenTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelled(DataSet ADataSet, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription WHERE p_reason_subs_cancelled_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelled(DataSet AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelled(AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelled(DataSet AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelled(AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelled(out PSubscriptionTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPReasonSubscriptionCancelled(FillDataSet, ACode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelled(out PSubscriptionTable AData, String ACode, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelled(out AData, ACode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelled(out PSubscriptionTable AData, String ACode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelled(out AData, ACode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelledTemplate(DataSet ADataSet, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_subscription", AFieldList, new string[] {
                            "p_publication_code_c", "p_partner_key_n"}) + " FROM PUB_p_subscription, PUB_p_reason_subscription_cancelled WHERE " +
                            "PUB_p_subscription.p_reason_subs_cancelled_code_c = PUB_p_reason_subscription_cancelled.p_code_c")
                            + GenerateWhereClauseLong("PUB_p_reason_subscription_cancelled", PReasonSubscriptionCancelledTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PSubscriptionTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelledTemplate(DataSet AData, PReasonSubscriptionCancelledRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelledTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelledTemplate(DataSet AData, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelledTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelledTemplate(out PSubscriptionTable AData, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PSubscriptionTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPReasonSubscriptionCancelledTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelledTemplate(out PSubscriptionTable AData, PReasonSubscriptionCancelledRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelledTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelledTemplate(out PSubscriptionTable AData, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelledTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPReasonSubscriptionCancelledTemplate(out PSubscriptionTable AData, PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPReasonSubscriptionCancelledTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPReasonSubscriptionCancelled(String ACode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 24);
            ParametersArray[0].Value = ((object)(ACode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_subscription WHERE p_reason_subs_cancelled_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPReasonSubscriptionCancelledTemplate(PReasonSubscriptionCancelledRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_subscription, PUB_p_reason_subscription_cancelled WHERE " +
                "PUB_p_subscription.p_reason_subs_cancelled_code_c = PUB_p_reason_subscription_cancelled.p_code_c" + GenerateWhereClauseLong("PUB_p_reason_subscription_cancelled", PReasonSubscriptionCancelledTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PReasonSubscriptionCancelledTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String APublicationCode, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(APublicationCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(APartnerKey));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_subscription WHERE p_publication_code_c = ? AND p_partner_key_n = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PSubscriptionRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_subscription" + GenerateWhereClause(PSubscriptionTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PSubscriptionTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_subscription", PSubscriptionTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_subscription", PSubscriptionTable.GetColumnStringList(), PSubscriptionTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_subscription", PSubscriptionTable.GetColumnStringList(), PSubscriptionTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PSubscription", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Possible attributes for partner contacts.  Gives the description of each attribute code.  An attribute is a type of contact that was made or which occurred with a partner.
    public class PContactAttributeAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PContactAttribute";

        /// original table name in database
        public const string DBTABLENAME = "p_contact_attribute";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_attribute_code_c"}) + " FROM PUB_p_contact_attribute")
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PContactAttributeTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PContactAttributeTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PContactAttributeTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AContactAttributeCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_attribute_code_c"}) + " FROM PUB_p_contact_attribute WHERE p_contact_attribute_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AContactAttributeCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AContactAttributeCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AContactAttributeCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AContactAttributeCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PContactAttributeTable AData, String AContactAttributeCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AContactAttributeCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PContactAttributeTable AData, String AContactAttributeCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AContactAttributeCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PContactAttributeTable AData, String AContactAttributeCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AContactAttributeCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_attribute_code_c"}) + " FROM PUB_p_contact_attribute")
                            + GenerateWhereClause(PContactAttributeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PContactAttributeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PContactAttributeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PContactAttributeTable AData, PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PContactAttributeTable AData, PContactAttributeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PContactAttributeTable AData, PContactAttributeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PContactAttributeTable AData, PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_contact_attribute", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String AContactAttributeCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_contact_attribute WHERE p_contact_attribute_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_contact_attribute" + GenerateWhereClause(PContactAttributeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AContactAttributeCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_contact_attribute WHERE p_contact_attribute_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_contact_attribute" + GenerateWhereClause(PContactAttributeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PContactAttributeTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_contact_attribute", PContactAttributeTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_contact_attribute", PContactAttributeTable.GetColumnStringList(), PContactAttributeTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_contact_attribute", PContactAttributeTable.GetColumnStringList(), PContactAttributeTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PContactAttribute", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Possible attribute details for each contact attribute.  Breaks down the attribute into more specifice information that applies to a contact with a partner.
    public class PContactAttributeDetailAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PContactAttributeDetail";

        /// original table name in database
        public const string DBTABLENAME = "p_contact_attribute_detail";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_contact_attribute_detail")
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeDetailTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PContactAttributeDetailTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PContactAttributeDetailTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PContactAttributeDetailTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttrDetailCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_contact_attribute_detail WHERE p_contact_attribute_code_c = ? AND p_contact_attr_detail_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeDetailTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AContactAttributeCode, AContactAttrDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PContactAttributeDetailTable AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PContactAttributeDetailTable AData, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AContactAttributeCode, AContactAttrDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PContactAttributeDetailTable AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_contact_attribute_detail")
                            + GenerateWhereClause(PContactAttributeDetailTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeDetailTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PContactAttributeDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PContactAttributeDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PContactAttributeDetailTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PContactAttributeDetailTable AData, PContactAttributeDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PContactAttributeDetailTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PContactAttributeDetailTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_contact_attribute_detail", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttrDetailCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_contact_attribute_detail WHERE p_contact_attribute_code_c = ? AND p_contact_attr_detail_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_contact_attribute_detail" + GenerateWhereClause(PContactAttributeDetailTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPContactAttribute(DataSet ADataSet, String AContactAttributeCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_contact_attribute_detail WHERE p_contact_attribute_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeDetailTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPContactAttribute(DataSet AData, String AContactAttributeCode, TDBTransaction ATransaction)
        {
            LoadViaPContactAttribute(AData, AContactAttributeCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttribute(DataSet AData, String AContactAttributeCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttribute(AData, AContactAttributeCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttribute(out PContactAttributeDetailTable AData, String AContactAttributeCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPContactAttribute(FillDataSet, AContactAttributeCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPContactAttribute(out PContactAttributeDetailTable AData, String AContactAttributeCode, TDBTransaction ATransaction)
        {
            LoadViaPContactAttribute(out AData, AContactAttributeCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttribute(out PContactAttributeDetailTable AData, String AContactAttributeCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttribute(out AData, AContactAttributeCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeTemplate(DataSet ADataSet, PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_contact_attribute_detail", AFieldList, new string[] {
                            "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_contact_attribute_detail, PUB_p_contact_attribute WHERE " +
                            "PUB_p_contact_attribute_detail.p_contact_attribute_code_c = PUB_p_contact_attribute.p_contact_attribute_code_c")
                            + GenerateWhereClauseLong("PUB_p_contact_attribute", PContactAttributeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeDetailTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPContactAttributeTemplate(DataSet AData, PContactAttributeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeTemplate(DataSet AData, PContactAttributeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeTemplate(out PContactAttributeDetailTable AData, PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPContactAttributeTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPContactAttributeTemplate(out PContactAttributeDetailTable AData, PContactAttributeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeTemplate(out PContactAttributeDetailTable AData, PContactAttributeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeTemplate(out PContactAttributeDetailTable AData, PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPContactAttribute(String AContactAttributeCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_contact_attribute_detail WHERE p_contact_attribute_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPContactAttributeTemplate(PContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_contact_attribute_detail, PUB_p_contact_attribute WHERE " +
                "PUB_p_contact_attribute_detail.p_contact_attribute_code_c = PUB_p_contact_attribute.p_contact_attribute_code_c" + GenerateWhereClauseLong("PUB_p_contact_attribute", PContactAttributeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PContactAttributeTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaPPartnerContact(DataSet ADataSet, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_p_contact_attribute_detail", AFieldList, new string[] {
                            "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_contact_attribute_detail, PUB_p_partner_contact_attribute WHERE " +
                            "PUB_p_partner_contact_attribute.p_contact_attribute_code_c = PUB_p_contact_attribute_detail.p_contact_attribute_code_c AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = PUB_p_contact_attribute_detail.p_contact_attr_detail_code_c AND PUB_p_partner_contact_attribute.p_contact_id_i = ?")
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeDetailTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(DataSet AData, Int32 AContactId, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContact(AData, AContactId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(DataSet AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContact(AData, AContactId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(out PContactAttributeDetailTable AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerContact(FillDataSet, AContactId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(out PContactAttributeDetailTable AData, Int32 AContactId, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContact(out AData, AContactId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(out PContactAttributeDetailTable AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContact(out AData, AContactId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(DataSet ADataSet, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_contact_attribute_detail", AFieldList, new string[] {
                            "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_contact_attribute_detail, PUB_p_partner_contact_attribute, PUB_p_partner_contact WHERE " +
                            "PUB_p_partner_contact_attribute.p_contact_attribute_code_c = PUB_p_contact_attribute_detail.p_contact_attribute_code_c AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = PUB_p_contact_attribute_detail.p_contact_attr_detail_code_c AND PUB_p_partner_contact_attribute.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i")
                            + GenerateWhereClauseLong("PUB_p_partner_contact", PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PContactAttributeDetailTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(DataSet AData, PPartnerContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(DataSet AData, PPartnerContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(out PContactAttributeDetailTable AData, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PContactAttributeDetailTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerContactTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(out PContactAttributeDetailTable AData, PPartnerContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(out PContactAttributeDetailTable AData, PPartnerContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(out PContactAttributeDetailTable AData, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaPPartnerContact(Int32 AContactId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_contact_attribute_detail, PUB_p_partner_contact_attribute WHERE " +
                        "PUB_p_partner_contact_attribute.p_contact_attribute_code_c = PUB_p_contact_attribute_detail.p_contact_attribute_code_c AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = PUB_p_contact_attribute_detail.p_contact_attr_detail_code_c AND PUB_p_partner_contact_attribute.p_contact_id_i = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerContactTemplate(PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_contact_attribute_detail, PUB_p_partner_contact_attribute, PUB_p_partner_contact WHERE " +
                        "PUB_p_partner_contact_attribute.p_contact_attribute_code_c = PUB_p_contact_attribute_detail.p_contact_attribute_code_c AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = PUB_p_contact_attribute_detail.p_contact_attr_detail_code_c AND PUB_p_partner_contact_attribute.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i" +
                        GenerateWhereClauseLong("PUB_p_partner_contact_attribute", PContactAttributeDetailTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerContactTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttrDetailCode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_contact_attribute_detail WHERE p_contact_attribute_code_c = ? AND p_contact_attr_detail_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_contact_attribute_detail" + GenerateWhereClause(PContactAttributeDetailTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PContactAttributeDetailTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_contact_attribute_detail", PContactAttributeDetailTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_contact_attribute_detail", PContactAttributeDetailTable.GetColumnStringList(), PContactAttributeDetailTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_contact_attribute_detail", PContactAttributeDetailTable.GetColumnStringList(), PContactAttributeDetailTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PContactAttributeDetail", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// How contacts are made
    public class PMethodOfContactAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PMethodOfContact";

        /// original table name in database
        public const string DBTABLENAME = "p_method_of_contact";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_method_of_contact_code_c"}) + " FROM PUB_p_method_of_contact")
                            + GenerateOrderByClause(AOrderBy)), PMethodOfContactTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PMethodOfContactTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMethodOfContactTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PMethodOfContactTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PMethodOfContactTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, String AMethodOfContactCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMethodOfContactCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_method_of_contact_code_c"}) + " FROM PUB_p_method_of_contact WHERE p_method_of_contact_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PMethodOfContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMethodOfContactCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMethodOfContactCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, String AMethodOfContactCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AMethodOfContactCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMethodOfContactTable AData, String AMethodOfContactCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMethodOfContactTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AMethodOfContactCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMethodOfContactTable AData, String AMethodOfContactCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMethodOfContactCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PMethodOfContactTable AData, String AMethodOfContactCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AMethodOfContactCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_method_of_contact_code_c"}) + " FROM PUB_p_method_of_contact")
                            + GenerateWhereClause(PMethodOfContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PMethodOfContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PMethodOfContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PMethodOfContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMethodOfContactTable AData, PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PMethodOfContactTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMethodOfContactTable AData, PMethodOfContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMethodOfContactTable AData, PMethodOfContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PMethodOfContactTable AData, PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_method_of_contact", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(String AMethodOfContactCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMethodOfContactCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_method_of_contact WHERE p_method_of_contact_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_method_of_contact" + GenerateWhereClause(PMethodOfContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(String AMethodOfContactCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMethodOfContactCode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_method_of_contact WHERE p_method_of_contact_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_method_of_contact" + GenerateWhereClause(PMethodOfContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PMethodOfContactTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_method_of_contact", PMethodOfContactTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_method_of_contact", PMethodOfContactTable.GetColumnStringList(), PMethodOfContactTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_method_of_contact", PMethodOfContactTable.GetColumnStringList(), PMethodOfContactTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PMethodOfContact", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Details of contacts with partners
    public class PPartnerContactAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PPartnerContact";

        /// original table name in database
        public const string DBTABLENAME = "p_partner_contact";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPartnerContactTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PPartnerContactTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPartnerContactTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact WHERE p_contact_id_i = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AContactId, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AContactId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AContactId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPartnerContactTable AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AContactId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPartnerContactTable AData, Int32 AContactId, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AContactId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPartnerContactTable AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AContactId, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact")
                            + GenerateWhereClause(PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPartnerContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPartnerContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPartnerContactTable AData, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPartnerContactTable AData, PPartnerContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPartnerContactTable AData, PPartnerContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPartnerContactTable AData, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(Int32 AContactId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact WHERE p_contact_id_i = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact" + GenerateWhereClause(PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact WHERE p_partner_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out PPartnerContactTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartner(FillDataSet, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartner(out PPartnerContactTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartner(out PPartnerContactTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartner(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_p_partner WHERE " +
                            "PUB_p_partner_contact.p_partner_key_n = PUB_p_partner.p_partner_key_n")
                            + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PPartnerContactTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PPartnerContactTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PPartnerContactTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerTemplate(out PPartnerContactTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartner(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact WHERE p_partner_key_n = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_p_partner WHERE " +
                "PUB_p_partner_contact.p_partner_key_n = PUB_p_partner.p_partner_key_n" + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet ADataSet, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(AMailingCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact WHERE p_mailing_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet AData, String AMailingCode, TDBTransaction ATransaction)
        {
            LoadViaPMailing(AData, AMailingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(DataSet AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailing(AData, AMailingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(out PPartnerContactTable AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPMailing(FillDataSet, AMailingCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPMailing(out PPartnerContactTable AData, String AMailingCode, TDBTransaction ATransaction)
        {
            LoadViaPMailing(out AData, AMailingCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailing(out PPartnerContactTable AData, String AMailingCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailing(out AData, AMailingCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet ADataSet, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_p_mailing WHERE " +
                            "PUB_p_partner_contact.p_mailing_code_c = PUB_p_mailing.p_mailing_code_c")
                            + GenerateWhereClauseLong("PUB_p_mailing", PMailingTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, PMailingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(DataSet AData, PMailingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out PPartnerContactTable AData, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPMailingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out PPartnerContactTable AData, PMailingRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out PPartnerContactTable AData, PMailingRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMailingTemplate(out PPartnerContactTable AData, PMailingRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMailingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPMailing(String AMailingCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 50);
            ParametersArray[0].Value = ((object)(AMailingCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact WHERE p_mailing_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPMailingTemplate(PMailingRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_p_mailing WHERE " +
                "PUB_p_partner_contact.p_mailing_code_c = PUB_p_mailing.p_mailing_code_c" + GenerateWhereClauseLong("PUB_p_mailing", PMailingTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PMailingTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPMethodOfContact(DataSet ADataSet, String AMethodOfContactCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMethodOfContactCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact WHERE p_contact_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMethodOfContact(DataSet AData, String AMethodOfContactCode, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContact(AData, AMethodOfContactCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMethodOfContact(DataSet AData, String AMethodOfContactCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContact(AData, AMethodOfContactCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMethodOfContact(out PPartnerContactTable AData, String AMethodOfContactCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPMethodOfContact(FillDataSet, AMethodOfContactCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPMethodOfContact(out PPartnerContactTable AData, String AMethodOfContactCode, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContact(out AData, AMethodOfContactCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMethodOfContact(out PPartnerContactTable AData, String AMethodOfContactCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContact(out AData, AMethodOfContactCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMethodOfContactTemplate(DataSet ADataSet, PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_p_method_of_contact WHERE " +
                            "PUB_p_partner_contact.p_contact_code_c = PUB_p_method_of_contact.p_method_of_contact_code_c")
                            + GenerateWhereClauseLong("PUB_p_method_of_contact", PMethodOfContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPMethodOfContactTemplate(DataSet AData, PMethodOfContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContactTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMethodOfContactTemplate(DataSet AData, PMethodOfContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContactTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMethodOfContactTemplate(out PPartnerContactTable AData, PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPMethodOfContactTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPMethodOfContactTemplate(out PPartnerContactTable AData, PMethodOfContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContactTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMethodOfContactTemplate(out PPartnerContactTable AData, PMethodOfContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContactTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPMethodOfContactTemplate(out PPartnerContactTable AData, PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPMethodOfContactTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPMethodOfContact(String AMethodOfContactCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 16);
            ParametersArray[0].Value = ((object)(AMethodOfContactCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact WHERE p_contact_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPMethodOfContactTemplate(PMethodOfContactRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_p_method_of_contact WHERE " +
                "PUB_p_partner_contact.p_contact_code_c = PUB_p_method_of_contact.p_method_of_contact_code_c" + GenerateWhereClauseLong("PUB_p_method_of_contact", PMethodOfContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PMethodOfContactTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaSModule(DataSet ADataSet, String AModuleId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AModuleId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact WHERE s_module_id_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSModule(DataSet AData, String AModuleId, TDBTransaction ATransaction)
        {
            LoadViaSModule(AData, AModuleId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSModule(DataSet AData, String AModuleId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSModule(AData, AModuleId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSModule(out PPartnerContactTable AData, String AModuleId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSModule(FillDataSet, AModuleId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSModule(out PPartnerContactTable AData, String AModuleId, TDBTransaction ATransaction)
        {
            LoadViaSModule(out AData, AModuleId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSModule(out PPartnerContactTable AData, String AModuleId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSModule(out AData, AModuleId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSModuleTemplate(DataSet ADataSet, SModuleRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_s_module WHERE " +
                            "PUB_p_partner_contact.s_module_id_c = PUB_s_module.s_module_id_c")
                            + GenerateWhereClauseLong("PUB_s_module", SModuleTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSModuleTemplate(DataSet AData, SModuleRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSModuleTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSModuleTemplate(DataSet AData, SModuleRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSModuleTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSModuleTemplate(out PPartnerContactTable AData, SModuleRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSModuleTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSModuleTemplate(out PPartnerContactTable AData, SModuleRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSModuleTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSModuleTemplate(out PPartnerContactTable AData, SModuleRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSModuleTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSModuleTemplate(out PPartnerContactTable AData, SModuleRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSModuleTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaSModule(String AModuleId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AModuleId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact WHERE s_module_id_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSModuleTemplate(SModuleRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_s_module WHERE " +
                "PUB_p_partner_contact.s_module_id_c = PUB_s_module.s_module_id_c" + GenerateWhereClauseLong("PUB_s_module", SModuleTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, SModuleTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaSUser(DataSet ADataSet, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AUserId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact WHERE s_user_id_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSUser(DataSet AData, String AUserId, TDBTransaction ATransaction)
        {
            LoadViaSUser(AData, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(DataSet AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUser(AData, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(out PPartnerContactTable AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSUser(FillDataSet, AUserId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSUser(out PPartnerContactTable AData, String AUserId, TDBTransaction ATransaction)
        {
            LoadViaSUser(out AData, AUserId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUser(out PPartnerContactTable AData, String AUserId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUser(out AData, AUserId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet ADataSet, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_s_user WHERE " +
                            "PUB_p_partner_contact.s_user_id_c = PUB_s_user.s_user_id_c")
                            + GenerateWhereClauseLong("PUB_s_user", SUserTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet AData, SUserRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(DataSet AData, SUserRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PPartnerContactTable AData, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSUserTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PPartnerContactTable AData, SUserRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PPartnerContactTable AData, SUserRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSUserTemplate(out PPartnerContactTable AData, SUserRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSUserTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaSUser(String AUserId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AUserId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact WHERE s_user_id_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSUserTemplate(SUserRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_s_user WHERE " +
                "PUB_p_partner_contact.s_user_id_c = PUB_s_user.s_user_id_c" + GenerateWhereClauseLong("PUB_s_user", SUserTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, SUserTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaPContactAttributeDetail(DataSet ADataSet, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttrDetailCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_p_partner_contact_attribute WHERE " +
                            "PUB_p_partner_contact_attribute.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_p_partner_contact_attribute.p_contact_attribute_code_c = ? AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(DataSet AData, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetail(AData, AContactAttributeCode, AContactAttrDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(DataSet AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetail(AData, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(out PPartnerContactTable AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPContactAttributeDetail(FillDataSet, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(out PPartnerContactTable AData, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetail(out AData, AContactAttributeCode, AContactAttrDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(out PPartnerContactTable AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetail(out AData, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(DataSet ADataSet, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_p_partner_contact_attribute, PUB_p_contact_attribute_detail WHERE " +
                            "PUB_p_partner_contact_attribute.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_p_partner_contact_attribute.p_contact_attribute_code_c = PUB_p_contact_attribute_detail.p_contact_attribute_code_c AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = PUB_p_contact_attribute_detail.p_contact_attr_detail_code_c")
                            + GenerateWhereClauseLong("PUB_p_contact_attribute_detail", PContactAttributeDetailTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(DataSet AData, PContactAttributeDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(DataSet AData, PContactAttributeDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(out PPartnerContactTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPContactAttributeDetailTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(out PPartnerContactTable AData, PContactAttributeDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(out PPartnerContactTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(out PPartnerContactTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaPContactAttributeDetail(String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttrDetailCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_p_partner_contact_attribute WHERE " +
                        "PUB_p_partner_contact_attribute.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_p_partner_contact_attribute.p_contact_attribute_code_c = ? AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPContactAttributeDetailTemplate(PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_p_partner_contact_attribute, PUB_p_contact_attribute_detail WHERE " +
                        "PUB_p_partner_contact_attribute.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_p_partner_contact_attribute.p_contact_attribute_code_c = PUB_p_contact_attribute_detail.p_contact_attribute_code_c AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = PUB_p_contact_attribute_detail.p_contact_attr_detail_code_c" +
                        GenerateWhereClauseLong("PUB_p_partner_contact_attribute", PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PContactAttributeDetailTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaPPartnerPPartnerReminder(DataSet ADataSet, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_p_partner_reminder WHERE " +
                            "PUB_p_partner_reminder.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_p_partner_reminder.p_partner_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminder(DataSet AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminder(AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminder(DataSet AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminder(AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminder(out PPartnerContactTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerPPartnerReminder(FillDataSet, APartnerKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminder(out PPartnerContactTable AData, Int64 APartnerKey, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminder(out AData, APartnerKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminder(out PPartnerContactTable AData, Int64 APartnerKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminder(out AData, APartnerKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminderTemplate(DataSet ADataSet, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_p_partner_reminder, PUB_p_partner WHERE " +
                            "PUB_p_partner_reminder.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_p_partner_reminder.p_partner_key_n = PUB_p_partner.p_partner_key_n")
                            + GenerateWhereClauseLong("PUB_p_partner", PPartnerTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminderTemplate(DataSet AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminderTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminderTemplate(DataSet AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminderTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminderTemplate(out PPartnerContactTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerPPartnerReminderTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminderTemplate(out PPartnerContactTable AData, PPartnerRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminderTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminderTemplate(out PPartnerContactTable AData, PPartnerRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminderTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerPPartnerReminderTemplate(out PPartnerContactTable AData, PPartnerRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerPPartnerReminderTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaPPartnerPPartnerReminder(Int64 APartnerKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[0].Value = ((object)(APartnerKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_p_partner_reminder WHERE " +
                        "PUB_p_partner_reminder.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_p_partner_reminder.p_partner_key_n = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerPPartnerReminderTemplate(PPartnerRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_p_partner_reminder, PUB_p_partner WHERE " +
                        "PUB_p_partner_reminder.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_p_partner_reminder.p_partner_key_n = PUB_p_partner.p_partner_key_n" +
                        GenerateWhereClauseLong("PUB_p_partner_reminder", PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated LoadViaLinkTable
        public static void LoadViaSGroup(DataSet ADataSet, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AGroupId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(AUnitKey));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_s_group_partner_contact WHERE " +
                            "PUB_s_group_partner_contact.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_s_group_partner_contact.s_group_id_c = ? AND PUB_s_group_partner_contact.s_group_unit_key_n = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroup(DataSet AData, String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            LoadViaSGroup(AData, AGroupId, AUnitKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(DataSet AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroup(AData, AGroupId, AUnitKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(out PPartnerContactTable AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroup(FillDataSet, AGroupId, AUnitKey, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroup(out PPartnerContactTable AData, String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            LoadViaSGroup(out AData, AGroupId, AUnitKey, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroup(out PPartnerContactTable AData, String AGroupId, Int64 AUnitKey, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroup(out AData, AGroupId, AUnitKey, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet ADataSet, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact", AFieldList, new string[] {
                            "p_contact_id_i"}) + " FROM PUB_p_partner_contact, PUB_s_group_partner_contact, PUB_s_group WHERE " +
                            "PUB_s_group_partner_contact.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_s_group_partner_contact.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_partner_contact.s_group_unit_key_n = PUB_s_group.s_unit_key_n")
                            + GenerateWhereClauseLong("PUB_s_group", SGroupTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, SGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(DataSet AData, SGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out PPartnerContactTable AData, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactTable();
            FillDataSet.Tables.Add(AData);
            LoadViaSGroupTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out PPartnerContactTable AData, SGroupRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out PPartnerContactTable AData, SGroupRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaSGroupTemplate(out PPartnerContactTable AData, SGroupRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaSGroupTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated CountViaLinkTable
        public static int CountViaSGroup(String AGroupId, Int64 AUnitKey, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 20);
            ParametersArray[0].Value = ((object)(AGroupId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.Decimal, 10);
            ParametersArray[1].Value = ((object)(AUnitKey));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_s_group_partner_contact WHERE " +
                        "PUB_s_group_partner_contact.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_s_group_partner_contact.s_group_id_c = ? AND PUB_s_group_partner_contact.s_group_unit_key_n = ?",
                        ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaSGroupTemplate(SGroupRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact, PUB_s_group_partner_contact, PUB_s_group WHERE " +
                        "PUB_s_group_partner_contact.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i AND PUB_s_group_partner_contact.s_group_id_c = PUB_s_group.s_group_id_c AND PUB_s_group_partner_contact.s_group_unit_key_n = PUB_s_group.s_unit_key_n" +
                        GenerateWhereClauseLong("PUB_s_group_partner_contact", PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, SGroupTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 AContactId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_partner_contact WHERE p_contact_id_i = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_partner_contact" + GenerateWhereClause(PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PPartnerContactTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        ((PPartnerContactRow)(TheRow)).ContactId = ((Int32)(DBAccess.GDBAccessObj.GetNextSequenceValue("seq_contact", ATransaction)));
                        TTypedDataAccess.InsertRow("p_partner_contact", PPartnerContactTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_partner_contact", PPartnerContactTable.GetColumnStringList(), PPartnerContactTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_partner_contact", PPartnerContactTable.GetColumnStringList(), PPartnerContactTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PPartnerContact", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }

    /// Associates a p_contact_attribute_detail with a p_partner_contact.  A contact with a partner may have more than one p_contact_attribute_detail associated with it.
    public class PPartnerContactAttributeAccess : TTypedDataAccess
    {

        /// CamelCase version of table name
        public const string DATATABLENAME = "PPartnerContactAttribute";

        /// original table name in database
        public const string DBTABLENAME = "p_partner_contact_attribute";

        /// this method is called by all overloads
        public static void LoadAll(DataSet ADataSet, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i", "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_partner_contact_attribute")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactAttributeTable.GetTableName(), ATransaction, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, TDBTransaction ATransaction)
        {
            LoadAll(AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(DataSet AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPartnerContactAttributeTable AData, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadAll(FillDataSet, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadAll(out PPartnerContactAttributeTable AData, TDBTransaction ATransaction)
        {
            LoadAll(out AData, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadAll(out PPartnerContactAttributeTable AData, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadAll(out AData, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadByPrimaryKey(DataSet ADataSet, Int32 AContactId, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttributeCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[2].Value = ((object)(AContactAttrDetailCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i", "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_partner_contact_attribute WHERE p_contact_id_i = ? AND p_contact_attribute_code_c = ? AND p_contact_attr_detail_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactAttributeTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AContactId, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AContactId, AContactAttributeCode, AContactAttrDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(DataSet AData, Int32 AContactId, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(AData, AContactId, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPartnerContactAttributeTable AData, Int32 AContactId, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadByPrimaryKey(FillDataSet, AContactId, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPartnerContactAttributeTable AData, Int32 AContactId, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AContactId, AContactAttributeCode, AContactAttrDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadByPrimaryKey(out PPartnerContactAttributeTable AData, Int32 AContactId, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadByPrimaryKey(out AData, AContactId, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static void LoadUsingTemplate(DataSet ADataSet, PPartnerContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i", "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_partner_contact_attribute")
                            + GenerateWhereClause(PPartnerContactAttributeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactAttributeTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPartnerContactAttributeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(DataSet AData, PPartnerContactAttributeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPartnerContactAttributeTable AData, PPartnerContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadUsingTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPartnerContactAttributeTable AData, PPartnerContactAttributeRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPartnerContactAttributeTable AData, PPartnerContactAttributeRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadUsingTemplate(out PPartnerContactAttributeTable AData, PPartnerContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadUsingTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// this method is called by all overloads
        public static int CountAll(TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact_attribute", ATransaction, false));
        }

        /// this method is called by all overloads
        public static int CountByPrimaryKey(Int32 AContactId, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttributeCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[2].Value = ((object)(AContactAttrDetailCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact_attribute WHERE p_contact_id_i = ? AND p_contact_attribute_code_c = ? AND p_contact_attr_detail_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// this method is called by all overloads
        public static int CountUsingTemplate(PPartnerContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact_attribute" + GenerateWhereClause(PPartnerContactAttributeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow)));
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(DataSet ADataSet, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttrDetailCode));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i", "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_partner_contact_attribute WHERE p_contact_attribute_code_c = ? AND p_contact_attr_detail_code_c = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactAttributeTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(DataSet AData, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetail(AData, AContactAttributeCode, AContactAttrDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(DataSet AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetail(AData, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(out PPartnerContactAttributeTable AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPContactAttributeDetail(FillDataSet, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(out PPartnerContactAttributeTable AData, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetail(out AData, AContactAttributeCode, AContactAttrDetailCode, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetail(out PPartnerContactAttributeTable AData, String AContactAttributeCode, String AContactAttrDetailCode, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetail(out AData, AContactAttributeCode, AContactAttrDetailCode, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(DataSet ADataSet, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact_attribute", AFieldList, new string[] {
                            "p_contact_id_i", "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_partner_contact_attribute, PUB_p_contact_attribute_detail WHERE " +
                            "PUB_p_partner_contact_attribute.p_contact_attribute_code_c = PUB_p_contact_attribute_detail.p_contact_attribute_code_c AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = PUB_p_contact_attribute_detail.p_contact_attr_detail_code_c")
                            + GenerateWhereClauseLong("PUB_p_contact_attribute_detail", PContactAttributeDetailTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactAttributeTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(DataSet AData, PContactAttributeDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(DataSet AData, PContactAttributeDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(out PPartnerContactAttributeTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPContactAttributeDetailTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(out PPartnerContactAttributeTable AData, PContactAttributeDetailRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(out PPartnerContactAttributeTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPContactAttributeDetailTemplate(out PPartnerContactAttributeTable AData, PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPContactAttributeDetailTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPContactAttributeDetail(String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[2];
            ParametersArray[0] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[0].Value = ((object)(AContactAttributeCode));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttrDetailCode));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact_attribute WHERE p_contact_attribute_code_c = ? AND p_contact_attr_detail_code_c = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPContactAttributeDetailTemplate(PContactAttributeDetailRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact_attribute, PUB_p_contact_attribute_detail WHERE " +
                "PUB_p_partner_contact_attribute.p_contact_attribute_code_c = PUB_p_contact_attribute_detail.p_contact_attribute_code_c AND PUB_p_partner_contact_attribute.p_contact_attr_detail_code_c = PUB_p_contact_attribute_detail.p_contact_attr_detail_code_c" + GenerateWhereClauseLong("PUB_p_contact_attribute_detail", PContactAttributeDetailTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PContactAttributeDetailTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void LoadViaPPartnerContact(DataSet ADataSet, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, ((GenerateSelectClause(AFieldList, new string[] {
                            "p_contact_id_i", "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_partner_contact_attribute WHERE p_contact_id_i = ?")
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactAttributeTable.GetTableName(), ATransaction, ParametersArray, AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(DataSet AData, Int32 AContactId, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContact(AData, AContactId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(DataSet AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContact(AData, AContactId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(out PPartnerContactAttributeTable AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerContact(FillDataSet, AContactId, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(out PPartnerContactAttributeTable AData, Int32 AContactId, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContact(out AData, AContactId, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContact(out PPartnerContactAttributeTable AData, Int32 AContactId, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContact(out AData, AContactId, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(DataSet ADataSet, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            ADataSet = DBAccess.GDBAccessObj.Select(ADataSet, (((GenerateSelectClauseLong("PUB_p_partner_contact_attribute", AFieldList, new string[] {
                            "p_contact_id_i", "p_contact_attribute_code_c", "p_contact_attr_detail_code_c"}) + " FROM PUB_p_partner_contact_attribute, PUB_p_partner_contact WHERE " +
                            "PUB_p_partner_contact_attribute.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i")
                            + GenerateWhereClauseLong("PUB_p_partner_contact", PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators))
                            + GenerateOrderByClause(AOrderBy)), PPartnerContactAttributeTable.GetTableName(), ATransaction, GetParametersForWhereClause(ATemplateRow), AStartRecord, AMaxRecords);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(DataSet AData, PPartnerContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(DataSet AData, PPartnerContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(out PPartnerContactAttributeTable AData, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction, StringCollection AOrderBy, int AStartRecord, int AMaxRecords)
        {
            DataSet FillDataSet = new DataSet();
            AData = new PPartnerContactAttributeTable();
            FillDataSet.Tables.Add(AData);
            LoadViaPPartnerContactTemplate(FillDataSet, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, AOrderBy, AStartRecord, AMaxRecords);
            FillDataSet.Tables.Remove(AData);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(out PPartnerContactAttributeTable AData, PPartnerContactRow ATemplateRow, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(out AData, ATemplateRow, null, null, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(out PPartnerContactAttributeTable AData, PPartnerContactRow ATemplateRow, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(out AData, ATemplateRow, null, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static void LoadViaPPartnerContactTemplate(out PPartnerContactAttributeTable AData, PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, StringCollection AFieldList, TDBTransaction ATransaction)
        {
            LoadViaPPartnerContactTemplate(out AData, ATemplateRow, ATemplateOperators, AFieldList, ATransaction, null, 0, 0);
        }

        /// auto generated
        public static int CountViaPPartnerContact(Int32 AContactId, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[1];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar("SELECT COUNT(*) FROM PUB_p_partner_contact_attribute WHERE p_contact_id_i = ?", ATransaction, false, ParametersArray));
        }

        /// auto generated
        public static int CountViaPPartnerContactTemplate(PPartnerContactRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            return Convert.ToInt32(DBAccess.GDBAccessObj.ExecuteScalar(("SELECT COUNT(*) FROM PUB_p_partner_contact_attribute, PUB_p_partner_contact WHERE " +
                "PUB_p_partner_contact_attribute.p_contact_id_i = PUB_p_partner_contact.p_contact_id_i" + GenerateWhereClauseLong("PUB_p_partner_contact", PPartnerContactTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow, PPartnerContactTable.GetPrimKeyColumnOrdList())));
        }

        /// auto generated
        public static void DeleteByPrimaryKey(Int32 AContactId, String AContactAttributeCode, String AContactAttrDetailCode, TDBTransaction ATransaction)
        {
            OdbcParameter[] ParametersArray = new OdbcParameter[3];
            ParametersArray[0] = new OdbcParameter("", OdbcType.Int);
            ParametersArray[0].Value = ((object)(AContactId));
            ParametersArray[1] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[1].Value = ((object)(AContactAttributeCode));
            ParametersArray[2] = new OdbcParameter("", OdbcType.VarChar, 32);
            ParametersArray[2].Value = ((object)(AContactAttrDetailCode));
            DBAccess.GDBAccessObj.ExecuteNonQuery("DELETE FROM PUB_p_partner_contact_attribute WHERE p_contact_id_i = ? AND p_contact_attribute_code_c = ? AND p_contact_attr_detail_code_c = ?", ATransaction, false, ParametersArray);
        }

        /// auto generated
        public static void DeleteUsingTemplate(PPartnerContactAttributeRow ATemplateRow, StringCollection ATemplateOperators, TDBTransaction ATransaction)
        {
            DBAccess.GDBAccessObj.ExecuteNonQuery(("DELETE FROM PUB_p_partner_contact_attribute" + GenerateWhereClause(PPartnerContactAttributeTable.GetColumnStringList(), ATemplateRow, ATemplateOperators)), ATransaction, false, GetParametersForWhereClause(ATemplateRow));
        }

        /// auto generated
        public static bool SubmitChanges(PPartnerContactAttributeTable ATable, TDBTransaction ATransaction, out TVerificationResultCollection AVerificationResult)
        {
            bool ResultValue = true;
            bool ExceptionReported = false;
            DataRow TheRow = null;
            AVerificationResult = new TVerificationResultCollection();
            for (RowCount = 0; (RowCount != ATable.Rows.Count); RowCount = (RowCount + 1))
            {
                TheRow = ATable[RowCount];
                try
                {
                    if ((TheRow.RowState == DataRowState.Added))
                    {
                        TTypedDataAccess.InsertRow("p_partner_contact_attribute", PPartnerContactAttributeTable.GetColumnStringList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Modified))
                    {
                        TTypedDataAccess.UpdateRow("p_partner_contact_attribute", PPartnerContactAttributeTable.GetColumnStringList(), PPartnerContactAttributeTable.GetPrimKeyColumnOrdList(), ref TheRow, ATransaction, UserInfo.GUserInfo.UserID);
                    }
                    if ((TheRow.RowState == DataRowState.Deleted))
                    {
                        TTypedDataAccess.DeleteRow("p_partner_contact_attribute", PPartnerContactAttributeTable.GetColumnStringList(), PPartnerContactAttributeTable.GetPrimKeyColumnOrdList(), TheRow, ATransaction);
                    }
                }
                catch (OdbcException ex)
                {
                    ResultValue = false;
                    ExceptionReported = false;
                    if ((ExceptionReported == false))
                    {
                        AVerificationResult.Add(new TVerificationResult("[ODBC]", ex.Errors[0].Message, "ODBC error for table PPartnerContactAttribute", ex.Errors[0].NativeError.ToString(), TResultSeverity.Resv_Critical));
                    }
                }
            }
            return ResultValue;
        }
    }
}