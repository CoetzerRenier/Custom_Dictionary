using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Dictionary
{
    internal class CDictionary<TKey, TValue>
    {
        List<TKey> keys;
        List<TValue> values;

        public CDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if (keys.Contains(key))
            {
                Console.WriteLine("Key already exists.");
                return;
            }

            keys.Add(key);
            values.Add(value);
        }

        public void Remove(TKey key)
        {
            int index = keys.IndexOf(key);
            if (index != -1)
            {
                keys.RemoveAt(index);
                values.RemoveAt(index);
                Console.WriteLine($"Removed key: {key}");
            }
            else
            {
                Console.WriteLine("Key not found.");
            }
        }

        public void Update(TKey key, TValue newValue)
        {
            int index = keys.IndexOf(key);
            if (index != -1)
            {
                values[index] = newValue;
                Console.WriteLine($"Updated key: {key}");
            }
            else
            {
                Console.WriteLine("Key not found.");
            }
        }

        public void DisplayAll()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                Console.WriteLine($"Key: {keys[i]}, Value: {values[i]}");
            }
        }
    }
}
