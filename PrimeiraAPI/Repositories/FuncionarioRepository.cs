using PrimeiraAPI.Data;
using PrimeiraAPI.Interfaces;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Repositories;

public class FuncionarioRepository : IFuncionarioRepository
{
    private readonly PrimeiraAPIContext _context = new PrimeiraAPIContext();

    public void Adicionar(Funcionario funcionario)
    {
        _context.Funcionario.Add(funcionario);
        _context.SaveChanges();
    }

    public List<Funcionario> ListarTodos()
    {
        return _context.Funcionario.ToList();
    }
}
