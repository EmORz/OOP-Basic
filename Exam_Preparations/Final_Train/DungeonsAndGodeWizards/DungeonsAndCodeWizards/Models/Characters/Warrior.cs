using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Characters.Contracts;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Warrior : Character, IAttackable
    {
        private const double health = 100;
        private const double armor = 50;
        private const double abilityPoints = 40;

        public Warrior(string name, Faction faction) 
            : base(name, health, armor, abilityPoints, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            EnsureBothAreAlive(character);
            if (character == this)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }
            if (character.Faction == this.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
            }
            character.TakeDamage(character.AbilityPoints);
        }
    }
}
