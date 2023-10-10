# mindworks
Loo C#-is klass, mis arvutab tipupaaridena etteantud etteantud ats�klilises suunatud graafis k�ik v�imalikud teed kahe tipu vahel. 
Tippe t�histavad juhuslikud t�isarvud. Graaf on esitatud kujul List<Tuple<int, int>> kus iga Tuple<int, int> esitab graafil seost 
esimeselt tuple elemendilt teisele. K�ik v�imalikud teed tuleb tagastada List<List<int>> struktuuris.

N�iteks graafi

var graph = new List<(int, int)> { (1, 2), (1, 3), (2, 4), (3, 4) };

Korral k�sides seoseid tippude 1 ja 4 vahel peab programm tagastama

[[1,2,4], [1,3,4]]

Vastus: Pidasin silmas koodi loetavust ja lihtsust ning �ritasin v�ltida asjatut keerukust.
Algoritmi valisin samuti lihtsust silmas pidades: https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/

Tagasiside:


Kokkuv�te Marko t��st:

- Ta ei ole jalgratast leiutama asunud vaid on v�tnud depth first searchi (koodis ka viidanud, kust ta selle v�ttis) ning teinud 
  vist �he k�ige primitiivsematest (mitte halvas m�ttes) ja l�hematest implementatsioonidest, mida ma n�inud olen C#-is
- Kuna lahendus on nii otsekohene, on ta m�istetav 15 sekundiga. Ainukene korraks l�histav koht on �hes testiversioonis char-ide 
  kasutus tippudena (mida .NET taustal ise cast-ib t�isarvudeks)
- Embedded s�steemide arendajalt ootaks minimaalseid optimeerimisi, eelk�ige adjacency listi kasutust, hetkel iga tipu juures 
  enumereeritakse kogu graaf uuesti, suurte reaalsete graafide juures on see v�ga kulukas
- Samal teemal j�tkates, igas iteratsioonis uue currentPathi loomine ei ole v�ga optimaalne, selle asemel v�iks currentPath-i 
  kopeerida ainult sobiva tee leidmisel.
- Ta on �lesande ilusasti pannud README.md-sse - kommunikatsiooni olulisus on tal selge, st. peegeldab tagasi, millist �lesannet 
  ta lahendab
- Teste pole, mis v�ibolla oleks olnud parem l�henemine kui 3-e erineva test-graafiga lihtsalt tulemuse v�ljastamine

Kokkuv�tteks - lahendus on p�ris hea selles m�ttes, et tegemist pole keerulise pusserdusega, nagu me tihtipeale saame, see on 
pragmaatiline ja �leliigset seal pole. Hea meelega teeks ta tehnilise vestluse, kus k�iks �le peamised ootused tehnilistele oskustele. 
Erinevalt algoritmilisest "kas ta oskab programmeerida p�him�ttelisest" �lesandest seal me k�ime tavaliselt �le kogu stacki ja vaatame, 
millises osad tugevused ja kas ning kus n�rkused.