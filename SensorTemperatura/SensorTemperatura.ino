//Sensor de Temperatura
// analogRead - 0 -1023
// 0-5000 [mV]
// LM35   10 [mV/°C]
//T=5000[mV]*analogRead()/10[mV/°C]/1023 
const int AnalogIn=0;
int Temperatura;

void setup() {
  Serial.begin(9600);
}
void loop() {
  Temperatura=500*analogRead(AnalogIn)/1023;
  Serial.write(Temperatura);
  //Serial.println(Temperatura);
  delay(1000);
}
