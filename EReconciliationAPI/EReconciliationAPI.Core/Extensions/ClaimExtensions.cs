using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EReconciliationAPI.Core.Extensions
{
    public static class ClaimExtensions
    {
        public static void AddNameIdentityfier(this ICollection<Claim> claims, string nameIdentityfier)
        {
            claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentityfier));
        }
        public static void AddEmail(this ICollection<Claim> claims, string email)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, email));
        }
        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim(ClaimTypes.Name,name));
        }
        public static void AddRoles(this ICollection<Claim> claims, string[] roles)
        {
            roles.ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role,role)));
        }
        public static void AddCompany(this ICollection<Claim> claims, string company)
        {
            claims.Add(new Claim(ClaimTypes.Anonymous, company));
        }
    }
}
