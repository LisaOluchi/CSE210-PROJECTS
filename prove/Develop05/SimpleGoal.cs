using System;

namespace EternalQuestProgram
{
    class SimpleGoal : Goal
    {
        protected bool _isComplete;

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            return $"Name: {_shortName}, Description: {_description}, Points: {_points}, Status: {(IsComplete() ? "Completed" : "Incomplete")}";
        }

        public override string GetStringRepresentation()
        {
            return _isComplete ? "[X]" : "[ ]";
        }

        public override string GetShortName()
        {
            return _shortName;
        }
    }
}
