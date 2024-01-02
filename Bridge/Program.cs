using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {

        /* TODO: provide an explanation. Personally I didn't quite understand the purpose of the bridge pattern */

        static void Main(string[] args)
        {
            MailBridge mb = new MailBridge();
            CSharpMail CSMail = new CSharpMail();
            VB_Mail VBMail = new VB_Mail();

            mb.SendFrom(VBMail);
            mb.SendFrom(CSMail);

            Console.ReadKey();
        }
    }
}
