using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Tutor : Pessoa
    {
        public string? cpf { get; set; }

        //public Tutor(string ctCpf, string ctNome, string ctTelefone, string ctEmail): base(ctNome, ctTelefone, ctEmail)
        //{
        //    nome = ctNome;
        //    telefone = ctTelefone;
        //    email = ctEmail;
        //    cpf = ctCpf;
        //}

        public Tutor CadastrarTutor()
        {
            Tutor tutor = new Tutor();
            Console.Write("Digite o nome do tutor: ");
            tutor.nome = Console.ReadLine();
            Console.Write("Digite o telefone do tutor: ");
            tutor.telefone = Console.ReadLine();
            Console.Write("Digite o email do tutor: ");
            tutor.email = Console.ReadLine();
            Console.Write("Digite o cpf do tutor: ");
            tutor.cpf = Console.ReadLine();
            return tutor;
        }

    }
}
