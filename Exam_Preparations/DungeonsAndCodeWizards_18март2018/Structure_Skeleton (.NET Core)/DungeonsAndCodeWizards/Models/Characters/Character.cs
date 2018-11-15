using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public abstract class Character
    {
        private const double defaultRestHealMultiplier = 0.2;
       
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private Bag bag;
        private Faction faction;
        private double restHealMultiplier;
        private bool isAlive;
        private double abilityPoints;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;

            this.IsAlive = true;
            this.RestHealMultiplier = defaultRestHealMultiplier;
        }

        public virtual double RestHealMultiplier
        {
            get { return restHealMultiplier; }
            private set { restHealMultiplier = value; }
        }

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
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
                if (value > this.BaseArmor)
                {
                    this.armor = this.baseArmor;
                }
                else if (value < 0)
                {
                    this.armor = 0;
                }
                else
                {
                    armor = value;
                }
            }
        }

        public double BaseArmor
        {
            get { return baseArmor; }
            private set
            {
                baseArmor = value;
            }
        }

        public double Health
        {
            get { return health; }
            set
            {
                if (value > this.BaseHealth)
                {
                    this.health = this.baseHealth;
                }
                else if (value <= 0)
                {
                    this.health = 0;
                    this.IsAlive = false;
                }
                else
                {
                    this.health = value;
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

        //Methods



        public void GiveCharacterItem(Item item, Character character)
        {
            AreBothLive(character);
            character.ReceiveItem(item);

        }

        public void ReceiveItem(Item item)
        {
            InsureIsLive();
            this.Bag.AddItem(item);
        }
        public void UseItemOn(Item item, Character character)
        {
            AreBothLive(character);
            item.AffectCharacter(character);
        }
        public void UseItem(Item item)
        {
            InsureIsLive();
            item.AffectCharacter(this);
        }

        protected void AreBothLive(Character character)
        {
            if (!character.IsAlive || !this.isAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        public void Rest()
        {
            InsureIsLive();
            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }


        public void TakeDamage(double hitPoints)
        {
            InsureIsLive();
            if (this.Armor - hitPoints >= 0)
            {
                this.Armor -= hitPoints;
            }
            else
            {
                var reminder = hitPoints - this.Armor;
                this.Armor = 0;
                this.Health -= reminder;
            }

        }

        protected void InsureIsLive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
    }
}
