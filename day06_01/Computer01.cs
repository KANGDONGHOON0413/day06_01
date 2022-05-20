#define ALPHA   //이 파일에서만 사용가능
#undef DEBUG    //DEBUG는 사용하지 않겠다는 의미

using System;
using static day06_01.Computer02;

//전처리기 연습
namespace day06_01
{
    class Computer01
    {
        
        static void Main(string[] args)
        {
            bool verbose = false;
#if(ALPHA)
            Console.WriteLine("test environment: verbose opthion is set");
            verbose = true;
#else
            Console.WriteLine("production");
#endif
            if (verbose)
            {
                
                Console.WriteLine("verbose mode");
#if(!DEBUG)
                var Server = Computer02.Server();
                Console.WriteLine(Server);
#endif
            }
        }
    }
}
