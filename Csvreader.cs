using System;
using System.Collections.Generic;
using System.IO;
using System Text;
using System.Linq;
namespace Csvreader
{
    public class csvclass
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
        }
           
        static void location(string List,string loc)
        {
           
            var record = List.Where(e => e.Location == loc);
            foreach (var loca in record)
            {
                Console.WriteLine(loca.Employee_ID + "|" + "|" + loca.Name + "|" + loca.DOB + "|" + loca.Designation + "|" + loca.Location);
            }
        }
        static void dateofbirth(string List,DateTime date)
        {
            var dateAndTime = DateTime.Now;
            date = dateAndTime.Date;
            
            var record = List.Where(e => e.DOB <= date);
            foreach (var birthdate in record)
            {
                Console.WriteLine(birthdate.Employee_ID + "|" + "|" + birthdate.Name + "|" + birthdate.DOB + "|" + birthdate.Designation + "|" + birthdate.Location);
            }

        }
        static void Designation( string List,string des)
        {
            var record = List.Where(e => e.Designation == des);
            foreach (var desig in record)
            {
                Console.WriteLine(desig.Employee_ID + "|" + "|" + desig.Name + "|" + desig.DOB + "|" + desig.Designation + "|" + desig.Location);
            }
        }
    }
}

