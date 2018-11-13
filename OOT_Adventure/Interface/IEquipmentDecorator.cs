using System;

namespace OOT_Adventure
{
    public interface IEquipmentDecorator:IEntity
    {
        void SetEntity(IEntity entity);
    }
}
