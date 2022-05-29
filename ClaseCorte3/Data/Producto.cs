using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClaseCorte3.Data
{
    public class Producto
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
        public string descripcion { get; set; }
    }
}
