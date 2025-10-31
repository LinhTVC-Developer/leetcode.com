using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp.Examples.SignleLinkNode;

public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data) {
        this.Data = data;
        this.Next = null;
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Node head = new Node(10);
//        head.Next = new Node(20);
//        head.Next.Next = new Node(30);
//        head.Next.Next.Next = new Node(40);

//        while (head != null)
//        {
//            Console.Write(head.Data + " ");
//            head = head.Next;
//        }
//    }
//}
