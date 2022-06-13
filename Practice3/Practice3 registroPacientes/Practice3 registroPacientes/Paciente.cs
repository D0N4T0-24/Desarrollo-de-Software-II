using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_registroPacientes
{
    public class Paciente
    {
        public Guid Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Sexo { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string Nacionalidad { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public bool Seguro { get; set; }
        public string NumeroSeguro { get; set; }
        public DateTime Fecha { get; set; }
    }
}
