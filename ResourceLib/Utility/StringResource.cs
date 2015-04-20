﻿using System;
using System.Collections.Generic;
using System.Xml;

namespace ResourceLib.Utility
{
    /// <summary>
    ///     String Resource
    /// </summary>
    /// <remarks>
    ///     这个功能的负责人是MoLing。
    ///     有任何翻译上的问题，或者您想共享某个语种的翻译文件，请在Github上给MoLing留言
    /// </remarks>
    public class StringResource
    {
        /// <summary>
        ///     字符枚举
        /// </summary>
        public enum TextType
        {
            UseDefaultLanguage,

            Main_Menu_Mangt,
            Main_Menu_Mangt_AddConnection,
            Main_Menu_Mangt_Disconnect,
            Main_Menu_Mangt_Status,
            Main_Menu_Mangt_Refresh,
            Main_Menu_Mangt_Exit,
            Main_Menu_DataView,
            Main_Menu_DataView_Previous,
            Main_Menu_DataView_Next,
            Main_Menu_DataView_First,
            Main_Menu_DataView_Last,
            Main_Menu_DataView_Query,
            Main_Menu_DataView_Aggregation,
            Main_Menu_DataView_ConvertSql,
            Main_Menu_DataView_DataFilter,

            Main_Menu_Operation,
            Main_Menu_Operation_Server,
            Main_Menu_Operation_Server_NewDB,
            Main_Menu_Operation_Server_UserInfo,
            Main_Menu_Operation_Server_AddUserToAdmin,
            Main_Menu_Operation_Server_DelFromAdmin,
            Main_Menu_Operation_Server_SlaveResync,
            Main_Menu_Operation_Server_CloseServer,
            Main_Menu_Operation_Server_Properties,

            Main_Menu_Operation_Database,
            Main_Menu_Operation_Database_DelDB,
            Main_Menu_Operation_Database_AddDC,
            Main_Menu_Operation_Database_AddUser,
            Main_Menu_Operation_Database_DelUser,
            Main_Menu_Operation_Database_EvalJs,
            Main_Menu_Operation_Database_RepairDatabase,
            Main_Menu_Operation_DataCollection,
            Main_Menu_Operation_DataCollection_DelDC,
            Main_Menu_Operation_DataCollection_Index,
            Main_Menu_Operation_DataCollection_DropDocument,
            Main_Menu_Operation_DataCollection_AddDocument,
            Main_Menu_Operation_DataCollection_ReIndex,
            Main_Menu_Operation_DataCollection_Rename,
            Main_Menu_Operation_DataCollection_Compact,
            Main_Menu_Operation_DataCollection_CreateJavaScript,
            Main_Menu_Operation_DataCollection_DropJavaScript,
            Main_Menu_Operation_DataCollection_View,
            Main_Menu_Operation_DataCollection_ExportToFile,
            Main_Menu_Operation_DataDocument,
            Main_Menu_Operation_DataDocument_AddElement,
            Main_Menu_Operation_DataDocument_DropElement,
            Main_Menu_Operation_DataDocument_ModifyElement,
            Main_Menu_Operation_DataDocument_CopyElement,
            Main_Menu_Operation_DataDocument_CutElement,
            Main_Menu_Operation_DataDocument_PasteElement,
            Main_Menu_Operation_DataDocument_OpenInNativeEditor,

            Main_Menu_Operation_FileSystem,
            Main_Menu_Operation_FileSystem_UploadFile,
            Main_Menu_Operation_FileSystem_UploadFolder,
            Main_Menu_Operation_FileSystem_Download,
            Main_Menu_Operation_FileSystem_OpenFile,
            Main_Menu_Operation_FileSystem_DelFile,
            Main_Menu_Operation_FileSystem_InitGFS,

