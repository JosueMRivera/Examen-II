using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleTicket
    {
        public int Id { get; set; }
        public int IdTicket { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public decimal Precio { get; set; }

        public DetalleTicket()
        {
        }

        public DetalleTicket(int id, int idTicket, string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta, decimal precio)
        {
            Id = id;
            IdTicket = idTicket;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Precio = precio;
        }
    }
}
