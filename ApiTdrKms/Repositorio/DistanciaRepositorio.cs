using ApiTdrKms.Data;
using ApiTdrKms.Modelos;
using ApiTdrKms.Repositorio.IRepositorio;

namespace ApiTdrKms.Repositorio
{
    public class DistanciaRepositorio : IDistanciaRepositorio
    {
        private readonly ApplicationDbContext _bd;

        public DistanciaRepositorio(ApplicationDbContext bd)
        {
            _bd = bd;
        }
        //public bool ActualizarDistancia(Distancia distancia)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool BorrarDistancia(Distancia distancia)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CrearDistancia(Distancia distancia)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool ExisteDistancia(string nombre)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool ExisteDistancia(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public ICollection<Distancia> GetDistancia(string fechaInicio, string fechaFin, string token)
        {
            return _bd.Distancia.Where(c => c.FechaInicio == fechaInicio && c.FechaFin == fechaFin && c.Token == token).ToList();
        }

        //public Distancia GetDistancia()
        //{
        //    throw new NotImplementedException();
        //}

        public ICollection<Distancia> GetInfo()
        {
            return _bd.Distancia.OrderBy(c => c.Flota).ToList();
        }

        //public bool Guardar()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
