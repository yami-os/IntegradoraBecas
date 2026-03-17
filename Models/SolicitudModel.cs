namespace Api_Becas.Models
{
    public class SolicitudModel
    {
        public int Sol_Id { get; set; }

        public DateTime Sol_Fecha { get; set; }
        public string? Sol_Estado { get; set; }
        public string? sol_Comentarios { get; set; }
        public string? Sol_CorreoEsr { get; set; }
        public string? Sol_CraerContra { get; set; }
        public int Sol_Telefono { get; set; }
        public string? Sol_Direccion {  get; set; }
    }
}
