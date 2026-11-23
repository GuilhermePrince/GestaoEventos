using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoEventos.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do evento é obrigatório!")]
        [StringLength(80, MinimumLength =5, ErrorMessage = "O nome deve conter entre 5 e 80 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição é obrigatória!")]
        [StringLength(800, MinimumLength = 10, ErrorMessage = "A descrição deve conter no mínimo 10 caracteres!")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Local do evento é obrigatório!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve conter entre 3 e 100 caracteres.")]
        public string Local { get; set; } = string.Empty;

        public DateTime DataEvento { get; set; }

        [Range(1, 1000, ErrorMessage = "Deve haver entre 1 e 1000 vagas no evento!")]
        public int QuantidadeVagas { get; set; }
        public decimal ValorIngresso { get; set; }
    }
}