using System;

namespace EternalQuestProgram
{
    abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public void SetShortName(string shortName)
        {
            _shortName = shortName;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public void SetPoints(int points)
        {
            _points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailsString();
        public abstract string GetStringRepresentation();
        public abstract string GetShortName();
    }
}
