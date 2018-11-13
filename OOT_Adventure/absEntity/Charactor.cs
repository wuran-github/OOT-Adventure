using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOT_Adventure
{
    public abstract class Charactor : IEntity
    {
        //要执行的任务
        protected Quest quest;
        protected decimal successRate;
        protected string description;
        public string GetDesc()
        {
            return description;
        }

        public decimal GetSuccessRate()
        {
            return successRate;
        }
        public virtual SetQuest(Quest quest){
            this.quest=quest;
        }
        public virtual ExecuteQest(){
            
        }
    }
}
