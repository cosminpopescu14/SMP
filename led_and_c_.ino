#define BaudRate 9600
#define led 13
char option;

void setup() {
  // put your setup code here, to run once:
  
  pinMode(led, OUTPUT);
  Serial.begin(BaudRate);

}

void loop() {
  // put your main code here, to run repeatedly:
  option = Serial.read();
  
  switch(option)
  {
    case '1' : digitalWrite(led, HIGH);
      break;
      
     case '0' : digitalWrite(led, LOW);
      break;
    
  }
  

}
