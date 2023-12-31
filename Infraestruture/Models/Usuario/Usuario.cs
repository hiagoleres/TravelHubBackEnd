﻿using TravelHub.Models.VOs;

namespace TravelHub.Models.Usuario
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Role { get; set; }
    }
}
