using System;

namespace WorkingWithNUlls
{
    public class Player
    {
        private readonly SpecialDefence _specialDefence;

        public Player(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public int Health { get; set; } = 100;
        public int? LastLogin { get; set; }
        public string Name { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public void Hit(int damage)
        {
            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);
            Health -= totalDamageTaken;
            Console.WriteLine($"{Name} Health has beed reduced by {totalDamageTaken} to  {Health}");
        }
    }
}