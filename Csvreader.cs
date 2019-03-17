using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Csvreader
{
    public class csv1
    {

        static void Main(string[] args)
        {
            var recordFile = File.ReadAllLines("C:/CSVRecord.csv");

            var List = from historyPrice in recordFile
                       let data = historyPrice.Split(',')
                       select new
                       {
                           Employee = data[0],
                           Name = data[1],
                           date = data[2],
                           designation = data[3],
                           Location = data[4]
                           
                       };

            foreach (var price in List)
            {
                Console.WriteLine(price.Employee + "|" + price.Name + "|" + price.date + "|" + price.designation + "|" + price.Location);
            }

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
        }
        static void location(List<string> List,string loc)
        {
           
            var record = List.Where(e => e.Location == loc);
            foreach (var detail in record)
            {
                Console.WriteLine(detail.Employee_ID + "|" + "|" + detail.Name + "|" + detail.DOB + "|" + detail.Designation + "|" + detail.Location);
            }
        }
        static void dateofbirth(List<string> List,DateTime date)
        {
            var dateAndTime = DateTime.Now;
            date = dateAndTime.Date;
            
            var record = List.Where(e => e.DOB <= date);
            foreach (var detail in record)
            {
                Console.WriteLine(detail.Employee_ID + "|" + "|" + detail.Name + "|" + detail.DOB + "|" + detail.Designation + "|" + detail.Location);
            }

        }
        static void Designation( List<string> List,string des)
        {
            var record = List.Where(e => e.Designation == des);
            foreach (var detail in record)
            {
                Console.WriteLine(detail.Employee_ID + "|" + "|" + detail.Name + "|" + detail.DOB + "|" + detail.Designation + "|" + detail.Location);
            }
             Console.WriteLine("Press any key to exit");
             Console.ReadLine();
        }
    }
}

