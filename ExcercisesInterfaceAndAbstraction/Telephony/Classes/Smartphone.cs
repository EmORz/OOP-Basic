using Telephony.Contracts;

namespace Telephony.Classes
{
    public class Smartphone : ISmartphone
    {
        public Smartphone()
        {
            this.Model = "Smartphone";
        }

        public string Model { get; set; }


        public string Browsing(string url)
        {
            if (IsHaveNumInUr(url))
            {
                return $"Browsing: {url}!";
            }
            return "Invalid URL!";
        }

        public string Call(string phoneNumber)
        {
            if (IsNmberValid(phoneNumber))
            {
                return $"Calling... {phoneNumber}";
            }
            return "Invalid number!";
        }
        //Chek for validation => URL => no number || Call => only digits

        private bool IsHaveNumInUr (string inputUrl)
        {
            for (int i = 0; i < inputUrl.Length; i++)
            {
                if (char.IsDigit(inputUrl[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsNmberValid(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
