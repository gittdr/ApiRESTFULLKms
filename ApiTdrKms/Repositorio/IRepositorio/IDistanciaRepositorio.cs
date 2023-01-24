using ApiTdrKms.Modelos;

namespace ApiTdrKms.Repositorio.IRepositorio
{
    public interface IDistanciaRepositorio
    {
        ICollection<Distancia> GetInfo();
        ICollection<Distancia> GetDistancia(string fechaInicio, string fechaFin, string token);
        //Distancia GetDistancia();
        //bool ExisteDistancia(string nombre);
        //bool ExisteDistancia(int id);
        //bool CrearDistancia(Distancia distancia);
        //bool ActualizarDistancia(Distancia distancia);
        //bool BorrarDistancia(Distancia distancia);
        //bool Guardar();
    }
}
