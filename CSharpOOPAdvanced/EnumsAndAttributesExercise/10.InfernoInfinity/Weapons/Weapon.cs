using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using _10.InfernoInfinity.Enumerations;
using _10.InfernoInfinity.Gems;

namespace _10.InfernoInfinity.Weapons
{
    class Weapon
    {
        public Weapon(string name, int minDamage, int maxDamage, int sockets, LevelOfRarity levelOfRarity)
        {
            this.Name = name;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.Sockets = sockets;
            this.LevelOfRarity = levelOfRarity;
            this.GemsCollection = new Gem[sockets];
        }

        public string Name { get; set; }

        public int MaxDamage { get; set; }

        public int MinDamage { get; set; }

        public int Sockets { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Vitality { get; set; }

        public LevelOfRarity LevelOfRarity { get; set; }

        public Gem[] GemsCollection { get; set; }

        public void AddGem(Gem Gem, int index)
        {
            if (index >= 0 && index < this.GemsCollection.Length)
            {
                this.GemsCollection[index] = Gem;
                ApplyGemStatistics(Gem);
            }
        }

        private void ApplyGemStatistics(Gem gem)
        {
            this.Strength += gem.StrengthBonus;
            this.Agility += gem.AgilityBonus;
            this.Vitality += gem.VitalityBonus;

            this.MinDamage += gem.StrengthBonus*2;
            this.MaxDamage += gem.StrengthBonus*3;

            this.MinDamage += gem.AgilityBonus;
            this.MaxDamage += gem.AgilityBonus*4;
        }

        public void Remove(int index)
        {
            if ((index >= 0 && index < this.GemsCollection.Length) && this.GemsCollection[index] != null)
            {
                RemoveGemStatistics(this.GemsCollection[index]);

                this.GemsCollection[index] = null;
            }

        }

        private void RemoveGemStatistics(Gem gem)
        {
            this.Strength -= gem.StrengthBonus;
            this.Agility -= gem.AgilityBonus;
            this.Vitality -= gem.VitalityBonus;

            this.MinDamage -= gem.StrengthBonus * 2;
            this.MaxDamage -= gem.StrengthBonus * 3;

            this.MinDamage -= gem.AgilityBonus;
            this.MaxDamage -= gem.AgilityBonus * 4;
        }

        public void Print()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            string weapon = $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
            return weapon;
        }
    }
}
