using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);*/

            //PARTE2
            //Node n1 = new Node(p1);

            Person p1 = new Person(80, "p1");
            Node n1 = new Node(p1);
            Person p2 = new Person(70, "p2");
            Person p3 = new Person(60, "p3");
            Person p4 = new Person(50, "p4");
            Person p5 = new Person(40, "p5");
            Person p6 = new Person(11, "p6");
            Person p7 = new Person(11, "p7");
            Person p8 = new Person(11, "p8");
            n1.AddChildren(p1);
            n1.AddChildren(p2);
            n1.AddChildren(p3);
            n1.AddChildren(p4);
            n1.AddChildren(p5);
            n1.AddChildren(p6);
            n1.AddChildren(p7);
            n1.AddChildren(p8);

            // visitar el árbol aquí
        }
    }
}
