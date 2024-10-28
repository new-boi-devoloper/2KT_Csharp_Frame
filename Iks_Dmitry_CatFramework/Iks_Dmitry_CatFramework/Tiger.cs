using System.Numerics;

namespace Iks_Dmitry_CatFramework
{
    public class Tiger<TWeight, TFluffiness> : Cat
        where TWeight : INumber<TWeight>
        where TFluffiness : INumber<TFluffiness>
    {

        public override int Fluffiness => _fluff;
        public double Weight => _weight;

        private double _weight = 50;
        private int _fluff;

        public Tiger(double weight, int fluffiness)
        {
            if (weight < 75.0 || weight > 140.0)
            {
                throw new CatException($"Unable to create a tiger with weight: {weight}");
            }

            if (fluffiness < 0 || fluffiness > 100)
            {
                throw new CatException($"Unable to create a tiger with fluffiness: {fluffiness}");
            }


            _weight = weight;
            _fluff = fluffiness;
        }

        public override string FluffinessCheck()
        {
            return "Kycb!";
        }

        public override string ToString()
        {
            return $"A tiger with _weight: {Weight} _fluff: {Fluffiness}";
        }

    }
}
