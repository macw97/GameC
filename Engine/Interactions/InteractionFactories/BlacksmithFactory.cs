using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Interactions.Built_In;

namespace Game.Engine.Interactions.InteractionFactories
{
    class BlacksmithFactory:InteractionFactory
    {
        public List<Interaction> CreateInteractionsGroup(GameSession parentSession)
        {
            BlacksmithEncounter blacksmith = new BlacksmithEncounter(parentSession);
            return new List<Interaction>() { blacksmith };
        }
    }
}
