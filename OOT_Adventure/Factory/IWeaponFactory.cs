using System;

namespace OOT_Adventure
{
    public interface IWeaponFactory
    {
        Weapon GetInstance(WeaponEnum type);
    }
}