            Main_Menu_Operation_ProfillingLevel,
            Main_Menu_Operation_BackupAndRestore,
            Main_Menu_Operation_BackupAndRestore_Restore,
            Main_Menu_Operation_BackupAndRestore_BackupDB,
            Main_Menu_Operation_BackupAndRestore_BackupDC,
            Main_Menu_Operation_BackupAndRestore_Import,
            Main_Menu_Operation_BackupAndRestore_Export,
            Main_Menu_Tool,
            Main_Menu_Tool_DOS,
            Main_Menu_Tool_Access,
            Main_Menu_Tool_Setting,
            Main_Menu_Distributed,
            Main_Menu_Distributed_ReplicaSet,
            Main_Menu_Distributed_ShardingConfig,
            Main_Menu_Help,
            Main_Menu_Help_About,
            Main_Menu_Help_Thanks,
            Main_Menu_Help_UserGuide,


            Main_Tab_Tree,
            Main_Tab_Table,
            Main_Tab_Text,
            Main_StatusBar_Text_Ready,

            AddConnection_Title,
            AddConnection_ConnectionName,
            AddConnection_Name_Description,
            AddConnection_Host_Description,
            AddConnection_Port_Description,
            AddConnection_UserName_Description,
            AddConnection_Password_Description,
            AddConnection_DBName,
            AddConnection_DBName_Description,
            AddConnection_MainReplsetName,
            AddConnection_MainReplsetName_Description,
            AddConnection_Priority,
            AddConnection_SocketTimeOut,
            AddConnection_ConnectionTimeOut,

            AddConnection_MasterSlave,
            AddConnection_SafeMode,
            AddConnection_ShardingSvrType,
            AddConnection_ServerType_Data,
            AddConnection_ServerType_Configuration,
            AddConnection_ServerType_Route,
            AddConnection_ServerType_Arbitration,

            AddConnection_Region_ReplaceSet,
            AddConnection_Region_ReplaceSetName,
            AddConnection_Region_ReplaceSetName_Description,
            AddConnection_Region_ReplaceSetList,
            AddConnection_Region_AddHost,
            AddConnection_Region_RemoveHost,
            AddConnection_ConnectionString,
            AddConnection_Attention_Description,
            AddConnection_Attention2_Description,

            CollectionIndex_Title,
            CollectionIndex_Tab_Current,
            CollectionIndex_Tab_Current_Del,
            CollectionIndex_Tab_Manager,

            Connect_Title,
            Connect_Action_Del,
            Connect_Action_Cancel,

            ConvertSql_Title,

            Distinct_Action_LoadQuery,
            Distinct_SelectField,

            DosCommand_Tab_Deploy,
            DosCommand_Tab_Deploy_Authentication,
            DosCommand_Tab_Deploy_MasterAddress,
            DosCommand_Tab_Deploy_Port,
            DosCommand_Tab_Deploy_Master,
            DosCommand_Tab_Deploy_Slave,
            DosCommand_Tab_Deploy_SlaveSource,
            DosCommand_Tab_Deploy_DBPath,
            DosCommand_Tab_Deploy_LogPath,
            DosCommand_Tab_Deploy_Log,
            DosCommand_Tab_Deploy_AppendMode,
            DosCommand_Tab_Backup,
            DosCommand_Tab_Backup_Server,
            DosCommand_Tab_Backup_Port,
            DosCommand_Tab_Backup_DBName,
            DosCommand_Tab_Backup_DCName,
            DosCommand_Tab_Backup_Path,
            DosCommand_Tab_ExIn,
            DosCommand_Tab_ExIn_Server,
            DosCommand_Tab_ExIn_Port,
            DosCommand_Tab_ExIn_DBName,
            DosCommand_Tab_ExIn_DCName,
            DosCommand_Tab_ExIn_ColumnList,
            DosCommand_Tab_ExIn_Workfile,
            DosCommand_Tab_ExIn_Import,
            DosCommand_Tab_ExIn_Export,
            DosCommand_Tab_ExIn_Operation,
            DosCommand_Run,
            DosCommand_Browse,
            DosCommand_Clean,
            DosCommand_LogLevel,

