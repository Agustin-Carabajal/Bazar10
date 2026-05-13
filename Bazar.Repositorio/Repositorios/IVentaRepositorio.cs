using Bazar.BD.Datos.Entity;
using Bazar.Shared.DTO;

namespace Bazar.Repositorio.Repositorios
{
    public interface IVentaRepositorio : IRepositorio<Venta>
    {
       // Task<VentaResumenDTO?> SelecResumenVentas(string cod);
        
        Task<Venta?> SelectByVentaCod(string cod);
        Task<VentaResumenDTO?> SelecResumenVentasDia(DateTime dia);
    }
}