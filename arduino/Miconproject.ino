#include "Wiper.h"
#include "Sensor.h"

Wiper wiper;
Sensor sensor;
enum Mode { Mapping, Tracking } mode;
void setup()
{
    Serial.begin(9600);
    wiper.attach(11);
    sensor.setting(3); // 인터럽트핀으로 2혹은 3밖에 못써서 echo는 2번으로 고정
    attachInterrupt(0, ISR1, CHANGE);
    mode = Mapping;
}

void loop()
{
    switch (mode)
    {
        case Mapping:
            wiper.wipe();
            break;
        case Tracking:
            wiper.track();
            break;
    }

    String st1 = String(sensor.send_dist()); // Dist값 string
    String st2 = String(wiper.send_deg()); // 현재 angle(deg단위)값 string

    DataSend(st1, st2);

    delay(100);
}

//외부인터럽트 Sensor.cpp에!
void ISR1()
{
    sensor.ISR_sensor();
}

void DataSend(String dist, String deg)
{
    String sbuff;
    sbuff = String(cSTX) + dist + ':' + deg + String(cETX) + String(cCR) + String(cLF);
    Serial.print(sbuff);
}
