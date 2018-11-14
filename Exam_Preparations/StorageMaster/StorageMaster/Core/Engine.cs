using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class Engine
    {
        private StorageMaster storageMaster;
        private bool IsRunning;

        public Engine(StorageMaster storageMaster)
        {
            this.storageMaster = storageMaster;
            IsRunning = false;
        }

        public void Run()
        {
            IsRunning = true;

            while (IsRunning)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();

                var command = tokens[0];
                var output = "";
                try
                {
                    switch (command)
                    {
                        case "AddProduct":
                            var typeProduct = tokens[1];
                            var priceProduct = double.Parse(tokens[2]);
                            output = this.storageMaster.AddProduct(typeProduct, priceProduct);
                            break;
                        case "RegisterStorage":
                            var type = tokens[1];
                            var name = (tokens[2]);
                            output = this.storageMaster.RegisterStorage(type, name);
                            break;
                        case "LoadVehicle":
                            output = this.storageMaster.LoadVehicle(tokens.Skip(1));
                            break;
                        case "SelectVehicle":
                            output = this.storageMaster.SelectVehicle(tokens[1], int.Parse(tokens[2]));
                            break;
                        case "SendVehicleTo":
                            output = this.storageMaster.SendVehicleTo(tokens[1], int.Parse(tokens[2]), tokens[3]);
                            break;
                        case "UnloadVehicle":
                            output = this.storageMaster.UnloadVehicle(tokens[1], int.Parse(tokens[2]));
                            break;
                        case "GetStorageStatus":
                            output = this.storageMaster.GetStorageStatus(tokens[1]);
                            break;
                        case "END":
                            output = this.storageMaster.GetSummary();
                            IsRunning = false;
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    output = $"Error: {ex.Message}"; 
                }               

                Console.WriteLine(output);
            }
        }
    }
}
