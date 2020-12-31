using System;
using System.Collections.Generic;
using System.Text;

namespace AudioPlayer
{
    /*Add extra bass with music*/
    class DecorateWithExtraBass : PlayerDecorator
    {
        public DecorateWithExtraBass(IPlayer player):base(player)
        {
            //call base class constroctor.
        }

        public override IPlayer Player()
        {
            //override base class virtual method.
            return base.Player();
        }

        public void Play()
        {
            //Play music with extra bass.
            var player = Player();
            player.PlayMusic();/*Extra bass logic*/
            Console.WriteLine(" with extra bass!");
        }
    }
}
