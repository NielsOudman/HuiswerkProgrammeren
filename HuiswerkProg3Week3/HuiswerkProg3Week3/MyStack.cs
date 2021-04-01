using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuiswerkProg3Week3
{
    public class MyStack<T>
    {
        
        private List<T> items = new List<T>();
        public void Push(T item)
        {
            items.Add(item);
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("stack Empty");
            }
            return items.Last();
        }
        public T Pop()
        {
            T item = items.Last();
            items.RemoveAt(items.Count -1);
            return item;
        }
        public bool IsEmpty()
        {
         if (items.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}

