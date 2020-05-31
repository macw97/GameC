using Game.Engine.Interactions.Built_In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.InteractionFactories
{
    class MargeryMauriceFactory:InteractionFactory
    {
        public List<Interaction> CreateInteractionsGroup(GameSession parentSession)
        {
            MauriceEncounter maurice = new MauriceEncounter(parentSession);
            MargeryEncounter margery = new MargeryEncounter(parentSession, maurice);
            return new List<Interaction>() { margery, maurice };
        }
    }
}
