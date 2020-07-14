using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetosEmprestados
{
    class BorrowedObject
    {
        public string objectName { get; set; }
        public DateTime borrowedObjectDate { get; set; }
        public DateTime returnDate { get; set; }
        public string borrowedPerson { get; set; }

        public BorrowedObject()
        {

        }

        public BorrowedObject(string objectName, DateTime borrowedObjectDate, DateTime returnDate, string borrowedPerson)
        {
            this.objectName = objectName;
            this.borrowedObjectDate = borrowedObjectDate;
            this.returnDate = returnDate;
            this.borrowedPerson = borrowedPerson;
        }
    }
}
