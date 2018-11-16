using DungeonsAndCodeWizards.Models.Characters;
using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private List<Character> characters;
        private Stack<Item> items;
        private int rounds;

        public DungeonMaster()
        {
            this.characters = new List<Character>();
            this.items = new Stack<Item>();
        }

        public string JoinParty(string[] args)
        {
            var faction = args[0];
            var characterType = args[1];
            var name = args[2];
            Character character;
            if (!Enum.TryParse(faction, out Faction factionResult))
            {
                throw new ArgumentException($"Invalid faction \"{ faction }\"!");
            }
            switch (characterType)
            {
                case "Warrior":
                    character = new Warrior(name, factionResult);
                    break;
                case "Cleric":
                    character = new Cleric(name, factionResult);
                    break;
                default:
                    throw new ArgumentException($"Invalid character type \"{ characterType }\"!");
            }
            this.characters.Add(character);
            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            var itemName = args[0];
            Item item;
            switch (itemName)
            {
                case "ArmorRepairKit":
                    item = new ArmorRepairKit();
                    break;
                case "HealthPotion":
                    item = new HealthPotion();
                    break;
                case "PoisonPotion":
                    item = new PoisonPotion();
                    break;
                default:
                    throw new ArgumentException($"Invalid item \"{itemName}\"!");
            }
            this.items.Push(item);

            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];
            Character character = GetCharacter(characterName);
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }
            var item = this.items.Pop();
            character.Bag.AddItem(item);
            return $"{characterName} picked up {item.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            var characterName = args[0];
            var itemName = args[1];
            Character character = GetCharacter(characterName);
            var item = character.Bag.GetItem(itemName);
            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            var giverName = args[0];
            var receiverName = args[1];
            var itemName = args[2];

            var giver = GetCharacter(giverName);
            var receiver = GetCharacter(receiverName);

            var item = giver.Bag.GetItem(itemName);
            receiver.UseItemOn(item, receiver);


            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            var giverName = args[0];
            var receiverName = args[1];
            var itemName = args[2];


            var giver = GetCharacter(giverName);
            var receiver = GetCharacter(receiverName);

            var item = giver.Bag.GetItem(itemName);
            receiver.ReceiveItem(item);

            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in characters.OrderByDescending(x => x.IsAlive).
                ThenByDescending(x => x.Health))
            {
                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {(character.IsAlive?"Alive": "Dead")}");
            }
            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            var giverCharacterName = args[0];
            var recieverCharacterName = args[1];
            
            var attaker = GetCharacter(giverCharacterName);
            var receiver = GetCharacter(recieverCharacterName);

            if (attaker is Cleric)
            {
                throw new ArgumentException($"{attaker.Name} cannot attack!");
            }
            ((Warrior)(attaker)).Attack(receiver);
            sb.AppendLine(string.Format($"{attaker.Name} attacks {receiver.Name} for {attaker.AbilityPoints} hit points! {receiver.Name} has" +
                $" {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!"));

            if (!receiver.IsAlive)
            {
                sb.AppendLine($"{receiver.Name} is dead!");
            }
            return sb.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {

            var healerName = args[0];
            var healingReceiverName = args[1];

            var giver = GetCharacter(healerName);
            var receiver = GetCharacter(healingReceiverName);

            if (giver is Warrior)
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }
            ((Cleric)(giver)).Heal(receiver);

            return $"{giver.Name} heals {receiver.Name} for {giver.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
        }

        public string EndTurn(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in characters.Where(x => x.IsAlive))
            {
                sb.Append($"{character.Name} rests ({character.Health} => ");
                character.Rest();
                sb.AppendLine($"{character.Health})");
            }
            if (characters.Count(x => x.IsAlive)<=1)
            {
                rounds++;
            }
            return sb.ToString().TrimEnd(); ;
        }

        public bool IsGameOver()
        {
            if (rounds>1)
            {
                return true;

            }
            return false;
        }

        private Character GetCharacter(string characterName)
        {
            var character = this.characters.FirstOrDefault(x => x.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            return character;
        }

    }
}
