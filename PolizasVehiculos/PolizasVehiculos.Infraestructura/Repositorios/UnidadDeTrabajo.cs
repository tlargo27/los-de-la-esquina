using PolizasVehiculos.Core.Entidades;
using PolizasVehiculos.Core.Interfaces;
using PolizasVehiculos.Infraestructura.Datos;
using System.Threading.Tasks;

namespace PolizasVehiculos.Infraestructura.Repositorios
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private readonly DBSegurosContext _contexto;
        private readonly IRepositorio<Pais> _paisRepositorio;
        private readonly ISeguridadRepositorio _seguridadRepositorio;

        public UnidadDeTrabajo(DBSegurosContext contexto)
        {
            _contexto = contexto;
        }

        public IRepositorio<Pais> PaisRepositorio => _paisRepositorio ?? new RepositorioBase<Pais>(_contexto);

        public ISeguridadRepositorio SeguridadRepositorio => _seguridadRepositorio ?? new SeguridadRepositorio(_contexto);

        public void Dispose()
        {
            if (_contexto != null) 
            {
                _contexto.Dispose();
            }
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _contexto.SaveChangesAsync();
        }
    }
}
