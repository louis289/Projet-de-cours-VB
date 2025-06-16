# Cahier des charges – Projet VB

---

## Introduction

Ce projet a pour objectif de reproduire un logiciel présenté en cours, disponible ici : [SourceREADME\projet.exe](SourceREADME/projet.exe).

Ce logiciel permet de contrôler des LEDs via une carte Arduino Uno connectée au port `COM5`, à l’aide du module I2C décrit dans les fichiers suivants :

* [carte\_extension\_I2C.pdf](SourceREADME/carte_extension_I2C.pdf)

* [TPI2C.pdf](SourceREADME/TPI2C.pdf)

La problématique est la suivante : le code source original étant considéré comme perdu, il est nécessaire de recréer l'application en Visual Basic (VB).

Ce dépôt Git contient :

* le présent cahier des charges,

* les fichiers sources de la nouvelle application,

* l’exécutable de l’application,

* le code à téléverser sur l’Arduino Uno réalisé durant les TPs : [CodeUno.ino](CodeUno/CodeUno.ino)

Les améliorations apportées seront détaillées en fin de document.

## Visuel

### À l’ouverture

![l’ouverture](SourceREADME\image1.png)

---

## Zone principale

### Visualisation de 4 LEDs sur 50 états

- Affichage continu sous forme de rectangles verticaux pour chaque LED  
- Alignement vertical, taille uniforme, espacement constant

**Couleurs des LEDs :**

- **LED 1** (en haut) : vert `RGB(0, 128, 0)`
- **LEDs 2, 3, 4** (sous la LED verte) : jaune `RGB(255, 255, 0)`

---

### Modification de l’état des LEDs

#### Clic simple :

- **Clic droit** : met l'état de la LED cliquée à `0`
- **Clic gauche** : met l'état de la LED cliquée à `1`

#### Clic long :

- Modifie les LEDs comprises entre les coordonnées X du début et de la fin du clic (sur le même bandeau)
- **Clic droit** : met ces LEDs à `0`
- **Clic gauche** : met ces LEDs à `1`

### Accessibilité :

- Espacement entre les LEDs pour une meilleure lisibilité
- Zones actives élargies : il est possible de cliquer légèrement en dehors de la couleur visible
- La séparation entre deux LEDs est centrée dans l'espace entre elles

---

## Boutons de contrôle (en bas à gauche)

- **"Mise à 0"** : toutes les LEDs éteintes (noir)
  ![Mise à 0](SourceREADME\image1.png)
- **"Mise à 1"** : toutes les LEDs allumées (vert ou jaune selon la LED)
  ![Mise à 1](SourceREADME\image2.png)
- **"Initialisation"** : applique un modèle prédéfini (1 case = 5 LEDs) :

| LED   | 0-4 | 5-9 | 10-14 | 15-19 | 20-24 | 25-29 | 30-34 | 35-39 | 40-44 | 45-49 |
| ----- | --- | --- | ----- | ----- | ----- | ----- | ----- | ----- | ----- | ----- |
| LED 1 | 1   | 0   | 0     | 0     | 1     | 0     | 1     | 0     | 0     | 1     |
| LED 2 | 0   | 1   | 0     | 0     | 0     | 1     | 1     | 0     | 0     | 1     |
| LED 3 | 0   | 0   | 1     | 0     | 1     | 0     | 0     | 1     | 0     | 1     |
| LED 4 | 0   | 0   | 0     | 1     | 0     | 1     | 0     | 1     | 0     | 1     |

![Initialisation](SourceREADME\image3.png)

---

## Curseur et voyants

### Curseur noir

- Représente la position actuelle
- Se déplace via une **barre de défilement** située sous les LEDs
- Clic sur une LED à la position du curseur : inverse l’état de cette LED

### Labels :

- Sous la barre de défilement :  
  `"Position curseur : X"` (X de 0 à 49)
- En haut à droite des LEDs :  
  `"Position actuelle Y X"`  
  (Y : bandeau [0 à 3], X : état [0 à 49])
- `"Ligne départ Y"` : dernière LED sur laquelle la souris a été pressée

---

## Lecture des LEDs

### Curseur rouge

- Apparaît après le lancement de la lecture
- Superposé au curseur noir (Z-index supérieur)

### Zone de lecture (à droite, sous les labels)

- **Label** : `"Vitesse : X ms"` (temps d'affichage par état)
- **Barre de défilement** : règle la vitesse entre **500 ms** et **100 ms** (pas de 1 ms)

### Checkboxes (non cliquables)

- Représentent les LEDs transmises à l’Arduino
- Accompagnées de labels `"LED i"` (i = 1 à 4)

### Label "Valeur X : Y"

- Calcule la valeur binaire actuelle selon la formule :  
  `Y = (LED1 * 8) + (LED2 * 4) + (LED3 * 2) + (LED4 * 1)`
- Affiche `"Fin"` à la fin de la lecture
- Affiche `"Valeur"` avant la première lecture

---

## Boutons de lecture

- **"Marche"** : démarre la lecture (curseur rouge avance)
- **"Pause"** : suspend la lecture
- **"Remise à 0"** : ramène le curseur au début
- **"Stop"** : arrête la lecture, affiche "Fin", masque le curseur rouge

### Barre de chargement

- Indique la progression du curseur rouge

---

## Menu

Le menu est divisé en trois sections : **Valeurs**, **Fichier**, **Timer**

### Valeurs

- **Mise à 0**
- **Mise à 1**
- **Initialisation**

### Fichier

- **Ouvrir** : charge une configuration depuis un fichier
- **Enregistrer** : sauvegarde la configuration actuelle

#### Format du fichier :

- Sans extension
- Chaque ligne = un état d’une LED
- Ordre des données :
  - LED1 : 50 premières lignes
  - LED2 : suivantes, etc.
- Format des valeurs :  
  - `True` pour 1  
  - `False` pour 0

### Timer

- **Démarrer** : équivaut à "Marche"
- **Remise à 0** : équivaut à "Remise à 0"
- **Pause** : équivaut à "Pause"
- **Stop** : équivaut à "Stop"

---

## Améliorations

- Ajout de la communication avec l’Arduino.

- Les **checkboxes** indiquant l’état des LEDs sont désormais non modifiables par clic, pour éviter toute confusion sur leur rôle purement indicatif.

- Ajout du contrôle des **quatre dernières LEDs**, qui n’étaient pas prises en charge dans la version originale.

- Création d’un **mode déconnecté** : lorsqu’aucune communication avec l’Arduino n’est possible, un message informe l’utilisateur des causes possibles :
  
  - Arduino non branchée sur le port `COM5`
  
  - Carte Arduino défectueuse
  
  - Aucune carte branchée
  
  - Port série déjà utilisé par une autre application (ex. : l’IDE Arduino)

---