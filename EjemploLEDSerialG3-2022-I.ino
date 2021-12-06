//Ejemplo de puerto serie
int LED=13; //Puerto digital
char dato; //Guardar la tecla presionada
void setup() {
  Serial.begin(9600); //9600  es la velocidad de transferencia de datos
  pinMode(LED,OUTPUT);
 }

void loop() {
  Serial.flush();
  dato = Serial.read(); //Lee el dato enviado por el teclado
  
  switch(dato)
  {
    case 'p':
      digitalWrite(LED,HIGH);
      break;
    case 'a':
      digitalWrite(LED,LOW);
      break;    
  }

}
