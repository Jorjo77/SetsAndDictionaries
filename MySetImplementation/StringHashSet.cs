using System;
using System.Collections.Generic;
using System.Text;

namespace MySetImplementation
{
    class SetElement
    {
        public List<string> Keys { get; set; }
    }
    public class StringHashSet
    {
        private SetElement[] array;

        public StringHashSet(int capacity = 8)
        {
            array = new SetElement[capacity];
        }

        public void Add(string key)
        {
            int index = HashFunction(key);
            if (array[index]!= null)
            {
                array[index].Keys.Add(key);
            }
            else
            {
                array[index] = new SetElement() { Keys = new List<string> { key } };
            }

        }

        private int HashFunction(string key)
        {
            return Math.Abs(key.GetHashCode()% array.Length);
            //това долу е нашата слаба хеш функция, може да видя разликата м/у двете!!!
            //int ascciResult = 0;
            //for (int i = 0; i < key.Length; i++)
            //{
            //    ascciResult += key[i];
            //}
            //return ascciResult % array.Length;
        }
        public bool Contains(string key)
        {
            int index = HashFunction(key);
            if (array[index]!=null)
            {

            }
            for (int i = 0; i < array[index].Keys.Count; i++)
            {
                if (array[index].Keys[i]== key)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
