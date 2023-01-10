using LojaEFCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaEFCore.Domain
{
    class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public StatusPedido Status { get; set; }
        public string Observacao { get; set; }
        public ICollection<PedidoItem> Itens { get; set; }
    }
}
