**Tesztelő:** Matuch Richárd

**Tesztelés dátuma:** 2021.10.14

| Tesztszám | Teszt eset                                 | Várt eredmény                               | Tényleges Eredmény                            | Megjegyzés |
| --------- | ------------------------------------------ | ------------------------------------------- | --------------------------------------------- | ---------- |
| T001      | Beállítások betöltése                      | A program helyesen tölti be a beállításokat | A program helyesen betöltötte a beállításokat | Nem találtam problémát          |
| T002      | Beállítások betöltése hibás paraméterekkel | A program kezeli a hibákat                  | A program betöltötte a hibás paramétereket, de nem állt le. A neállítások elérhetetlenné váltak. | Megoldva, és feltöltve (commit név: Prototípus-brállítás betölt. javít.) |
| T003 | Fájl kiválasztása | Kiválaszható egy fájl, mejből olvasni lehet | Ki lehet egy fájlt, melyből a program kiolvasta az adatokat, majd elvégezte a műveletet | Nem találtam problémát |
| T004 | Fájl kiválasztása | A mégse gomra kattintva nem történik semmi | A program kiírta jelenlegi fájl helyének a fájlkiválasztó nevét | Megoldva, feltöltve (commit név:  Prototípus-kód javítása, szépítése) |
| T005 | Szöveg titkosítása | A program elvégzi a titkosítás műveletét, ad vissza egy kulcsot | A program elvégezte a műveletet, visszaadott egy kulcsot | Nem találtam problémát |
| T006 | Szöveg titkosítása | A program elvégzi a titkosítás műveletét, ad vissza egy kulcsot | A program hibásan titkosított | Megoldva, feltöltve. Probléma: az input meg nem engedett karaktert tartalmazott. (commit név: Tesztelés - hibás input kezelés) |
| T006 | Titkosítási beállítások megadása | Helytelen paramétereket a program kezeli. | Helytelen paramétereket a program kezelte. | nem találtam problémát. |
| T007 | Visszafejtés | Helytelen kulcs és titkosítási módszer esetén nem tudja visszafejteni a szöveget | Várt eredmény végbement | Nem találtam problémát |
| T008 | Visszafejtés | Fájl beolvasásának bpipálása mellett nem próbálja beolvasni a megadott fájlt | A program be próbálta olvasni az input fájlt | Megoldva,feltöltve (commit név: Tesztelés - fájl kiválasztás javítás) |
