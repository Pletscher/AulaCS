﻿using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto(): base("strConn")
        {

        }
        public DbSet<Atividade> Atividades { get; set; }

        public DbSet<Categoria> Categorias {get; set;}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
