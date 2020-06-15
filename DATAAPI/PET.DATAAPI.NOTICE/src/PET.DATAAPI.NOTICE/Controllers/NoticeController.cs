using Microsoft.AspNetCore.Mvc;
using PET.DATAAPI.NOTICE.CORE.Interfaces.Services;
using System.Threading.Tasks;

namespace PET.DATAAPI.NOTICE.Controllers
{
    [Route("/Notice")]
    [Produces("application/json")]
    [ApiController]
    public class NoticeController : Controller
    {
        private readonly INoticeService _noticeSevice;

        public NoticeController(INoticeService noticeSevice)
        {
            this._noticeSevice = noticeSevice;
        }

        [HttpGet]
        public async Task<string> GETNotice([FromQuery] string input)
        {
            var rs = await this._noticeSevice.notice(input);
            return rs;
        }
    }
}