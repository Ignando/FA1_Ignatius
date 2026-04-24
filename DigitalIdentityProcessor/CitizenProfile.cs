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
            if (string.IsNullOrWhiteSpace(IDNumber) || IDNumber.Length < 6 || !IDNumber.Take(6).All(char.IsDigit))
            {
                return -1;
            }

            var year = int.Parse(IDNumber[..2]);
            var month = int.Parse(IDNumber.Substring(2, 2));
            var day = int.Parse(IDNumber.Substring(4, 2));

            var currentYear = DateTime.Today.Year % 100;
            var century = year <= currentYear ? 2000 : 1900;

            try
            {
                var birthDate = new DateTime(century + year, month, day);
                var age = DateTime.Today.Year - birthDate.Year;

                if (birthDate.Date > DateTime.Today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
            catch
            {
                return -1;
            }
        }

        public string ValidateID()
        {
            if (string.IsNullOrWhiteSpace(IDNumber))
            {
                return "Invalid ID: number is required.";
            }

            if (IDNumber.Length != 13)
            {
                return "Invalid ID: South African IDs must contain 13 digits.";
            }

            if (!IDNumber.All(char.IsDigit))
            {
                return "Invalid ID: only numeric characters are allowed.";
            }

            if (Age < 0 || Age > 130)
            {
                return "Invalid ID: embedded birth date is not valid.";
            }

            if (string.IsNullOrWhiteSpace(CitizenshipStatus))
            {
                return "Invalid profile: citizenship status is required.";
            }

            return $"Valid ID profile. Citizen age verified as {Age}.";
        }
    }
}
