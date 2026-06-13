namespace MinimolApiMacacosEBananasV1.Models;

public class Macaco
{
    public Macaco(string nome, int bananasIniciais)
    {
        _macacos ++;
        Id = _macacos;

        Nome = nome;
        Bananas = bananasIniciais;
    }

    public int Id { get; set; }
    public string? Nome { get; set; }
    public int Bananas { get; set; }

    private static int _macacos;

    public void PerderBananas(int quantidade)
        => Bananas -= quantidade;

    public void GanharBananas(int quantidade)
        => Bananas += quantidade;
}
