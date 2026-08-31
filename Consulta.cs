using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria
{
	public class Consulta
	{
		public int idConsulta {  get; private set; }
		public string? dataConsulta { get; set; }
		public string? horaConsulta { get; set; }
		public string? triagem {  get; set; }
		public string? situacao { get; set; }

		public Animal animal = new Animal();
		public Tutor tutor = new Tutor();
		public Veterinario veterinario = new Veterinario();

		public void AgendarConsulta(List<Animal> ListaAnimal)
		{
            bool animalExiste = false;

                Console.WriteLine("Digite o id do animal");
                animal.IdAnimal = int.parse(console.ReadLine());
                foreach (Animal animalCadastrado in ListaAnimal)
                {
                    if (animal.IdAnimal == animalCadastrado.IdAnimal)
                    {
                        animalExiste = true;
                        return animalCadastrado
                    }   
                }
            
                if (animalExiste == False)
                { 
                    Console.WriteLine("Animal não cadastrado!")
                }
        }
	}
}