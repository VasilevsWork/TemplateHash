using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTemp
{
    class MyPerson
    {
        int age;
        string name;
    }

    class MyHashTable
    {
        class Node
        {
            public string key;
            public MyPerson value;
        }

        List<Node>[] dataArr = new List<Node>[20];

        public MyHashTable()
        {
            // TODO: Инициализировать списки
            //for (int i = 0; )
        }


        private int Hash(string key)
        {
            int val = 0;
            foreach (var elem in key)
            {
                val += elem;
            }

            return val % dataArr.Length;
        }

        public void Add(string key, MyPerson data)
        {
            Node node = new Node();
            node.key = key;
            node.value = data;

            int index = Hash(key);
            dataArr[index].Add(node);
        }

        public MyPerson Find(string key)
        {
            int index = Hash(key);
            foreach (Node node in dataArr[index])
            {
                if (key == node.key)
                    return node.value;
            }

            return new MyPerson();
        }
        

    }
}
