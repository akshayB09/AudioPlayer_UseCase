using System;

namespace AudioPlayer
{
    class Program
    {
        static void Main()
        {
            string val;
            Console.Write("Enter path: ");
            val = Console.ReadLine();
            var format = val.Split(",");

            if (format[1] == "add_extra_bass")
            {
                var player = PlayerFactory.Player(format[0]);
                if (player != null)
                {
                    var playWithExtraBass = new DecorateWithExtraBass(player);
                    playWithExtraBass.Play();
                }
                else
                {
                    Console.Write("Format not supported");
                }

            }
            else if (format[1] == "add_extra_bass decompress ")
            {
                var player = PlayerFactory.Player(format[0]);
                if (player != null)
                {
                    var playWithExtraBass = new DecorateWithExtraBassDecompress(player);
                    playWithExtraBass.Play();
                }
                else
                {
                    Console.Write("Format not supported");
                }
            }

            Console.ReadLine();
        }
    }
}
