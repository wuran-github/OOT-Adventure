using System;

namespace OOT_Adventure
{
    public interface IItemFactory
    {
        Item GetInstance(ItemEnum type);
    }
}
