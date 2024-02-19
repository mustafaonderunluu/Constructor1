using System;


namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 2,
                FirstName = "Önder",
                LastName = "Ünlü",
                Sehir = "İstanbul"
            };


            Customer customer2 = new Customer(id:15,firstname:"Cemil",lastname:"Kına",sehir:"Mersin" );




            Console.WriteLine(customer2.Firstname);
            Console.WriteLine(customer.FirstName);

   Console.ReadKey();


            
        }

    }


    class Customer
    {

        public Customer()
        {




        }
        //default constroctor (bu blok arka planda herzaman çalışır)
        public Customer(int id, string firstname, string lastname, string sehir)
        {
           

            

            İd = id;
            Firstname = firstname;
            Lastname = lastname;
            Sehir = sehir;
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sehir { get; set; }
        public int İd { get; }
        public string Firstname { get; }
        public string Lastname { get; }

    }

}
