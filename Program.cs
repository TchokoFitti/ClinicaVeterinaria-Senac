namespace ClinicaVeterinaria
{
    public class Program
    {
        public static void Main()
        {

            string[] animal = new string[6];
            string[] tutor = new string[4];

            Animal novoAnimal = new Animal();
            Tutor novoTutor = new Tutor();

            List<Animal> ListaAnimal = new List<Animal>();
            List<Tutor> ListaTutor = new List<Tutor>();

            Console.WriteLine("===== Clínica Veterinária =====");
            Console.WriteLine("_-_-_-_Menu Principal_-_-_-_");
            Console.WriteLine("1 - Cadastrar Animal");
            Console.WriteLine("2 - Cadastrar Tutor");
            Console.WriteLine("Digite a opção desejada: ");
            int opcaoMenu = int.Parse(Console.ReadLine()!);

            switch (opcaoMenu)
            {
                case 1: 
                    novoAnimal=novoAnimal.CadastrarAnimal();
                    ListaAnimal.Add(novoAnimal);
                    break;
                case 2:
                    novoTutor=novoTutor.CadastrarTutor();
                    ListaTutor.Add(novoTutor);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            
            }
            
        }
    }
}
