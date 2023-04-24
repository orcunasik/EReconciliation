using EReconciliationAPI.Core.Entities;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.Entities.Dtos
{
    public class SendMailDto : IDto
    {
        public MailParameter mailParameter { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
    }
}
