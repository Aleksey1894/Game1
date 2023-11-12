
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.IO;

namespace Game1
{

    class Program
    {
        static void Main()
        {

            SnakeGameManager game = new SnakeGameManager();

            game.Start();


        }
    }
}
