namespace EReconciliationAPI.Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public int CompanyId { get; set; }
    }
}
