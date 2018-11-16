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
            this.storageMaster = new StorageMaster();
            this.IsRunning = true;
        }
        public void Run()
        {
            while (this.IsRunning)
            {

                string line = Console.ReadLine();
                string[] tokens = line.Split();
                var command = tokens[0];
                var result = "";
                try
                {
                    switch (command)
                    {
                        case "AddProduct":
                            result = this.storageMaster.AddProduct(tokens[1], double.Parse(tokens[2]));
                            break;
                        case "RegisterStorage":
                            result = this.storageMaster.RegisterStorage(tokens[1], (tokens[2]));
                            break;
                        case "LoadVehicle":
                            result = this.storageMaster.LoadVehicle(tokens.Skip(1));
                            break;
                        case "SelectVehicle":
                            result = this.storageMaster.SelectVehicle(tokens[1], int.Parse(tokens[2]));
                            break;
                        case "SendVehicleTo":
                            result = this.storageMaster.SendVehicleTo(tokens[1], int.Parse(tokens[2]), tokens[3]);
                            break;
                        case "UnloadVehicle":
                            result = this.storageMaster.UnloadVehicle(tokens[1], int.Parse(tokens[2]));
                            break;
                        case "GetStorageStatus":
                            result = this.storageMaster.GetStorageStatus(tokens[1]);
                            break;
                        case "END":
                            result = this.storageMaster.GetSummary();
                            IsRunning = false;
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    result = $"Error: {ex.Message}";
                }
                Console.WriteLine(result);

            }


        }
    }
}
