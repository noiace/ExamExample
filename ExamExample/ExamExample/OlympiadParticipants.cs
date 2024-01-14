using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamExample
{
    public class OlympiadParticipants : IComparable <OlympiadParticipants>, ICloneable
    {
        private string _initial;
        private int _firstStep;
        private int _secondStep;

        public string Initial { get => _initial; set => _initial = value; }
        public int FirstStep { get => _firstStep; set => _firstStep = value < 0 ? 0 : value > 40 ? 40 : value; }
        public int SecondStep { get => _secondStep; set => _secondStep = value < 0 ? 0 : value > 60 ? 60 : value; }

        public OlympiadParticipants(string initial, int firstStep, int secondStep)
        {
            Initial = initial;
            FirstStep = firstStep;
            SecondStep = secondStep;
        }

        public int Sum()
        {
            return FirstStep + SecondStep;
        }

        public int CompareTo(OlympiadParticipants other)
        {
            if (other ==null)
                return 1;

            return Sum().CompareTo(other.Sum()); 
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
