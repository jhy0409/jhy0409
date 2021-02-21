// 1. LED ON -  0. OFF
// 2. BUZZER    3. SERVO

#define LED 13
#define MEL 8
#define SRV 2

#define DO1   262 // 4옥타브 도
#define RE    294 // 레
#define MI    330 // 미
#define FA    349
#define SOL   392
#define LA    440
#define SI    494
#define DO2   523
#define DELAY 300
const int hakGyo[] =  {SOL, SOL, LA, LA, SOL, SOL, MI, SOL, SOL,
                       MI, MI, RE, SOL, SOL, LA, LA, SOL, SOL, MI, SOL, MI, RE, MI, DO1
                      };

// 객체 import
#include <Servo.h>
Servo myservo;
int pos = 0;
void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  pinMode(MEL, OUTPUT);

  myservo.attach(SRV);
}

void loop() {
  controlSystem();
}

void controlSystem() {
  if (Serial.available()) {
    char ch = Serial.read();
    if (ch == '1') {
      digitalWrite(LED, HIGH);
      Serial.println("LED ON");
    } else if (ch == '0') {
      digitalWrite(LED, LOW);
      Serial.println("LED OFF");
    } else if (ch == '2') {
      Serial.println("BUZZER");
      digitalWrite(MEL, HIGH);
      musicStart();
      digitalWrite(MEL, LOW);
    } else if (ch == '3') {
      digitalWrite(SRV, HIGH);
      Serial.println("SERVO");

      for (pos = 0; pos <= 180; pos += 1) {
        myservo.write(pos);
        delay(15);
      }
      for (pos = 180; pos >= 0; pos -= 1) {
        myservo.write(pos);
        delay(15);
      }
    }
  }
}
void musicStart() {
  for (int i = 0; i < sizeof(hakGyo) / sizeof(int); i++) {
    tone(MEL, hakGyo[i], 300);
    delay(DELAY);
  }
}
