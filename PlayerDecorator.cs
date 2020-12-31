using System;
using System.Collections.Generic;
using System.Text;

namespace AudioPlayer
{
    /*Add filter to music player*/
    public abstract class PlayerDecorator 
    {
        private readonly IPlayer _player;
        public PlayerDecorator(IPlayer player)
        {
            this._player = player;
        }
        public virtual IPlayer Player()
        {
           return this._player;
        }

    }
}
