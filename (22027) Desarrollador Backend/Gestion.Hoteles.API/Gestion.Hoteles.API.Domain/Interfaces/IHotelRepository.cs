using Gestion.Hoteles.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Interfaces
{
    public interface IHotelRepository
    {
        Task<HotelEntity> CreateHotelAsync(HotelEntity hotelEntity);
        Task<HotelEntity> UpdateHotelAsync(HotelEntity hotelEntity);
        Task<HotelEntity> DeleteHotelAsync(int id);
    }
}
