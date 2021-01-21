using System;

namespace ecommerce.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public int QtdEstoque { get; set; }
        public decimal Valor { get; set; }
    }
}