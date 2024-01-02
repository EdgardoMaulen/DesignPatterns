using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class DataBaseMail : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Mail send from Database");
        }
    }
}
