using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizedSet.App
{
  

    public class RandomizedSet
    {
        private List<int> values; 
        private Dictionary<int, int> valToIndex; 
        private Random random;

        public RandomizedSet()
        {
            values = new List<int>();
            valToIndex = new Dictionary<int, int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            if (valToIndex.ContainsKey(val))
                return false; 

            valToIndex[val] = values.Count; 
            values.Add(val); 
            return true;
        }

        public bool Remove(int val)
        {
            if (!valToIndex.ContainsKey(val))
                return false;

            int index = valToIndex[val]; 

            values.RemoveAt(index); 

           
            valToIndex.Remove(val);

          
            for (int i = index; i < values.Count; i++)
            {
                valToIndex[values[i]] = i; 
            }

            return true;
        }

        public int GetRandom()
        {
            int randomIndex = random.Next(values.Count);
            return values[randomIndex];
        }
    }

}
