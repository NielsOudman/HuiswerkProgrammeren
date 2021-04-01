using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuiswerkProg3Week3
{
    public class MyList<T>
    {
        private T item;
        private MyList<T> next = null;
        public MyList(T item)
        {
            this.item = item;
        }
        public void Add(T item)
        {
            //opgave 4
            if (next == null)
            {
                next = new MyList<T>(item);
            }
            else
            {
                next.Add(item);
            }



        }
        public T ItemAt(int index)
        {
            //opgave 5
            if (index == 0)
            {
                return item; 
            }
            if (next == null)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return next.ItemAt(index - 1);
            }
      
        }
        public int Count()
        {
            //opgave 6
            if (item == null)
            {
                return 0;

            }     
            if (next == null)
            {
                return 1;
            }
            return 1 + next.Count();
            
        }
        public MyList<T> Reverse()
        {
            //opgave 9 (optioneel)
            throw new NotImplementedException();
        }
    }

}
