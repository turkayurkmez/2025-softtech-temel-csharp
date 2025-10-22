using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Weapon
    {
        //Genel silah sınıfı....
        public int Damage { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Düşmana {this.GetType().Name} ile saldırıldı ve {Damage} puan zarar verildi");
        }
        public virtual void ChangePosition()
        {
            //görsel bir operasyon....
            Console.WriteLine("Pozisyon değişti");
        }
    }

    public class Gun: Weapon
    {
        public int BulletCount { get; set; }
        public int MaxAmmo { get; set; }

        public int Distance { get; set; }

        public void ReloadAmmo()
        {
            Console.WriteLine("Şarjör değiştirildi");
        }
    }

    public class Rifle: Gun
    {
        public bool IsZoomable { get; set; }
    }

    public class Knife: Weapon
    {
        public string Vendor { get; set; }

    }

    public class AK47: Rifle
    {
        public AK47()
        {
            MaxAmmo = 50;  
        }

        public override void ChangePosition()
        {
            Console.WriteLine("AK47 omuza dayanarak destek alındı");
        }

    }

    public class Pistol : Gun
    {
        public bool IsSilencer { get; set; }
    }

    public class Glock18 : Pistol
    {
        public Glock18()
        {
            Weight = 120;
            Damage = 30;
            Price = 5;
        }
        public bool BurstFireEnabled { get; set; }
        public override void ChangePosition()
        {
            if (BurstFireEnabled)
            {
                Console.WriteLine("Nişan alındı ve seri atış ile ateş edildi");
            }
        }
    }
}
