using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models;

public class Funcionario
{
    public Funcionario(string nome, string cpf, string cargo, decimal salario, bool ativo)
    {
        Nome = nome;
        Cpf = cpf;
        Cargo = cargo;
        Salario = salario;
        Ativo = ativo;
    }

    [Key]
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Cargo { get; set; }
    public decimal Salario { get; set; }
    public bool Ativo { get; set; }
}
