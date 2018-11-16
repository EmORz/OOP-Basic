using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Characters.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Warrior : Character, IAttackable
    {
        //100 Base Health, 50 Base Armor, 40 Ability Points, and a Satchel as a bag.
        private const double baseHealth = 100;
        private const double baseArmour = 50;
        private const double baseAbilityPoints = 40;

        public Warrior(string name, Faction faction) 
            : base(name, baseHealth, baseArmour, baseAbilityPoints, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            AreBothLive(character);

            if (this == character)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }
            if (this.Faction == character.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
            }
            character.TakeDamage(character.AbilityPoints);
        }
    }
}
