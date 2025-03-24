using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Demo
{
    public static class PersonExtensions
    {
        public static string GetInitials(this Person p)
        {
            return p.Name;
        }

    }
}
