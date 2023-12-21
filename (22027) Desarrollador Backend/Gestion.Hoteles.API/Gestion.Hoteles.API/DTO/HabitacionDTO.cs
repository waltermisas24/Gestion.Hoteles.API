namespace Gestion.Hoteles.API.DTO
{
    public class HabitacionDTO
    {
        public int Identificador { get; set; }
        public int IdentificadorHotel { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public string Tipo { get; set; }
        public double Impuesto { get; set; }
        public int CantidadHuespedes { get; set; }
        public bool Habilitado { get; set; }
    }
}
