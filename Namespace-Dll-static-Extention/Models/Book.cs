using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_static_Extention.Models
{
    internal   class Book
    {

        public static int Count { get; set; }

        public Book()
        {
            Count++;
        }


    }
}
