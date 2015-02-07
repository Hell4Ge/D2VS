using System;
using System.Collections.Generic;
using System.Text;

namespace D2VS.Gateway
{
    public class Gate
    {
        public String name { private set; get; }
        public String ip { private set; get; }
        public String timezone { private set; get; }


        public Gate(string name, string ip, string timezone)
        {
            this.name = name;
            this.ip = ip;
            this.timezone = timezone;
        }

        public override String ToString()
        {
            return '\n' + this.ip + '\n' + this.timezone + "\n" + this.name;
        }
    }
}