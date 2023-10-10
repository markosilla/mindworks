# mindworks
Loo C#-is klass, mis arvutab tipupaaridena etteantud etteantud atsüklilises suunatud graafis kõik võimalikud teed kahe tipu vahel. 
Tippe tähistavad juhuslikud täisarvud. Graaf on esitatud kujul List<Tuple<int, int>> kus iga Tuple<int, int> esitab graafil seost 
esimeselt tuple elemendilt teisele. Kõik võimalikud teed tuleb tagastada List<List<int>> struktuuris.

Näiteks graafi

var graph = new List<(int, int)> { (1, 2), (1, 3), (2, 4), (3, 4) };

Korral küsides seoseid tippude 1 ja 4 vahel peab programm tagastama

[[1,2,4], [1,3,4]]

Vastus: Pidasin silmas koodi loetavust ja lihtsust ning üritasin vältida asjatut keerukust.
Algoritmi valisin samuti lihtsust silmas pidades: https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/

Tagasiside:


Kokkuvõte Marko tööst:

- Ta ei ole jalgratast leiutama asunud vaid on võtnud depth first searchi (koodis ka viidanud, kust ta selle võttis) ning teinud 
  vist ühe kõige primitiivsematest (mitte halvas mõttes) ja lühematest implementatsioonidest, mida ma näinud olen C#-is
- Kuna lahendus on nii otsekohene, on ta mõistetav 15 sekundiga. Ainukene korraks lühistav koht on ühes testiversioonis char-ide 
  kasutus tippudena (mida .NET taustal ise cast-ib täisarvudeks)
- Embedded süsteemide arendajalt ootaks minimaalseid optimeerimisi, eelkõige adjacency listi kasutust, hetkel iga tipu juures 
  enumereeritakse kogu graaf uuesti, suurte reaalsete graafide juures on see väga kulukas
- Samal teemal jätkates, igas iteratsioonis uue currentPathi loomine ei ole väga optimaalne, selle asemel võiks currentPath-i 
  kopeerida ainult sobiva tee leidmisel.
- Ta on ülesande ilusasti pannud README.md-sse - kommunikatsiooni olulisus on tal selge, st. peegeldab tagasi, millist ülesannet 
  ta lahendab
- Teste pole, mis võibolla oleks olnud parem lähenemine kui 3-e erineva test-graafiga lihtsalt tulemuse väljastamine

Kokkuvõtteks - lahendus on päris hea selles mõttes, et tegemist pole keerulise pusserdusega, nagu me tihtipeale saame, see on 
pragmaatiline ja üleliigset seal pole. Hea meelega teeks ta tehnilise vestluse, kus käiks üle peamised ootused tehnilistele oskustele. 
Erinevalt algoritmilisest "kas ta oskab programmeerida põhimõttelisest" ülesandest seal me käime tavaliselt üle kogu stacki ja vaatame, 
millises osad tugevused ja kas ning kus nõrkused.