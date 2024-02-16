using CapaLogicaNegocio.SignoZodiacal;
using Microsoft.AspNetCore.Mvc;
using SignoZodiacal.Models;
using System.Diagnostics;

namespace SignoZodiacal.Controllers
{
    public class SignoController : Controller
    {
        private readonly ILogger<SignoController> _logger;
        private readonly LogicaSignoZodiacal logicaSigno = new();
        public SignoController(ILogger<SignoController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View(new DatosSignoZodiacal());
        }


        [HttpPost]
        public IActionResult Index(DatosSignoZodiacal dsz)
        {
            dsz.signo = logicaSigno.determinarSigno(dsz);
            return View(dsz);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}