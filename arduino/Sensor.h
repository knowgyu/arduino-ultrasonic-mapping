const char cSTX=2,cETX=3, cCR=13,cLF=10;
#define echo 2 // echo



class Sensor{
  int trig=3;
  bool wave_finished = true;
  unsigned int pulsein = 0,pulseout = 0;
  void Trigger();
  public:
  void setting(int trig);
  double send_dist();
  void ISR_sensor();
  
};
