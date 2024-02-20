using System;

namespace EternalQuestProgram
{
    class EternalGoal : Goal
    {
        public override void RecordEvent()
        {
            Console.WriteLine("Recording event for Eternal Goal...");
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetailsString()
        {
            return ""; // Add appropriate details here
        }

        public override string GetStringRepresentation()
        {
            return "[ ]";
        }

        public override string GetShortName()
        {
            return _shortName;
        }
    }
}
