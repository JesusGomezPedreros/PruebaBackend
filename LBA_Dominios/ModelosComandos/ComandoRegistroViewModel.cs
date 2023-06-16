namespace LBA_Dominios.ModelosComandos
{
    public class ComandoRegistroViewModel
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int identificacion { get; set; }
        public int edad { get; set; }
        public string tipoLicencia { get; set; }
    }

    public class ComandoInscribirModuloClaseViewModel
    {
        public int idEstudiante { get; set; }
        public int idModulo { get; set; }
        public int idClase { get; set; }

    }

}
