using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeServerStream pipeform = new NamedPipeServerStream("pipeform", PipeDirection.Out);

        }
    }
}
