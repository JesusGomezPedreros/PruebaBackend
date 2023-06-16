using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;
using LBA_Negocio.Contratos;

namespace LBA_Negocio.Fachada
{
    public class Fachada : IFachada
    {
        private readonly IConsultaPrueba _consultaPrueba;
        private readonly IComandosPrueba _comandosPrueba;

        public Fachada(IConsultaPrueba consultaPrueba, IComandosPrueba comandosPrueba)
        {
            _consultaPrueba = consultaPrueba;
            _comandosPrueba = comandosPrueba;
        }
        public Task<string> ConsultaEstudiantes()
        {
            return _consultaPrueba.ConsultaEstudiantes();
        }
        public Task<string> ConsultaModulos()
        {
            return _consultaPrueba.ConsultaModulos();
        }
        public Task<string> ConsultaClases()
        {
            return _consultaPrueba.ConsultaClases();
        }
        public Task<string> RegistrarEstudiantes(ComandoRegistroViewModel comandoRegistroViewModel)
        {
            return _comandosPrueba.RegistrarEstudiantes(comandoRegistroViewModel);
        }
        public Task<string> InscribirModuloClase(ComandoInscribirModuloClaseViewModel claseViewModel)
        {
            return _comandosPrueba.InscribirModuloClase(claseViewModel);
        }
        public  Task<string> ConsultaModuloClaseEstudiante(int idEstudiante)
        {
            var resultado =  _consultaPrueba.ConsultaModuloClaseEstudiante(idEstudiante);
            return resultado;
        }

    }
}
