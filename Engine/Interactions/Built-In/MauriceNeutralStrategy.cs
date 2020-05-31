using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.Built_In
{
    class MauriceNeutralStrategy:IMauriceStrategy
    {
        public void Execute(GameSession session,bool visited)
        {
            if (visited)
            {
                session.SendText("Hi buddy see you on the field");
                return;

            }
            session.SendText("Hello stranger I don't know you and I know everyone here. I'm Maurice, if you need any help let me know");
            
        }
    }
}
