using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAndTravel.Models
{
    public class Promocao
    {
        [Key]
        public int ID { get; set; }

        /*Nome Da Promoção*/
        [Required(ErrorMessage = "Digite o Nome da Promoção", AllowEmptyStrings = false)]
        [Display(Name = "Nome da Promoção")]
        public string Nome { get; set; }


        /*Nome Do Destino*/
        [Required(ErrorMessage = "Selecione um Destino", AllowEmptyStrings = false)]
        [Display(Name = "Destino")]
        public int DestinoID { get; set; }
        [ForeignKey("DestinoID")]
        public virtual Destino Destino { get; set; }

        /*Descrição Curta*/
        [Required(ErrorMessage = "Descrição com no máximo 20 caractéres", AllowEmptyStrings = false)]
        [Display(Name = "Descrição Curta")]
        [StringLength(100, MinimumLength = 5)]
        public string Descricao { get; set; }

        /*Nome Do Destino*/
        [Required(ErrorMessage = "Desconto entre 5 e 60%", AllowEmptyStrings = false)]
        [Range(5, 60, ErrorMessage = "Permitido desconto entre 5 e 60%")]
        [Display(Name = "Desconto%")]
        public double Desconto { get; set; }
    }

}
