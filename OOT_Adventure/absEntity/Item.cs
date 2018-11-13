using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOT_Adventure
{
    public abstract class Item : IEquipmentDecorator
    {
        protected IEntity entity;
        protected decimal successRate;
        protected string description;
        public virtual string GetDesc()
        {
            return entity.GetDesc()+","+description;
        }

        public virtual decimal GetSuccessRate()
        {
            return  entity.GetSuccessRate()*(1+successRate);
        }

        public void SetEntity(IEntity entity)
        {
            this.entity=entity;
        }
    }
}
