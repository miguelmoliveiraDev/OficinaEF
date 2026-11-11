using Microsoft.AspNetCore.Mvc;

namespace OficinaEF.Controllers; // Onde esta o arquivo 

public class ProdutosController : Controller
{
    //agora temos as ações, como iremos  acessar uma pagina 
    public IActionResult Index()
    {
        return Content("Catálogo de Produtos");
    }
}
  
  