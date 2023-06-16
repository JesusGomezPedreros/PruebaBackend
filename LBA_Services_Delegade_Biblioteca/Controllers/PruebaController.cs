using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;
using LBA_Negocio.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace LBA_Services_Delegade_Biblioteca.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class PruebaController : Controller
    {
        private readonly IFachada _fachada;
        delegate string delegadaConsultaEstudiantes();
        delegate string delegadaConsultaModulos();
        delegate string delegadaConsultaClases();
        delegate string delegadaRegistrarEstudiantes(ComandoRegistroViewModel comandoRegistroViewModel);
        delegate string delegadaInscribirModuloClase(ComandoInscribirModuloClaseViewModel claseViewModel);
        delegate string delegadaConsultaModuloClaseEstudiante(int idEstudiante);


        public PruebaController(IFachada fachada)
        {
            _fachada= fachada;
        }
        [HttpGet("ConsultaEstudiantes")]
        public async Task<string> ConsultaEstudiantes()
        {
            // Declaración de una delegada que devuelve la consulta de estudiantes
            delegadaConsultaEstudiantes delegada = delegate ()
            {
                return _fachada.ConsultaEstudiantes().Result;
            };
            // Ejecución de la delegada y retorno del resultado
            return delegada();
        }

        [HttpGet("ConsultaModulos")]
        public async Task<string> ConsultaModulos()
        {
            // Declaración de una delegada que devuelve la consulta de módulos
            delegadaConsultaModulos delegada = delegate ()
            {
                return _fachada.ConsultaModulos().Result;
            };
            // Ejecución de la delegada y retorno del resultado
            return delegada();
        }

        [HttpGet("ConsultaClases")]
        public async Task<string> ConsultaClases()
        {
            // Declaración de una delegada que devuelve la consulta de clases
            delegadaConsultaClases delegada = delegate ()
            {
                return _fachada.ConsultaClases().Result;
            };
            // Ejecución de la delegada y retorno del resultado
            return delegada();
        }

        [HttpPost("RegistrarEstudiantes")]
        public async Task<string> RegistrarEstudiantes(ComandoRegistroViewModel comandoRegistroViewModel)
        {
            // Declaración de una delegada que registra estudiantes
            delegadaRegistrarEstudiantes delegada = delegate (ComandoRegistroViewModel _comandoRegistroViewModel)
            {
                return _fachada.RegistrarEstudiantes(_comandoRegistroViewModel).Result;
            };
            // Ejecución de la delegada y retorno del resultado
            return delegada(comandoRegistroViewModel);
        }
         
        [HttpPost("InscribirModuloClase")]
        public async Task<string> InscribirModuloClase(ComandoInscribirModuloClaseViewModel claseViewModel)
        {
            // Declaración de una delegada que inscribe un módulo y una clase
            delegadaInscribirModuloClase delegada = delegate (ComandoInscribirModuloClaseViewModel _claseViewModel)
            {
                return _fachada.InscribirModuloClase(_claseViewModel).Result;
            };
            // Ejecución de la delegada y retorno del resultado
            return delegada(claseViewModel);
        }

        [HttpGet("ConsultaModuloClaseEstudiante")]
        public async Task<string> ConsultaModuloClaseEstudiante(int idEstudiante)
        {
            // Declaración de una delegada que consulta los módulos y clases de un estudiante
            delegadaConsultaModuloClaseEstudiante delegada = delegate (int _idEstudiante)
            {
                return _fachada.ConsultaModuloClaseEstudiante(_idEstudiante).Result;
            };
            // Ejecución de la delegada y retorno del resultado
            return delegada(idEstudiante);
        }



    }
}
