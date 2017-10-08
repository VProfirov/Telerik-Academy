using System;
using System.ComponentModel.DataAnnotations;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-adapted chemical compound
            ClassToAdapt_Compound unknown = new ClassToAdapt_Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            ClassToAdapt_Compound water = new Adapter_RichCompound("Water");
            water.Display();

            ClassToAdapt_Compound benzene = new Adapter_RichCompound("Benzene");
            benzene.Display();

            ClassToAdapt_Compound ethanol = new Adapter_RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }

    class ClassToAdapt_Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;
        public ClassToAdapt_Compound(string chemical)
        {
            _chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine($"\nCompound:{_chemical} -------");
        }
    }

    class Adapter_RichCompound: ClassToAdapt_Compound
    {
        private Adaptee_ChemicalDatabank _adaptee_bank;
        public Adapter_RichCompound(string adaptedVal):base(adaptedVal){}

        public override void Display()
        {
            _adaptee_bank = new Adaptee_ChemicalDatabank();

            _boilingPoint = _adaptee_bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _adaptee_bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _adaptee_bank.GetMolecularWeight(_chemical);
            _molecularFormula = _adaptee_bank.GetMolecularStructure(_chemical);

            base.Display();
            Console.WriteLine($" Formula:{_molecularFormula}");
            Console.WriteLine($" Weight:{_molecularFormula}");
            Console.WriteLine($" Meling Pt:{_meltingPoint}");
            Console.WriteLine($" Boiling Pt:{_boilingPoint}");
        }
    }

    class Adaptee_ChemicalDatabank
    {
        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            // Boiling Point
            else
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }
    }
}
