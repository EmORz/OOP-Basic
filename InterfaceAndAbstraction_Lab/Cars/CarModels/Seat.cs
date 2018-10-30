using Cars.Interfaces;
using System.Text;

namespace Cars.CarModels
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; private set; }
                           
        public string Color{ get; private set;  }

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
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}")
                .AppendLine(this.Start())
                .AppendLine(this.Stop());
            return sb.ToString();
        }
    }
}
