using System;
using System.Collections.Generic;

namespace DSHashTables
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        //passing the key value pair to the linked list
        private readonly LinkedList<KeyValue<K, V>>[] iteams;

        //created constructor of the class
        public MyMapNode(int size)
        {
            this.size = size;
            this.iteams = new LinkedList<KeyValue<K, V>>[size];
        }

        protected int getArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }

            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }


        }
        //method getlinkedlist, has  a return type linkist as a key value pair
        //parameter is position it will be an index
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = iteams[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                iteams[position] = linkedList;
            }
            return linkedList;

        }
    }

    public struct KeyValue<k, v>
    {
        public k key { get; set; }
        public v value { get; set; }
    }
}