            EvalJS_Title,
            EvalJS_Method,
            EvalJS_Run,
            EvalJS_Parameter,

            Group_Tab_Reduce,
            Group_Tab_Finalize,
            Group_Tab_Group,
            Group_Tab_Group_Notes,
            Group_Tab_InitColumn,
            Group_Tab_InitColumn_Note,
            Group_Tab_Result,
            Group_LoadQuery,

            //Option
            Option_Title,
            Option_BinPath,
            Option_Language,
            Option_RecordPerPage,
            Option_RefreshInterval,

            //MapReduce
            MapReduce_MapFunction,
            MapReduce_ReduceFunction,
            MapReduce_Result,
            MapReduce_Run,

            Query_Title,
            Query_Filter,
            Query_Filter_AddCondition,
            Query_FieldInfo,
            Query_Action_Load,

            Replset_Title,
            Replset_AddServer,
            Replset_RemoveServer,
            Replset_Remove,
            Replset_InitReplset,

            ServiceStatus_Title,
            ServiceStatus_ServerInfo,
            ServiceStatus_DataBaseInfo,
            ServiceStatus_CollectionInfo,
            ServiceStatus_CurrentOperationInfo,

            ShardingConfig_Title,
            ShardingConfig_AddSharding,
            ShardingConfig_ReplsetName,
            ShardingConfig_EnableSharding,
            ShardingConfig_DBName,
            ShardingConfig_CollectionName,
            ShardingConfig_FieldName,
            ShardingConfig_Action_DBSharding,
            ShardingConfig_Action_CollectionSharding,

            //Controller
            ctlIndexCreate_Index,
            ctlIndexCreate_Description,
            ctlFieldInfo_Show,

            //GFS
            GFS_filename,
            GFS_length,
            GFS_chunkSize,
            GFS_uploadDate,
            GFS_md5,
            GFS_Insert_Option_RemoteFileName,
            GFS_Insert_Option_OnlyFilename,
            GFS_Insert_Option_FullPath,
            GFS_Insert_Option_FileAlreadyExist,
            GFS_Insert_Option_JustAddIt,
            GFS_Insert_Option_Rename,
            GFS_Insert_Option_SkipIt,
            GFS_Insert_Option_Overwrite,
            GFS_Insert_Option_Stop,
            GFS_Insert_Option_IngoreSubFolder,
            GFS_Insert_Option_DirectorySeparatorChar,

            //DataBase_Status
            DataBase_Status_DataBaseName,
            DataBase_Status_CollectionCount,
            DataBase_Status_DataSize,
            DataBase_Status_FileSize,
            DataBase_Status_IndexCount,
            DataBase_Status_IndexSize,
            DataBase_Status_ObjectCount,
            DataBase_Status_StorageSize,

            //Collection_Status
            Collection_Status_CollectionName,
            Collection_Status_ObjectCount,
            Collection_Status_DataSize,
            Collection_Status_LastExtentSize,
            Collection_Status_StorageSize,
            Collection_Status_TotalIndexSize,
            Collection_Status_AverageObjectSize,
            Collection_Status_PaddingFactor,
            Collection_Status_MaxDocuments,
            Collection_Status_MaxSize,
            Collection_Status_IsCapped,
            Collection_Status_IsAutoIndexId,

            Collection_Resume_AutoRefresh,
            Collection_Stop_AutoRefresh,

            //Index
            Index_Asce,
            Index_Desc,
            Index_NoSort,

            Index_Background,
            Index_RepeatDel,
            Index_Sparse,
            Index_Unify,
            Index_Name,
            Index_Keys,
            Index_Version,
            Index_ExpireData,
            Index_NameSpace,

            //Exception
            Exception_NotConnected,
            Exception_NotConnected_Note,
            Exception_AuthenticationException,
            Exception_AuthenticationException_Note,

            Selected_Server,
            Selected_DataBase,
            Selected_Collection,
            Selected_Data,
            Selected_Indexes,
            Selected_Index,
            Selected_GFS,
            Selected_UserList,

