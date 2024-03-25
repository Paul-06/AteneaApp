using Postgrest.Attributes;
using Postgrest.Models;

namespace AteneaApp.Models
{
    [Table("services")]
    public class ServiceModel : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("icon")]
        public string Icon { get; set; }
        public string IconFormatted
        {
            get
            {
                var hex = Icon.Replace("&#x", "").Replace(";", ""); // Elimina la parte "&#x" y ";" del string.
                int value = int.Parse(hex, System.Globalization.NumberStyles.HexNumber); // Convierte el hexadecimal a un entero.
                char character = (char)value; // Convierte el entero a un char.
                return character.ToString(); // Devuelve el char como string.
            }
        }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}
