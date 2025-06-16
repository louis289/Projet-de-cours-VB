#include <rgb_lcd.h>
#include <Wire.h>

rgb_lcd lcd;
char test = 0;
String inputString = "";         // Chaîne pour stocker les données entrantes
bool stringComplete = false;     // Flag pour indiquer si la chaîne est complète

void setup() {
  // Initialisation du port série
  Serial.begin(9600);
  lcd.begin(16, 2);
  lcd.setRGB(0, 0, 255);
  Wire.begin();
  inputString.reserve(200); // Réserve de la mémoire pour la chaîne
}

void loop() {
  // Lire les données série
  while (Serial.available()) {
    char inChar = (char)Serial.read();
    if (inChar == '*') {
      stringComplete = true;
      break;
    }
    inputString += inChar;
  }

  // Si la chaîne est complète, traiter les données
  if (stringComplete) {
    // Convertir la chaîne hexadécimale en un entier
    long valeur = strtol(inputString.c_str(), NULL, 16);

    // Afficher la valeur sur le LCD
    lcd.clear();
    lcd.print(inputString);

    // Envoyer la valeur via I2C
    Wire.beginTransmission(0b0111111);
        Wire.write(~valeur);
    Wire.endTransmission();

    // Réinitialiser la chaîne et le flag
    inputString = "";
    stringComplete = false;
  }
}

