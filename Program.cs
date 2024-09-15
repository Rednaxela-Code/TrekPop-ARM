using System.Device.Gpio;

class Program
{
    static void Main(string[] args)
    {
        // Definieer de pin die je wilt gebruiken
        int relaisPin1 = 17;
        int relaisPin2 = 27;
        int relaisPin3 = 22;
        int relaisPin4 = 23;
        int relaisPin5 = 24;
        int relaisPin6 = 25;
        int relaisPin7 = 16;
        int relaisPin8 = 26;

        int switchPin1 = 17;

        bool isRunning = true;

        // Maak een nieuwe GPIOController aan
        using (GpioController controller = new GpioController())
        {
            // Stel de pin in als output
            controller.OpenPin(relaisPin1, PinMode.Output);
            controller.OpenPin(relaisPin2, PinMode.Output);
            controller.OpenPin(relaisPin3, PinMode.Output);
            controller.OpenPin(relaisPin4, PinMode.Output);
            controller.OpenPin(relaisPin5, PinMode.Output);
            controller.OpenPin(relaisPin6, PinMode.Output);
            controller.OpenPin(relaisPin7, PinMode.Output);
            controller.OpenPin(relaisPin8, PinMode.Output);
            // hoe is sdit
            controller.OpenPin(switchPin1, PinMode.InputPullDown);
            while (isRunning)
            {
                if (controller.Read(switchPin1) == PinValue.High)
                {
                    controller.Write(relaisPin3, PinValue.High);
                }
                else if (controller.Read(switchPin1) == PinValue.Low)
                {
                    controller.Write(relaisPin3, PinValue.Low);
                }
            }


            // // Zet de pin hoog (relais aan)
            // controller.Write(relaisPin1, PinValue.High);
            // Console.WriteLine("Relais is ingeschakeld.");
            // Thread.Sleep(1000);
            // controller.Write(relaisPin2, PinValue.High);
            // Console.WriteLine("Relais is ingeschakeld.");
            // Thread.Sleep(1000);
            // controller.Write(relaisPin3, PinValue.High);
            // Console.WriteLine("Relais is ingeschakeld.");
            // Thread.Sleep(1000);
            // controller.Write(relaisPin4, PinValue.High);
            // Console.WriteLine("Relais is ingeschakeld.");
            // Thread.Sleep(1000);
            // controller.Write(relaisPin5, PinValue.High);
            // Console.WriteLine("Relais is ingeschakeld.");
            // Thread.Sleep(1000);
            // controller.Write(relaisPin6, PinValue.High);
            // Console.WriteLine("Relais is ingeschakeld.");
            // Thread.Sleep(1000);
            // controller.Write(relaisPin7, PinValue.High);
            // Console.WriteLine("Relais is ingeschakeld.");
            // Thread.Sleep(1000);
            // controller.Write(relaisPin8, PinValue.High);
            // Console.WriteLine("Relais is ingeschakeld.");
            // Thread.Sleep(1000);

            // // Wacht 5 seconden
            // Thread.Sleep(5000);

            // // Zet de pin laag (relais uit)
            // controller.Write(relaisPin1, PinValue.Low);
            // controller.Write(relaisPin2, PinValue.Low);
            // controller.Write(relaisPin3, PinValue.Low);
            // controller.Write(relaisPin4, PinValue.Low);
            // controller.Write(relaisPin5, PinValue.Low);
            // controller.Write(relaisPin6, PinValue.Low);
            // controller.Write(relaisPin7, PinValue.Low);
            // controller.Write(relaisPin8, PinValue.Low);
            // Console.WriteLine("Relais zijn uitgeschakeld.");

            // // Sluit de pin
            // controller.ClosePin(relaisPin1);
            // controller.ClosePin(relaisPin2);
            // controller.ClosePin(relaisPin3);
            // controller.ClosePin(relaisPin4);
            // controller.ClosePin(relaisPin5);
            // controller.ClosePin(relaisPin6);
            // controller.ClosePin(relaisPin7);
            // controller.ClosePin(relaisPin8);
        }

        Console.WriteLine("GPIO-opruiming voltooid.");
    }
}

public class Motor
{

}
