using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroRepository;

        public HeroRepository()
        {
            heroRepository = new List<Hero>();
        }

        public int Count
        {
            get
            {
                return heroRepository.Count;
            }
        }

        public void Add(Hero hero) 
        {
            heroRepository.Add(hero);
        }

        public void Remove(string name) 
        {
            if (heroRepository.Count>0)
            {
                foreach (var hero in heroRepository)
                {

                    if (hero.Name == name)
                    {
                        heroRepository.Remove(hero); break;

                    }
                }
            }

        }

        public Hero GetHeroWithHighestStrength() 
        { 
           var highestLenghtHero = heroRepository.OrderByDescending(l => l.Item.Strenght).FirstOrDefault();

            return highestLenghtHero;
        }

        public Hero GetHeroWithHighestAbility() 
        {
            var highestAbilityHero = heroRepository.OrderByDescending(l => l.Item.Ability).FirstOrDefault();
            return highestAbilityHero;
        }

        public Hero GetHeroWithHighestIntelligence() 
        {
            var highestIntelligenceHero = heroRepository.OrderByDescending(l => l.Item.Intelligence).FirstOrDefault();
            return highestIntelligenceHero;

        }

        public override string ToString()
        {
            StringBuilder printHeroes = new StringBuilder();

            foreach (var hero in heroRepository)
            {
                printHeroes.AppendLine(hero.ToString());
            }

         return printHeroes.ToString().Trim();
        }




    }
}
