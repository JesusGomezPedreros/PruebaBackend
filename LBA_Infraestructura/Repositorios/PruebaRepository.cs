using LBA_Dominios.ModelosComandos;
using LBA_Infraestructura.Contratos;
using System.Data;
using System.Data.SqlClient;

namespace LBA_Infraestructura.Repositorios
{
    public class PruebaRepository : Repository, IPruebaRepository
    {
        private SqlCommand _comandogeneral;

        public PruebaRepository()
        {
            _comandogeneral = new SqlCommand();
        }
        // Consulta de estudiantes
        public async Task<string> ConsultaEstudiantes()
        {
            _comandogeneral.Parameters.Clear();
            var resultado = await EjecutarFuncion(_comandogeneral, "LeerInformacionEstudiantes");
            return resultado;
        }
        // Consulta de módulos
        public async Task<string> ConsultaModulos()
        {
            _comandogeneral.Parameters.Clear();
            var resultado = await EjecutarFuncion(_comandogeneral, "LeerModulos");
            return resultado;
        }
        // Consulta de clases
        public async Task<string> ConsultaClases()
        {
            _comandogeneral.Parameters.Clear();
            var resultado = await EjecutarFuncion(_comandogeneral, "LeerClases");
            return resultado;
        }

        // Registro de estudiantes
        public async Task<string> RegistrarEstudiantes(ComandoRegistroViewModel comandoRegistroViewModel)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@Nombres", SqlDbType.VarChar).Value = comandoRegistroViewModel.nombres;
            _comandogeneral.Parameters.AddWithValue("@Apellidos", SqlDbType.VarChar).Value = comandoRegistroViewModel.apellidos;
            _comandogeneral.Parameters.AddWithValue("@Identificacion", SqlDbType.Int).Value = comandoRegistroViewModel.identificacion;
            _comandogeneral.Parameters.AddWithValue("@Edad", SqlDbType.Int).Value = comandoRegistroViewModel.edad;
            _comandogeneral.Parameters.AddWithValue("@TipoLicencia", SqlDbType.VarChar).Value = comandoRegistroViewModel.tipoLicencia;
            _comandogeneral.Parameters.Add("@Resultado", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            await EjecutarFuncion(_comandogeneral, "CrearEstudiante");
            return _comandogeneral.Parameters["@Resultado"].Value.ToString();
        }
        // Inscripción de un módulo y una clase
        public async Task<string> InscribirModuloClase(ComandoInscribirModuloClaseViewModel claseViewModel)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@IdEstudiante", SqlDbType.Int).Value = claseViewModel.idEstudiante;
            _comandogeneral.Parameters.AddWithValue("@IdModulo", SqlDbType.Int).Value = claseViewModel.idModulo;
            _comandogeneral.Parameters.AddWithValue("@IdClase", SqlDbType.Int).Value = claseViewModel.idClase;
            _comandogeneral.Parameters.Add("@Resultado", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
            await EjecutarFuncion(_comandogeneral, "InscribirModuloClase");
            return _comandogeneral.Parameters["@Resultado"].Value.ToString();
        }
        // Consulta de módulos y clases de un estudiante
        public async Task<string> ConsultaModuloClaseEstudiante(int idEstudiante)
        {
            _comandogeneral.Parameters.Clear();
            _comandogeneral.Parameters.AddWithValue("@IdEstudiante", SqlDbType.Int).Value = idEstudiante;
            var resultado = await EjecutarFuncion(_comandogeneral, "ListarModuloClaseEstudiante");
            return resultado;
        }

    }
}
