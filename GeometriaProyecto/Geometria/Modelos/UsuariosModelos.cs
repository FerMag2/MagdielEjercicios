using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biseccion.Modelos
{
    public class UsuariosModelos
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Escuela { get; set; }

        public string Pasword { get; set; }
        public string Correo { get; set; }
    }
}
