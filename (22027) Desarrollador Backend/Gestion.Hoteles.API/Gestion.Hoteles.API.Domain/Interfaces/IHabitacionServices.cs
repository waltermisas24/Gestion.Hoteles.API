using Gestion.Hoteles.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Interfaces
{
    public interface IHabitacionServices
    {
        Task<HabitacionEntity> CreateAsync(HabitacionEntity hotelEntity);
        Task<HabitacionEntity> UpdateAsync(HabitacionEntity hotelEntity);
        Task<HabitacionEntity> DeleteAsync(int id);
    }
}
