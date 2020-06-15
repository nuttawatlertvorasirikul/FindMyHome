using PET.DATAAPI.NOTICE.CORE.Interfaces.Repositories;
using PET.DATAAPI.NOTICE.CORE.Interfaces.Services;
using System.Threading.Tasks;

namespace PET.DATAAPI.NOTICE.CORE.Services
{
    public class NoticeService : INoticeService
    {
        private readonly INoticeRepository _noticeRepository;
        public NoticeService(INoticeRepository noticeRepository)
        {
            this._noticeRepository = noticeRepository;
        }
        public async Task<string> notice(string input)
        {
            var rs = await this._noticeRepository.notice(input);
            return rs;
        }
    }
}