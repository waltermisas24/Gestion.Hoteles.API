using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.Domain.Interfaces;
using Gestion.Hoteles.API.Domain.Services;
using Gestion.Hoteles.API.DTO;
using Gestion.Hoteles.API.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace Gestion.Hoteles.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionController : Controller
    {
        private readonly IReservacionServices _reservacionServices;
        public ReservacionController(IReservacionServices reservacionServices)
        {
            _reservacionServices = reservacionServices;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReservacionDTO reservaDTO)
        {
            try
            {
                ReservacionEntity reserva = await _reservacionServices.CreateAsync(ReservacionMapper.MapReservacionDTOtoEntity(reservaDTO));

                return new OkObjectResult(ReservacionMapper.MapReservacionEntitytoDTO(reserva));
            }
            catch (Exception ex)
            {
                return ErrorResponse(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("{hotelId}")]
        public async Task<IActionResult> ObtenerPorHotel(int hotelId)
        {
            try
            {
                DetalleReservacionEntity reservas = await _reservacionServices.ObtenerPorHotelAsync(hotelId);

                return new OkObjectResult(ReservacionMapper.MapDetalleReservacionEntityToDTO(reservas));
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
