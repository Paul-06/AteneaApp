using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AteneaApp.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public string ImageName { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public double MotorLitros { get; set; }
        public double KmRecorridos { get; set; }
        public int CantPasajeros { get; set; }
        public int Anio { get; set; }
        public double Precio { get; set; }
        public string PrecioStr { 
            get {
                // Create a CultureInfo object for a culture that uses space as the number group separator.
                var customCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberGroupSeparator = " ";
                customCulture.NumberFormat.CurrencySymbol = "$";

                // Format the price using the custom culture.
                return Precio.ToString("C", customCulture);
            }
        }
        public bool IsNew { get; set; }
        public string Estado
        {
            get
            {
                return (IsNew) ? "New" : "Old";
            }
        }
    }
}
