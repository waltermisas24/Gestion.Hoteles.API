using Gestion.Hoteles.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Interfaces
{
    public interface IHabitacionRepository
    {
        Task<HabitacionEntity> CreateHabitacionAsync(HabitacionEntity habitacionEntity);
        Task<HabitacionEntity> UpdateHabitacionAsync(HabitacionEntity habitacionEntity);
        Task<HabitacionEntity> DeleteHabitacionAsync(int id);
    }
}
