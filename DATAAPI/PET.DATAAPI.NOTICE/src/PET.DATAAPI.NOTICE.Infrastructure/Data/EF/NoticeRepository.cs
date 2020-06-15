using PET.DATAAPI.NOTICE.CORE.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PET.DATAAPI.NOTICE.Infrastructure.Data.EF
{
    public class NoticeRepository : INoticeRepository
    {
        public async Task<string> notice(string input)
        {
            await Task.Delay(1000);
            return input+"_repo";
        }
    }
}
