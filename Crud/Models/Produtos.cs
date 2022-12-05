using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Produtos
    {
        public int id_produto { get; set; }
        public string desc_produto { get; set; }
        public string cod_prod { get; set; }
        public DateTime dt_valid { get; set; }
        public decimal preco { get; set; }
        public decimal qtde { get; set; }
    }

    public class Alimenticios : Produtos
    {
        public decimal medida { get; set; }
        public string tipo { get; set; }
    }
}
