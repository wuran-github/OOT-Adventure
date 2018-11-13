using System;

namespace OOT_Adventure
{
    public interface ISkillFactory
    {
        Skill GetInstance(SkillEnum type);
    }
}
