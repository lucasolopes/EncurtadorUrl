using EncurtadorUrl.Services.Implementations;
using EncurtadorUrl.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EncurtadorUrl.Controllers
{
    [ApiController]
    [Route("shorten-url")]
    public class EncurtadorController : ControllerBase
    {
        private readonly IEncurtadorService _encurtadorService;

        public EncurtadorController(IEncurtadorService encurtadorService)
        {
            _encurtadorService = encurtadorService;
        }

        [HttpPost]
        public ActionResult<string> CreateShortLink(string link)
        {
              string shortLink = _encurtadorService.CreateShortLink(link);
              var request = HttpContext.Request;
              var fullUrl = $"{request.Scheme}://{request.Host}";
              return Ok(fullUrl+"//"+shortLink);
        }

        [HttpGet]
        public ActionResult<List<string>> GetAllLink()
        {
            return Ok(_encurtadorService.GetShortLinks());
        }

    }
}
