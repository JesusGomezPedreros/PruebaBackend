using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;

namespace LBA_Negocio.Contratos
{
    public interface IComandosPrueba
    {
        Task<string> RegistrarEstudiantes(ComandoRegistroViewModel comandoRegistroViewModel);
        Task<string> InscribirModuloClase(ComandoInscribirModuloClaseViewModel claseViewModel);

    }
}
