CREATE TABLE [dbo].[Myoffice_ACPD] (
    [acpd_sid]          CHAR (20)      NOT NULL,
    [acpd_cname]        NVARCHAR (60)  NULL,
    [acpd_ename]        NVARCHAR (40)  NULL,
    [acpd_sname]        NVARCHAR (40)  NULL,
    [acpd_email]        NVARCHAR (60)  NULL,
    [acpd_status]       TINYINT        NULL,
    [acpd_stop]         BIT            NULL,
    [acpd_stopMemo]     NVARCHAR (600) NULL,
    [acpd_LoginID]      NVARCHAR (30)  NULL,
    [acpd_LoginPW]      NVARCHAR (60)  NULL,
    [acpd_memo]         NVARCHAR (120) NULL,
    [acpd_nowdatetime]  DATETIME       NULL,
    [appd_nowid]        NVARCHAR (20)  NULL,
    [acpd_upddatetitme] DATETIME       NULL,
    [acpd_updid]        NVARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([acpd_sid] ASC),
    CHECK ([acpd_status]=(99) OR [acpd_status]=(0))
);

