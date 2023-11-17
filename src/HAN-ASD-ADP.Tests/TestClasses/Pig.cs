using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Reflection.Metadata;

namespace HAN_ASD_ADP.Tests.TestClasses
{
    public class Pig
    {
        public string TattooNumber { get; }
        private int[] DNA { get; set; }

        public Pig(string tattooNumber, int[] dNA)
        {
            TattooNumber = tattooNumber;
            DNA = dNA;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Pig);
        }

        public bool Equals(Pig other, int relationship = 80)
        {
            if (other is null)
            {
                return false;
            }
            if (other.TattooNumber == TattooNumber)
            {
                return true;
            }

            // See how similar the pigs DNA is compared to the other Pig by checking the value in DNA at the same position of the array
            // If amount of simimlarities breaches the desired relationship value the return true
            int similarities = 0;
            int availableDnaPositions = Math.Min(DNA.Length, other.DNA.Length);
            for (int i = 0; i < availableDnaPositions; i++)
            {
                if (DNA[i] == other.DNA[i])
                {
                    similarities++;
                    if(similarities >= relationship)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
