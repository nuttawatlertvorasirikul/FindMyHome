using System.Threading.Tasks;

namespace PET.DATAAPI.NOTICE.CORE.Interfaces.Repositories
{
    public interface INoticeRepository
    {
        Task<string> notice(string input);
    }
}