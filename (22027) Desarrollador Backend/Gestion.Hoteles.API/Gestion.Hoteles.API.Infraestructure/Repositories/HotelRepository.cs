using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.Domain.Interfaces;
using Gestion.Hoteles.API.Infraestructure.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestion.Hoteles.API.Infraestructure.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly SqlSettings _sqlSettings;
        public HotelRepository(IOptions<Settings> settings)
        {
            _sqlSettings = settings.Value.SqlSettings;
        }

        public async Task<HotelEntity> CreateHotelAsync(HotelEntity hotelEntity)
        {
            using (var connection = new SqlConnection(_sqlSettings.ConnectionStrings))
            {
                connection.Open();

                var parametros = new { Nombre = hotelEntity.Nombre, Ubicacion = hotelEntity.Ubicacion, Estado = hotelEntity.Habilitado };
                var resultado = await connection.QueryFirstOrDefaultAsync<HotelEntity>(
                    "InsertarHotel",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );

                resultado.Habilitado = !resultado.Habilitado;

                return resultado;
            }
        }

        public async Task<HotelEntity> DeleteHotelAsync(int id)
        {
            using (var connection = new SqlConnection(_sqlSettings.ConnectionStrings))
            {
                connection.Open();

                var parametros = new
                {
                    Id = id,
                    Estado = false
                };
                var resultado = await connection.QueryFirstOrDefaultAsync<HotelEntity>(
                    "EliminadoLogicoHotel",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );

                return resultado;
            }
        }

        public async Task<HotelEntity> UpdateHotelAsync(HotelEntity hotelEntity)
        {
            using(var connection = new SqlConnection(_sqlSettings.ConnectionStrings))
            {
                connection.Open();

                var parametros = new { 
                    Id = hotelEntity.Id,
                    Nombre = hotelEntity.Nombre, 
                    Ubicacion = hotelEntity.Ubicacion, 
                    Estado = hotelEntity.Habilitado 
                };
                var resultado = await connection.QueryFirstOrDefaultAsync<HotelEntity>(
                    "ActualizarHotel",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );

                resultado.Habilitado = !resultado.Habilitado;

                return resultado;
            }
        }
    }
}
