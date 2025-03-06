using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LikeLion9_2
{
    public class Warrior : GameChaaracter
    {
        public Warrior(string name) : base(name, 100, 15, 10)
        {
        }

        public override void BasicAttack(GameChaaracter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 기본 공격을 시도합니다.");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameChaaracter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 휠윈드를 시전합니다.");
            target.TakeDamage(Attack * 2);
        }
    }
}
