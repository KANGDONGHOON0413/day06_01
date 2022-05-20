#define BETA
using System;

namespace day06_01
{
    public class Computer02
    {
        public static string Server()
        {
            string server;
#if(ALPHA)
            server = "Alpha testing....";

#elif (BETA)
            server = "Beta testing....";
#else
            server = "Operating....";
#endif
            return server;
        }
    }
}
