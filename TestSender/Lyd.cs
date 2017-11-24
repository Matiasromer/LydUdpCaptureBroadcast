using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSender
{
    public class Lyd
    {
        public string  Lyde { get; set; }
        public int Id { get; set; }

        public Lyd()
        {
            
        }

        public override string ToString()
        {
            return $"{Lyde}";
        }

    }


}
