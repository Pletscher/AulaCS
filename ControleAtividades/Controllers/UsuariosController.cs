using Controllers.DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class UsuariosController
    {
        //List<Atividade> minhasAtividades = new List<Atividade>();

        private Contexto contexto = new Contexto();
        private object minhasAtividades;

        //Adicionar
        public void Adicionar(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
        }

        //Listar todos
        public IList<Usuario> ListarTodos()
        {
            return contexto.Usuarios.ToList();
        }   
          
        //Listar por nome

            public IList<Usuario>ListarPorNome(string nome)
        {
            //LINQ
            //var usuariosComNome = from usu in contexto.Usuarios
            //                     where usu.Nome == nome
            //                      select usu;

            //LAMBDA
            return contexto.Usuarios.Where(usu => usu.Nome == nome).ToList();
        }
       

        //Buscar por ID
        public Usuario BuscarPorID(int id)
        {
            
            return contexto.Usuarios.Find(id);
        }
       

        //Editar
        public void Editar(Usuario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
               
        }

        //Excluir
        public void Excluir(int id)
        {
            Usuario usu = BuscarPorID(id);

            if(usu !=null)
            {
                //primeira maneira de fazer
                //contexto.Entry(usu).State = System.Data.Entity.EntityState.Deleted;

                // segunda maneira de fazer
                contexto.Usuarios.Remove(usu);

                contexto.SaveChanges();

            }
        }


}
}
