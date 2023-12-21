using Gestion.Hoteles.API.Domain.Entities;
using Gestion.Hoteles.API.DTO;

namespace Gestion.Hoteles.API.Mapper
{
    public class ReservacionMapper
    {
        public static ReservacionEntity MapReservacionDTOtoEntity(ReservacionDTO reservacionDTO)
        {
            ReservacionEntity reservacionEntity = new ReservacionEntity
            {
                Id = reservacionDTO.Identificador,
                IdHabitacion = reservacionDTO.IdentificadorHabitacion,
                FechaInicio = reservacionDTO.FechaInicio,
                FechaFinal = reservacionDTO.FechaFinal,
                Precio = reservacionDTO.Precio,
                NombreContactoEmergencia = reservacionDTO.NombreContactoEmergencia,
                TelefonoContactoEmergencia = reservacionDTO.TelefonoContactoEmergencia,
                Estado = reservacionDTO.Estado
            };

            reservacionEntity.Huespedes = new List<HuespedEntity>();

            foreach (HuespedDTO huesped in reservacionDTO.Huespedes)
            {
                HuespedEntity huespedEntity = new HuespedEntity();

                huespedEntity.Id = huesped.Identificador;
                huespedEntity.Documento = huesped.Documento;
                huespedEntity.TipoDocumento = huesped.TipoDocumento;
                huespedEntity.Nombre = huesped.Nombre;
                huespedEntity.Apellido = huesped.Apellido;
                huespedEntity.FechaNacimiento = huesped.FechaNacimiento;
                huespedEntity.Genero = huesped.Genero;
                huespedEntity.Email = huesped.Email;
                huespedEntity.Telefono = huesped.Telefono;

                reservacionEntity.Huespedes.Add(huespedEntity);
            }

            return reservacionEntity;
        }

        public static ReservacionDTO MapReservacionEntitytoDTO(ReservacionEntity reservacionEntity)
        {
            ReservacionDTO reservacionDTO = new ReservacionDTO
            {
                Identificador = reservacionEntity.Id,
                IdentificadorHabitacion = reservacionEntity.IdHabitacion,
                FechaInicio = reservacionEntity.FechaInicio,
                FechaFinal = reservacionEntity.FechaFinal,
                Precio = reservacionEntity.Precio,
                NombreContactoEmergencia = reservacionEntity.NombreContactoEmergencia,
                TelefonoContactoEmergencia = reservacionEntity.TelefonoContactoEmergencia,
                Estado = reservacionEntity.Estado
            };

            reservacionDTO.Huespedes = new List<HuespedDTO>();

            foreach (HuespedEntity huesped in reservacionEntity.Huespedes)
            {
                HuespedDTO huespedDTO = new HuespedDTO();

                huespedDTO.Identificador = huesped.Id;
                huespedDTO.Documento = huesped.Documento;
                huespedDTO.TipoDocumento = huesped.TipoDocumento;
                huespedDTO.Nombre = huesped.Nombre;
                huespedDTO.Apellido = huesped.Apellido;
                huespedDTO.FechaNacimiento = huesped.FechaNacimiento;
                huespedDTO.Genero = huesped.Genero;
                huespedDTO.Email = huesped.Email;
                huespedDTO.Telefono = huesped.Telefono;

                reservacionDTO.Huespedes.Add(huespedDTO);
            }

            return reservacionDTO;
        }

        public static DetalleReservacionDTO MapDetalleReservacionEntityToDTO(DetalleReservacionEntity detalleReservacionEntity)
        {
            DetalleReservacionDTO detalleReservacionDTO = new DetalleReservacionDTO();

            detalleReservacionDTO.Hotel.Identificador = detalleReservacionEntity.Hotel.Id;
            detalleReservacionDTO.Hotel.Nombre = detalleReservacionEntity.Hotel.Nombre;
            detalleReservacionDTO.Hotel.Ubicacion = detalleReservacionEntity.Hotel.Ubicacion;

            detalleReservacionDTO.Habitaciones = new List<HabitacionReservaDTO>();
            foreach (HabitacionReservaEntity habitacion in detalleReservacionEntity.Habitaciones)
            {
                HabitacionReservaDTO habitacionReservaDTO = new HabitacionReservaDTO();

                habitacionReservaDTO.Identificador = habitacion.Id;
                habitacionReservaDTO.IdentificadorHotel = habitacion.IdHotel;
                habitacionReservaDTO.Nombre = habitacion.Nombre;
                habitacionReservaDTO.Costo = habitacion.Costo;
                habitacionReservaDTO.Tipo = habitacion.Tipo;
                habitacionReservaDTO.Impuesto = habitacion.Impuesto;
                habitacionReservaDTO.CantidadHuespedes = habitacion.CantidadHuespedes;
                habitacionReservaDTO.Habilitado = habitacion.Habilitado;

                habitacionReservaDTO.Reservas = new List<ReservacionDTO>();
                foreach (ReservacionEntity reservacion in habitacion.Reservas)
                {
                    ReservacionDTO reservacionDTO = new ReservacionDTO();

                    reservacionDTO.Identificador = reservacion.Id;
                    reservacionDTO.IdentificadorHabitacion = reservacion.IdHabitacion;
                    reservacionDTO.FechaInicio = reservacion.FechaInicio;
                    reservacionDTO.FechaFinal = reservacion.FechaFinal;
                    reservacionDTO.Precio = reservacion.Precio;
                    reservacionDTO.NombreContactoEmergencia = reservacion.NombreContactoEmergencia;
                    reservacionDTO.TelefonoContactoEmergencia = reservacion.TelefonoContactoEmergencia;
                    reservacionDTO.Estado = reservacion.Estado;

                    reservacionDTO.Huespedes = new List<HuespedDTO>();
                    foreach (HuespedEntity huesped in reservacion.Huespedes)
                    {
                        HuespedDTO huespedDTO = new HuespedDTO();

                        huespedDTO.Identificador = huesped.Id;
                        huespedDTO.Documento = huesped.Documento;
                        huespedDTO.TipoDocumento = huesped.TipoDocumento;
                        huespedDTO.Nombre = huesped.Nombre;
                        huespedDTO.Apellido = huesped.Apellido;
                        huespedDTO.FechaNacimiento = huesped.FechaNacimiento;
                        huespedDTO.Genero = huesped.Genero;
                        huespedDTO.Email = huesped.Email;
                        huespedDTO.Telefono = huesped.Telefono;

                        reservacionDTO.Huespedes.Add(huespedDTO);
                    }
                    habitacionReservaDTO.Reservas.Add(reservacionDTO);
                }
                detalleReservacionDTO.Habitaciones.Add(habitacionReservaDTO);
            }

            return detalleReservacionDTO;
        }
    }
}
