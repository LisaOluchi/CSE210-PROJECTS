using System;

namespace EternalQuestProgram
{
    class ChecklistGoal : Goal
    {
        protected int _amountCompleted;
        protected int _target;
        protected int _bonus;

        public ChecklistGoal(int target, int bonus)
        {
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"Name: {_shortName}, Description: {_description}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus} points";
        }

        public override string GetStringRepresentation()
        {
            return IsComplete() ? "[X]" : "[ ]";
        }

        public override string GetShortName()
        {
            return _shortName;
        }
    }
}
