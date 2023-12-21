using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.Domain.Interfaces;
using Gestion.Hoteles.API.DTO;
using Gestion.Hoteles.API.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace Gestion.Hoteles.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : Controller
    {
        private readonly IHotelServices _hotelServices;
        public HotelController(IHotelServices hotelServices)
        {
            _hotelServices = hotelServices;
        }

        [HttpPost]
        public async Task<IActionResult> Create(HotelDTO hotelDTO)
        {
            try
            {
                var hotel = await _hotelServices.CreateAsync(HotelMapper.MapHotelDTOToEntity(hotelDTO));

                return new OkObjectResult(HotelMapper.MapHotelEntityToDTO(hotel));
            }
            catch (Exception ex)
            {
                return ErrorResponse(500, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(HotelDTO hotelDTO)
        {
            try
            {
                var hotel = await _hotelServices.UpdateAsync(HotelMapper.MapHotelDTOToEntity(hotelDTO));

                return new OkObjectResult(HotelMapper.MapHotelEntityToDTO(hotel));
            }
            catch (Exception ex)
            {
                return ErrorResponse(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var hotel = await _hotelServices.DeleteAsync(id);

                return new OkObjectResult(HotelMapper.MapHotelEntityToDTO(hotel));
            }
            catch (Exception ex)
            {
                return ErrorResponse(500, ex.Message);
            }
        }

        private IActionResult ErrorResponse(int codeError, string message)
        {
            ErrorMessageDTO errorMessage = new ErrorMessageDTO();
            errorMessage.CodeError = codeError;
            errorMessage.Message = message;

            return new BadRequestObjectResult(errorMessage);
        }
    }
}
