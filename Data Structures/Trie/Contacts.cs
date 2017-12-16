using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    class Node
    {
        public char word;
        public List<Node> child;
        public int passCount;

        public Node()
        {
            passCount = 1;
            child = new List<Node>();
        }
    }

    static Node head = new Node();
    static int addCount = 0;
    static void Main(String[] args)
    {
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            if (input.Split(' ')[0] == "add") add(input.Split(' ')[1]);
            else find(input.Split(' ')[1]); 
        }
    }

    static void add(string name)
    {
        addCount++;
        int repeat = addCount;
        int length = name.Length;
        Node node = null;

        if (head.child.Count == 0)
        {
            node = new Node();
            node.word = name[0];
            head.child.Add(node);
        }
        
        for (int i = 0; i < length; i++)
        {
            int index = 0;
            Node cur = head;
            while (cur != null && index < length)
            {
                if (cur.child.Count == 0)
                {
                    node = new Node();
                    node.word = name[index];
                    cur.child.Add(node);
                    break;
                }
                else
                {
                    Node find = cur.child.Find(x => x.word == name[index]);
                    if (find == null)
                    {
                        node = new Node();
                        node.word = name[index];
                        cur.child.Add(node);
                        break;
                    }
                    else
                    {
                        cur = find;
                        if (find.passCount < repeat) find.passCount++;
                        index++;
                    }
                }
            }
            i = index;
            repeat = 0;
        }
    }

    static void find(string str)
    {
        Node cur = head;
        for (int i = 0; i < str.Length; i++)
        {
            Node node = cur.child.Find(x => x.word == str[i]);
            if (node != null)
            {
                cur = node;
            }
            else
            {
                Console.WriteLine("0");
                return;
            }
        }

        Console.WriteLine(cur.passCount);
    }
}