using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetosEmprestados
{
    class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public List<BorrowedObject> myObjects = new List<BorrowedObject>();

        public Person()
        {

        }

        public Person(string name, string phone, string adress)
        {
            Name = name;
            Phone = phone;
            Adress = adress;
        }


        public void RegisterObjectInList()
        {
            BorrowedObject objeto = new BorrowedObject();

            Console.Write("Digite o nome do objeto: ");
            objeto.objectName = Console.ReadLine();
            Console.WriteLine("Digite a data que o objeto foi emprestado: [ANO-MES-DIA]");
            objeto.borrowedObjectDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite a pessoa que voce emprestou esse objeto: ");
            objeto.borrowedPerson = Console.ReadLine();
            myObjects.Add(objeto);
            
        }

        public void ShowObjectsInList()
        {
            foreach(BorrowedObject obj in myObjects)
            {
                Console.WriteLine("Nome do objeto:" + obj.objectName);
                Console.WriteLine("Data de emprestimo: " + obj.borrowedObjectDate);
                Console.WriteLine("Emprestado para: " + obj.borrowedPerson);
            }
        }
    }

   




}
