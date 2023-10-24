using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuml.src.fuml.syntax.values
{
    public class LiteralString : LiteralSpecification
    {
        public string value = "";

        public void setValue(string value)
        {
            this.value = value;
        } // setValue
    } // LiteralString
}
