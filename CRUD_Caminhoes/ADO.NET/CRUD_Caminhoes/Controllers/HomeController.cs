using CRUD_Caminhoes.Models;
using CRUD_Caminhoes.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Caminhoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CaminhaoRepository caminhaoRepos = new CaminhaoRepository();
            ModelState.Clear();

            return View(caminhaoRepos.SelecionarCaminhao());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Caminhao caminhao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CaminhaoRepository caminhaoRepos = new CaminhaoRepository();

                    caminhaoRepos.AddCaminhao(caminhao);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }            
        }

        public IActionResult Gerar()
        {
            CaminhaoRepository caminhaoRepos = new CaminhaoRepository();

            Caminhao c1 = new Caminhao(1, "Mercedes-Benz L-312", "Motor OM-312, de injeção direta, 6 cilindros em linha e 112 cv de potência.", DateTime.Now);            
            Caminhao c2 = new Caminhao(2, "VW 24.250", "Aquele que parece o Bob esponja", DateTime.Now);
            Caminhao c3 = new Caminhao(3, "Ford F-14000", "O sapão", DateTime.Now);

            caminhaoRepos.AddCaminhao(c1);
            caminhaoRepos.AddCaminhao(c2);
            caminhaoRepos.AddCaminhao(c3);

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            CaminhaoRepository caminhaoRepos = new CaminhaoRepository();

            return View(caminhaoRepos.SelecionarCaminhao().Find(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult Editar(Caminhao caminhao)
        {
            try
            {
                CaminhaoRepository caminhaoRepos = new CaminhaoRepository();
                caminhaoRepos.AtualizarCaminhao(caminhao);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Detalhes(int id)
        {
            CaminhaoRepository caminhaoRepos = new CaminhaoRepository();
            return View(caminhaoRepos.SelecionarCaminhao().Find(c => c.Id == id));
        }

        public IActionResult Deletar(int id)
        {
            CaminhaoRepository caminhaoRepos = new CaminhaoRepository();
            return View(caminhaoRepos.SelecionarCaminhao().Find(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult Deletar(Caminhao caminhao)
        {
            try
            {
                CaminhaoRepository caminhaoRepos = new CaminhaoRepository();

                caminhaoRepos.ExcluirCaminhao(caminhao);

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
