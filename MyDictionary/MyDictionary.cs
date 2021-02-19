using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            keys = new TKey[keys.Length + 1];

            TValue[] tempValues = values;
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[1] = tempKeys[i];
                values[1] = tempValues[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public int count
        {
            get { return keys.Length; }
        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("KEY : "+keys[i]+ " value :" + values[i]);
            }
        }


    }
}
