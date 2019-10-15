using System;
using Newtonsoft.Json;

namespace SilverBullet
{
    public class Silver
    {
        private readonly Bullet _bullet;

        public Silver(Bullet bullet)
        {
            _bullet = bullet;
        }

        public string Shoot(object something)
        {
            return JsonConvert.SerializeObject(something);
        }
    }
}