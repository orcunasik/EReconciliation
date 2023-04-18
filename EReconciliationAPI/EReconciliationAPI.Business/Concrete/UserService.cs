using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.DataAccess.Abstract;

namespace EReconciliationAPI.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(p => p.Email == email);
        }

        public List<OperationClaim> GetClaims(User user, int companyId)
        {
            return _userDal.GetClaims(user,companyId);
        }
    }
}
