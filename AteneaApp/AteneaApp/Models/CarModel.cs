using Postgrest.Attributes;
using Postgrest.Models;

namespace AteneaApp.Models
{
    [Table("cars")]
    public class CarModel : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("marca_id")]
        public int MarcaId { get; set; }

        [Column("image_url")]
        public string ImageUrl { get; set; }

        [Column("modelo")]
        public string Modelo { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("motor_litros")]
        public double MotorLitros { get; set; }

        [Column("km_recorridos")]
        public double KmRecorridos { get; set; }

        [Column("cant_pasajeros")]
        public int CantPasajeros { get; set; }

        [Column("anio")]
        public int Anio { get; set; }

        [Column("precio")]
        public double Precio { get; set; }

        [Column("rating")]
        public double Rating { get; set; }

    }
}
