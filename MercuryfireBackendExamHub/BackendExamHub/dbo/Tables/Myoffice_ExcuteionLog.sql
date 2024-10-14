CREATE TABLE [dbo].[Myoffice_ExcuteionLog] (
    [DeLog_AuthID]           INT              NOT NULL,
    [DeLog_StoredPrograms]   NVARCHAR (120)   NULL,
    [DeLog_GroupID]          UNIQUEIDENTIFIER NULL,
    [DeLog_isCustomDebug]    BIT              NULL,
    [DeLog_ExecutionProgram] NVARCHAR (120)   NULL,
    [DeLog_ExecuteionInfo]   NVARCHAR (MAX)   NULL,
    [DeLog_VerifyNeeded]     BIT              NULL,
    [exelog_nowdatetime]     DATETIME         NULL,
    PRIMARY KEY CLUSTERED ([DeLog_AuthID] ASC)
);

