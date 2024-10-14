
CREATE PROCEDURE [dbo].[AddMyofficeACPD]
    @AcpdCname NVARCHAR(60),
    @AcpdEname NVARCHAR(40),
    @AcpdSname NVARCHAR(40),
    @AcpdEmail NVARCHAR(60),
    @AcpdStatus TINYINT,
    @AcpdStop BIT,
    @AcpdStopMemo NVARCHAR(600) = NULL,  -- 默認為 NULL
    @AcpdLoginID NVARCHAR(30),
    @AcpdLoginPW NVARCHAR(60),
    @AcpdMemo NVARCHAR(120) = NULL,       -- 默認為 NULL
    @AppdNowid NVARCHAR(20),
    @AcpdNowdatetime DATETIME, 
    @AcpdUpddatetitme DATETIME = NULL,    -- 默＝－認為 NULL
    @AcpdUpdid NVARCHAR(20) = NULL         -- 默認為 NULL
AS
BEGIN
    SET NOCOUNT ON;
	
	DECLARE @AcpdSID char(20);
	EXEC　[dbo].[NEWSID] @TableName = N'Myoffice_ACPD' ,@ReturnSID = @AcpdSID OUTPUT

		INSERT INTO Myoffice_ACPD (
		acpd_sid,
        acpd_cname,
        acpd_ename,
        acpd_sname,
        acpd_email,
        acpd_status,
        acpd_stop,
        acpd_stopMemo,
        acpd_LoginID,
        acpd_LoginPW,
        acpd_memo,
        acpd_nowdatetime,
        appd_nowid,
        acpd_upddatetitme,
        acpd_updid
    )
    VALUES (
	　　@AcpdSID,
        @AcpdCname,
        @AcpdEname,
        @AcpdSname,
        @AcpdEmail,
        @AcpdStatus,
        @AcpdStop,
        @AcpdStopMemo,
        @AcpdLoginID,
        @AcpdLoginPW,
        @AcpdMemo,
        @AcpdNowdatetime,
        @AppdNowid,
        @AcpdUpddatetitme,
        @AcpdUpdid
    );
END