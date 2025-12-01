using GenericsDemoLibrary;
using System;
using System.Collections;
using System.Collections.Generic;

using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        //List<String> strs=new List<String>();
        //strs.Add("Hello");
        //strs.Add("Good Morning");

        List<Employee> emplist=new List<Employee>();//generic collections--collection type---->employee and collection name=emplist

        Employee e1=new Employee();
        e1.Empid = 100;
        e1.Ename = "Anuj";
        e1.Deptno = 10;
       emplist.Add(e1);
       emplist.Add(new Employee {Empid=102,Ename="Sakshi",Deptno=10 });
        emplist.Add(new Employee { Empid = 103, Ename = "Simran", Deptno = 10 });
        emplist.Add(new Employee { Empid = 105, Ename = "Jack", Deptno = 10 });
        emplist.Add(new Employee { Empid = 104, Ename = "Jim", Deptno = 30 });
        emplist.Add(new Employee { Empid = 106, Ename = "Tim", Deptno = 20 });
        emplist.Add(new Employee { Empid = 101, Ename = "Shashi", Deptno = 20 });


        emplist.Sort();

        foreach (var item in emplist)
        {
            Console.WriteLine(item.Empid);
            Console.WriteLine(item.Ename);
            Console.WriteLine(item.Deptno);
            Console.WriteLine();
        }














        //Non Generic Collections--- they can hold any type of data(ie the object datatype can be used here)

        //ArrayListDemo();

        //  StackDemo();
        //QueueDemo();

        //   Hashtable h=new Hashtable();
        //   h.Add(1, "100");
        ////   h.Add("1", "100");//key string 1 -value is string 100
        //   //h.Add(1.0, 100);
        //   h.Add(2, 200);
        //   h.Add(3, 200);
        //   h.Add(4, 200);
        //   h.Add(5, 200);    
        //   h.Add(6, 200);




    }


    private static void HashTableDemo()
    {
        Hashtable h = new Hashtable {
            {1,100 },
            {2,400}, {3,100}, {4,100},{5,200 },{6,200}, {7,300}

        };

        IDictionaryEnumerator ie = h.GetEnumerator();
        while (ie.MoveNext())
        {
            Console.Write(ie.Key + " " + ie.Value);
            Console.WriteLine();
        }
        Console.WriteLine("Using for each");

        foreach (DictionaryEntry item in h)
        {
            Console.WriteLine(item.Value + "  " + item.Key);
        }


        int[] points = h.Values.Cast<int>().ToArray();
        int[] keys = h.Keys.Cast<int>().ToArray();

        Array.Sort(points);
        Console.WriteLine("Sorted on points value");
        foreach (var item in points)
        {
            Console.WriteLine(item);
        }

        //convert to 2 d array the hashtable
        int[,] result = new int[keys.Length, 7];
        for (int i = 0; i < keys.Length; i++)
        {
            result[i, 0] = keys[i];
            result[i, 1] = points[i];
        }

        //Printing 2D array
        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.WriteLine($"{result[i, 0]} -- {result[i, 1]}");
        }
    }
    private static void QueueDemo()
    {

        //int[] a = new int[2] { 1000, 2000 };
        //Queue q = new Queue(a);

        //Queue q = new Queue();
        Queue q1 = new Queue(10);
        q1.Enqueue(1);
        q1.Enqueue(2);
        q1.Enqueue(3);
        q1.Enqueue(4);
        q1.Enqueue(5);

        foreach (var item in q1)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("--------");
        int[] copiedque = new int[10];
        q1.CopyTo(copiedque, 0);

        foreach (var item in copiedque)
        {
            Console.WriteLine(item);
        }


        //FIFO
    }

    private static void StackDemo()
    {
        int[] a = new int[5] { 10, 20, 30, 40, 50 };
        Stack s = new Stack(a);//ICollection overload
        //Stack LIFO 
        s.Push(100);
        s.Push("Hello");
        s.Push('A');
        foreach (var item in s)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------");
        object element = s.Pop();    //A removed
        Console.WriteLine("Removed " + element);

        element = s.Peek();
        Console.WriteLine("Topmost element on the stack=" + element);
    }

    private static void ArrayListDemo()
    {
        ArrayList a = new ArrayList(1);
        a.Add(1);

        a.Add(2);
        a.Add(4);
        a.Add("HEllo");
        a.Add('A');
        a.Add(new DateOnly(2025, 09, 11));


        a.Remove(1);//it searches for value 1 and removes 

        a.RemoveAt(2);//value at index 2--removes Hello 
        //2,4,A,2025-09-11

        a.RemoveRange(0, 2);//starting from index 0 remove 2 element
        //foreach (var item in a)
        //{
        //    Console.WriteLine(item);
        //}

        //A, 2025-09-11
        int[] arr = new int[5] { 10, 20, 30, 40, 50 };//collection
        a.AddRange(arr); //adding at the end 
        //A, 2025-09-11,10,20,30,40,50
        int[] arr1 = new int[5] { 100, 200, 300, 400, 500 };
        a.InsertRange(4, arr1);
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
    }
}