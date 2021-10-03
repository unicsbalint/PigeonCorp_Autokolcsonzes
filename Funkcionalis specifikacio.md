# Funkcionális specifikáció
## 1. Jelenlegi helyzet leírása
## 2. Vágyállomrendszer leírása

Csapatunkat egy olyan program írásával bízták meg,
mely képes szövegeket titkosítani egy vagy több módszerrel is egyszerre.
A titkosításhoz meg kell adni bizonyos paramétereket (jelszó és egyebek),
majd ugyanezek paramétereket használva a felhasználó vissza is tudja fejteni
a titkosított szöveget. A program célja az információ biztonságosabb tárolása
és küldése. A program képes lenne több titkosítást is használni a szövegen,
ezzel kevésbé föltörhetővé válik az illegális fejtők számára. A program titkosítani/visszafejteni kívánt szöveget fájlból vagy egy szövegdobozból
olvasná be, és a titkosított/visszafejtet szöveget fájlba menti vagy egy
szövegdobozon keresztül írja ki a felhasználónak. Ha a felhasználó vissza
szeretné fejteni a kívánt titkosított üzenetet, akkor tudnia kell a használt
módszert és a módszerhez szükséges paramétert is. Ha ezt hibásan választja ki
a kapott szöveg olvashatatlan lesz számára.

## 3. Jelenlegi üzleti folyamatok modellje

A mai világban az üzenetváltásaink biztonsága nem mindig tudható elég megfelelőnek, könnyedén
elolvashatóak üzeneteink, ha:
   * Az üzenetküldő klienst feltörik, vagy tömeges áttörés, vagy adatszivárgás áldozatává esik,
   üzeneteink a nyilvánosság, vagy egy harmadik fél elé kerülhet.
   * Véletlenül nem jelentkezünk ki az üzenetküldő kliensből, és magára hagyjuk a számítógépet.
   * Malware áldozatává esve.
   * Szolgáltatók nem használnak elég erős titkosítást.

Szintén nem lehet megbízni 100%-ig egy adott üzenetküldő cég biztonságában, mivel:
   * Elolvashatják üzeneteinket a tudtunk nélkül.
   * Eladhatják harmadik feleknek.
   * Egyes szolgáltatók nem haszálnak titkosítást az üzenetek küldésekor, fogadásakor.

## 4. Igényelt üzleti folyamatok modellje
## 5. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Felület | Főablak | A felhasználó itt írhatja be a szöveget, vagy megadhatja azt a fájl, és kiválaszthatja, hogy mit szeretne vele csinálni (titkosítani/visszafejteni). Ha a megadott szöveg/fájl tartalmazna nem értelmezett karaktert, a program hibaüzenetben értesíti a felhasználót. |
| K2 | Felület | Beállítás | A felhasználó itt állíthatja be a titkosítási paramétereket:  Milyen titkosítási módszereket alkalmazzon. A titkosítani kívánt szöveg bevitele és kiíratása. (Szövegdoboz/fájl). A kiválasztott titkosítási módszerek paraméterei (eltolás mértéke, jelszó, stb...) Ha valamelyik követelmény helytelen, a program hibaüzenettel figyelmezteti a felhasználót. |
| K3 | Kriptográfiai módszer | Caesar-féle titkosítás | A betűkhöz hozzárendeli az utána lévőt eltolási mértékkel. Az így kapott kódolt szöveg már nem tartalmaz értelmes szavakat. |
| K4 | Kriptográfiai módszer |  Kulcsszavas Caesar-féle titkosítás | Hasonló a Caesar-féle titkosításhoz, az első néhány betűt a kulcsszó betűihez rendeli hozzá. Ezzel nehezebbé teszi az illegális fejtő munkáját. |
| K5 | Kriptográfiai módszer | Hill-féle titkosítás | Mátrixokkal való szorzást és maradékos osztást alkalmazva betűpárokat kódol betűpárokká. |
| K6 | Kriptográfiai módszer | Vigenére-féle titkosítás | Karaktertáblázatot alkalmazva kódolja a betűket a szövegben. A kódolást a jelszó karaktereinek segítségével végzi el. |
| K7 | Kriptográfiai módszer | Autoclave titkosítás | Hasonló Vigenére-féle titkosításhoz. Az első pár karaktert maga a jelszó karakterei kódolják le, majd utána a szöveg többi rész, ezáltal nehezíti a fejtést. |
| K8 | Funkció | Fájl/szövegdoboz beolvasása | A kiválasztott fájlt, vagy a szövegdobozba beírt szöveg beolvasása. |
| K9 | Funkció | Titkosítás, visszafejtés | A megadott beállításokkal a program titkosítja/visszafejti a kívánt szöveget, fájlt. |
| K10 | Funkció |  Fájl/szövegdobozba írás | A titksoított/visszafejtett szöveget fájlba írni vagy egy szövegdobozba visszaírni. |

## 6. Használati esetek

1. Titkosító felhasználó: Be tudja állítani a kívánt titkosítási módszereket. Miután kiválasztotta, meg kell adnia a kiválasztott módszerek paramétereit (pl.: jelszó), ezután a kívánt mentési forma alapján a program fájlba menti vagy szövegdobozon keresztül íratja ki a titkosított szöveget
2. Visszafejtő felhasználó: A titkosító felhasználó alapján beállítja a kívánt módszereket, azok paramétereit, majd a mentési formát. A visszafejtett szöveget a program ugyanúgy egy fájlba írja ki vagy egy szövegdobozon keresztül írja ki, a felhasználó választása alapján.

## 7. Megfeleltetés, hogyan fedik le a használati eseteket a követelményeket
## 8. Képernyőtervek

### Főablak:
![foablak](https://github.com/unicsbalint/PigeonCorp_MessageEncrypter/blob/main/imgs/main.png)
### Beállítások:
![beallitasok](https://github.com/unicsbalint/PigeonCorp_MessageEncrypter/blob/main/imgs/settings.png)

## 9. Forgatókönyvek
## 10. Funkcó - követelmény megfeleltetése

| Id | Követelmény | Funkció |
| :---: | --- | --- |
| K1 | Egyszerű, innovatív | A program funkciója a legfontosabb, de az is egy kihagyatlan rész, hogy kinézete és használata is egyszerű, felhasználóbarát legyen. Itt a felhasználó titkosít hatja vagy visszafejtheti a szöveget vagy fájlokat. |
| K2 | Sokszínű használat | Miután kiválasztotta a szöveget vagy fájlt, amit titkosítani vagy visszafejteni szeretne a felhasználó, azután kiválaszthatja a paraméteradással, hogy hogyan is szeretné használni. Bár helytelen követelmény használatnál figyelmeztet. |
| K3 | Gyorsaság | A megfelelő működése mellett az is egy fontos tényező, hogy a kódolást vagy visszafejtést gyorsan tegye meg, de a gyorsasága miatt ne történjen hiba a folyamat alatt vagy a folyamat végén. |
| K4 | Folytatás | A szöveget miután titkosítottjuk lehessen tovább titkosítani vagy ha visszafejtettünk, lehessen visszafejteni amíg vissza nem kapjuk az értelmes szöveget. |

## 11 Fogalomszótár
