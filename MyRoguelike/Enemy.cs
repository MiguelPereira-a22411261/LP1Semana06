using System;

namespace MyRoguelike
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        static int pwrupCount;
        
        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public static int GetPowerUpCount()
        {
            return pwrupCount;
        }
        public string SetName()
        {
            string scndname = Console.ReadLine();
            name = scndname;
            return name;

        }
        
        public void PickupPowerUp(PowerUp powerUp, float powerVal)
        {
            if (powerUp == PowerUp.Health)
            {
                health += powerVal;
                if (health > 100) health = 100;
                Console.WriteLine("Health: " + health);
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += powerVal;
                if (shield > 100) shield = 100;
                Console.WriteLine("Shield: " + shield);
            }
            pwrupCount++;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
    }
}