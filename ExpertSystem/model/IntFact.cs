using System;

namespace ExpertSystem.model
{
    class IntFact : IFact
    {
        protected String name;
        protected int value;
        protected int level = 0;
        protected String question = null;

        public IntFact(String _name, int _value, String _question, int _level)
        {
            name = _name;
            value = _value;
            question = _question;
            level = _level;
        }

        public String Name()
        {
            return name;
        }

        public object Value()
        {
            return value;
        }

        public int Level()
        {
            return level;
        }

        public void SetLevel(int _level)
        {
            level = _level;
        }

        public string Question()
        {
            return question;
        }

        public override string ToString()
        {
            return name + "=" + value + " (" + level + ")";
        }
    }
}
