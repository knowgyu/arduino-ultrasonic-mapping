#include <Servo.h>
class Wiper
{
    Servo servo; // Servo Library
    int angle; // servo position
    int increment; // increment of angle
    unsigned long prevMillis; // last update of position
    double deg;

    public:
    static char mode;
    void attach(int pin);
    void detach();
    void update();
    double send_deg();
    void wipe();
    void track();
};
