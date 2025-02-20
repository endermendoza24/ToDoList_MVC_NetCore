﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ListaToDo.Models
{
    public class ToDoListItem
    {
        public int Id { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El título es obligatorio ")]

        [StringLength(200, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 2)]

        [Display(Name = "Titulo")]
        public string Titulo { get; set; }


        public int Prioridad { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha vencimiento")]

        public DateTime Fecha { get; set; } = System.DateTime.Today;

        public bool Completada { get; set; }
        public int IdCategoria { get; set; }
    }
}