using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.Core.Extensions;
using EReconciliationAPI.Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EReconciliationAPI.Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get;}
        private TokenOptions _tokenOptions;
        DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims, int companyId)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions,user,signingCredentials,operationClaims,companyId);
            var jwtSecurtiyTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurtiyTokenHandler.WriteToken(jwt);
            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration,
                CompanyId = companyId
            };
        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials, List<OperationClaim> operationClaims, int companyId)
        {
            var jwt = new JwtSecurityToken(
                    issuer: tokenOptions.Issuer,
                    audience: tokenOptions.Audience,
                    expires: _accessTokenExpiration,
                    notBefore: DateTime.Now,
                    claims: SetClaims(user, operationClaims, companyId),
                    signingCredentials: signingCredentials
                    );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims, int companyId)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentityfier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.Name}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());
            claims.AddCompany(companyId.ToString());
            return claims;
        }
    }
}
