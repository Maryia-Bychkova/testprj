using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    internal class Triangle
    {
        private int _firstSide;
        private int _secondSide;
        private int _thirdSide;

        public int FirstSide 
        {
            get => _firstSide;
            set
            {
                _firstSide = value;
                CheckForZero(_firstSide);
                if (AllSidesAreEntered())
                {
                    if (value > _secondSide + _thirdSide)
                    {
                        throw new InvalidSideLenght($"One side should be longer than two anothers, {value}");
                    }
                }
            }
        }

        public int SecondSide
        {
            get => _secondSide;
            set
            {
                _secondSide = value;
                CheckForZero(_secondSide);
                if (AllSidesAreEntered())
                {
                    if (_secondSide > _firstSide + _thirdSide)
                    {
                        throw new InvalidSideLenght($"One side should be longer than two anothers, {value}");
                    }
                }

            }
        }
        public int ThirdSide
        {
            get => _thirdSide;
            set
            {
                _thirdSide = value;
                CheckForZero(_thirdSide);
                if (AllSidesAreEntered())
                {
                    if (_thirdSide > _secondSide + _firstSide)
                    {
                        throw new InvalidSideLenght($"One side should be longer than two anothers, {value}");
                    }
                }
            }
        }

        bool AllSidesAreEntered()
        {
            var sides = new[] { _firstSide, _secondSide, _thirdSide };

            return sides.All(x => x > 0);
        }

        void CheckForZero(int length)
        {
            if(length <= 0)
            {
                throw new ArgumentException("Triengle side can not be 0");
            }
        }

    }

}
