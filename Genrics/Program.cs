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
        //static void Main()
        //{
        //    ArrayList patients = new ArrayList();
        //    Console.WriteLine("enter number of patients");
        //    int p=int.Parse(Console.ReadLine());
        //    for (int i = 0; i <= p; i++)
        //    {
        //        Console.WriteLine("enter patient nameas");
        //        patients.Add(Console.ReadLine());

        //    }
        //    //// Add patients
        //    //patients.Insert(0, "abc");
        //    //patients.Add("Ravi");
        //    //patients.Add("Kiran");
        //    //patients.Add("Suresh");

        //    Console.WriteLine("After Add:");
        //    foreach (var pt in patients)
        //    {
        //        Console.WriteLine(pt);
        //    }

        //    // Insert patient indx
        //    Console.WriteLine("enter position to insert");
        //    int pos=int.Parse(Console.ReadLine());
        //    Console.WriteLine("enter patient name");
        //    string pname=Console.ReadLine();
        //    patients.Insert(pos, pname  );

        //    Console.WriteLine("\nAfter Insert:");
        //    foreach (var pt in patients)
        //    {
        //        Console.WriteLine(pt);
        //    }

        //    // Check patient exists
        //    Console.WriteLine("enter patient name to check exists or not");
        //    string patientexit=Console.ReadLine();
        //    Console.WriteLine("\nContains Ravi? " + patients.Contains(patientexit));

        //    // Remove patient by value
        //    Console.WriteLine("enter patient name to remove");
        //    string removename=Console.ReadLine();
        //    patients.Remove(removename);

        //    Console.WriteLine("\nAfter Remove:");
        //    foreach (var pt in patients)
        //    {
        //        Console.WriteLine(pt);
        //    }

        //    // Remove patient by index
        //    Console.WriteLine("enter position to removeat");
        //    int rpos=int.Parse(Console.ReadLine());
        //    patients.RemoveAt(rpos);

        //    Console.WriteLine("\nAfter RemoveAt:");
        //    foreach (var pt in patients)
        //    {
        //        Console.WriteLine(pt);
        //    }

        //    // Count patients
        //    Console.WriteLine("\nTotal Patients: " + patients.Count);

        //    // Access by index
        //    Console.WriteLine("enter index number  ");
        //    int index=int.Parse(Console.ReadLine());
        //    Console.WriteLine("  Patient: " + patients[index]);


        //    // Clear all patients
        //    //patients.Clear();

        //    //Console.WriteLine("\nAfter Clear:");
        //    //Console.WriteLine("Total Patients: " + patients.Count);

        //    // Clear
        //    Console.Write("\nDo You Want to Clear All Records? (yes/no): ");
        //    string choice = Console.ReadLine();

        //    if (choice.ToLower() == "yes")
        //    {
        //        patients.Clear();
        //        Console.WriteLine("All Records Cleared");
        //        Console.WriteLine("Total Patients: " + patients.Count);
        //    }
        //}









        ///=======================================================================================
        //Hashtable

        //static void Main(string[] args)
        //{

        //    Hashtable ht = new Hashtable();
        //    ht.Add("1", "one");
        //    ht.Add("2", "two");
        //    ht.Add("3", "three");
        //    Console.WriteLine("hash table elements");
        //   foreach (DictionaryEntry entry in ht)
        //    {
        //        Console.WriteLine("ky {0} value{1}", entry.Key, entry.Value);
        //    }
        //    Console.WriteLine("accesed by Key");
        //    Console.WriteLine("key:1 value{0}", ht["1"]);
        //    Console.WriteLine("Remove by Key");
        //    ht.Remove("2");
        //    foreach (DictionaryEntry entry in ht)
        //    {

        //        Console.WriteLine("key {0} value{1}", entry.Key, entry.Value);
        //    }
        //    Console.WriteLine("contains key :1{0}",ht.ContainsKey("1"));

        //}







        // ==================================================================================




        //static void Main(string[] args)
        //{
        //    Console.WriteLine("=====arraylist=======");
        //    ArrayList al=new ArrayList();
        //    al.Add("sandy");
        //    al.Add("palka");
        //    al.Add("rama");
        //    al.Add("kothi");

        //    Console.WriteLine("array list students");
        //    foreach(var item  in al)
        //    {
        //        Console.WriteLine(item);
        //    }


        //    //=====================================
        //    Console.WriteLine("==============hashtable============");
        //    Hashtable ht= new Hashtable();
        //    ht.Add("1", "rama");
        //    ht.Add("2", "raj");
        //    ht.Add("3", "potti");
        //    Console.WriteLine("printing hashtable key value pairs ");

        //    foreach (DictionaryEntry item2 in ht)
        //    {
        //        Console.WriteLine("key {0}    value{1}   ",item2.Key,item2.Value);
        //    }

        //    //queue
        //    Console.WriteLine("=========Queue================");
        //    Queue queue= new Queue();
        //    queue.Enqueue("rama");
        //    queue.Enqueue("raj");
        //    queue.Enqueue("ramesh");
        //    queue.Enqueue("gold meadlist");

        //    Console.WriteLine("queue members");
        //    foreach(var q in queue)
        //    {
        //        Console.WriteLine(q);
        //    }
        //    Console.WriteLine("--------------------------");
        //    Console.WriteLine("dequeue "+queue.Dequeue());
        //    Console.WriteLine("after dequeue" );
        //    foreach (var q in queue)
        //    {
        //        Console.WriteLine(q);
        //    }

        //    Console.WriteLine("============stack===================");
        //    Console.WriteLine("SAtCK");
        //    //stack
        //    Stack s= new Stack();


        //    s.Push("asp.net mvc core");
        //    s.Push("asp.net mvc");
        //    s.Push("asp.net");

        //    Console.WriteLine("stack list");
        //   foreach (var st in s)
        //    {
        //        Console.WriteLine(st);
        //    }

        //    Console.WriteLine("--------------------------");
        //    Console.WriteLine(" after pop "+s.Pop());
        //    foreach(var st in s)
        //    {
        //        Console.WriteLine(st);

        //    }
        //}
        //======================================================================================================

        //LIST:
        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int>();
        //    numbers.Add(1);
        //    numbers.Add(3);
        //    numbers.Add(2);
        //    numbers.Add(4);
        //    numbers.Add(6);
        //    numbers.Add(5);
        //    Console.WriteLine("inside list numvers");
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);

        //    }
        //    numbers.Sort();
        //    Console.WriteLine("aftre soting numbers");
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    numbers.Remove(3);
        //    Console.WriteLine("after removing an element");
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);

        //    }
        //    Console.WriteLine("total number elements in lis" + numbers.Count);
        //    Console.WriteLine("contains 2" + numbers.Contains(2));
        //    numbers.RemoveAt(0);
        //    Console.WriteLine("ofter romoving index 0");
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    numbers.Clear();
        //    Console.WriteLine("total number of elemts ofter clear" + numbers.Count);

        //}

        //

        //static void Display(List<string> students)
        //{
        //    foreach (string student in students)
        //    {
        //        Console.WriteLine(student);
        //    }
        //}

        //static void Main()
        //{


        //    List<string> students = new List<string>();


        //    students.Add("Ravi");
        //    students.Add("kothi");
        //    students.Add("sandy");

        //    Console.WriteLine("After add:");
        //    Display(students);


        //    students.Insert(1, "Suresh");
        //    Console.WriteLine("after insert:");
        //    Display(students);


        //    students.Remove("kothi");
        //    Console.WriteLine("After Remove:");
        //    Display(students);


        //    students.RemoveAt(0);
        //    Console.WriteLine("After RemoveAt:");
        //    Display(students);


        //    Console.WriteLine("Contains sandy? " +
        //                      students.Contains("sandy"));


        //    Console.WriteLine("index of sandy: " +
        //                      students.IndexOf("sandy"));


        //    Console.WriteLine("Total Students: " +
        //                      students.Count);


        //    students.Sort();
        //    Console.WriteLine("after sort:");
        //    Display(students);


        //    students.Reverse();
        //    Console.WriteLine("after reverse:");
        //    Display(students);


        //    students[0] = "palika";
        //    Console.WriteLine("After Update:");
        //    Display(students);


        //    Console.WriteLine("using foreach:");
        //    foreach (string student in students)
        //    {
        //        Console.WriteLine(student);
        //    }


        //    students.Clear();
        //    Console.WriteLine("After Clear:");
        //    Console.WriteLine("Count " + students.Count);
        //}


        //static void Main(string[] args)
        //{
        //   Stack <string> st=new Stack<string>();
        //    st.Push("rama");
        //    st.Push("raju");
        //    st.Push("ramesh");
        //    st.Push("rani");
        //   Console.WriteLine("elements in stack");
        //   foreach(var s in st)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.WriteLine("pop on element" + st.Pop());
        //    Console.WriteLine("peek on element"+st.Peek());
        //    Console.WriteLine(" all number " + st.Count());
        //    st.Clear();
        //    Console.WriteLine("after clearing all number "+st.Count());
        //}

        
    }

}


