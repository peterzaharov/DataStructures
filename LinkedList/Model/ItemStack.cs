using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class ItemStack<T>
    {
        public T Data { get; set; }
        public ItemStack<T> Previous { get; set; }
        public ItemStack(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
