using System;
using System.Collections.Generic;
using System.Text;

namespace LojaEFCore.Domain
{
    class PedidoItem
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int  Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
    }
}
