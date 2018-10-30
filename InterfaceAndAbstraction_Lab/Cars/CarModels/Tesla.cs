using Cars.Interfaces;
using System.Text;

namespace Cars.CarModels
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }
        public string Model
        {
            get; private set;
        }
        public string Color { get; private set; }
        public int Battery
        {
            get; private set;
        }

        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaak!";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries")
                .AppendLine(Start())
                .AppendLine(Stop());
            return sb.ToString();
        }
    }
}
