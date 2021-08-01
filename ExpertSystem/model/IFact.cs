using System;

namespace ExpertSystem
{
    interface IFact
    {
        String Name();
        Object Value();
        int Level();
        String Question();

        void SetLevel(int p);
    }
}
