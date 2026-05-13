using Bazar.BD.Datos.Entity;
using Bazar.Shared.DTO;

namespace Bazar.Repositorio.Repositorios
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Task<List<UsuarioMostrarDTO>> SelecListaUsuario();
        Task<UsuarioMostrarDTO?> SelecUsuarioMostrar(string dni);
        Task<Usuario?> SelectByDni(string dni);
    }
}