using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankk
{
    internal class BankCatrd
    {
        private string pan;
        public string PAN { get; }

        private int cvc;
        public int CVC { get; }

        private string expiryDate;
        public string ExpiryDate { get; set; }

        public decimal Balans { get; set; }

        public BankCatrd()
        {
            GenerateRandomPAN();
            GenerateRandomCVC();
            expiryDate = DateTime.Now.AddYears(4).ToString();
            Balans = 0;
        }

        private void GenerateRandomPAN()
        {
            Random rand = new Random();
            string pan = string.Empty;
            for (int i = 1; i < 16; i++)
            {
                pan += rand.Next(0, 10).ToString();
            }
            this.pan = pan;
        }

        private void GenerateRandomCVC()
        {
            Random rand = new Random();
            cvc = rand.Next(100, 1000);
        }

        public override string ToString()
        {
            return 
$@"
PAN: {PAN}
CVC: {CVC};
Expiry Date: {ExpiryDate}
";
        }
    }
}
