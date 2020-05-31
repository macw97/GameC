using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.Built_In
{
    class MargeryEncounter:ListBoxInteraction
    {
        private MauriceEncounter localThief;
        private int visits = 0;
        public MargeryEncounter(GameSession ses,MauriceEncounter thief):base(ses)
        {
            Name = "interaction0005";
            this.localThief = thief;
            this.Enterable = false;
        }
        protected override void RunContent()
        {
           if(visits==-1)
           {
                parentSession.SendText("\nWhat you want? You don't want to help me so I don't have time for you.");
                return;
           }
           if(visits==1)
            {
                parentSession.SendText("\nSo now you want to help me ?");
                int choice = GetListBoxChoice(new List<string>() { "Yes I can help you now", "NO" });
                if (choice == 0)
                {
                    visits = 2;
                    parentSession.SendText("\nGreat, so someone stole my equipment I need you to find Maurice becuse it's probably him ");
                    localThief.Strategy = new MauriceSuspociousStrategy();
                    return;
                }
                else
                {
                    visits = -1;
                    parentSession.SendText("\nOK don't talk to me again");
                    return;
                }

            }
            if (visits == 2 && parentSession.GetActiveItemNames().Contains("item0014") && parentSession.GetActiveItemNames().Contains("item0015")) 
            {
                parentSession.SendText("\nOH! You found my armor thank you so much this is your reward");
                parentSession.UpdateStat(8, 200);
               // parentSession.RemoveItemPosition(2, 0);
               // parentSession.RemoveItemPosition(3, 0);
              
                visits = 3;
                return;
            }
            if(visits==2)
            {
                parentSession.SendText("\nRemember it's probably Maurice he have to have my equipment");
                return;
            }
           if(visits==3)
            {
                parentSession.SendText("\nThank you for help again!");
                return;
            }

            parentSession.SendText("\nHello adventurer. My name is Margery. Someone stole my equipment could you please help me find it?");
            int choice1 = GetListBoxChoice(new List<string>() { "No problem, do you suspect anyone ?", "What exactly happened ?", "Sorry I don't have time to help you." });
            switch(choice1)
            {
                case 0:
                    parentSession.SendText("\nI heard about local thief called Maurice maybe it's him or he heard something about that.");
                    parentSession.SendText("Please find my armor and weapon I will pay you 200 gold .");
                    int choice2 = GetListBoxChoice(new List<string>() { "I will do my best.", "MAURICE o hell no I will not help you" });
                    if (choice2 == 0)
                    {
                        visits =2;
                        localThief.Strategy = new MauriceSuspociousStrategy();
                    }
                    else
                    {
                        visits = -1;
                    }
                    break;
                case 1:
                    parentSession.SendText("\nWhen I was sleeping someone sneeked into my tent and stole everything it's probably this local thief Maurice");
                    int choice3 = GetListBoxChoice(new List<string>() { "Don't worry I will find your equipment", "Sorry I don't want to take part in this" });
                    if (choice3 == 0)
                    {
                        visits = 2;
                        localThief.Strategy = new MauriceSuspociousStrategy();
                    }
                    else
                        visits = -1;
                    break;
                case 2:
                    parentSession.SendText("\nFine, someone better will help me then");
                    visits = 1;
                    break;
            } 

        }
    }
}
