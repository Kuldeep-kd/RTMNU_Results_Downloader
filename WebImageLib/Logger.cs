using System;

namespace WebImageLib
{
    public static class Logger
    {
        public static void Log(string Message, int Code)
        {
            Console.WriteLine(Message + " Error code: " + Code);
        }
    }
}
