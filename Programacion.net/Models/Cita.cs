namespace Programacion.net.Models
{
    public class cita
    {
        public int Id { get; set; }
        public int clienteId { get; set; }
        public int ServicioId { get; set; }
        public DateTime fecha { get; set; }

        public TimeSpan hora { get; set; }

        public string estado { get; set; } // "Pendiente", "Confirmada", "Cancelada"

        public string comentarios { get; set; } // Comentarios adicionales sobre la cita 
    }
}
