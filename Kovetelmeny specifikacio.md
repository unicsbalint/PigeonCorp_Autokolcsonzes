# Követelmény specifikáció

## 1. Áttekintés

A Pigeon Corp. azzal lett megbízva, hogy tervezzenek egy olyan rendszert,
ahol a megrendelő cég nem bízik az üzenetküldő rendszerek biztonsággal kapcsolatos intézkedéseiben,
így szeretnének a bizalmas üzenetváltásaikat még biztonságosabbá tenni,
viszont a mostani üzenetküldő rendszerüket szeretnék megtartani.
Egy olyan szoftverre van szükségük, amik a cég üzeneteit titkosítani tudják,
hogy csak azon felhasználók számára legyen olvasható, akik rendelkeznek a szoftverrel.
Erre a kérésre terveztünk egy olyan szoftvert, amivel ez megvalósítható.

## 2. A jelenlegi helyzet leírása

A megrendelő cégnek tevékenységi köréből adódóan, rengeteg fontos,
bizalmas adatot és információt kell megosztania az alkalmazottaival,
hogy a munkájukat hatékonyan tudják végezni.
Jelenleg minden fontosabb cégen belüli adatot és információt papíron,
személyesen kell megosztaniuk egymással, ugyanis a cég által használt nyilvános levelezőrendszert nem tartják elég biztonságosnak.
Ennek a legnagyobb hátránya, - azon kívül, hogy ineffektív és pocsék - hogy ez a módszer megköveteli,
hogy az alkalmazottaikat a papír alapú adat és információ cserék megzavarják, kizökkentik őket munkájukból,
és a papír alapú bizalmas irat tárolás miatt nagyon szigorú intézkedéseket kellett bevezetniük az irodájukban,
ami szintén negatív kihatással van az alkalmazottaik munkavégzésére.

## 3. Vágyálomrendszer

Csapatunk egy olyan programot szeretne készíteni,
ami tudna titkosítani szöveget egy vagy több módszerrel is egyszerre,
majd ugyanazok a paraméterek (jelszó és egyebek) segítségével vissza is tudja fejteni.
Célunk az információ tárolásának és küldésének biztonságosabbá tétele.
A programban beállítható a használt titkosítás,
akár több is egyszerre a nagyobb biztonságért és nehezebb illegális visszafejtésért.
A titkosítani/visszafejteni kívánt szöveget vagy fájlból olvassa be a program,
vagy a felhasználó egy szövegdobozba írhatja. A kapott szöveget ugyanígy egy fájlba lehet menteni,
vagy a programon belül egy szövegdoboz írja ki. A felhasználónak,
aki vissza szeretné fejteni a titkosított szöveget,
tudnia kell a titkosítás módszerét és a jelszavát is.
Ha hibásan választja ki, akkor a visszakapott szövegben belül nem lesz értelmezhető szó.

## 4. Jelenlegi üzleti folyamatok modellje

A mai világban az üzenetváltásaink biztonsága nem mindig tudható elég megfelelőnek, könnyedén elolvashatóak üzeneteink, ha:
   * Az üzenetküldő klienst feltörik, vagy tömeges áttörés áldozatává esik, üzeneteink a nyilvánosság, vagy egy harmadik fél elé kerülhet.
   * Véletlenül nem jelentkezünk ki az üzenetküldő kliensből, és magára hagyjuk a számítógépet.
   * Malware áldozatává esve.
   * Szolgáltatók nem használnak elég erős titkosítást.

Szintén nem lehet megbízni 100%-ig egy adott üzenetküldő cég biztonságában, mivel:
   * Elolvashatják üzeneteinket a tudtunk nélkül.
   * Eladhatják harmadik feleknek.
   * Egyes szolgáltatók nem használnak titkosítást az üzenetek küldésekor, fogadásakor.

## 5. Igényelt üzleti folyamatok modellje

A megrendelő alkalmazottai képesek legyenek a szoftveren belül a beírni egy szöveget,
majd ez alapján a szöveg alapján visszakapni a titkosítottat.
Miután ezt a titkosított szöveget elküldi a felhasználó,
a fogadó képes legyen a szoftver megléte mellett a titkosított szöveget visszafejteni az eredetire, 
így biztosítva, hogy az üzenetet csak a cég alkalmazottai tudják olvasni.

## 6. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Felület | Főablak | A felhasználó itt írhatja be a szöveget, vagy megadhatja azt a fájl, és kiválaszthatja, hogy mit szeretne vele csinálni (titkosítani/visszafejteni). Ha a megadott szöveg/fájl tartalmazna nem értelmezett karaktert, a program hibaüzenetben értesíti a felhasználót. |
| K2 | Felület | Beállítás | A felhasználó itt állíthatja be a titkosítási paramétereket: Milyen titkosítási módszereket alkalmazzon. A titkosítani kívánt szöveg bevitele és kiíratása. (Szövegdoboz/fájl). A kiválasztott titkosítási módszerek paraméterei (eltolás mértéke, jelszó, stb..) Ha valamelyik követelmény helytelen, a program hibaüzenettel figyelmezteti a felhasználót. |
| K3 | Kriptográfiai módszer | Caesar-féle titkosítás | A betűkhöz hozzárendeli az utána lévőt eltolási mértékkel. Az így kapott kódolt szöveg már nem tartalmaz értelmes szavakat. |
| K4 | Kriptográfiai módszer | Kulcsszavas Caesar-féle titkosítás | Hasonló a Caesar-féle titkosításhoz, az első néhány betűt a kulcsszó betűihez rendeli hozzá. Ezzel nehezebbé teszi az illegális fejtő munkáját. |
| K5 | Kriptográfiai módszer | Hill-féle titkosítás | Mátrixokkal való szorzást és maradékos osztást alkalmazva betűpárokat kódol betűpárokká. |
| K6 | Kriptográfiai módszer | Vigenére-féle titkosítás | Karaktertáblázatot alkalmazva kódolja a betűket a szövegben. A kódolást a jelszó karaktereinek segítségével végzi el. |
| K7 | Kriptográfiai módszer | Autoclave titkosítás | Hasonló Vigenére-féle titkosításhoz. Az első pár karaktert maga a jelszó karakterei kódolják le, majd utána a szöveg többi rész, ezáltal nehezíti a fejtést. |
| K8 | Funkció | Titkosítás, visszafejtés | A megadott beállításokkal a program titkosítja/visszafejti a kívánt szöveget, fájlt. |

## 7. Fogalomtár
   * Malware: Rosszindulatú, kártékony szoftver, amelyet adatlopásra is használnak.
   * Kódolás: Az adatok más felhasználható formátumba történő átalakítása különböző rendszerek által.
   * Titkosítás: A titkosítás az adatok átalakításának módja, azzal a szándékkal, hogy titokban tartja.
   * Adatszivárgás: Amikor védett, bizalmas adatok valamilyen módon kijutnak, „kiszivárognak” a védett környezetből.
   * Kulcsszó: Olyan szó, amelyben nincsen betű ismétlés.
