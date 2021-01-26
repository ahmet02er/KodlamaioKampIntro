using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<T, D>
    {
        T[] keys;
        D[] values;
        T[] tempKeys;
        D[] tempValues;
        public MyDictionary()
        {
            keys = new T[0];
            values = new D[0];
        }
        public void Add(T key, D value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new T[keys.Length + 1];
            values = new D[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int j = 0; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " = " + values[i]);
            }
        }
    }
}
