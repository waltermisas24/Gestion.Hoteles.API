using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.Domain.Interfaces;
using Gestion.Hoteles.API.Infraestructure.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Hoteles.API.Infraestructure.Repositories
{
    public class ReservacionRepository : IReservacionRepository
    {
        private readonly SqlSettings _sqlSettings;
        public ReservacionRepository(IOptions<Settings> settings)
        {
            _sqlSettings = settings.Value.SqlSettings;
        }

        public Task<ReservacionEntity> CreateReservacionAsync(ReservacionEntity hotelEntity)
        {
            throw new NotImplementedException();
        }

        public Task<DetalleReservacionEntity> ObtenerPorHotelAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
