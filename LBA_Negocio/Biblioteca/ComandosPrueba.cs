using LBA_Dominios.ModelosComandos;
using LBA_Dominios.ModelosConsultas;
using LBA_Infraestructura.Contratos;
using LBA_Negocio.Contratos;

namespace LBA_Negocio.Biblioteca
{
    public class ComandosPrueba : IComandosPrueba
    {
        private readonly IPruebaRepository _PruebaRepository;
        public ComandosPrueba(IPruebaRepository pruebaRepository)
        {
            _PruebaRepository = pruebaRepository;
        }
        public async Task<string> RegistrarEstudiantes(ComandoRegistroViewModel comandoRegistroViewModel)
        {
            string resultado = await _PruebaRepository.RegistrarEstudiantes(comandoRegistroViewModel);
            return resultado;
        }
        public async Task<string> InscribirModuloClase(ComandoInscribirModuloClaseViewModel claseViewModel)
        {
            string resultado = await _PruebaRepository.InscribirModuloClase(claseViewModel);
            return resultado;
        }

    }
}
