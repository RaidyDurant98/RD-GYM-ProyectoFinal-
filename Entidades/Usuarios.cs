﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
        public string Cargo { get; set; }

        public Usuarios()
        {

        }

        public Usuarios(int usuarioId, string nombres, string nombreUsuario, string clave, string confirmarClave, string cargo)
        {
            this.UsuarioId = usuarioId;
            this.Nombres = nombres;
            this.NombreUsuario = nombreUsuario;
            this.Clave = clave;
            this.ConfirmarClave = confirmarClave;
            this.Cargo = cargo;
        }
    }
}
