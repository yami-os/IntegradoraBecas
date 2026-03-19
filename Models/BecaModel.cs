namespace Api_Becas.Models
{
    public class BecaModel
    {
        public int Bec_Id { get; set; }
        public string? Bec_NombreConvocatoria {  get; set; }
        public string? Bec_NombreEstudiante {  get; set; }
        public string? Bec_CorreoEstudiante { get; set; }
        public string? Bec_ContraEstudiante { get; set; }
        public string? Bec_CarreraEstudiante { get; set; }
        public int Bec_TelefonoEstudiante { get; set; }
        public string? Bec_DirreccionEstudiante {  get; set; }
    }
}
