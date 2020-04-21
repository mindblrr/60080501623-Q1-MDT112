using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            void setup()
            {
                Serial.begin(9600);  
                pinMode(2, INPUT_PULLUP);
                pinMode(3, OUTPUT);
                pinMode(4, OUTPUT);
                pinMode(5, OUTPUT);
                pinMode(6, OUTPUT);
                pinMode(7, OUTPUT);
                pinMode(9, OUTPUT);
                pinMode(10, OUTPUT);
                pinMode(11, OUTPUT);
                pinMode(12, OUTPUT);
                pinMode(13, OUTPUT);
                tone(8, 200, 500);  
                delay(250);        
                tone(8, 400, 100);    
            }
        }
    }
}
