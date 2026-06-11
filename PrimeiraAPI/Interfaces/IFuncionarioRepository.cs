using PrimeiraAPI.Models;

namespace PrimeiraAPI.Interfaces;

public interface IFuncionarioRepository
{
    void Adicionar(Funcionario funcionario);

    List<Funcionario> ListarTodos();
}
