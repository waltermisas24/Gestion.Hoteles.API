using Gestion.Hoteles.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Interfaces
{
    public interface IReservacionRepository
    {
        Task<ReservacionEntity> CreateReservacionAsync(ReservacionEntity hotelEntity);
        Task<DetalleReservacionEntity> ObtenerPorHotelAsync(int Id);
    }
}
