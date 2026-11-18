using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProductos_Practica_Examen.Models
{
    public sealed class UsuarioSesion
    {
        public int IdUsuario { get; init; }
        public string NombreUsuario { get; init; }= string.Empty;
    }
}
