using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;

namespace Game.Engine.Interactions.Built_In
{
    class BlacksmithEncounter:ListBoxInteraction
    {
        private int visits = 0;
        public BlacksmithEncounter(GameSession ses):base(ses)
        {
            Name = "interaction0008";
            Enterable = false;
        }
        protected override void RunContent()
        {
            if(visits>=1)
            {
                parentSession.SendText("\nSorry friend I already enchanced your equipment can't do that twice");
                return;
            }
            parentSession.SendText("\nHello stranger I'm a dwarf blacksmith how can I help you ?\n");
            int choice = GetListBoxChoice(new List<string>() { "I would like to enchace my weapon", "I would like to enchace my armor" });
            switch (choice)
            {
                case 0:
                    parentSession.SendText("\nOK this is the deal I can enchance your weapon depending on package:\n1.(Str+20) - 200 gold\n2.(Str+50) - 400 gold");
                    int choice2 = GetListBoxChoice(new List<string>() { "I will take package nr 1.", "I will take package nr 2." });
                    if (choice2 == 0)
                    {
                        if (parentSession.currentPlayer.Gold >= 200)
                        {
                            parentSession.UpdateStat(8, -200);
                            if (parentSession.currentPlayer is Mage)
                                parentSession.UpdateStat(5, 20);
                            else
                                parentSession.UpdateStat(2, 20);
                            visits++;
                            return;
                        }
                        else
                            parentSession.SendText("\nYou don't have enough gold. I can't enchance your weapon\n");
                    }
                    if (choice2 == 1)
                    {
                        if (parentSession.currentPlayer.Gold >= 400)
                        {
                            parentSession.UpdateStat(8,-400);
                            if (parentSession.currentPlayer is Mage)
                                parentSession.UpdateStat(5, 50);
                            else
                                parentSession.UpdateStat(2, 50);
                            visits++;
                            return;
                        }
                        else
                            parentSession.SendText("\nYou don't have enough gold. I can't enchance your weapon\n");
                    }
                    break;
                case 1:
                    parentSession.SendText("\nOK this is the deal I can enchance your armor depending on package:\n1.(Armor+20) - 200 gold\n2.(Armor+50) - 400 gold");
                    int choice3 = GetListBoxChoice(new List<string>() { "I will take package nr 1.", "I will take package nr 2." });
                    if (choice3 == 0)
                    {
                        if (parentSession.currentPlayer.Gold >= 200)
                        {
                            parentSession.UpdateStat(8, -200);
                            parentSession.UpdateStat(3, 20);
                            visits++;
                            return;
                        }
                        else
                            parentSession.SendText("\nYou don't have enough gold. I can't enchance your weapon\n");
                    }
                    if (choice3 == 1)
                    {
                        if (parentSession.currentPlayer.Gold >= 400)
                        {
                            parentSession.UpdateStat(8, -400);
                            parentSession.UpdateStat(3, 50);
                            visits++;
                            return;
                        }
                        else
                            parentSession.SendText("\nYou don't have enough gold. I can't enchance your weapon\n");
                    }
                    break;
            }

        }
    }
}

