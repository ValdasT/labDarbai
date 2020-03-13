## 0.1 versija ##

- Programa paprašo pasirinkti studento įvedimą ranka paspaudus "y".
- Programa paprašo įvesti studento vardą, pavardę, namų darbų kiekį.
- Programa paklausia ar pažymius įvesti ranka "r" ar su generuoti "g".
- Jei naudotojas pasirinko įvesti ranka "r", programa prašys įvesti pažimį tiek kartų, koks pažymių kiekis buvo įvestas pradžioje. Ir gale paprašis įvesti egzamino pažimį.
- Jei naudotojas pasirinko sugeneruoti pažymius, programa sugeneruos atsitiktine tvarka pažymius.
- Kai pažymiai bus sukurti programa pasiuls įvesti kito studento duomenis "y" arba  spausdinti įvestų studentų pažimių vidurkį "v" arba medianą "m". Taip pat naudotojas gali sustabdyti programą "x".
- Jei pasirinkta spausdinti studentų vidurkius "v", bus atspausdinta lentelė su duomenimis.

|  Vardas  |  Pavarde   |  Galutinis (Vid.)  |
|----------|------------|--------------------|
|  Vardas  | Vardenis   |        3.50        |
|  Pavarde | pavardenis |        8.01        |
|  Vardas  | Pavardenis |        1.55        |
      
- Jei pasirinkta spausdinti studentų medianą "m", bus atspausdinta lentelė su duomenimis.

|  Vardas  |  Pavarde   |  Galutinis (Med.)  |
|----------|------------|--------------------|
|  Vardas  | Vardenis   |        3.50        |
|  Pavarde | pavardenis |        8.01        |
|  Vardas  | Pavardenis |        1.55        |

- Taip pat naudotojas gali sustabdyti programą "x".


## 0.2 versija ##

- Programa paprašo pasirinkti studento įvedimą ranka paspaudus "y" arba nuskaityti duomenis iš failo "f".
- Jei pasirinkta skaityti duomenis iš failo "f" programa nuskaito failą "kursiokai.txt" .
- Kai yra nuskaityti duomenis arba įvesti ranka, tada programa leidžia atspausdinti duomenis. Jeigu reikia tik studentu pažimių vidurkio spoaudžiama  "v", jei medianos - "m", jeigu medianos ir vudurkio vienoje lentelėje spaudžiam "l".

|  Vardas  |  Pavarde   |  Galutinis (Vid.)  |  Galutinis (Med.)  |
|----------|------------|--------------------|--------------------|
|  Vardas  | Vardenis   |        8.88        |        9.00        |
|  Pavarde | pavardenis |        7.06        |        7.00        |
|  Vardas  | Pavardenis |        7.06        |        7.00        |

- Taip pat naudotojas gali sustabdyti programą "x".
      
## 0.3 versija ##

- Ištaisytos klaidos, pagreitinta programa.

## 0.4 versija ##

- Programa paprašo pasirinkti studento įvedimą ranka paspaudus "y" arba nuskaityti duomenis iš failo "f".
- Sugeneruoti 5 failus "5".Sukuria 5 failus su studentų duomenimis. Surušiuoja juos į du sąrašus ir išsaugo dviejuose failuose.
- Programa parodo duomenis per kiek laiko atliko skirtingų failų rušiavimą ir generevaimą. 

````
10 irasu sukurta per ---> 00:00:00.0087251
100 irasu sukurta per ---> 00:00:00.0007531
1000 irasu sukurta per ---> 00:00:00.0030478
10000 irasu sukurta per ---> 00:00:00.0261629
100000 irasu sukurta per ---> 00:00:00.2422451
````
- Taip pat naudotojas gali sustabdyti programą "x".

## 0.5 versija ##

- Programa paprašo pasirinkti studento įvedimą ranka paspaudus "y" arba nuskaityti duomenis iš failo "f".
- Sugeneruoti 5 failus "5".Sukuria 5 failus su studentų duomenimis. Surušiuoja juos į du sąrašus ir išsaugo dviejuose failuose.
- Programa parodo duomenis per kiek laiko atliko skirtingų failų rušiavimą ir generevaimą. 
- Programuoje implementuota konteineriu greičio testavimo uždauotis "k" su skirtingais konteinerio tipais ir skirtingo dydžio failais.
- Programa atspausdina greičio rezultatus:
````
failas: visi-10.txt
Su List'u greitis: 00:00:00.0020335
Su Linkedlist'u greitis: 00:00:00.0005619
Su Queue greitis: 00:00:00.0004115
---------------------------------------------
failas: visi-100.txt
Su List'u greitis: 00:00:00.0003621
Su Linkedlist'u greitis: 00:00:00.0004650
Su Queue greitis: 00:00:00.0004411
---------------------------------------------
failas: visi-1000.txt
Su List'u greitis: 00:00:00.0028274
Su Linkedlist'u greitis: 00:00:00.0134785
Su Queue greitis: 00:00:00.0028052
---------------------------------------------
failas: visi-10000.txt
Su List'u greitis: 00:00:00.0275661
Su Linkedlist'u greitis: 00:00:00.8786983
Su Queue greitis: 00:00:00.0208593
---------------------------------------------
failas: visi-100000.txt
Su List'u greitis: 00:00:00.2101275
Su Linkedlist'u greitis: 00:01:49.4073582
Su Queue greitis: 00:00:00.1734309
---------------------------------------------
````
**Rezultatai skaičiuojami minutėmis, sekundėmis ir milisekundėmis**
- Iš gautų rezultatų matosi, kad greičiausiai veikia Listas ir Queue, lėčiausias Linkedlist.

