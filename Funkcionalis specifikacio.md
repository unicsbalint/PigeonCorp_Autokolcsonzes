# Funkcionális specifikáció
## 1. Jelenlegi helyzet leírása

A megerendelő cégnek tevékenységi köréből adódóan, rengeteg fontos,
bizalmas adatot és információt kell megoszania az alkalmazottaival,
hogy a munkájukat hatékonyan tudják végezni.
Jelenleg minden fontosabb cégen belüli adatot és információt papíron,
személyesen kell megosztaniuk egymással,
ugyanis a cég által használt nyilvános levelezőrendszert nem tartják elég biztonságosnak.
Ennek a legnagyobb hátránya, - azon kívül, hogy ineffektív és pocskék - 
hogy ez a módszer megköveteli, hogy az alkalmazottaikat a papír alapú adat és információ cserék megzavarják,
kizökkentik őket munkájukból, és a papír alapú bizalmas irat tárolás miatt nagyon szigorú intézkedéseket kellett bevezetniük az irodájukban,
ami szintén negatív kihatással van az alkalmazottaik munkavégzésére.

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
![image](https://github.com/unicsbalint/PigeonCorp_MessageEncrypter/blob/main/imgs/funkspec-igenyeltuzletifolyamatok.png)
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

K1:  A felhasználót ez az ablak fogadja amikor elindítja a szoftvert,
ezen a felületen már rögtön meg is kezdheti a szövegbevitelt és a titkosítást, vagy fejtést.

K2: Ezen a felületen tudja a felhasználó a titkosítási beállításokat megadni,
mint, hogy milyen titkosítási módszert használjon és, hogy az milyen bonyolult
legyen.

K3, K4, K5, K6, K7: Titkosítási módszerek, a felhasználó a
beállítások menüben tud váltania kívánt módszerek között.

K8: A felhasználónak lehetősége van egész fájlokat is titkosítani a
szimpla szövegbevitel mellett, a főoldalon kiválaszthatja, hogy
milyen formában szeretné a szöveget bevinni.

K9: A szövegbevitel után a felhasználó képes megadni, hogy
a jelenlegi szöveget titkosítani vagy visszafejteni szeretné.

K10: A szövegbeolvasáshoz hasonlóan a felhasználónak lehetősége
van a visszafejtett szöveget fájlba is kiíírni.

## 8. Képernyőtervek

### Főablak:
![foablak](https://github.com/unicsbalint/PigeonCorp_MessageEncrypter/blob/main/imgs/main.png)
### Beállítások:
![beallitasok](https://github.com/unicsbalint/PigeonCorp_MessageEncrypter/blob/main/imgs/settings.png)

## 9. Forgatókönyvek

Minden felhasználónak a program megnyitásakor a főablak jelenik meg,
melyben látható:
    *	Szövegdoboz.
    *	Fájl kiválasztás gomb.
    *	Beállítások gomb.
    *	Művelet indítása gomb.
    *	4 pipa
        -	Fájlba olvasás,
        -	Fájlba írás, 
        -	szöveg titkosítása, 
        -	titkosított szöveg visszafejtése

A szövegdobozba írjuk azt a szöveget, amit szeretnénk:
*	Titkosítani
*	Visszafejteni
*	Akár csak fájlba írni

Visszafejtésnél ügyeljünk, hogy a titkosított üzenetet „helyesen” írjuk le, mert a legkisebb elírás
is megváltoztathatja az igazi üzenetet, és így a visszafejtőnek problémája fog akadni az értelmezéssel.
Mondhatjuk ezt a titkosításnál is, hiszen, ha elírjuk a titkosított szöveget, akkor a titkosított 
szöveg is más lesz, így a visszafejtve is más üzenetet fog visszaadni, nem pedig az eredetit.

Fájl kiválasztás gombbal, kiválaszthatjuk a fájlt, amit titkosítani, vagy visszafejteni szeretnénk. 
A fájl formátuma .txt legyen. Miután kiválasztottjuk a fájlt, vessünk egy pillantást a szövegre,
hogy „helyesen” van-e írva, a titkosítási hibák elkerülése miatt.

Beállítások gombra kattintva egy mellék ablak nyílik meg, ahol kiválaszthatjuk a kívánt kódolási, 
és dekódolási módszereket. Többféle titkosítási módszert találhatunk itt, ami segíti, hogy 
komplexebb védelme legyen az adott szöveg, vagy fájlnak, így biztonságosabbá téve azt.
Például:
*	Caeser-féle titkosítás
*	Kulcsszavas Caeser-féle titkosítás
*	Hill-féle titkosítás
*	Vigenére-féle titkosítás
*	Autoclave titkosítás

Caeser-féle titkosítás: 
A betűkhöz hozzárendeli az utána lévőt eltolási mértékkel. Az így kapott kódolt szöveg már nem tartalmaz értelmes szavakat.

Kulcsszavas Caeser-féle titkosítás: 
Hasonló a Caesar-féle titkosításhoz, az első néhány betűt a kulcsszó betűihöz rendeli hozzá. Ezzel nehezebbé teszi az illegális fejtő munkáját.

Hill-féle titkosítás:
Mátrixokkal való szorzást és maradékos osztást alkalmazva betűpárokat kódol betűpárokká.

Vigenére-féle titkosítás:
Karaktertáblázatot alkalmazva kódolja a betűket a szövegben. A kódolást a jelszó karaktereinek segítségével végzi el.

Autoclave titkosítás:
Hasonló Vigenére-féle titkosításhoz. Az első pár karaktert maga a jelszó karakterei kódolják le, majd utána a szöveg többi rész, ezáltal nehezíti a fejtést.

Ezután menthetjük a beállításainkat, és kódolhatunk, illetve dekódolhatunk,
vagy a mégse gombra megyünk és nem mentjük el változtatásainkat.

Beállíthatjuk a főablakon, hogy milyen műveletet akarunk csinálni a jelölő négyzet bepipálásával.
Fájból olvasás: bepipáljuk, ha a már leírott formátumban létezik a szöveg, amit kódolni/dekódolni szeretnénk.
Fájlból írás: bepipáljuk, ha fájlba szeretnénk írni a kódolt, illetve dekódolt üzenetet.
Szöveg titkosítás: bepipáljuk, ha a szöveget titkosítani szeretnénk.
Titkosított szöveg visszafejtése: bepipáljuk, ha a titkosított szöveget vissza szeretnénk fejteni az eredeti szövegre.

Művelet indításával elvégezhetjük a kódolást/dekódolást, ha minden beállítottunk. Ha tovább kell kódolni/dekódolni akkor addig folytatjuk, amíg nem kapjuk meg az eredeti szöveget, vagy már eléggé biztonságosnak véljük.


## 10. Funkcó - követelmény megfeleltetése

| Id | Követelmény | Funkció |
| :---: | --- | --- |
| K1 | Egyszerű, innovatív | A program funkciója a legfontosabb, de az is egy kihagyatlan rész, hogy kinézete és használata is egyszerű, felhasználóbarát legyen. Itt a felhasználó titkosít hatja vagy visszafejtheti a szöveget vagy fájlokat. |
| K2 | Sokszínű használat | Miután kiválasztotta a szöveget vagy fájlt, amit titkosítani vagy visszafejteni szeretne a felhasználó, azután kiválaszthatja a paraméteradással, hogy hogyan is szeretné használni. Bár helytelen követelmény használatnál figyelmeztet. |
| K3 | Gyorsaság | A megfelelő működése mellett az is egy fontos tényező, hogy a kódolást vagy visszafejtést gyorsan tegye meg, de a gyorsasága miatt ne történjen hiba a folyamat alatt vagy a folyamat végén. |
| K4 | Folytatás | A szöveget miután titkosítottjuk lehessen tovább titkosítani vagy ha visszafejtettünk, lehessen visszafejteni amíg vissza nem kapjuk az értelmes szöveget. |

## 11 Fogalomszótár
