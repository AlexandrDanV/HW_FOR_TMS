using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGeneric
{
    public class MyStack<T>
    {
        List<T> list = new List<T>();

        public bool IsEmpty = true;
        public void Push(T element)
        {
            list.Add(element);
            Set_isEmpty();
        }
        public T Pop()
        {
            try
            {
                if (IsEmpty is true) { throw new Exception("The stack is empty"); }
            }
            catch (Exception) { throw; }

            var item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Set_isEmpty();
            return item;
        }
        public T Peek()
        {
            try
            {
                if (IsEmpty is true) { throw new Exception("The stack is empty"); }
            }
            catch (Exception) { throw; }

            if (IsEmpty is true) { throw new Exception("The stack is empty"); }
            return list[list.Count - 1];
        }

        public int Count()
        {
            return list.Count;
        }
        private void Set_isEmpty() => IsEmpty = (list.Count > 0) ? false : true;

    }
}
