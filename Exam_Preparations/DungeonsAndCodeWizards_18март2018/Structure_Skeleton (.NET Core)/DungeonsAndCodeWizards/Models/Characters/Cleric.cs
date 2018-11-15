using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Characters.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Cleric : Character, IHealable
    {
        private const double baseHealth = 50;
        private const double baseArmour = 25;
        private const double baseAbility = 40;

        public Cleric(string name, Faction faction) 
            : base(name, baseHealth, baseArmour, baseAbility, new Backpack(), faction)
        {
        }
        public override double RestHealMultiplier => 0.5;
        public void Heal(Character character)
        {
            AreBothLive(character);
            if (character.Faction != this.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }
            character.Health += this.AbilityPoints;
        }
    }
}
