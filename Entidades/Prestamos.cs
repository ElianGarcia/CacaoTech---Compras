﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacaoTech.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoID { get; set; }
        public DateTime Fecha { get; set; } 
        public int ProductorID { get; set; }
        [ForeignKey("ProductorID")]
        public virtual Productores Productor { get; set; }
        public int Tiempo { get; set; }
        public decimal Monto { get; set; }
        public decimal Balance { get; set; }
        public decimal Interes { get; set; }
        public decimal Total { get; set; }
        public int UsuarioID { get; set; }
        [ForeignKey("UsuarioID")]
        public virtual Usuarios Usuarios { get; set; }

        public Prestamos(int prestamoID, DateTime fecha, int productorID, Productores productor, int tiempo, decimal monto, decimal balance, decimal interes, decimal total, int usuarioID, Usuarios usuarios)
        {
            PrestamoID = prestamoID;
            Fecha = fecha;
            ProductorID = productorID;
            Productor = productor ?? throw new ArgumentNullException(nameof(productor));
            Tiempo = tiempo;
            Monto = monto;
            Balance = balance;
            Interes = interes;
            Total = total;
            UsuarioID = usuarioID;
            Usuarios = usuarios ?? throw new ArgumentNullException(nameof(usuarios));
        }

        public Prestamos(int prestamoID, DateTime fecha, int productorID, int tiempo, decimal monto, decimal balance, decimal interes, decimal total, int usuarioID)
        {
            PrestamoID = prestamoID;
            Fecha = fecha;
            ProductorID = productorID;
            Tiempo = tiempo;
            Monto = monto;
            Balance = balance;
            Interes = interes;
            Total = total;
            UsuarioID = usuarioID;
        }


        public Prestamos()
        {

        }
    }
}