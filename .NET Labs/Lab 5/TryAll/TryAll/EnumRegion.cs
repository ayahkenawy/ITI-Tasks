using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAll
{
    enum Gender
    {
       male,
       female
    }
    [Flags]
    enum Position
    {
        guest=0b_0001,
        developer = 0b_0010,
        secretary = 0b_0100,
        dba = 0b_1000,
        officer = 0b_1111
    }
}
