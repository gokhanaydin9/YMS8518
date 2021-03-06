﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class Araba
    {
        public int LastikSayisi { get; set; }
        public int KapiSayisi { get; set; }
        public int HorsePower { get; set; }
        public int Tork { get; set; }
        public int Agirlik { get; set; }
    }

    public class ArabaV2 : Araba
    {
       public bool UcuyorMu { get; set; }

    }

    public class ArabaV3 : ArabaV2
    {
        public bool IsinlaniyorMu { get; set; }
    }

    public class ArabaV4 : ArabaV3
    {
        public bool YoktanVaroluyor { get; set; }
    }

    public class Ferrari : ArabaV2,Drive
    {
        public bool TersUcabiliyorMu { get; set; }

        public void Geri()
        {
            throw new NotImplementedException();
        }

        public void Ileri()
        {
            throw new NotImplementedException();
        }

        public void Sag()
        {
            throw new NotImplementedException();
        }

        public void Sol()
        {
            throw new NotImplementedException();
        }
    }

    public interface Drive
    {
        void Ileri();
        void Geri();
        void Sag();
        void Sol();


    }
}
