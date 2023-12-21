using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Services
{
    public class ReservacionServices : IReservacionServices
    {
        private readonly IReservacionRepository _reservacionRepository;
        public ReservacionServices(IReservacionRepository reservacionRepository)
        {
            _reservacionRepository = reservacionRepository;
        }

        public async Task<ReservacionEntity> CreateAsync(ReservacionEntity hotelEntity)
        {
            var reservacion = await _reservacionRepository.CreateReservacionAsync(hotelEntity);

            return reservacion;
        }

        public async Task<DetalleReservacionEntity> ObtenerPorHotelAsync(int id)
        {
            var reservaciones = await _reservacionRepository.ObtenerPorHotelAsync(id);

            return reservaciones;
        }
    }
}
