using SAUGroup.Bookstore.Models;
using System.Threading.Tasks;

namespace SAUGroup.Bookstore.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);
    }
}