using Microsoft.AspNetCore.Mvc;

namespace MVC2026;

public class CadastroController : Controller // a classe cadastro, herda da classe controller
{
    public IActionResult Aluno()
    {
        return View();
    }

}
