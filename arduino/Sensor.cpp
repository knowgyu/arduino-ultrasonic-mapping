#include "Sensor.h"
#include <Arduino.h>

void Sensor::setting(int trig)
{
  pinMode(trig,OUTPUT);
  pinMode(echo,INPUT);

  Trigger();
}

void Sensor::Trigger()
{
  wave_finished = false;

  digitalWrite(trig,LOW);
  delayMicroseconds(2);
  digitalWrite(trig,HIGH);
  delayMicroseconds(10);
  digitalWrite(trig,LOW);
}

double Sensor::send_dist()
{
  if (wave_finished){
  double dist = (pulsein - pulseout) / 58.2;
  Trigger();
  
  return dist;
  }
}

void Sensor::ISR_sensor()
{
  if (digitalRead(echo)==HIGH){
    pulseout = micros();
  }
  
  else{
    pulsein = micros();
    wave_finished = true;
  }
}
