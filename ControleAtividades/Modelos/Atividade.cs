using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public int Descricao { get; set; }

        public string CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario _Usuario { get; set; }

    }

    

    
}
