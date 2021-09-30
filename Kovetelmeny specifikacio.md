# Követelmény specifikáció

## 1. Áttekintés

A Pigeon Corp. azzal lett megbízva, hogy tervezzenek egy olyan rendszert,
ahol a megrendelő cég nem bízik az üzenetküldő rendszerek biztonsággal kapcsolatos intézkedéseiben,
így szeretnének a bizalmas üzenetváltásaikat még biztonságosabbá tenni,
viszont a mostani üzenetküldő rendszerüket szeretnék megtartani.
Egy olyan szoftverre van szükségük amik a cég üzenetit titkosítani tudják,
hogy csak azon felhasználók számára legyen olvasható akik rendelkeznek a szoftverrel.
Erre a kérésre terveztünk egy olyan szoftvert amivel ez megvalósítható.

## 2. A jelenlegi helyzet leírása

A megerendelő cégnek tevékenységi köréből adódóan, rengeteg fontos,
bizalmas adatot és információt kell megoszania az alkalmazottaival,
hogy a munkájukat hatékonyan tudják végezni.
Jelenleg minden fontosabb cégen belüli adatot és információt papíron,
személyesen kell megosztaniuk egymással, ugyanis a cég által használt nyilvános levelezőrendszert nem tartják elég biztonságosnak.
Ennek a legnagyobb hátránya, - azon kívül, hogy ineffektív és pocskék - hogy ez a módszer megköveteli,
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

## 4. Pályázat törvények, rendeletek, szabványok és ajánlások felsorolása
## 5. Jelenlegi üzleti folyamatok modellje

## 6. Igényelt üzleti folyamatok modellje

A megrendelő alkalmazottai képesek legyenek a szoftveren belül a beírni egy szöveget,
majd ez alapján a szöveg alapján visszakapni a titkosítottat.
Miután ezt a titkosított szöveget elküldi a felhasználó,
a fogadó képes legyen a szoftver megléte mellett a titkosított szöveget visszafejteni az eredetire, 
így biztosítva, hogy az üzenetet csak a cég alkalmazottai tudják olvasni.

## 7. Követelménylista
## 8. Fogalomtár
