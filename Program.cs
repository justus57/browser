using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace browser
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = "https://www.google.com";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
        public static void getdetails(string accountNo,string memberNo)
        {

        }
    }
}
