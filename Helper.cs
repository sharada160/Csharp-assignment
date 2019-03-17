using System;
using System.IO;
using System.Text;

namespace Helper
{
    class CsvHelper
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the choice" +
                "1.loc" + "2.DOB" + "3.designation");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("enter the location name");
                    var loc= Console.ReadLine();
                    location(List,loc);
                    break;
                case 2:
                    Console.WriteLine("enter the Dob");
                    //var date = DateTime.Now.ToString("dd/MM/yyyy");
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    dateofbirth(List,dob);
                    break;
                case 3:
                    Console.WriteLine("enter designation");
                    var des = Console.ReadLine();
                    Designation(List, des);
                    break;

            }
            
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
         }
      }
  }
