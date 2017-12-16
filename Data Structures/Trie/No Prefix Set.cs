using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    class Node
    {
        public char word;
        public List<Node> child;
        public bool isEnd;

        public Node()
        {
            isEnd = false;
            child = new List<Node>();
        }
    }

    static Node head = new Node();
    static void Main(String[] args)
    {
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string str = Console.ReadLine();
            if (add(str) == false)
            {
                Console.WriteLine("BAD SET");
                Console.WriteLine(str);
                return;
            }
        }
        Console.WriteLine("GOOD SET");
    }

    static bool add(string name)
    {
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
                        if (find.isEnd == true) return false;
                        cur = find;
                        index++;
                    }
                }
            }
            i = index;
        }

        if (node == null) return false;
        
        node.isEnd = true;
        return true;
    }
}