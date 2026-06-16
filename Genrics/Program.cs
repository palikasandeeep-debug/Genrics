using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics
{

    //class Employee2
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }
    //}
    internal class Program
    {

        //class genric
        //{

        //    internal void displaystudent<t>(t a)
        //    {
        //        Console.WriteLine("student details are"+a);
        //    }










        //internal void display<p>(p a)
        //{
        //    Console.WriteLine("a values is"+a);
        //}
        //internal void cal<p>(p b,p c)
        //{
        //    Console.WriteLine("b values is" + b);
        //    Console.WriteLine("c vlue is"+c);
        //}
        //internal void dtypes<p,s>(p b, s c)
        //{
        //    Console.WriteLine("b values is" + b);
        //    Console.WriteLine("c vlue is" + c);
        //}

        //}
        //static void Main(string[] args)
        //{


        //
        // List<Employee2> employees = new List<Employee2>()
        //{
        //    new Employee2 { Id = 1, Name = "Ram", Salary = 25000 },
        //    new Employee2 { Id = 2, Name = "Ravi", Salary = 35000 },
        //    new Employee2 { Id = 3, Name = "Sita", Salary = 45000 },
        //    new Employee2 { Id = 4, Name = "John", Salary = 20000 },
        //    new  Employee2{Id=5,Name="sandy,",Salary=60000}
        //};

        //    var result = employees.Where(e => e.Salary > 30000);

        //    foreach (var emp in result)
        //    {
        //        Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Salary);
        //    }


        //==========================================================================================================









        //int[] number = {1,2,3,4,5};
        //var evn = from n in number
        //          where n % 2 == 0
        //          select n;
        //foreach( var n in evn )
        //{
        //    Console.WriteLine(n);
        //}





        //================================================================================





        //genric g = new genric();
        //g.display<int>(100);
        //g.display<string>("sandy");
        //g.cal<string>("palika","sandy");
        //g.cal<double>(0.3, 0.5);
        //g.dtypes<int, string>(100, "chary");
        //g.dtypes<string, int>("sandy", 123);
        //    g.displaystudent<int>(123);
        //    g.displaystudent<string>("sandy");
        //}
        //}

        //==========================================================================================================================================

        //static void Main(string[] args)
        //{


        //    Stack st = new Stack();
        //    st.Push("first");
        //    st.Push("second");
        //    st.Push("third");
        //    st.Push("fourth");
        //    st.Push("fifth");
        //    Console.WriteLine("elements are");
        //    foreach (var item in st)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    Console.WriteLine("pop elements is{0}" + st.Pop());
        //    foreach (var item in st)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    Console.WriteLine("peek elements is{0}" + st.Peek());
        //    foreach (var item in st)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    Console.WriteLine("pop elements is{0}" + st.Count);
        //    st.Clear();
        //    Console.WriteLine("pop elements is{0}" + st.Count);


        //}

        //===============================================================================================
        //   QUEUE EXAMPLE


        //static void Main(string[] args)
        //{
        //    Queue quee = new Queue();
        //    quee.Enqueue("document1");
        //    quee.Enqueue("document2");
        //    quee.Enqueue("document3");
        //    Console.WriteLine("elements in Quee");
        //    foreach (var item in quee)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    Console.WriteLine("printed document is :" + quee.Dequeue());
        //    Console.WriteLine("\n waiting documents");

        //    foreach (var item in quee)
        //    {
        //        Console.WriteLine(item);

        //    }

        //    Console.WriteLine(" next document is :" + quee.Peek());
        //    Console.WriteLine("total documents are waiting :" + quee.Count);


        //}




         //=================================================================================================================
         //ArayyLIst Example
        static void Main()
        {
            ArrayList patients = new ArrayList();
            Console.WriteLine("enter number of patients");
            int p=int.Parse(Console.ReadLine());
            for (int i = 0; i <= p; i++)
            {
                Console.WriteLine("enter patient nameas");
                patients.Add(Console.ReadLine());

            }
            //// Add patients
            //patients.Insert(0, "abc");
            //patients.Add("Ravi");
            //patients.Add("Kiran");
            //patients.Add("Suresh");

            Console.WriteLine("After Add:");
            foreach (var pt in patients)
            {
                Console.WriteLine(pt);
            }
    
            // Insert patient indx
            Console.WriteLine("enter position to insert");
            int pos=int.Parse(Console.ReadLine());
            Console.WriteLine("enter patient name");
            string pname=Console.ReadLine();
            patients.Insert(pos, pname  );

            Console.WriteLine("\nAfter Insert:");
            foreach (var pt in patients)
            {
                Console.WriteLine(pt);
            }
        
            // Check patient exists
            Console.WriteLine("enter patient name to check exists or not");
            string patientexit=Console.ReadLine();
            Console.WriteLine("\nContains Ravi? " + patients.Contains(patientexit));

            // Remove patient by value
            Console.WriteLine("enter patient name to remove");
            string removename=Console.ReadLine();
            patients.Remove(removename);

            Console.WriteLine("\nAfter Remove:");
            foreach (var pt in patients)
            {
                Console.WriteLine(pt);
            }

            // Remove patient by index
            Console.WriteLine("enter position to removeat");
            int rpos=int.Parse(Console.ReadLine());
            patients.RemoveAt(rpos);

            Console.WriteLine("\nAfter RemoveAt:");
            foreach (var pt in patients)
            {
                Console.WriteLine(pt);
            }

            // Count patients
            Console.WriteLine("\nTotal Patients: " + patients.Count);

            // Access by index
            Console.WriteLine("enter index number  ");
            int index=int.Parse(Console.ReadLine());
            Console.WriteLine("  Patient: " + patients[index]);


            // Clear all patients
            //patients.Clear();

            //Console.WriteLine("\nAfter Clear:");
            //Console.WriteLine("Total Patients: " + patients.Count);

            // Clear
            Console.Write("\nDo You Want to Clear All Records? (yes/no): ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "yes")
            {
                patients.Clear();
                Console.WriteLine("All Records Cleared");
                Console.WriteLine("Total Patients: " + patients.Count);
            }
        }
    }

    

}

