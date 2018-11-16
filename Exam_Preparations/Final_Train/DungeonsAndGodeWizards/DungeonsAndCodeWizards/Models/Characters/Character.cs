using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public abstract class Character
    {
        /*
•	IsAlive – boolean value (default value: True)
*/

        private const double defaultRestHealtMulti = 0.2;
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        private Bag bag;
        private Faction faction;
        private double restHealMultiplier;
        private bool isAlive;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;

            this.RestHealMultiplier = defaultRestHealtMulti;
            this.IsAlive = true;
        }

        public bool IsAlive
        {
            get { return isAlive; }
            private set { isAlive = value; }
        }
        public virtual double RestHealMultiplier
        {
            get { return restHealMultiplier; }
            private set { restHealMultiplier = value; }
        }
        public Faction Faction
        {
            get { return faction; }
            private set { faction = value; }
        }
        public Bag Bag
        {
            get { return bag; }
            private set { bag = value; }
        }
        public double AbilityPoints
        {
            get { return abilityPoints; }
            private set { abilityPoints = value; }
        }
        public double Armor
        {
            get { return armor; }
            set
            {
                if (value <= 0)
                {
                    this.armor = 0;
                }
                else if (value > this.BaseArmor)
                {
                    this.armor = this.baseArmor;
                }
                armor = value;
            }
        }
        public double BaseArmor
        {
            get { return baseArmor; }
            private set { baseArmor = value; }
        }
        public double Health
        {
            get { return health; }
            set
            {
                if (value <= 0)
                {
                    this.health = 0;
                    this.IsAlive = false;
                }
                else if (value > this.BaseHealth)
                {
                    this.health = this.baseHealth;
                }
                else
                {
                    health = value;
                }
            }
        }
        public double BaseHealth
        {
            get { return baseHealth; }
            private set { baseHealth = value; }
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }
        //TODO implement methods in Character abstract class

        public void TakeDamage(double hitPoints)
        {
            EnsureIsAlive();
            if (this.Armor-hitPoints>0)
            {
                this.Armor -= hitPoints;
            }
            else
            {
                var remindre = hitPoints - this.Armor;
                this.Health -= remindre;
                this.Armor = 0;
            }
        }
        public void Rest()
        {
            EnsureIsAlive();
            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }
        public void UseItem(Item item)
        {
            EnsureIsAlive();
            item.AffectCharacter(this);
        }
        public void UseItemOn(Item item, Character character)
        {
            EnsureBothAreAlive(character);
            item.AffectCharacter(character);
        }
        public void GiveCharacterItem(Item item, Character character)
        {
            EnsureBothAreAlive(character);
            character.ReceiveItem(item);
        }
        public void ReceiveItem(Item item)
        {
            EnsureIsAlive();
            this.Bag.AddItem(item);
        }

        //Inner methods
        protected void EnsureBothAreAlive(Character character)
        {
            if (!this.IsAlive&& !character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
        protected void EnsureIsAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
    }
}
