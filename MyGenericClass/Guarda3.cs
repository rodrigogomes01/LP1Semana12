using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private List<T> variableList = new List<T>();
        private T v1, v2, v3;

        public Guarda3()
        {
            v1 = default;
            v2 = default;
            v3 = default;

            variableList.Add(v1);
            variableList.Add(v2);
            variableList.Add(v3);
        }

        public T GetItem(int i)
        {
            return variableList[i];
        }
        public void SetItem(int i, T item)
        {

            if (i > 2 || i < 0)
                throw new IndexOutOfRangeException();

            else
                variableList[i] = item;
        }

    }
}