using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Domain.Services
{
    public class HotelServices : IHotelServices
    {
        private readonly IHotelRepository _hotelRepository;
        public HotelServices(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<HotelEntity> CreateAsync(HotelEntity hotelEntity)
        {
            hotelEntity.Habilitado = true;

            var hotel = await _hotelRepository.CreateHotelAsync(hotelEntity);

            return hotel;
        }

        public async Task<HotelEntity> DeleteAsync(int id)
        {
            var hotel = await _hotelRepository.DeleteHotelAsync(id);

            return hotel;
        }

        public async Task<HotelEntity> UpdateAsync(HotelEntity hotelEntity)
        {
            hotelEntity.Habilitado = true;

            var hotel = await _hotelRepository.UpdateHotelAsync(hotelEntity);

            return hotel;
        }
    }
}