## 1.0 versija ##
- Programoje papildyta konteinerio testavimo užduotis. Gritis skaičiuojams trijuose konteinerių tipuose ir skirtingo dydžio failuose, bet skaičiavimai atliekiami skirtingais būdais.
- Programa atspausdina gautus rezultatus:
````
failas: visi-10.txt
Su List'u greitis: 00:00:00.0020605
Su List'u greitis (pagreitintas): 00:00:00.0001320
Su List'u greitis su istrinimais: 00:00:00.0001009

Su Linkedlist'u greitis: 00:00:00.0005474
Su Linkedlist'u greitis (pagreitintas): 00:00:00.0000978
Su Linkedlist'u greitis su istrinimais: 00:00:00.0002445

Su Queue greitis: 00:00:00.0005175
Su Queue greitis (pagreitintas): 00:00:00.0000974
Su Queue greitis su istrinimais: 00:00:00.0005155
---------------------------------------------
failas: visi-100.txt
Su List'u greitis: 00:00:00.0003564
Su List'u greitis (pagreitintas): 00:00:00.0003310
Su List'u greitis su istrinimais: 00:00:00.0003235

Su Linkedlist'u greitis: 00:00:00.0004824
Su Linkedlist'u greitis (pagreitintas): 00:00:00.0003282
Su Linkedlist'u greitis su istrinimais: 00:00:00.0004124

Su Queue greitis: 00:00:00.0004470
Su Queue greitis (pagreitintas): 00:00:00.0003300
Su Queue greitis su istrinimais: 00:00:00.0015801
---------------------------------------------
failas: visi-1000.txt
Su List'u greitis: 00:00:00.0037375
Su List'u greitis (pagreitintas): 00:00:00.0027394
Su List'u greitis su istrinimais: 00:00:00.0027239

Su Linkedlist'u greitis: 00:00:00.0134235
Su Linkedlist'u greitis (pagreitintas): 00:00:00.0028623
Su Linkedlist'u greitis su istrinimais: 00:00:00.0084112

Su Queue greitis: 00:00:00.0106143
Su Queue greitis (pagreitintas): 00:00:00.0020090
Su Queue greitis su istrinimais: 00:00:00.5974053
---------------------------------------------
failas: visi-10000.txt
Su List'u greitis: 00:00:00.0244806
Su List'u greitis (pagreitintas): 00:00:00.0221319
Su List'u greitis su istrinimais: 00:00:00.0304380

Su Linkedlist'u greitis: 00:00:00.8673559
Su Linkedlist'u greitis (pagreitintas): 00:00:00.0250935
Su Linkedlist'u greitis su istrinimais: 00:00:00.5534366

Su Queue greitis: 00:00:00.6849182
Su Queue greitis (pagreitintas): 00:00:00.0263853
Su Queue greitis su istrinimais: 00:09:33.7553775
---------------------------------------------
failas: visi-100000.txt
Su List'u greitis: 00:00:00.2200914
Su List'u greitis (pagreitintas): 00:00:00.2180724
Su List'u greitis su istrinimais: 00:00:00.5510121

Su Linkedlist'u greitis: 00:01:39.2978381
Su Linkedlist'u greitis (pagreitintas): 00:00:00.2712676
Su Linkedlist'u greitis su istrinimais: 00:00:59.1753696

Su Queue greitis: 00:01:08.8850364
Su Queue greitis (pagreitintas): 00:00:00.2396848
Su Queue greitis su istrinimais: 01:12:45.7343734
````
**Rezultatai skaičiuojami minutėmis, sekundėmis ir milisekundėmis**
- Iš gautų rezultatų matosi, kad greičiausiai veikia Listas ir Queue, lėčiausias Linkedlist. Bet kai programauoje yra naudojami trinimai List yra greičiausias. Linkedlist trinimai ir Queue užtrunka daug kartų ilgiau. Queue konteinio duomenų skaičiavimas su ištrinimais užtrunka labai daug laiko. Bet pavyko visus konteinerius pagreitinti nuo orginalios versijos.

## Diegimo instrukcija ##

1. github aplankale "labDarbai" reikia nueiti į **Releases** skiltį.
2. Pasirinkti versiją.
3. Išplėsti skiltį **Assets**.
4. Parsisiusti "Source code (zip)".
5. Išskleisti į pasirinktą aplankalą parsisiustą failą.
6. Paleisti programą per pasirinktą IDE.
