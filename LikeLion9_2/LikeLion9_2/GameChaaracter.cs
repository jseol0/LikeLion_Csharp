using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion9_2
{
    public abstract class GameChaaracter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        protected GameChaaracter(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }

        //추상메서드 : 모든 캐릭터가 구현해야하는 기본공격
        public abstract void BasicAttack(GameChaaracter target);

        //추상메서드 : 모든 캐릭터가 구현해야하는 특수공격
        public abstract void SpecialAttack(GameChaaracter target);

        //일반 메서드 : 모든 캐릭터가 공유하는 기능
        public void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - Defense);

            Health = Math.Max(0, Health - actualDamage);

            Console.WriteLine($"{Name}가(이) {actualDamage}의 피해를 받았습니다. 남은체력 : {Health}");
        }
    }
}
