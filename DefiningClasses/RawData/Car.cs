using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string model;
        public Engine engine;
        public List<Tire> tire;
        public Cargo cargo;



        public Car(string model, Engine engine, List<Tire> tire, Cargo cargo)
        {
            this.model = model;
            this.engine = engine;
            this.tire = tire;
            this.cargo = cargo;
        }
    }
}
