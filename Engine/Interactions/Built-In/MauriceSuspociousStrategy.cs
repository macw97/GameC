using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Monsters;
using Game.Engine.CharacterClasses;
using Game.Engine.Items;
using Game.Engine.Items.BasicArmor;

namespace Game.Engine.Interactions.Built_In
{
    class MauriceSuspociousStrategy:IMauriceStrategy
    {
        public void Execute(GameSession session,bool visited)
        {
            if(visited==false)
            {
                session.SendText("\nNo one will talk to me like that I'm not such a thief");
                session.SendText("Let's fight");
                session.FightThisMonster(new Maurice(5));
            }
            if (visited == true)
            {
                session.SendText("\nYes it's me but please don't tell anyone I give you back here things");
            }
            session.AddThisItem(new MargeryWeapon());
            session.AddThisItem(new MargeryArmor());

        }
    }
}
