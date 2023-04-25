using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Veterinaria.Models
{
    public class Persona
    {
        [PrimaryKey]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Cedula { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string Edad { get; set; }

        [MaxLength(13)]
        public string Rol { get; set; }

        [MaxLength(50)]   
        public string Usuario { get; set; }

        [MaxLength(10)]
        public string Password { get; set; }
      
    }
}
