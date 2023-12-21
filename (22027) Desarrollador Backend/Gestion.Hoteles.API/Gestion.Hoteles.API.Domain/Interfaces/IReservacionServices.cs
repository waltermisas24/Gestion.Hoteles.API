using Gestion.Hoteles.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Interfaces
{
    public interface IReservacionServices
    {
        Task<ReservacionEntity> CreateAsync(ReservacionEntity hotelEntity);
        Task<DetalleReservacionEntity> ObtenerPorHotelAsync(int id);
    }
}
