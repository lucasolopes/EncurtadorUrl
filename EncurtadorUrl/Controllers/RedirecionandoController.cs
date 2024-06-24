using EncurtadorUrl.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EncurtadorUrl.Controllers
{
    [ApiController]
    [Route("")]
    public class RedirecionandoController : ControllerBase
    {
        private readonly IEncurtadorService encurtadorService;

        public RedirecionandoController(IEncurtadorService encurtadorService)
        {
            this.encurtadorService = encurtadorService;
        }

        [HttpGet("{urlEncurtada}")]
        public IActionResult Redirecionar(string urlEncurtada)
        {
            var urlOriginal = encurtadorService.ObterUrlOriginal(urlEncurtada);

            if (string.IsNullOrEmpty(urlOriginal))
            {
                return NotFound();
            }

            return Redirect(urlOriginal);
        }


    }
}
