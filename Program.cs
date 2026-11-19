using System;

namespace OOP_HT4
{
    class Program
    {
        static void Main()
        {
            T1Student.RunTask1();

            Console.WriteLine("Task2: EMPLOYEE, DEVELOPER VA DESIGNER");

            Employee emp = new Employee("Ali", "IT");
            emp.ShowInfo();

            Developer dev = new Developer("Vali", "IT", "C#");
            dev.ShowInfo();

            Console.WriteLine("Task3: Device and Phone");
            var phone = new Phone("Pixel");
            phone.ShowModel();
            phone.ShowPhoneModel();

            Console.WriteLine("Task4: CINEMA SHOW ");
            
            var email = new EmailNotification("Yangi dars", "a@b.uz");

            Console.WriteLine(email.Title);        
            Console.WriteLine(email.EmailAddress);   

            var lift = new EmailNotification("B1", 3);          // nom, 3 qavat
            var show = new CinemaShow("Adventure", 4);
            Console.WriteLine(lift.Call(2));         
            Console.WriteLine(lift.Call(4)); 
            Console.WriteLine(show.Reserve(1));         // True
            Console.WriteLine(show.Reserve(3));         // True
            Console.WriteLine(show.Reserve(3));         // False
            Console.WriteLine(show.Reserve(5));         // False
            Console.WriteLine(show.Cancel(1));          // True
            Console.WriteLine(show.Cancel(2));          // False
            Console.WriteLine(show.GetAvailableSeats());      

            bool[] nusxa = lift.GetFloors();        
            nusxa[0] = true;                 
            Console.WriteLine(lift.GetFloors()[0]);
        }
    }

    internal class CinemaShow
    {
        private string v1;
        private int v2;

        public CinemaShow(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal bool Cancel(int v)
        {
            throw new NotImplementedException();
        }

        internal bool GetAvailableSeats()
        {
            throw new NotImplementedException();
        }

        internal bool Reserve(int v)
        {
            throw new NotImplementedException();
        }
    }

    internal class EmailNotification
    {
        private string v1;
        private int v2;
        private string v;

        public EmailNotification(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public EmailNotification(string v1, string v)
        {
            this.v1 = v1;
            this.v = v;
        }

        public bool Title { get; internal set; }
        public bool EmailAddress { get; internal set; }

        internal bool Call(int v)
        {
            throw new NotImplementedException();
        }

        internal bool[] GetFloors()
        {
            throw new NotImplementedException();
        }
    }
}



