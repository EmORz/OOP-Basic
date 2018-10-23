namespace ClassBox
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width =  double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            //
            try
            {
                Box box = new Box(lenght, width, height);
                var surfaceArea = box.SurfaceArea();
                var surfaceLateral = box.LateralSurface();
                var volume = box.Volume();

                Console.WriteLine($"Surface Area - {surfaceArea:f2}");
                Console.WriteLine($"Lateral Surface Area - {surfaceLateral:f2}");
                Console.WriteLine($"Volume - {volume:f2}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
          
          

        }
    }
}
