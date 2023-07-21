using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes.Lenguajes
{
    public static class LenguageBuilder
    {

        public static Lenguaje getLenguage(LenguageEnum lenguage)
        {
            switch (lenguage)
            {
                case(LenguageEnum.Castellano): return new Castellano();
                case(LenguageEnum.Ingles): return new English();
                case(LenguageEnum.Italiano): return new Italiano();

                default: throw new Exception("Lenguage not added");
            }
        }

        public static Lenguaje getLenguage(int lenguage)
        {
            return getLenguage((LenguageEnum)lenguage);
        }
    }
}
