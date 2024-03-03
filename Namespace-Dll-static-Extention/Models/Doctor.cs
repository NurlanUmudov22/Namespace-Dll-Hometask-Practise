using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Dll_static_Extention.Models
{
    internal static class Doctor
    {
        public static int Id { get; set; }
        public static string Name { get; set; }

        static Doctor()
        {
            Console.WriteLine("static constructor");
        }

    }
}
