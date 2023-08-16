# Projekt-Dokumentation


Ava Hassani
| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 25.8  | 0.0.1   | Habe PAP erstellt, an der Projektdokumentation gearbeitet, mich mit C# vertrauter gemacht|
| 1.9   | 0.0.2   | ersten code erstellt|                                                              |
|8.9    | 0.0.3  | try/catch eingefügt um ungültige Eingaben aufzufangen, Dokumentation weitergeführt | 
|15.9| 0.0.4| Fehler behoben, dass man normal weiter raten kann nach einer Fehleingabe ohne gleich zu verlieren.|
22.9| 0.0.5|Lernbericht erstellt, Dokumentation abgeschlossen|

##  Für das Programm benötigt es Ein- und Ausgaben sowie Loops.

### 1.1 Ihr Projekt

Number-Guessing-Game Prgramm in welchem man generierte Zahl erraten muss und das Programm reagiert auf Eingaben.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | geheime Zahl zwischen 1 und 100 generieren| Funktional|Als User möchte ich, dass das Programm eine Zahl generiert welche ich nicht weiss und erraten muss |
|2 | Anzahl Versuche| qualität| Als User möchte ich, dass ich nur eine begrenzte Anzahl an Veruche habe.
|3| Anweisung|Qualität| Als User möchte ich, dass mir die "Spielregenl", der Ablauf des Spiels und was meine Rolle ist bzw. was ich machen muss als User mir mittgeteilt werden|
| 4 | Hinweisung  | Qualität| Als User möchte ich, dass das Programm mich darauf hinweist wenn meine Eingabe zu hoch oder zu niedrig ist |
|5 | korrektur | qualität/Funktional | Als User möchte ich, dass das Programm mich zurecht weist bei ungültigen Eingaben und mich dann weiter spielen lässt wenn die Eingabe gültig ist, ohne zu verlieren.|
|6| Versuche abziehen| qualität| Als User möchte ich, dass mir ein Versuch abgezogen wird nach jeder Fehleingabe.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 4.1  | Programm gestartet | 3       | Zahl ist zu klein/ gross|             
|4.2| TC-4.1| 45| Zahl ist zu gross/ klein|
| 5.1 |TC-4.2|300| Bitte nur Zahlen zwischen 1 und 100!|
|5.2| TC-5.1|-5 | Bitte nur Zahlen zwischen 1 und 100!|
|5.3|TC-5.2| sfkrn | Bitte nur Zahlen zwischen 1 und 100!|
|4.3|TC-4.2| 5| Zahl ist zu gross/ klein|
|4.4| TC-4.3|99 | Zahl zu gross/ klein|
|4.5| TC-4.4|18 | Zahl zu gross/ klein|
|4.6| TC-4.5|68 | Zahl zu gross/ klein|
|2.1| TC-4.9|99 |Sie haben verloren! Zahl wäre ... gewesen. Da 10 Versuche verbraucht|

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme
![guessinggame](https://user-images.githubusercontent.com/111045914/189060986-c62fd256-fed4-4a28-8b58-be7990338dc3.png)
 

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 5.A  | 15.9 | Ava | Bei Eingabe eines Buchstaben oder Wortes, hinweisung geben auf Bedingung (Nur Zahlen von 1-100| 2-3 Lektionenen|
|  5.B |  15.9| Ava | Nach der Hinweisung weiter spielen können | 1-2 Lektionen  


Total: 2 Arbeitspakete (notiert)


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 15.9  | Ava       |2-3 Lektionen  |   3 Lektionen        |
| 1.B  | 15.9  | Ava       |1-2 Lektionen  | 1 1/2 lektionen             |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Testergebnis |
| ---- | ----- | -------- | ------ |
| 4.1  |22.9   | Zahl ist zu klein |Hinweisung funktioniert|
| 4.2 |22.9|Zahl ist zu klein| Hinweisung funktioniert     |
|5.1|22.9|Zahlen zwischen 1 und 100!| Korrektur funktioniert|
|5.2|22.9|Zahlen zwischen 1 und 100!| Korrektur funktioniert|
|5.3|22.9| Zahlen zwischen 1 und 100!| Korrektur funktioniert|
|4.3 | 22.9| Zahl ist zu klein| Hinweisung funktioniert|
|4.4|22.9| Zahl ist zu gross|Hinweisung funktioniert|
|4.5|22.9|Zahl ist zu klein|Hinweisung funktioniert|
|4.6|22.9| Zahl ist zu gross| Hinweisung funktioniert|
|2.1|22.9| Sie haben verloren! Es wäre 43 gewesen!| geheime Zahl wird am ende verraten, nach zehntem Versuch hat man verloren, Fehleingaben werden als Versuch abgezogen|

## 6 Auswerten

https://github.com/ava8ha/LA_1100.Lernbericht

