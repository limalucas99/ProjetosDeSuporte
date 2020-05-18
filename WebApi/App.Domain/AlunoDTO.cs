﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Domain
{
    
    public class AlunoDTO
    {
        
        public int id { get; set; }

        [Required(ErrorMessage = "O nome é de Preenchimento Obrigatório")]
        [StringLength(50, ErrorMessage = "Nome tem no mínimo 2 caracteres e no máximo 50", MinimumLength = 2)]
        public string nome { get; set; }

        public string sobrenome { get; set; }

        public string telefone { get; set; }

        [Required(ErrorMessage = "O RA é de Preenchimento Obrigatório")]
        [Range(1,9999, ErrorMessage = "O intervalo para cadastro de  RA deve ser entre 1 e 9999")]
        public int? ra { get; set; }

        [RegularExpression(@"[0-9]{4}\-[0-9]{2}",ErrorMessage = "A data está fora do formato YYYY-MM")]
        public string data { get; set; }
    }
}