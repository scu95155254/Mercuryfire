CREATE PROCEDURE GetMyofficeACPDByAcpdSid
    @AcpdSid NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        acpd_sid,              -- 使用者主鍵
        acpd_cname,           -- 中文名稱
        acpd_ename,           -- 英文名稱
        acpd_sname,           -- 簡稱
        acpd_email,           -- 使用者信箱
        acpd_status,          -- 狀況 0=正常, 99=不正常
        acpd_stop,            -- 是否停用/不可登入
        acpd_stopMemo,        -- 停用原因
        acpd_LoginID,         -- 登入帳號
        acpd_LoginPW,         -- 登入密碼
        acpd_memo,            -- 備註
        acpd_nowdatetime,     -- 新增日期
        appd_nowid,           -- 新增人員代碼
        acpd_upddatetitme,    -- 修改日期
        acpd_updid            -- 修改人員代碼
    FROM 
        Myoffice_ACPD
    WHERE 
        acpd_sid = @AcpdSid;
END