using System;
using System.Collections.Generic;
using System.Text;

namespace AudioPlayer
{
    class PlayerFactory
    {
        public static IPlayer Player(string playerName)
        {
            IPlayer player = null;

            if(playerName.Contains(".mp3"))
            {
                player = new MP3Player();
            }
            else if(playerName.Contains(".flac"))
            {
                player = new FLACPlayer();
            }
            
            return player;
        }
    }
}
