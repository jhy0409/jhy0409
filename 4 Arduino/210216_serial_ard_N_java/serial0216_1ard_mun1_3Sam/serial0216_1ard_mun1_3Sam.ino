//c, c++
#define LED 13
#define MELODY 8
#define SERVO 2
#define SERVOS 1
//c#
// const int LED = 13;

#define DO1   262 // 4옥타브 도
#define RE    294 // 레
#define MI    330 // 미
#define FA    349
#define SOL   392
#define LA    440
#define SI    494
#define DO2   523
#define DELAY 300
const int hakGyo[] = {SOL, SOL, LA, LA, SOL, SOL, MI, SOL, SOL,
                      MI, MI, RE, SOL, SOL, LA, LA, SOL, SOL, MI, SOL, MI, RE, MI, DO1
                     };

#include <Servo.h>
Servo myservo;
int pos = 0;
void setup() {
  // 시리얼 통신 속도 (baudrate)
  Serial.begin(9600);
  // LED 출력 설정
  pinMode(LED, OUTPUT);
  pinMode(MELODY, OUTPUT);

  myservo.attach(SERVO);
}

void loop() {
  /*
    // 데이터 송신: 아두이노 -> PC
    Serial.print("온도: 26.5℃");
    Serial.println();
    delay(2000);
  */
  controlSystem();
}

void controlSystem() {
  if (Serial.available()) {
    // ---데이터 수신: PC -> 아두이노
    char ch = Serial.read();
    if (ch == '1') {
      digitalWrite(LED, HIGH);
      // 데이터 송신: 아두이노 -> PC
      Serial.println("LED ON");
    } else if (ch == '0') {
      digitalWrite(LED, LOW);
      Serial.println("LED OFF");


    } else if (ch == '2') {
      // 멜로디 재생
      Serial.println("BUZZER");
      digitalWrite(MELODY, HIGH);
      musicStart();
      delay(300);
      digitalWrite(MELODY, LOW);


    } else if (ch == '3') {
      digitalWrite(SERVO, HIGH);
      Serial.println("SERVO");

      // 서보모터 제어
      for (pos = 0; pos <= 180; pos += 1) { // 0~180도
        myservo.write(pos);
        delay(5);
      }
      for (pos = 180; pos >= 0; pos -= 1) {
        myservo.write(pos);
        delay(5);
      }
    }
  }
}

void musicStart() {
  for (int i = 0; i < sizeof(hakGyo) / sizeof(int); i++) {
    tone(MELODY, hakGyo[i], 300);
    delay(DELAY);
  }
}
