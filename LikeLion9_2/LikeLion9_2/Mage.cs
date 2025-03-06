using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion9_2
{
    public class Mage : GameChaaracter
    {
        public Mage(string name) : base(name, 80, 20, 5)
        { 
        }

        public override void BasicAttack(GameChaaracter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 마법 구체를 던집니다.");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameChaaracter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 화염 폭발을 시전합니다.");
            target.TakeDamage(Attack * 2);
        }
    }
}
