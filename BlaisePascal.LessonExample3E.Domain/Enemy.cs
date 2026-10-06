namespace BlaisePascal.LessonExample3E.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        // private: campo accessibile solo all'interno della classe Enemy
        // int: tipo di dato intero
        // health: nome dell attributo che rappresenta la salute del nemico
        private int _health;

        public int Health { get; private set; }

        // proprietà
        //public int Health
        //{
        //    get { return _health; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _health = 0;
        //        }
        //        else if (value > MaxHealth)
        //        {
        //            value = MaxHealth;

        //        }
        //        else
        //        {
        //            _health = value;
        //        }
        //    }
        //}

        public void setHealth(int newHealth)
        {
            if (newHealth < 0)
            {
                Health = 0;
            }
            else if (newHealth > MaxHealth)
            {
                Health = MaxHealth;
            }
            else
            {
                Health = newHealth;
            }
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                damage = 0;
            }
            setHealth(Health - damage);
        }

        // attributi costanti
        private const int MaxHealth = 100; // costante che rappresenta la salute massima del nemico
        // costruttore
        public Enemy()
        {
         
        }
    }
}
