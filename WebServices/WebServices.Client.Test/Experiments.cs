using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServices.Client.Test
{
    public class GenericsExampless<T>
    {
        public string PrintType()
        {
            return T.GetType()
        }

        public static void Swap<T1>(T1 lhs, T1 rhs)
        {
            T1 temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
