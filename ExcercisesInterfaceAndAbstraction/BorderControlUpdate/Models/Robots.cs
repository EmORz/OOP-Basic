using BorderControlUpdate.Contracts;

namespace BorderControlUpdate.Models
{
    public class Robots : IIdentifable
    {
        private string id;
        private string model;

        public Robots(string id, string model)
        {
            this.Id = id;
            this.Model = model;
        }

        public string Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
    }
}
