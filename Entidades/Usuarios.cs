﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nombres { get; set; }
        public string Contraseña { get; set; }
        public bool Nivel { get; set; }
        public string PreguntaSeguridad { get; set; }
        public string RespuestaSeguridad { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(int usuarioID, string nombres, string contraseña, bool nivel, string preguntaSeguridad, string respuestaSeguridad) : this(usuarioID, nombres, contraseña, nivel)
        {
            PreguntaSeguridad = preguntaSeguridad ?? throw new ArgumentNullException(nameof(preguntaSeguridad));
            RespuestaSeguridad = respuestaSeguridad ?? throw new ArgumentNullException(nameof(respuestaSeguridad));
        }

        public Usuarios(int usuarioID, string nombres, string contraseña, bool nivel)
        {
            UsuarioID = usuarioID;
            Nombres = nombres ?? throw new ArgumentNullException(nameof(nombres));
            Contraseña = contraseña ?? throw new ArgumentNullException(nameof(contraseña));
            Nivel = nivel;
        }
    }
}