using System.Collections.Generic;

namespace P01_RawData
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tire)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tire = tire;
        }
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tire> tire;
    }
}