            //MongoUtility
            Common_Username,
            Common_Password,
            Common_ChangePassword,
            Common_ReadOnly,
            Common_OK,
            Common_ConfirmPassword,
            Common_Close,
            Common_Cancel,
            Common_Refresh,
            Common_Yes,
            Common_No,
            Common_Detail,
            Common_Edit,
            Common_Save,
            Common_Save_Local,
            Common_Modify,
            Common_Add,
            Common_Server,
            Common_Connect,
            Common_DataBase,
            Common_Collection,
            Common_Host,
            Common_Port,
            Common_Browse,
            Common_Clear,
            Common_Test,
            Common_Advance_Option,
            Common_Collapse,
            Common_Expansion,
            Common_Name,
            Common_Value,
            Common_Type,
            Common_Roles,
            Common_Validate,
            Common_Search,

            //MessageBox
            Create_New_DataBase,
            Create_New_DataBase_Input,
            Drop_DataBase,
            Drop_DataBase_Confirm,
            Create_New_Collection,
            Rename_Collection,
            Rename_Collection_Input,
            Drop_Collection,
            Drop_Collection_Confirm,
            Drop_User,
            Drop_User_Confirm,
            Drop_Data,
            Drop_Data_Confirm,
            Restore_Connection_Confirm,

            SYSTEMC_COLNAME_chunks,
            SYSTEMC_COLNAME_collections,
            SYSTEMC_COLNAME_changelog,
            SYSTEMC_COLNAME_databases,
            SYSTEMC_COLNAME_lockpings,
            SYSTEMC_COLNAME_locks,
            SYSTEMC_COLNAME_mongos,
            SYSTEMC_COLNAME_settings,
            SYSTEMC_COLNAME_shards,
            SYSTEMC_COLNAME_tags,
            SYSTEMC_COLNAME_version,
            SYSTEMC_COLNAME_me,
            SYSTEMC_COLNAME_sources,
            SYSTEMC_COLNAME_slaves,
            COLLECTION_NAME_GFS_CHUNKS,
            COLLECTION_NAME_GFS_FILES,
            COLLECTION_NAME_OPERATION_LOG,
            COLLECTION_NAME_SYSTEM_INDEXES,
            COLLECTION_NAME_JAVASCRIPT,
            COLLECTION_NAME_SYSTEM_REPLSET,
            COLLECTION_NAME_REPLSET_MINVALID,
            COLLECTION_NAME_USER,
            COLLECTION_NAME_ROLE,
            COLLECTION_NAME_SYSTEM_PROFILE
        }

        /// <summary>
        ///     国际化文字字典
        /// </summary>
        private readonly Dictionary<string, string> _stringDic = new Dictionary<string, string>();

        /// <summary>
        ///     语种
        /// </summary>
        public string LanguageType = string.Empty;

        /// <summary>
        ///     字符资源
        /// </summary>
        /// <param name="LanguageFileName">当前语言文件</param>
        public void InitLanguage(string LanguageFileName)
        {
            var tag = string.Empty;
            var text = string.Empty;
            var reader = new XmlTextReader(LanguageFileName);
            _stringDic.Clear();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        // The node is an element.
                        if (reader.Name == "Language")
                        {
                            LanguageType = reader.GetAttribute("Type");
                            continue;
                        }
                        tag = reader.Name.Trim();
                        text = reader.ReadInnerXml().Trim();
                        if (!string.IsNullOrEmpty(tag) && !string.IsNullOrEmpty(text))
                        {
                            _stringDic.Add(tag, text);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        ///     Get Global String
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public string GetText(TextType tag)
        {
            var strText = string.Empty;
            _stringDic.TryGetValue(tag.ToString(), out strText);
            strText = string.IsNullOrEmpty(strText) ? tag.ToString() : strText.Replace("&amp;", "&");
            return strText;
        }
    }
}