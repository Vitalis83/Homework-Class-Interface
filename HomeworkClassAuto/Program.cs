using System.Xml.Linq;

namespace HomeworkClassAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trans1 = new TransmissionClass() { TransmissionName = "Stock", MaxGear = 4, SpeedOnGear = 20 };
            var trans2 = new TransmissionClass() { TransmissionName = "Great", MaxGear = 5, SpeedOnGear = 30 };
            var trans3 = new TransmissionClass() { TransmissionName = "Max", MaxGear = 6, SpeedOnGear = 40 };

            var engine1 = new EngineClass() { EngineName = "Stock", EngineMaxSpeed = 200 };
            var engine2 = new EngineClass() { EngineName = "Upgrade", EngineMaxSpeed = 300 };

            var carList = new List<CarClass>()
            {
            new CarClass("Accent", engine1, trans1),
            new CarClass("Lamba", engine2, trans2) ,
            new CarClass("Taxi", engine2, trans3 )
            };


            CarClass winner = default;

            foreach (var car in carList)
            {
                if (winner == null)
                { winner = car; }
                else
                    if(car.MaxCarSpeed() > winner.MaxCarSpeed())
                { winner = car; }
            }

            Console.WriteLine($"And the winner is {winner.name} with speed {winner.MaxCarSpeed()}");
            
            
        }
    }
}


/*##Lesson 4 Classes
1.Написать программу которая имитирут работу гоночного трека.
2. Каждая машина должна иметь сменный двигатель и сменную коробку передач.
3. Каждая машина должна иметь общий интерфейс что бы менеджер гонки не думал о деталях каждой машины
4. В конце работы программа должна объявить победителя которым будет являться машина развившая наибольшую скорость.
5. На скорость машины влияет кол-во перед в коробке и мощность двигателя.
6. Программа должна запускать как консольное приложение и иметь возможность задать кол-во машин учавствующих в гонке.*/