
const int pinT = 12;
void setup() {
  Serial.begin(9600);
  pinMode(pinT,OUTPUT);
  pinMode(13,OUTPUT);
}

int val;
int ref = 500;
int tol = 30;
float umid;
int reading=0;
float sumaTemp=0;
int N = 10;
int ref1=0;
unsigned long t0=0,t1=0;

void loop() {
  if(Serial.available())
  {
    ref1 = Serial.parseInt();
    if(ref1!=0)
      ref=ref1;
    Serial.print("ref: ");
    Serial.println(ref);
    delay(200);
  }

    t1 = millis();
    if(t1 - t0 > 100)
    {
        umid = 1023 - analogRead(A0);
        
        Serial.println(umid);
        if(umid < ref - tol)
        {
          digitalWrite(pinT,HIGH);
          digitalWrite(13,HIGH);
        }  
        if(umid > ref + tol)
        {
          digitalWrite(pinT,LOW);
          digitalWrite(13,LOW);
        }
       t0 = millis(); 
    }
}


