using ClientFactoryCore.HTTPClient.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientFactoryCore.HTTPClient
{
    public interface IPaisServicio
    {
        Task<List<PaisDTO>> ObtenerPaises();
        Task<List<PaisDTO>> ObtenerPaisesPorNombre(string nombre, bool textoCompleto=false);
        Task<List<PaisDTO>> ObtenerPaisesPorCodigo(string codigo);
    }
}