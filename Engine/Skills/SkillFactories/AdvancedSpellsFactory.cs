using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.CharacterClasses;
using Game.Engine.Skills.AdvancedSpells;


namespace Game.Engine.Skills.SkillFactories
{
    class AdvancedSpellsFactory:SkillFactory
    {
        public Skill CreateSkill(Player player)
        {
            List<Skill> playerSkills = player.ListOfSkills;
            Skill known = CheckContent(playerSkills);
            List<Skill> tmp = new List<Skill>();
            if (known == null)
            {
                EarthQuake s1 = new EarthQuake();
                Tsunami s2 = new Tsunami();
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1);
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)];
            }
            else if (known.decoratedSkill == null)
            {
                EarthQuakeDecorator s1 = new EarthQuakeDecorator(known);
                TsunamiDecorator s2 = new TsunamiDecorator(known);
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1);
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (playerSkills[0] is EarthQuake) tmp.Remove(s1);
                if (playerSkills[0] is Tsunami) tmp.Remove(s2);
                if (tmp.Count == 0) return null;

                return tmp[Index.RNG(0, tmp.Count)];
            }
            else
                return null;
        }
        private Skill CheckContent(List<Skill> skills)
        {
            foreach(Skill skill in skills)
            {
                if (skill is Tsunami || skill is EarthQuake || skill is TsunamiDecorator || skill is EarthQuakeDecorator)
                    return skill;
            }
            return null;
        }
    }
}
