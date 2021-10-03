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
## 7. Megfeleltetés, hogyan fedik le a használati eseteket a követelményeket
## 8. Képernyőtervek
## 9. Forgatókönyvek
## 10. Funkcó - követelmény megfeleltetése
## 11 Fogalomszótár