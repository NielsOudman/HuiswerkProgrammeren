using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuiswerkProg3Week3
{
    public class MyQueue<T>
    {
        private List<T> items = new List<T>();

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
        public void Enqueue (T item)
        {
            items.Add(item);
        }
    }
}
