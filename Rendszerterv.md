# Rendszerterv
## 1. A rendszer célja
## 2. Projektterv
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
## 9. Adatbázis terv

Adatbázis használatának hiányában nem szükséges az adatbázis terv.

## 10. Implementációs terv
## 11. Tesztterv
## 12. Telepítési terv

Fizikai telepítési terv: A titkosító/visszafejtő programnak nincs szüksége adatbázis szerverre, 
se webszerverre, se internetre, csak meg kell nyitnunk a PC-n.

Szoftver telepítési terv: Szükségünk van egy 32 bites Windows operációs rendszerű PC-re, 
hogy használni tudjuk a programot.

## 13. Karbantartási terv
