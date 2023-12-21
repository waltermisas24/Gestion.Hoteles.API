using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Services
{
    public class HabitacionServices : IHabitacionServices
    {
        private readonly IHabitacionRepository _habitacionRepository;
        public HabitacionServices(IHabitacionRepository habitacionRepository)
        {
            _habitacionRepository = habitacionRepository;
        }

        public async Task<HabitacionEntity> CreateAsync(HabitacionEntity hotelEntity)
        {
            hotelEntity.Habilitado = true;

            var habitacion = await _habitacionRepository.CreateHabitacionAsync(hotelEntity);

            return habitacion;
        }
        public async Task<HabitacionEntity> UpdateAsync(HabitacionEntity hotelEntity)
        {
            hotelEntity.Habilitado = true;

            var habitacion = await _habitacionRepository.UpdateHabitacionAsync(hotelEntity);

            return habitacion;
        }

        public async Task<HabitacionEntity> DeleteAsync(int id)
        {
            var habitacion = await _habitacionRepository.DeleteHabitacionAsync(id);

            return habitacion;
        }

    }
}
