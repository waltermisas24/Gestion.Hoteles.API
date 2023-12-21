using Gestion.Hoteles.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Interfaces
{
    public interface IHotelServices
    {
        Task<HotelEntity> CreateAsync(HotelEntity hotelEntity);
        Task<HotelEntity> UpdateAsync(HotelEntity hotelEntity);
        Task<HotelEntity> DeleteAsync(int id);
    }
}
