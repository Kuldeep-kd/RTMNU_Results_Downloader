using System;

namespace RTMNU_Results_Downloader
{
    public static class Logger
    {
        public static void Log(string Message, int Code)
        {
            Console.WriteLine(Message + " Error code: " + Code);
        }
    }
}
