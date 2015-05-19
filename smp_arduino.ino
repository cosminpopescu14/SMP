

void setup()
{
  Serial.begin(9600);
  //pinMode(13, OUTPUT);//scop de test
  int pompa_pin = A3;
}


void loop()
{
  byte val_umiditate_dorita = 0;//valoarea umiditatii citita de pe seriala
  int val_senzor_necalibrat;//umiditatea citita de  senzor
  int val_senzor_calibrat;
  
  val_senzor_necalibrat = analogRead(A0);
  val_senzor_calibrat = 1023 - val_senzor_calibrat;
  
  Serial.println(val_senzor_calibrat);//scop de testare
  
  if(Serial.available())//verific daca seriala este disponibila
  {
    val_umiditate_dorita = Serial.read();//citesc valoarea de pe seriala
        
        if(val_senzor_calibrat < val_umiditate_dorita)
        {
          //instructiuni pt pornirea pomplei
          digitalWrite(A3, HIGH);
          
        }
        
        if(val_senzor_calibrat > val_umiditate_dorita)
        {
          //comnada releu bec
          digitalWrite(A3, LOW);
        }
  }
  
  delay(1550);
}
