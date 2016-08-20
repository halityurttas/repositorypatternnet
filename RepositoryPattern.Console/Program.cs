using RepositoryPattern.Core.DomainObjecs;
using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                System.Console.Clear();
                System.Console.WriteLine("Select a process");
                System.Console.WriteLine("1 - List Students");
                System.Console.WriteLine("2 - Create a Student");
                System.Console.WriteLine("3 - Exit");
                string inputKey = System.Console.ReadLine();
                System.Console.Clear();
                if (inputKey == "1")
                {
                    System.Console.WriteLine("Select source");
                    System.Console.WriteLine("1 - Entity Framework");
                    System.Console.WriteLine("2 - XML Source");
                    inputKey = System.Console.ReadLine();
                    if (inputKey == "1")
                    {
                        var source = RepositoryFactory.Create<IStudentRepository>(ContextTypes.EntityFramework);
                        var items = source.GetAll();
                        foreach (var item in items)
                        {
                            System.Console.WriteLine(item.Name + " " + item.SurName + ": " + item.Classroom);
                        }
                    }
                    else if (inputKey == "2")
                    {
                        var source = RepositoryFactory.Create<IStudentRepository>(ContextTypes.XMLSource);
                        var items = source.GetAll();
                        foreach (var item in items)
                        {
                            System.Console.WriteLine(item.Name + " " + item.SurName + ": " + item.Classroom);
                        }
                    }
                    System.Console.Write("Press any key to continue...");
                    System.Console.ReadKey();
                }
                else if (inputKey == "2")
                {
                    Student student = new Student();
                    System.Console.Write("Name: ");
                    student.Name = System.Console.ReadLine();
                    System.Console.Write("SurName: ");
                    student.SurName = System.Console.ReadLine();
                    System.Console.Write("Classroom: ");
                    student.Classroom = System.Console.ReadLine();
                    System.Console.Clear();
                    System.Console.WriteLine("Select source");
                    System.Console.WriteLine("1 - Entity Framework");
                    System.Console.WriteLine("2 - XML Source");
                    inputKey = System.Console.ReadLine();
                    IStudentRepository source = null;
                    if (inputKey == "1")
                    {
                        source = RepositoryFactory.Create<IStudentRepository>(ContextTypes.EntityFramework);
                    }
                    else if (inputKey == "2")
                    {
                        source = RepositoryFactory.Create<IStudentRepository>(ContextTypes.XMLSource);
                    }
                    try
                    {
                        source.Insert(student);
                    }
                    catch (Exception ex)
                    {
                        System.Console.Write(ex);
                        System.Console.ReadKey();
                        continue;
                    }

                }
                else if (inputKey == "3")
                {
                    isRun = false;
                }
            }
        }
    }
}
