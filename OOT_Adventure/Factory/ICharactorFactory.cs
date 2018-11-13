using System;

namespace OOT_Adventure
{
    public interface ICharactorFactory
    {
        Charactor GetInstance(CharactorEnum type);
    }
}
