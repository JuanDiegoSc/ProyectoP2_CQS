﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoResenas.Models
{

    public class Juego
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre del Juego")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string? Descripcion { get; set; }


        [Display(Name = "Fecha creacion")]

        public string? FechaCreacion { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string? UrlImagen { get; set; }

        [Required(ErrorMessage = "La categoria es obligatoria")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }

        //public Resena? Resena { get; set; }

    }
}
