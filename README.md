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