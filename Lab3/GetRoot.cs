using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class GetRoot
    {
        public static string rootFolder =
            Directory.GetParent(Directory.GetCurrentDirectory())
            .Parent
            .Parent
            .Parent
            .ToString();
    }
}
