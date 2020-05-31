using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;
using Game.Engine.Skills.AdvancedWeaponMoves;
using Game.Engine.Skills.BasicWeaponMoves;

namespace Game.Engine.Skills.SkillFactories
{
    class AdvancedMovesFactory:SkillFactory
    {
        public Skill CreateSkill(Player player )
        {
            List<Skill> playerSkills = player.ListOfSkills;
            Skill known = Check(playerSkills);
            if (known == null)
            {
                JumpCut s1 = new JumpCut();
                Sword360Slash s2 = new Sword360Slash();
                List<Skill> tmp = new List<Skill>();
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1);
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)];
            }
            else if (known.decoratedSkill == null)
            {
               
                JumpCutDecorator s1 = new JumpCutDecorator(known);
                Sword360SlashDecorator s2 = new Sword360SlashDecorator(known);
                List<Skill> tmp = new List<Skill>();
              
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1);
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                foreach (Skill skill in playerSkills)
                {
                    if (skill is Sword360Slash) tmp.Remove(s2);
                    if (skill is JumpCut) tmp.Remove(s1);
                }
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)];
            }
            else
                return null;


        }
        private Skill Check(List<Skill> playerSkills)
        {
            foreach(Skill skill in playerSkills)
            {
                if (skill is JumpCut || skill is Sword360Slash  || skill is JumpCutDecorator || skill is Sword360SlashDecorator)
                    return skill;
            }
            return null;
        }
    }
}
