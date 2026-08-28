using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Animal
    {
        private int _idAnimal {  get; set; }
        public string? nomeAnimal { get; set; }
        public string? tipoAnimal { get; set; }
        public string? racaAnimal { get; set; }
        private string? _dataNascimento { get; set; }
        private string? _cpfTutor {  get; set; }

        //public Animal(int ctID, string ctNome, string ctTipo, string ctRaca, string ctData, string ctCPF)
        //{
        //    _idAnimal = ctID;
        //    nomeAnimal = ctNome;
        //    tipoAnimal = ctTipo;
        //    racaAnimal = ctRaca;
        //    _dataNascimento = ctData;
        //    _cpfTutor = ctCPF;
        //    Console.WriteLine($" Animal: {nomeAnimal}, do tutor de cpf {_cpfTutor} foi cadastrado.");
        //}

        public Animal CadastrarAnimal() 
        {
            Animal animal = new Animal();
            Console.Write("Digite o nome do animal: ");
            animal.nomeAnimal = Console.ReadLine();
            Console.Write("Digite o tipo do animal: ");
            animal.tipoAnimal = Console.ReadLine();
            Console.Write("Digite a raça do animal: ");
            animal.racaAnimal = Console.ReadLine();
            Console.Write("Digite a data de nascimento do animal: ");
            animal._dataNascimento = Console.ReadLine();
            Console.Write("Digite o cpf do tutor: ");
            animal._cpfTutor = Console.ReadLine();
            return animal;
        }
    }
}
