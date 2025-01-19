using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Generics
{
    internal class Box<T>
    {
        //public T Content { get; set; }

        //public String Log()
        //{
        //    return $"Box contains {Content}";
        //}

        private T _content;
        public Box(T content)
        {
            _content = content;
        }

        public void UpdateContent(T content)
        {
            _content = content;
        }

        public T GetContent()
        {
            return _content;
        }


    }
}
