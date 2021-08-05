using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Caminhoes.Models
{
    [Table("Caminhoes")]
    public class Caminhao
    {
        public Caminhao()
        {
            Id = this.Id;
            Nome = this.Nome;
            Descricao = this.Descricao;
            DtCriacao = this.DtCriacao;
        }
                
        //Construtor de edição
        public Caminhao(Caminhao caminhao)
        {
            Id = caminhao.Id;
            Nome = caminhao.Nome;
            Descricao = caminhao.Descricao;
            DtCriacao = caminhao.DtCriacao;
        }

        //Construtor parametrizado
        public Caminhao(int id, string nome, string descrição, DateTime dtCriacao)
        {
            Id = id;
            Nome = nome;
            Descricao = descrição;
            DtCriacao = dtCriacao;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo data de criação é obrigatório.")]
        public DateTime? DtCriacao { get; set; }
    }
}
