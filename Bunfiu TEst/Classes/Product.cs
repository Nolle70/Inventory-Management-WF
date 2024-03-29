﻿using System;

namespace Inventory_App
{
    public class Product : Classes.GenerateId
    {
        public string Namn { get; set; }

        public double pris;

        public long kvantitet;
        public Categories Kategori { get; set; }
        public int Sålda { get; set; }

        public double Pris //Ser till att priset inte sätts till negativt tal
        {
            get { return pris; }

            set
            {
                if (value >= 0)
                {
                    pris = value;
                }
                else
                {
                    throw new ArgumentException("Priset måste vara positivt");
                }
            }

        }
        public long Kvantitet //Ser till att kvantiteten inte sätts till negativt tal
        {
            get { return kvantitet; }

            set
            {
                if (value >= 0)
                {
                    kvantitet = value;
                }
                else
                {
                    throw new ArgumentException("Kvantiten måste vara positivt");
                }
            }

        }

        public bool InStock(int quantity)
        {
            if(Kvantitet > quantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
