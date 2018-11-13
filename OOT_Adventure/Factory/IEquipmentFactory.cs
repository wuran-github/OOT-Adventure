using System;

namespace OOT_Adventure
{
    public interface IEquipmentFactory
    {
        Item GetItem(ItemEnum type);
        Weapon GetWeapon(WeaponEnum type);
    }
}
