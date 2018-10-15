using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fp_stack.api.Entidades
{
    public class Forum
    {
        public int Id { get; set; }

        public int IdSolicitante { get; set; }

        public int IdGrupo { get; set; }

        public int IdAssunto { get; set; }

        public int IdPergunta { get; set; }

        public int IdResposta { get; set; }
        public DateTime DataCriacao { get; set; }
        
        public int Ativo { get; set; }

        public int Resolvido { get; set; }

        public int IdSolucionador { get; set; }

        public DateTime DataSolucao { get; set; }
    }
}
