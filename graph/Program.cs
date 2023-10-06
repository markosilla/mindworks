// See https://aka.ms/new-console-template for more information

var graph1 = new List<(int, int)> { (3, 4), (1, 2), (1, 3), (2, 4) };
var ret = FindPaths(graph1, 1, 4);
ret.ForEach(x => { x.ForEach(y => Console.Write($"{y} ")); Console.WriteLine(); });

/* https://en.wikipedia.org/wiki/Directed_acyclic_graph#/media/File:Tred-G.svg */
var graph2 = new List<(int, int)> { ('a', 'b'), ('a', 'c'), ('a', 'd'), ('a', 'e'), ('c', 'e'), ('c', 'd'), ('b', 'd'), ('d', 'e'), ('a', 'x') };
ret = FindPaths(graph2, 'a', 'e');
ret.ForEach(x => { x.ForEach(y => Console.Write($"{(char)y} ")); Console.WriteLine(); });

/* https://qph.cf2.quoracdn.net/main-qimg-0a231e2af88a88c5244e7bb5201aec43 */
var graph3 = new List<(int, int)> { (5, 11), (11, 2), (11, 10), (11, 9), (7, 11), (7, 8), (8, 9), (3, 10), (3, 8) };
ret = FindPaths(graph3, 5, 9);
/* ret = FindPaths(graph3, 7, 9); */
ret.ForEach(x => { x.ForEach(y => Console.Write($"{y} ")); Console.WriteLine(); });

static List<List<int>> FindPaths(List<(int, int)> graph, int src, int dest) {
    var paths = new List<List<int>>();

    DFS(graph, src, dest, new List<int>(), paths);

    return paths;
}

static void DFS(List<(int, int)> graph, int current, int dest, List<int> currentPath, List<List<int>> paths)
{
    currentPath = new List<int>(currentPath) { current };

    if (current == dest)
    {
        paths.Add(currentPath);
        return;
    }

    foreach (var edge in graph.Where(x => current == x.Item1))
    {
        DFS(graph, edge.Item2, dest, currentPath, paths);
    }
}


