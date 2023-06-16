using LBA_Dominios.ModelosConsultas;
using LBA_Infraestructura.Contratos;
using LBA_Negocio.Contratos;

namespace LBA_Negocio.Biblioteca
{
    public class ConsultaPrueba : IConsultaPrueba
    {
        private readonly IPruebaRepository _PruebaRepository;
        public ConsultaPrueba(IPruebaRepository pruebaRepository)
        {
            _PruebaRepository = pruebaRepository;
        }
        public async Task<string> ConsultaEstudiantes()
        {
            var resultado = await _PruebaRepository.ConsultaEstudiantes();
            return resultado;
        }
        public async Task<string> ConsultaModulos()
        {
            var resultado = await _PruebaRepository.ConsultaModulos();
            return resultado;
        }
        public async Task<string> ConsultaClases()
        {
            var resultado = await _PruebaRepository.ConsultaClases();
            return resultado;
        } 
        public async Task<string> ConsultaModuloClaseEstudiante(int idEstudiante)
        {
            var resultado = await _PruebaRepository.ConsultaModuloClaseEstudiante(idEstudiante);
            return resultado;
        }

    }
}
