using System;

namespace ex_AccessModifier
{
    internal class Program
    {
        class WaterHeater {

            protected int temperature;

            public void SetTemperature(int temperature)
            {
                if (temperature < -5 || temperature > 42) {
                    throw new Exception("Out of temperature range");
                }

                this.temperature = temperature;
            }

            internal void TurnOnWater() {
                Console.WriteLine($"Turn on water : {temperature}");
            }
        }

        static void Main(string[] args)
        {

            try
            { 
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /*
            Turn on water : 20
            Turn on water : -2
            Out of temperature range
             
             */


            /*
            접근 제한자
            public : 클래스 내/외부 모든 곳에서 접근 가능
            protected : 클래스 외부에서 접근 x. 파생 클래스에서 접근 가능
            private : 클래스 내부에서 접근 가능. 파생 클래스에서 접근 x
            internal : 같은 어셈블리에 있는 코드에서 public 으로 접근 가능. 다른 어셈블리에 있는 코드는 private과 같은 수준의 접근성 가짐
            protected internal : 같은 어셈블리에 있는 코드에서만 protected로 접근 가능. 다른 어셈블리에 있는 코드는 private과 같은 수준의 접근성 가짐
            private protected : 같은 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근 가능
             */

            /*
            어셈블리
            : .NET에서 컴파일된 코드, 타입 저보(메타데이터), 리소스 등 하나로 묶은 실행 단위
            : CLR이 로드하고 실행할 수 있음
            : 보통 EXE(실행 파일) 또는 DLL(라이브러리) GUDXO

            | 파일                    | 어셈블리? | 이유                          
            | MyApp.exe               | O         | 실행 가능, IL + 메타데이터 포함        
            | MyLibrary.dll           | O         | 참조 가능한 라이브러리, IL + 메타데이터 포함 
            | System.Linq.dll         | O         | .NET 라이브러리 어셈블리             
            | appsettings.json        | X         | 단순 데이터/설정 파일, CLR이 실행하지 않음  
            | readme.txt / logo.png   | X         | 단순 리소스 파일, CLR이 실행하지 않음     
            | .cs 파일                | X         | 소스 코드, 아직 컴파일되지 않음          

             */
        }
    }
}
