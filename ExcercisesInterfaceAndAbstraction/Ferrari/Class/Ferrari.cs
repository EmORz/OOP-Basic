using Ferrari;

namespace FerrariN
{

    public class Ferrari : ICar
    {

        private const string currentModel = "488-Spider";

        public Ferrari(string driver )
        {
            this.Driver = driver;
            this.Model = currentModel;
        }

        public string Model { get; set; }
        public string Driver { get; set; }

        public string Brakes()
        {
            return "Brakes!";
        }
        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            string temp = $"{this.Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}";
            return temp;
        }
    }
}
