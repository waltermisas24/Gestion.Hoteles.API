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
    public class HabitacionController : Controller
    {
        private readonly IHabitacionServices _habitacionServices;
        public HabitacionController(IHabitacionServices habitacionServices)
        {
            _habitacionServices = habitacionServices;
        }

        [HttpPost]
        public async Task<IActionResult> Create(HabitacionDTO habitacionDTO)
        {
            try
            {
                HabitacionEntity habitacion = await _habitacionServices.CreateAsync(HabitacionMapper.MapHabitacionDTOToEntity(habitacionDTO));

                return new OkObjectResult(HabitacionMapper.MapHabitacionEntityToDTO(habitacion));
            }
            catch (Exception ex)
            {
                return ErrorResponse(500, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(HabitacionDTO habitacionDTO)
        {
            try
            {
                HabitacionEntity habitacion = await _habitacionServices.UpdateAsync(HabitacionMapper.MapHabitacionDTOToEntity(habitacionDTO));

                return new OkObjectResult(HabitacionMapper.MapHabitacionEntityToDTO(habitacion));
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
                HabitacionEntity habitacion = await _habitacionServices.DeleteAsync(id);

                return new OkObjectResult(HabitacionMapper.MapHabitacionEntityToDTO(habitacion));
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
