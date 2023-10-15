using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace explorando_exemplo.Models
{
    public class Venda
    {
        public Venda()
        {

        }
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }
        public int Id { get; set; } //nome das propridades têm que ser o mesmo dos atributos no arquivo Json
        [JsonProperty("Nome_Produto")] // atributos em Json, caso o nome da propriedade no arquivo json esteja diferente da convenção do C#
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

    }
}