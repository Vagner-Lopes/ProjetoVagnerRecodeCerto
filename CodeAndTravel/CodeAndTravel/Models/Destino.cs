using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAndTravel.Models
{
    public class Destino
    {
        [Key]
        public int ID { get; set; }


        /*Nome Do Destino*/
        [Required(ErrorMessage = "Digite o Nome do Destino", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Destino")]
        public string Nome { get; set; }


        /*Estado De Origem*/
        [Required(ErrorMessage = "Selecione o Estado de Origem", AllowEmptyStrings = false)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }


        /*Cidade De Origem*/
        [Required(ErrorMessage = "Informe a Cidade de Origem", AllowEmptyStrings = false)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }


        /*Descrição Do Destino*/
        [Required(ErrorMessage = "Descrição entre 10 e 60 caractéres", AllowEmptyStrings = false)]
        [Display(Name = "Descrição")]
        [StringLength(100, MinimumLength = 10)]
        public string Descricao { get; set; }


        /*URL para as Imagens Dos Card*/
        [Required(ErrorMessage = "Informe uma URL para a Imagem", AllowEmptyStrings = false)]
        [Display(Name = "URL da Imagem")]
        public string ImgURL { get; set; }

        /*Valor*/
        [Required(ErrorMessage = "Informe o Valor do Destino", AllowEmptyStrings = false)]
        [Display(Name = "Valor")]
        public double Valor { get; set; }


    }

}
