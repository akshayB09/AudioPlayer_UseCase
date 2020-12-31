using System;
using System.Collections.Generic;
using System.Text;

namespace AudioPlayer
{
    //Add extra bass decompress with music
    class DecorateWithExtraBassDecompress: PlayerDecorator
    {
        public DecorateWithExtraBassDecompress(IPlayer player):base(player)
        {
            // Call base calss constroctor.
        }

        public override IPlayer Player()
        {
            //call base class virtual method  
            return base.Player();
        }

        public void Play()
        {
            //Play music with extra bass decompress
            var player = Player();
            player.PlayMusic();/*+ Extra Bass Decompree logic*/
            Console.WriteLine(" Extra Bass Decompree!");
        }
    }
}
