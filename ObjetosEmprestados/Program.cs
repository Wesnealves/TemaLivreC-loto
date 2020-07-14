using System;
using System.Collections.Generic;


namespace ObjetosEmprestados
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            bool repeatLoop = true;

            while (repeatLoop)
            {
                Console.Write("Quantas pessoas deseja cadastrar? ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    people.Add(RegisterPersonInList());
                }
                Console.WriteLine("Deseja fazer novos registros? [S/N]");
                if(Console.ReadLine().ToUpper() == "S" || Console.ReadLine().ToUpper() == "SIM")
                {
                    repeatLoop = true;
                }
                else
                {
                    repeatLoop = false;
                    ShowAllBorrowedObjects(people);
                }
                
            }
            
            
            

        }

        // Functions
        static Person RegisterPersonInList()
        {
            Person pessoa = new Person();

            Console.Write("Digite o nome da pessoa: ");
            pessoa.Name = Console.ReadLine();
            Console.Write("Digite o contato da pessoa: ");
            pessoa.Phone = Console.ReadLine();
            Console.Write("Digite o endereco da pessoa: ");
            pessoa.Adress = Console.ReadLine();

            Console.WriteLine("Deseja associar um objeto a esta pessoa? [S/N]");
            string resp = Console.ReadLine().ToUpper();

            if(resp == "S" || resp == "SIM") {pessoa.RegisterObjectInList();}
            
            return pessoa;
        }

        static void ShowAllBorrowedObjects(List<Person> people)
        {
           foreach (Person obj in people)
            {
              obj.ShowObjectsInList();
            }
           
           
        }
        

    }

   
}
