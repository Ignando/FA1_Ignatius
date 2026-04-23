using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalIdentityProcessor
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string name, string idNumber, string citizenship)
        {
            FullName = name;
            IDNumber = idNumber;
            CitizenshipStatus = citizenship;
            Age = CalculateAge();
        }

        private int CalculateAge()
        {
            // Extract YYMMDD from first 6 digits
            // Determine century (19xx or 20xx)
            // Return calculated age
        }

        public string ValidateID()
        {
            // Check length == 13
            // Check all numeric
            // Validate age is reasonable
            // Return validation message
        }
    }
}
