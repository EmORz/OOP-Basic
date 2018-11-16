using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Characters.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Cleric : Character, IHealable
    {
        private const double health = 50;
        private const double armor = 25;
        private const double abilityPoints = 40;

        public override double RestHealMultiplier => 0.5;
        public Cleric(string name, Faction faction)
            : base(name, health, armor, abilityPoints, new Backpack(), faction)
        {
        }

        public void Heal(Character character)
        {
            EnsureBothAreAlive(character);
            if (character.Faction !=this.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }
            character.Health += this.AbilityPoints;
        }
    }
}
