namespace Gestion.Hoteles.API.DTO
{
    public class DetalleReservacionDTO
    {
        public HotelDTO Hotel { get; set; }
        public List<HabitacionReservaDTO> Habitaciones { get; set; }
    }
}
