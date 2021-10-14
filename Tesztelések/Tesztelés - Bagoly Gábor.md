| Teszteset                                                 | Elvárt eredmény                                                                                                         | 
 |-----------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------| 
 | Helytelen titkosítási beállítások megadása                | A titkosítás nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy miért és milyen adatok megadásával történhet. |
 | Helyes titkosítási beállítások megadása                   | Megtörténik a titkosítás. A felhasználó kap egy kulcsot.                                                                | 
 | Helytelen fejtési beállítások megadása helytelen kulccsal | A fejtés nem történhet meg. Jelezni a felhasználónak, hogy helytelenek az adatok.                                       | 
 | Helytelen fejtési beállítások megadása helyes kulccsal    | A fejtés nem történhet meg. Jelezni a felhasználónak, hogy helytelenek az adatok.                                       | 
 | Helyes fejtési beállítások megadása helytelen kulccsal    | A fejtés nem történhet meg. Jelezni a felhasználónak, hogy helytelen a kulcs.                                           | 
 | Helyes fejtési beállítások megadása helyes kulccsal       | A fejtés végbemegy. A felhasználó megkapja az üzenetet.                                                                 | 

#### Ezeket a etszteseteket végrehalyatani a legtöbb kombinációval

**Tesztelő:** Bagoly Gábor

**Tesztelés dátuma:** 2021.október.14.

|Tesztszám          | Rövid leírás                                                                            | Várt eredmény                                                                                         | Eredmény                                                                                                                                                      | Megjegyzés                |
|-------------------|-----------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------|
|Teszt #01          | Helytelen titkosítási beállítások : Caesar                                              | Beállítások mentése nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.           | Beállítások elmentése nem hajtódik végre, jelzi a felhasználnak a problémát                                                                                   | Nem találtam problémát.   |
|Teszt #02          | Helytelen titkosítási beállítások : Kulcsszavas-Caesar                                  | Beállítások mentése nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.           | Beállítások elmentése nem hajtódik végre, jelzi a felhasználnak a problémát                                                                                   | Nem találtam problémát.   |
|Teszt #03          | Helytelen titkosítási beállítások : Hill                                                | Beállítások mentése nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.           | Beállítások elmentése nem hajtódik végre, jelzi a felhasználnak a problémát                                                                                   | Nem találtam problémát.   |
|Teszt #04          | Helytelen titkosítási beállítások : Vigenere                                            | Beállítások mentése nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.           | Beállítások elmentése nem hajtódik végre, jelzi a felhasználnak a problémát                                                                                   | Nem találtam problémát.   |
|Teszt #05          | Helytelen titkosítási beállítások : Autoclave                                           | Beállítások mentése nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy mi a gond.           | Beállítások elmentése nem hajtódik végre, jelzi a felhasználnak a problémát                                                                                   | Nem találtam problémát.   |

