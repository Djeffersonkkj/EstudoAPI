using System.Collections.Generic;
using MinimolApiMacacosEBananasV1.Models;

namespace MinimolApiMacacosEBananasV1.Interfaces;

public interface IMacacoService
{
    List<Macaco> ListarMacacos();

    void DarBanana (int idRemetente, int idDestinatario, int quantidade);

    void Excluir(int idMacaco);

    void CriarMacaco(string nome, int bananas);
}
