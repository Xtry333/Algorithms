﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Listy {
    public class Node {
        public int value;
        public Node nextNode;
        

        public Node(int v) {
            this.value = v;
            this.nextNode = null;
        }

        public int Dlugosc {
            get { return (nextNode == null ? 1 : 1 + nextNode.Dlugosc); }
        }

        public override string ToString() {
            if(nextNode == null)
                return value + "";
            return value + ", " + nextNode.ToString();
        }
    }

    public class Lista {
        public Node head = null;
        public Node tail = null;

        public void dodajNaPoczatek(Node node) {
            node.nextNode = head;
            tail = head;
            head = node;
        }
        public void usunGlowe() {
            if(head != null) {
                head = tail;
                if(tail != null)
                    tail = tail.nextNode;
            }
        }

        public void usunDrugi()
        {
            if(this.Dlugosc > 1)
            {
                head.nextNode = tail.nextNode;
            }
        }

        public void usunWskazany(int ktory)
        {
            Node tmpCurrentNote = head, tmpPreviousNode = head;
            int temp = 1;
            while (temp < ktory)
            {
                tmpPreviousNode = tmpCurrentNote;
                tmpCurrentNote = tmpCurrentNote.nextNode;
                temp++;
            }
            tmpPreviousNode.nextNode = tmpCurrentNote.nextNode;
        }

        public int Dlugosc {
            get { return (head == null ? 0 : head.Dlugosc); }
        }
        public override string ToString() {
            if(head == null) return "NULL";
            return head.ToString();
        }
    }
    class Program {
        static void Main(string[] args) {
            Lista lista = new Lista();

            Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);

            lista.dodajNaPoczatek(new Node(1));
            lista.dodajNaPoczatek(new Node(2));
            lista.dodajNaPoczatek(new Node(3));
            lista.dodajNaPoczatek(new Node(4));
            lista.dodajNaPoczatek(new Node(5));
            lista.dodajNaPoczatek(new Node(6));
            lista.dodajNaPoczatek(new Node(7));
            lista.dodajNaPoczatek(new Node(8));

            Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);

            //lista.usunDrugi();
            //Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);
            lista.usunWskazany(1);
            Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);
            //lista.usunGlowe();
            //Console.WriteLine("#: {1}: {0}",lista, lista.Dlugosc);
            //lista.usunGlowe();
            //Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);
            //lista.usunGlowe();
            //Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);
            //lista.usunGlowe();
            //Console.WriteLine("#: {1}: {0}", lista, lista.Dlugosc);

            Console.ReadKey();
        }
    }
}
