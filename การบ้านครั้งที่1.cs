using System;

namespace ConsoleApp32
{
    class UserN
    {
        public string firstName;
        public string lastName;
        public string email;
        public string street;
        public string city;
        public string zipCode;

        public UserN(string firstName, string lastName, string email, string street, string city, string zipCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
        }
        public string Name
        {
            get
            {
                return firstName + " " + lastName + email;
            }
        }
        public string Addess
        {
            get
            {
                return " Addess 131/75," + street + city + " zipCode" + zipCode;
            }
        }
    }
    class T_shirt
    {
        public string size;
        public string color;
        public string image;

        public T_shirt(string size, string color)
        {
            this.size = size;
            this.color = color;
        }
        class Size
        {
            public float price;
        }
        class Program
        {
            static void Main(string[] args)
            {
                UserN user = new UserN("jame", "watson", " jame@gmail.com", " Phutthamonthon Road", " Nakhon Pathom Province", " 10180");
                Console.Write(user.Name);
                Console.WriteLine(user.Addess);
                Console.WriteLine("ShoppingCart");
                Size L = new Size();
                L.price = 500f;

                Size M = new Size();
                M.price = 750f;

                Size S = new Size();
                S.price = 625f;

                Console.WriteLine("size L Red" + " " + L.price + " Bath");
                Console.WriteLine("size M Black" + " " + M.price + " Bath");
                Console.WriteLine("size S Yellow" + " " + S.price + " Bath");
                Console.WriteLine("Total cost = {0} Bath", L.price + M.price + S.price);
            }
        }
    }
} 

