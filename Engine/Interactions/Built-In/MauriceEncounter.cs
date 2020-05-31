using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.Built_In
{
    class MauriceEncounter : ListBoxInteraction
    {
        private bool visited = false; 
        public IMauriceStrategy Strategy {get;set;}
        public MauriceEncounter(GameSession ses):base(ses)
        {
            Name = "interaction0006";
            Enterable = false;
            Strategy = new MauriceNeutralStrategy();
        }
        protected override void RunContent()
        {
            if (visited == false && Strategy is MauriceNeutralStrategy)
            { 
                Strategy.Execute(parentSession,visited);
                visited = true;
                return;
            }
            if (visited==true && Strategy is MauriceNeutralStrategy)
            {
                Strategy.Execute(parentSession, visited);
            }
            if (Strategy is MauriceSuspociousStrategy)
            {
                parentSession.SendText("\nI heard you talked with Margery what you want from me?");
                int choice = GetListBoxChoice(new List<string>() { "People say that you stole here equipment. Give it back!", "Do you know where here things may be" });
                if(choice==0)
                {
                    Strategy.Execute(parentSession,false);
                    Strategy = new MauriceNeutralStrategy();
                    visited = true;
                }
                if(choice==1)
                {
                    Strategy.Execute(parentSession, true);
                    Strategy = new MauriceNeutralStrategy();
                    visited = true;
                }
             }
            
        }

    }
}
