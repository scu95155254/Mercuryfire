namespace MercuryfireWebApplication.Models
{
    public class MyofficeACPDModel
    {
        public string Acpd_Sid { get; set; }                 // 使用者主鍵
        public string Acpd_Cname { get; set; }            // 中文名稱
        public string Acpd_Ename { get; set; }            // 英文名稱
        public string Acpd_Sname { get; set; }            // 簡稱
        public string Acpd_Email { get; set; }            // 使用者信箱
        public byte Acpd_Status { get; set; }             // 狀況 0=正常, 99=不正常
        public bool Acpd_Stop { get; set; }               // 是否停用/不可登入
        public string Acpd_StopMemo { get; set; }         // 停用原因
        public string Acpd_LoginID { get; set; }          // 登入帳號
        public string Acpd_LoginPW { get; set; }          // 登入密碼
        public string Acpd_Memo { get; set; }              // 備註
        public DateTime Acpd_Nowdatetime { get; set; }    // 新增日期
        public string Appd_Nowid { get; set; }             // 新增人員代碼
        public DateTime? Acpd_Upddatetitme { get; set; }  // 修改日期，允許為空
        public string Acpd_Updid { get; set; }             // 修改人員代碼
    }
}
