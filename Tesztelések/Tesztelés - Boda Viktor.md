**Tesztelő:** Boda Viktor

**Tesztelés dátuma:** 2021.10.14

Tesztszám | Teszteset | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
Teszt #01 | Helytelen titkosítási beállítások megadása | 	A titkosítás nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy miért és milyen adatok megadásával történhet. | Nem történik meg a titkosítás és ezt jelzi is üzenetben a program | Nem találtam problémát.
Teszt #02 | Helyes titkosítási beállítások megadása | Megtörténik a titkosítás. A felhasználó kap egy kulcsot. | Sikeres titkosítás, és megkaptam a kulcsot. | Nem találtam problémát.
Teszt #03 | Helytelen fejtési beállítások megadása helytelen kulccsal | A fejtés nem történhet meg. Jelezni a felhasználónak, hogy helytelenek az adatok. | Nem engedte visszafejteni és üzenetben jelezte is a problémát | Nem találtam problémát.
Teszt #04 | Helytelen fejtési beállítások megadása helyes kulccsal | 	A fejtés nem történhet meg. Jelezni a felhasználónak, hogy helytelenek az adatok. | A helytelen beállítások miatt nem engedte a visszafejtést és jelezte is ezt üzenetben a program | Nem találtam problémát.
Teszt #05 | Helyes fejtési beállítások megadása helytelen kulccsal | A fejtés nem történhet meg. Jelezni a felhasználónak, hogy helytelen a kulcs. | Helytelen kulcs megadása miatt jelzett a program üzenetben, hogy a megadott kulcs nem létezik. | Nem találtam problémát.
Teszt #06 | Helyes fejtési beállítások megadása helyes kulccsal | A fejtés végbemegy. A felhasználó megkapja az üzenetet. | A helyes beállítások és létező kulcs használatával képes voltam visszafejteni a megadott szöveget. | Nem találtam problémát.
Teszt #07 | Nem megfelelő karakter megadása | Nem megfelelő karakter esetén nem megy végbe a titkosítás és jelzi a problémát | Miután nem megfelelő karakter adtam meg, a titkosítás nem ment végbe, és jelezte a program, hogy nem megfelelő karaktert használtam | Nem találtam problémát.
