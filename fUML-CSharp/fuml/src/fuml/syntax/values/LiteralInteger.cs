using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuml.src.fuml.syntax.values
{
    public class LiteralInteger : LiteralSpecification
    {
        public int value = 0;
        public void setValue(int value)
        {
            this.value = value;
        } // setValue
    } // LiteralInteger
}
