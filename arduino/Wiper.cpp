#include "Wiper.h"
#include <Arduino.h>


void Wiper::attach(int pin)
{
    servo.attach(pin);
    increment = 1;
    angle = 0;
    deg = 0;
}
void Wiper::detach()
{
    servo.detach();
}
void Wiper::wipe(){
  angle += increment;
  servo.write(angle);
  if ((angle>=180 || angle<=0))
  {
    increment = -increment;
  }

}
void Wiper::track(){
  
}
double Wiper::send_deg(){
  return double(angle);
}
