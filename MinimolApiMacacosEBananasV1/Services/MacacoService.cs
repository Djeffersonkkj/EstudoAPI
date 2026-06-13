using System.Collections.Generic;
using MinimolApiMacacosEBananasV1.Interfaces;
using MinimolApiMacacosEBananasV1.Models;

namespace MinimolApiMacacosEBananasV1.Services;

public class MacacoService : IMacacoService
{
    public MacacoService(IMacacoRepository macacoRepository)
    {
        _macacoRepository = macacoRepository;
    }

    private IMacacoRepository _macacoRepository;

    public List<Macaco> ListarMacacos()
    {
        return _macacoRepository.ListarMacacosAsync();
    }

    public void DarBanana (int idRemetente, int idDestinatario, int quantidade)
    {
        var remetente = _macacoRepository.ObterMacacoPorId(idRemetente);
        var destinatario = _macacoRepository.ObterMacacoPorId(idDestinatario);

        if (remetente == null || destinatario == null )
            return;

        remetente.PerderBananas(quantidade);
        destinatario.GanharBananas(quantidade);

    }
}
