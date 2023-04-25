using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria.Models
{
    internal class mascota
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string cedulaD { get; set; }

        [MaxLength(13)]
        public string edad { get; set; }

        [MaxLength(50)]
        public string especie { get; set; }

        [MaxLength(10)]
        public string raza { get; set; }

        [MaxLength(10)]
        public string caracteristica { get; set; }

        [MaxLength(10)]
        public string peso { get; set; }

    }
}
