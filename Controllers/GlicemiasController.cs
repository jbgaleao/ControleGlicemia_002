using AutoMapper;

using ControleGlicemia_002.Context;
using ControleGlicemia_002.Models;
using ControleGlicemia_002.ViewModel;

using Microsoft.AspNetCore.Mvc;

namespace ControleGlicemia_002.Controllers
{
    public class GlicemiasController : Controller
    {
        private readonly GlicemiaContext _context;
        private readonly IMapper _mapper;

        public GlicemiasController(GlicemiaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<GlicemiaViewModel> listaGlicemiasVM = new();
            //List<Glicemia> listaFiltrada = AplicarFiltroGlicemia(_context.GLICEMIAS.ToList(), condicao);
            foreach (Glicemia? g in _context.GLICEMIAS.ToList())
            {
                GlicemiaViewModel gVM = _mapper.Map<GlicemiaViewModel>(g);
                listaGlicemiasVM.Add(gVM);
            }
            return View(listaGlicemiasVM);
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastro(GlicemiaViewModel gVM)
        {
            if (ModelState.IsValid)
            {
                Glicemia g = _mapper.Map<Glicemia>(gVM);
                await _context.AddAsync(g);
                // gVM.EhErro = "N";
                await _context.SaveChangesAsync();
                ViewBag.MessageFormularioOK = "Formulário criado com sucesso!";
            }
            else
            {
                ViewBag.MessageFormularioErro = "Foram encontrados erros no formulário. Favor verificar os campos preenchidos.";
                // gVM.EhErro = "S";
                // gVM.MensagemRetorno = "";
            }
            return View(gVM);
        }

    }
}
