using System.Globalization;

namespace AbstractMethodFix.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        public Company()
        {            
        }
        public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }        
        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }        
    }
}