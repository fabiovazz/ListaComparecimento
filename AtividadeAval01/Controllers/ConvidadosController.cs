using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeAval01.Models;
namespace AtividadeAval01.Controllers
{
    public class ConvidadosController : Controller
    {
        private static IList<Convidado> convidados = new List<Convidado>() {
            new Convidado()
            {
                ConvidadoId = 1, Name = "Fabio", EMail = "fabiohv@gmail.com", Comparecimento = null, Telefone = "(35)9 9867-2893"
            }
        };
        public IActionResult Index()
        {
            return View(convidados);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Convidado conv)
        {
            convidados.Add(conv);
            conv.ConvidadoId = convidados.Select(m => m.ConvidadoId).Max() + 1;
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(convidados.Where(m => m.ConvidadoId == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Convidado conv)
        {
            convidados.Remove(convidados.Where(c => c.ConvidadoId == conv.ConvidadoId).First());
            convidados.Add(conv);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            return View(convidados.Where(m => m.ConvidadoId == id).First());
        }
        public IActionResult Delete(int id)
        {
            return View(convidados.Where(m => m.ConvidadoId == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Convidado conv)
        {
            convidados.Remove(convidados.Where(c => c.ConvidadoId == conv.ConvidadoId).First());
            return RedirectToAction("Index");
        }
    }
}
