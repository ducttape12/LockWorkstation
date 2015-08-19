using System;
using System.Runtime.InteropServices;

namespace LockWorkstation
{
    public class Program
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool LockWorkStation();

        public static void Main(string[] args)
        {
            if (!LockWorkStation())
            {
                Console.WriteLine("Unable to lock workstation.  Press any key to continue.");
                Console.Read();
            }
        }
    }
}
