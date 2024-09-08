using HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.IntroToDesignPattern.ActionAdventureGame
{
    public abstract class Character
    {
        public WeaponBehavior weaponBehavior { get; set; }

        public void Fight()
        {
            weaponBehavior.UseWeapon();
        }
    }
}
