using System.Numerics;

namespace Iks_Dmitry_CatFramework
{
    public class CuteCat< TFluffiness> : Cat
        where TFluffiness : INumber<TFluffiness>
    {
        public override int Fluffiness => _fluff;

        private int _fluff = 50;

        public CuteCat(int inputFluff)
        {
            if (inputFluff < 0 || inputFluff > 140)
            {
                throw new CatException($"Unable to create a cute cat with fluffiness: {inputFluff}");
            }

            _fluff = inputFluff;
        }

        public override string FluffinessCheck()
        {
            if (_fluff == 0) return "Sphynx";
            if (_fluff <= 20) return "Slightly";
            if (_fluff <= 50) return "Medium";
            if (_fluff <= 75) return "Heavy";
            return "OwO";
        }

        public override string ToString()
        {
            return $"A cute cat with fluffiness: {Fluffiness}";
        }
    }
}
