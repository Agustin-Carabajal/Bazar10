using Bazar.BD.Datos.Entity;
using Bazar.Shared.DTO;

namespace Bazar.Repositorio.Repositorios
{
    public interface IArticuloRepositorio : IRepositorio<Articulo>
    {
        Task<List<ArticuloListadoDTO>> SelecListaArticulo();
        Task<Articulo?> SelectByCod(string cod);
    }
}