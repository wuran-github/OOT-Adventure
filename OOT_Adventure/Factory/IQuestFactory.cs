using System;

namespace OOT_Adventure
{
    public interface IQuestFactory
    {
        Quest GetInstance(QuestEnum type);
    }
}
