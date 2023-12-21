using Dapper;
using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.Domain.Interfaces;
using Gestion.Hoteles.API.Infraestructure.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Infraestructure.Repositories
{
    public class HabitacionRepository : IHabitacionRepository
    {
        private readonly SqlSettings _sqlSettings;
        public HabitacionRepository(IOptions<Settings> settings)
        {
            _sqlSettings = settings.Value.SqlSettings;
        }

        public async Task<HabitacionEntity> CreateHabitacionAsync(HabitacionEntity habitacionEntity)
        {
            using (var connection = new SqlConnection(_sqlSettings.ConnectionStrings))
            {
                connection.Open();

                var parametros = new
                {
                    Hotel_Id = habitacionEntity.IdHotel,
                    Nombre = habitacionEntity.Nombre,
                    Costo = habitacionEntity.Costo,
                    Tipo_Habitacion = habitacionEntity.Tipo,
                    Impuesto = habitacionEntity.Impuesto,
                    Cantidad_Huespedes = habitacionEntity.CantidadHuespedes,
                    Estado = habitacionEntity.Habilitado
                };
                var resultado = await connection.QueryFirstOrDefaultAsync<HabitacionEntity>(
                    "InsertarHabitacion",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );

                resultado.Habilitado = !resultado.Habilitado;

                return resultado;
            }
        }

        public async Task<HabitacionEntity> DeleteHabitacionAsync(int id)
        {
            using (var connection = new SqlConnection(_sqlSettings.ConnectionStrings))
            {
                connection.Open();

                var parametros = new
                {
                    Id = id,
                    Estado = false
                };
                var resultado = await connection.QueryFirstOrDefaultAsync<HabitacionEntity>(
                    "EliminadoLogicoHabitacion",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );

                return resultado;
            }
        }

        public async Task<HabitacionEntity> UpdateHabitacionAsync(HabitacionEntity habitacionEntity)
        {
            using (var connection = new SqlConnection(_sqlSettings.ConnectionStrings))
            {
                connection.Open();

                var parametros = new
                {
                    Id = habitacionEntity.Id,
                    Hotel_Id = habitacionEntity.IdHotel,
                    Nombre = habitacionEntity.Nombre,
                    Costo = habitacionEntity.Costo,
                    Tipo_Habitacion = habitacionEntity.Tipo,
                    Impuesto = habitacionEntity.Impuesto,
                    Cantidad_Huespedes = habitacionEntity.CantidadHuespedes,
                    Estado = habitacionEntity.Habilitado
                };
                var resultado = await connection.QueryFirstOrDefaultAsync<HabitacionEntity>(
                    "ActualizarHabitacion",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );

                resultado.Habilitado = !resultado.Habilitado;

                return resultado;
            }
        }
    }
}
