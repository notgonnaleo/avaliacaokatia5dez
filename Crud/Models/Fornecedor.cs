using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Fornecedor
    {
        public int id_fornecedor { get; set; }
        public string cnpj { get; set; }
        public string razao_social { get; set; }
        public string endereco { get; set; }
        public string nome_fantasia { get; set; }
        public string telefone { get; set; }
        public string ins_est { get; set; }
    }
}
