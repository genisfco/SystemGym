using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GenesysGym
{
    public class Cliente
    {
        public int codcliente;
        public string nomecliente;
        public string cpf;
        public string rg;
        public string sexo;
        // CAMPOS COM DATA
        public string logradouro;
        public int numLogradouro;
        public string bairro;
        public string cidade;
        public string estado;
        public string cep;
        public string telefone;
        public string email;
    }
}
