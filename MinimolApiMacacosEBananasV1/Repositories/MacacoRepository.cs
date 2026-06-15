using System.Collections.Generic;
using System.Linq;
using MinimolApiMacacosEBananasV1.Interfaces;
using MinimolApiMacacosEBananasV1.Models;

namespace MinimolApiMacacosEBananasV1.Repositories;

public class MacacoRepository : IMacacoRepository
{
    private readonly List<Macaco> _macacos = [
        new Macaco("Geremias", 10),
        new Macaco("Cherilaine", 2),
        new Macaco("Carlito", 500)
    ];

    public List<Macaco> ListarMacacosAsync()
        => _macacos.ToList();

    public Macaco? ObterMacacoPorId(int id)
        => _macacos.FirstOrDefault(m => m.Id == id);

    public void Excluir(int idMacaco)
    {
        Macaco? macaco = _macacos.FirstOrDefault(m => m.Id == idMacaco);

        if (macaco == null)
            return;

        _macacos.Remove(macaco);
    }

    public void Adicionar(Macaco macaco)
    {
        _macacos.Add(macaco);
    }
}
