using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2_DI_Samurai
{
    class Samurai
    {
        private IWeapon _weapon;
        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void Attack(string target)
        {
            this._weapon.Hit(target);
        }
    }
}
