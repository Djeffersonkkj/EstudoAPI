using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Interfaces;
using PrimeiraAPI.Models;
using PrimeiraAPI.ViewModel;

namespace PrimeiraAPI.Controllers;

[ApiController] // Entender o que é isso depois
[Route("api/v1/funcionario")]
public class FuncionarioController : ControllerBase
{
    public FuncionarioController(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository ?? throw new ArgumentNullException(nameof(funcionarioRepository));
    }

    private readonly IFuncionarioRepository _funcionarioRepository;

    [HttpPost]
    public IActionResult Adicionar(FuncionarioViewModel funcionarioView)
    {
        var funcionario = new Funcionario(funcionarioView.Nome, funcionarioView.Cpf, funcionarioView.Cargo, funcionarioView.Salario, funcionarioView.Ativo);

        _funcionarioRepository.Adicionar(funcionario);
        
        return Ok();
    }

    [HttpGet]
    public IActionResult ListarTodos()
    {
        var funcionarios = _funcionarioRepository.ListarTodos();

        return Ok(funcionarios);
    }
    
}
