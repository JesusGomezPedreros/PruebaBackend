using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;

namespace LBA_Infraestructura.Contratos
{
    public interface IPruebaRepository
    {

        Task<string> ConsultaEstudiantes();
        Task<string> ConsultaModulos();
        Task<string> ConsultaClases();
        Task<string> RegistrarEstudiantes(ComandoRegistroViewModel comandoRegistroViewModel);
        Task<string> InscribirModuloClase(ComandoInscribirModuloClaseViewModel claseViewModel);
        Task<string> ConsultaModuloClaseEstudiante(int idEstudiante);


    }
}
