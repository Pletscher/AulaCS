﻿namespace Modelos
{
    public class Usuario
    {
        
        public int UsuarioID { get; set; }
        /*[Required]*/
        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}