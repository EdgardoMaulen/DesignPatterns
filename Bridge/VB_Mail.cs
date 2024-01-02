using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class VB_Mail : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Mail send from VB code");
        }
    }

}
