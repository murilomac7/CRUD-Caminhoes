using CRUD_Caminhoes.Models;
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
            return View(Data.CaminhoesCadastrados);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Gerar()
        {
            Caminhao c1 = new Caminhao(1, "Mercedes-Benz L-312", "Motor OM-312, de injeção direta, 6 cilindros em linha e 112 cv de potência.", DateTime.Now);
            Data.CaminhoesCadastrados.Add(c1);
            Caminhao c2 = new Caminhao(2, "VW 24.250", "Aquele que parece o Bob esponja", DateTime.Now);            
            Data.CaminhoesCadastrados.Add(c2);
            Caminhao c3 = new Caminhao(3, "Ford F-14000", "O sapão", DateTime.Now);
            Data.CaminhoesCadastrados.Add(c3);

            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Cadastrar(Caminhao caminhao)
        {
            if (ModelState.IsValid)
            {
                caminhao.Id = Data.CaminhoesCadastrados.Count() + 1;
                Data.CaminhoesCadastrados.Add(caminhao);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Editar(int id)
        {
            Caminhao editCaminhao = Data.CaminhoesCadastrados.Find(c => c.Id == id);
            return View(editCaminhao);
        }

        [HttpPost]
        public IActionResult Editar(Caminhao caminhao)
        {
            int indexToEdit = Data.CaminhoesCadastrados.FindLastIndex(c => c.Id == caminhao.Id);
            if(indexToEdit != -1)
            {
                Data.CaminhoesCadastrados[indexToEdit] = new Caminhao(caminhao);
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult Detalhes(int id)
        {
            Caminhao detalhesCaminhao = Data.CaminhoesCadastrados.Find(c => c.Id == id);
            return View(detalhesCaminhao);
        }

        public IActionResult Deletar(int id)
        {
            Caminhao detalhesCaminhao = Data.CaminhoesCadastrados.Find(c => c.Id == id);
            return View(detalhesCaminhao);
        }

        [HttpPost]
        public IActionResult Deletar(Caminhao caminhao)
        {
            int indexToDelete = Data.CaminhoesCadastrados.FindLastIndex(c => c.Id == caminhao.Id);
            if(indexToDelete != -1)
                Data.CaminhoesCadastrados.RemoveAt(indexToDelete);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
