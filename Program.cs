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
tone(8,200,500);
delay(250);
tone(8,400,100);
}
int l = 3;
int c = 1;
int time = 100;
void loop()
{
for(l = 3 ; l <= 13 ; l++) // chasing right
{
if(l == 8)
{
digitalWrite(l,0);
continue;
}
digitalWrite(l,1);
delay(time);
digitalWrite(l,0);
    if (digitalRead(2) == 0) 
    {   
    digitalWrite(l,1);     
    delay(time);          
    digitalWrite(l,0); 
    c = c * 2;
    time = time / 2;
    Serial.println("“Faster X 2 (Current Speed : X"+String(c)+"”)");    //show following
    tone(8,400,100);        // beep sound for 100 milliseconds
    delay(1000);
    } 
}
for(l = 13 ; l >= 3 ; l--) 
{
    if(l == 8)
    {
        digitalWrite(8,0); 
    }
    digitalWrite(l,1);  
    delay(time);  
    digitalWrite(l,0); 

    if(digitalRead(2) == 0)
    {
        c = c * 2;
        time = time / 2;
        Serial.println("“Faster X 2 (Current Speed : X"+String(c)+"”)");  
        tone(8,400,100); 
        delay(1000);
    }
}   
}
