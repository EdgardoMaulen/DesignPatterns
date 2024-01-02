using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class CSharpMail : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Mail send from c# code");
        }
    }
}
