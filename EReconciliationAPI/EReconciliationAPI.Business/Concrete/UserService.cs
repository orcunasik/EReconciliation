using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Business.ValidationRules.FluentValidation;
using EReconciliationAPI.Core.Aspects.Autofac.Validation;
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


        [ValidationAspect(typeof(UserValidator))]
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetById(int id)
        {
            return _userDal.Get(p => p.Id == id);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(p => p.Email == email);
        }

        public User GetByMailConfrimValue(string value)
        {
            return _userDal.Get(p => p.MailConfirmValue.ToString() == value);
        }

        public List<OperationClaim> GetClaims(User user, int companyId)
        {
            return _userDal.GetClaims(user,companyId);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
