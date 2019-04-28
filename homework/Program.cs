using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        public static string I { get; private set; }

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Client cl = new Client();
            Product pro = new Product();
            Order ord = new Order();




            string reserve = "I";
            string reserve2 = "M";
            string reserve3 = "P";
            string reserve4 = "O";
            String Choosen;
            int oportunity = 30;
            
                Console.WriteLine("Secim edin: I - ishci yaratmaq M - mushteri yaratmaq P - mehsul yaratmaq" +
                    " O - sifarish yaratmaq");

            do
            { 
                Choosen = Console.ReadLine();
         
                if (Choosen == reserve || Choosen == reserve2 || Choosen == reserve3 || Choosen == reserve4)
                {
                 
                    switch (Choosen)
                    {
                        case "I":
                            Console.WriteLine("Isci adini daxil edin");
                            emp.Name=Console.ReadLine();
                            Console.WriteLine("Isci soyadini daxil edin");
                            emp.Surname=Console.ReadLine();
                            Console.WriteLine("Iscinin yasini daxil edin");
                            emp.Yas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Iscinin vezifesini secin");
                            emp.Position=Console.ReadLine();
                            Console.WriteLine("Iscinin maasini daxil edin");
                            emp.Salary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Secdiyiniz isci: {emp.Name} {emp.Surname}." +
                                $" {emp.Yas} yasinda vesifesi: {emp.Position} maasi:{emp.Salary} manat");
                            Console.WriteLine("Secim edin: M - mushteri yaratmaq P - mehsul yaratmaq" +
                       " O - sifarish yaratmaq"); break;
                        case "M":
                            Console.WriteLine("Musteri adini daxil edin");
                            cl.Name_Client = Console.ReadLine();
                            Console.WriteLine("Musteri soyadini daxil edin");
                            cl.Surname_Client = Console.ReadLine();
                            Console.WriteLine("Musterinin yasini daxil edin");
                            cl.Age_Client = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Musterinin unvanini daxil edin");
                            cl.Address = Console.ReadLine();
                            Console.WriteLine("Musterinin elaqe nomresini daxil edin");
                            cl.Phone = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Secdiyiniz musteri: {cl.Name_Client} {cl.Surname_Client}." +
                                $" { cl.Age_Client} yasinda unvani: {cl.Address} elaqe nomresi: +994{cl.Phone}");
                            Console.WriteLine("Secim edin: P - mehsul yaratmaq" +
                  " O - sifarish yaratmaq");
                            break;
                        case "P":
                            Console.WriteLine("Mehsulun adini daxil edin");
                            pro.Name_product = Console.ReadLine();
                            Console.WriteLine("Mehsulun rengini secin");
                            pro.Color = Console.ReadLine();
                            Console.WriteLine("Mehsulun qiymetini daxil edin");
                            pro.Price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Secdiyiniz mehsul: {pro.Name_product} rengi: {pro.Color} qiymeti:{pro.Price} AZN");
                            Console.WriteLine("Secim edin: O - sifarish yaratmaq");
                            break;
                        case "O":
                            Console.WriteLine("Sifaris veren musterinin adini daxil edin");
                            cl.Name_Client = Console.ReadLine();
                            ord.Client_Order = cl;
                            Console.WriteLine("Sifaris olunan mehsulun adini daxil edin");
                            pro.Name_product = Console.ReadLine();
                            ord.Product_Order = pro;
                            Console.WriteLine("Sifarisin olunan mehsulun sayini daxil edin");
                            ord.Count = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Sifaris veren musteri: {ord.Client_Order.Name_Client} sifaris olunan mehsul: " +
                            $"{ord.Product_Order.Name_product} sayi:{ord.Count} eded");
                            break;
                        default:
                            Console.WriteLine("Yalnis secim etdiniz");
                            break;
                    }
                }
                else
                {
                    oportunity--;
                    Console.WriteLine("yalnis secim etdiniz");
                    if (oportunity == 0)
                    {
                        Console.WriteLine("Your service blocked");
                    }
                }


            } while (Choosen != reserve || Choosen != reserve2 || Choosen != reserve3 || Choosen != reserve4);
            Console.ReadLine();
        }
    }
}
