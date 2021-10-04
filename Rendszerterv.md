# Rendszerterv
## 1. A rendszer célja

A rendszer célja, hogy az üzeneteinket biztonságosabbá tegyük azzal, hogy különböző
titkosítási módszereket alkalmazunk. Ezeket a módszereket vegyíteni is lehet, mellyel
csökkenthetjük a szöveg visszafejtésének  esélyét idegen fejtők által. Fontos, hogy a
felhasználó könnyen el tudjon igazodni a felületeken ezért minimalista felhasználói felületet
kap a program. A titkosításhoz meg kell adni bizonyos paramétereket a beállításokban 
(például mekkora legyen a Caesar-féle titkosításnál az eltolás mértéke), majd ugyanezeket
a paramétereket használva a felhasználó vissza is tudja fejteni a titkosított szöveget. 
A program titkosítani/visszafejteni kívánt szöveget fájlból vagy egy szövegdobozból tudja be,- 
és a titkosított/visszafejtet szöveget fájlba menteni tudja vagy egy szövegdobozon keresztül
kiírja a felhasználónak. Ha a felhasználó vissza szeretné fejteni a kívánt titkosított üzenetet,
akkor tudnia kell a használt módszert és a módszerhez szükséges paramétert is.

## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
   * Scrum master: (TBD)
   * Product owner: (TBD)
   * Üzleti szereplők:
     - Megrendelő: (TBD)
     
### 2.2 Projektmunkások és felelőségek:
   * Frontend: (TBD)
   * Backend: (TBD)
   * Tesztelés:
     * Bagoly Gábor
     * Boda Viktor 
     * Fejes Bence
     * Matuch Richárd
     
### 2.3 Ütemterv

|Funkció                  | Feladat                                | Prioritás | Becslés (nap) | Aktuális becslés (nap) | Eltelt idő (nap) | Hátralévő idő (nap) |
|-------------------------|----------------------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                                 |         1 |             1 |                      1 |                1 |                   0 |             
|Funkcionális specifikáció|Megírás                                 |         1 |             1 |                      1 |                3 |                   0 |
|Rendszerterv             |Megírás                                 |         1 |             1 |                      1 |                3 |                   0 |
|Program                  |Képernyőtervek elkészítése              |         2 |             1 |                      1 |                0 |                   9 |
|Program                  |Prototípus elkészítése                  |         3 |             8 |                      8 |                0 |                   9 |
|Program                  |Alapfunkciók elkészítése                |         3 |             8 |                      8 |                0 |                   9 |
|Program                  |Titkostíási funkciók elkészítése        |         3 |             8 |                      8 |                0 |                   9 |
|Program                  |Fájlbaírás / Fájlból olvasás elkészítése|         3 |             8 |                      8 |                0 |                   9 |
|Program                  |Tesztelés                               |         4 |             2 |                      2 |                0 |                   9 |


## 3. Üzleti folyamatok modellje
## 4. Követelmények

### Funkcionális követelmények

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K1 | Titkosítás beállítása | A kívánt titkosításokat és paramétereket a felhasználó be tudja állítani. |
| K2 | Forrás beállítása | A felhasználó kiválaszthatja a kívánt szöveg forrását. Ez vagy egy fájl, vagy egy szövegdoboz a programon belül. |
| K3 | Kimenet beállítása | A felhasználó kiválaszthatja a titkosított/visszafejtett szöveg hova kerüljön kiírásra/mentésre |
| K4 | Cselekmény kiválasztása | A felhasználó miután kiválaszthatja, hogy titkosítani vagy visszafejteni szeretné a szöveget. |

### Nemfunkcionális követelmények

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K5 | Letisztult design | A program ablakainak a designja legyen letisztult, átlátható, könnyen használható. Törekszünk a lehető legkényelmesebb megjelenésre.

### Támogatott eszközök
.NET Framework használata miatt platformfüggő.
Csak olyan Windows rendszeren használható, melyen telepítve van a .NET Framework is.

## 5. Funkcionális terv
## 6. Fizikai környezet

### Vásárolt softwarekomponensek és külső rendszerek
Nincsenek vásárolt szoftverkomponensek.
### Hardver topológia
Az alkalmazás 32 bites Windows rendszerre készült, így a 64 bites verzión is működik.
### Fizikai alrendszerek
Kliens gépek: A követelményeknek megfelelő, Windows-t futtatatására alkalmas PC-k, amik rendelkeznek a .Net keretrendszerrel.
### Fejlesztő eszközök
Visual Studio 2019

## 7. Absztrakt domain modell
## 8. Architekturális terv

### Webszerver
A program nem kapcsolódik az internethez, ezért nem kell webszervert használni

### Adatbázis rendszer
A program nem kapcsolódik adatbázis rendszerhez, ezért nem kell adatbázis rendszert alkalmazni

### A program elérése, kezelése
A programot Windows operációs rendszert futtató és .NET keretrendszerrel rendelkező számítógép
futtathatja. A futtatás egyszerű, csak kétszer kell rákattintani a futtatható álományra, vagy
az allománynak a parancsikonjára.

## 9. Adatbázis terv

Adatbázis használatának hiányában nem szükséges az adatbázis terv,
de a program beállításokat egy fájlba menti el és olvassa be a könnyebb felhasználhatóság
érdekében. Egy felhasználó több ilyen beálítás fájlt is hordozhat magával, a különböző
tartalmú fájlok/üzenetek titkosításához.

## 10. Implementációs terv

 * C# program, ami a .NET keretrendszer alkalmazásával fut.
 * A felhasználói felület - windows form alkalmazás.
 * A programok objektum orientált programozási paradigma használatával.

## 11. Tesztterv
## 12. Telepítési terv

Fizikai telepítési terv: A titkosító/visszafejtő programnak nincs szüksége adatbázis szerverre, 
se webszerverre, se internetre, csak meg kell nyitnunk a PC-n.

Szoftver telepítési terv: Szükségünk van egy 32 bites Windows operációs rendszerű PC-re, 
hogy használni tudjuk a programot.

## 13. Karbantartási terv

Fontos ellenőrizni:
*	A kódolás/visszafejtés jól működik
*	A program nem lassul be

Új kódolási típus megjelenésénél fontos, hogy implementáljuk azt a programunkba, így a felhasználok új élménnyel gazdagodhatnak és biztonságosabbá tesszük a titkosítandó szöveget, fájlt.

Figyelembe kell venni a felhasználó által jött visszajelzést is a programmal kapcsolatban.
Ha hibát talált, mielőbb orvosolni kell, lehet az:
*	Működéssel kapcsolatos
*	Kinézet, dizájnnal kapcsolatos
