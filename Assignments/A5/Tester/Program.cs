using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


string choiceStr;
int choice;

List<Faculty> flist = new List<Faculty>();

do
{
    Console.WriteLine("1.  To add ");
    Console.WriteLine("2.  To Show all Faculty members");
    Console.WriteLine("3.  Serialize");
    Console.WriteLine("4.  De-Serialize");
    Console.WriteLine("10.  To Exit");
    Console.WriteLine("Enter Choice");

    choiceStr = Console.ReadLine();
    choice = int.Parse(choiceStr);
                string fileName = @"D:\IACSD PRAC\DOT_NET_hw\Assignments\A5\f.json";
   
    switch (choice)
    {
        case 1:
            Console.WriteLine("int facultyID,string fname,string lname,string subject,string ContactNumber");
            int facultyID = int.Parse(Console.ReadLine());
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            string subject = Console.ReadLine();
            string contactNumber = Console.ReadLine();
            flist.Add(new Faculty(facultyID, fname, lname, subject, contactNumber));
            Console.WriteLine("Faculty added SuccessFully");
            break;

        case 2:
            foreach (Faculty fac in flist)
            {
                Console.WriteLine(fac);
            }
            break;

        case 3:
                try
                {
                    var option = new JsonSerializerOptions {IncludeFields =  true};
                    var jsonFact = JsonSerializer.Serialize<List<Faculty>>(flist, option);
                    File.WriteAllText(fileName, jsonFact);
                }
                catch (System.Exception)
                {
                    
                    throw new Exception("Not Serialize");
                }
          
            break;
        case 4:
        try
        {
            string jsonString = File.ReadAllText(fileName);
            List<Faculty> jsonFaculty = JsonSerializer.Deserialize<List<Faculty>>(jsonString);
            Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach (Faculty f in jsonFaculty)
            {
                Console.WriteLine($"{f.FirstName} : {f.Subject}");
            }
        }
        catch (System.Exception)
        {
            
            throw new Exception("Not Deserialize");
        }
            
            break;
        case 10:
            Console.WriteLine("----------------Thank you for Using Our services-------------");
            break;

    }
} while (choice != 10);

