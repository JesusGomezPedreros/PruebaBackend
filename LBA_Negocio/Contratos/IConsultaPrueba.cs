using LBA_Dominios.ModelosConsultas;

namespace LBA_Negocio.Contratos
{
    public interface IConsultaPrueba
    {
        Task<string> ConsultaEstudiantes();
        Task<string> ConsultaModulos();
        Task<string> ConsultaClases();
        Task<string> ConsultaModuloClaseEstudiante(int idEstudiante);

    }
}
