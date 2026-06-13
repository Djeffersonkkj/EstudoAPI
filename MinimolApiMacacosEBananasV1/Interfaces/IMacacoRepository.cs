using System.Collections.Generic;
using MinimolApiMacacosEBananasV1.Models;

namespace MinimolApiMacacosEBananasV1.Interfaces;

public interface IMacacoRepository
{
    List<Macaco> ListarMacacosAsync();

    Macaco? ObterMacacoPorId(int id);

}
