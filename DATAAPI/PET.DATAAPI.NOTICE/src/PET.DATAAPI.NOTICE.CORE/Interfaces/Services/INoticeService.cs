using System.Threading.Tasks;

namespace PET.DATAAPI.NOTICE.CORE.Interfaces.Services
{
    public interface INoticeService
    {
        Task<string> notice(string input);
    }
}