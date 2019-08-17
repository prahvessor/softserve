using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Fraction
    {
        private int _numerator = 0;
        private int _denominator = 1;

        public Fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }

        public Fraction(int numerators, int denominator)
        {
            _numerator = numerators;

            if (denominator == 0)
            {
                throw new ArgumentException(String.Format("{0} is equal to 0", denominator), "denomenator");
            }
            else
            {
                _denominator = denominator;
            }
        }

        #region values accessors
        public int Nomenator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denomenator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }

        #endregion

        #region Arithmetical

        public static Fraction operator +(Fraction arg1, Fraction arg2)
        {
            Fraction result = new Fraction();
            int nok = NOK(arg1.Denomenator, arg2.Denomenator);
            
            result._numerator = arg1._numerator * Modifier(nok, arg1._denominator) + arg2._numerator * Modifier(nok, arg2._denominator);
            result._denominator = nok;

            return result;
        }

        public static Fraction operator -(Fraction arg1, Fraction arg2)
        {
            Fraction result = new Fraction();
            int nok = NOK(arg1.Denomenator, arg2.Denomenator);

            result._numerator = arg1._numerator * Modifier(nok, arg1._denominator) - arg2._numerator * Modifier(nok, arg2._denominator);
            result._denominator = nok;

            return result;
        }

        public static Fraction operator *(Fraction arg1, Fraction arg2)
        {
            return new Fraction(arg1._numerator * arg2._numerator, arg1._denominator * arg2._denominator);
        }

        public static Fraction operator /(Fraction arg1, Fraction arg2)
        {
            return new Fraction(arg1._numerator * arg2._denominator, arg1._denominator * arg2._numerator);
        }

        #endregion

        #region Logical
        public static bool operator >(Fraction arg1, Fraction arg2)
        {
            Fraction result = new Fraction();
            int nok = NOK(arg1.Denomenator, arg2.Denomenator);

            result._numerator = arg1._numerator * Modifier(nok, arg1._denominator) - arg2._numerator * Modifier(nok, arg2._denominator);
            result._denominator = nok;

            if (result._numerator > 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(Fraction arg1, Fraction arg2)
        {
            Fraction result = new Fraction();
            int nok = NOK(arg1.Denomenator, arg2.Denomenator);

            result._numerator = arg1._numerator * Modifier(nok, arg1._denominator) - arg2._numerator * Modifier(nok, arg2._denominator);
            result._denominator = nok;

            if (result._numerator < 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Fraction arg1, Fraction arg2)
        {
            Fraction result = new Fraction();
            int nok = NOK(arg1.Denomenator, arg2.Denomenator);

            result._numerator = arg1._numerator * Modifier(nok, arg1._denominator) - arg2._numerator * Modifier(nok, arg2._denominator);
            result._denominator = nok;

            if (result._numerator == 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Fraction arg1, Fraction arg2)
        {
            Fraction result = new Fraction();
            int nok = NOK(arg1.Denomenator, arg2.Denomenator);

            result._numerator = arg1._numerator * Modifier(nok, arg1._denominator) - arg2._numerator * Modifier(nok, arg2._denominator);
            result._denominator = nok;

            if (result._numerator != 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator >=(Fraction arg1, Fraction arg2)
        {
            if (arg1 > arg2 | arg1 == arg2)
            {
                return true;
            }

            return false;
        }

        public static bool operator <=(Fraction arg1, Fraction arg2)
        {
            if (arg1 < arg2 | arg1 == arg2)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region Service function
        private static int NOK(int denominator1, int denominator2)
        {
            int nok = 0;
            for (int i = 0; i < (denominator1 * denominator2 + 1); i++)
            {
                if (i % denominator2 == 0 && i % denominator1 == 0)
                {
                    nok = i;
                    if (i != 0)
                    {
                        break;
                    }
                }
            }
            return nok;
        }

        private static int Modifier(int nok, int denominator)
        {
            return nok / denominator;
        }
        #endregion

        #region Overriden
        public override string ToString()
        {
            return string.Format("{0}/{1}", Nomenator, Denomenator);
        }
        #endregion
    }
}
