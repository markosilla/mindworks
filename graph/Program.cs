// See https://aka.ms/new-console-template for more information

/* var graph = new List<(int, int)> { (3, 4), (1, 2), (1, 3), (2, 4) };
var ret = FindPaths(graph, 1, 4); */

/* var graph = new List<(int, int)> { ('a', 'b'), ('a', 'c'), ('a', 'd'), ('a', 'e'), ('c', 'e'), ('c', 'd'), ('b', 'd'), ('d', 'e'), ('a', 'x') };
var ret = FindPaths(graph, 'a', 'e');
ret.ForEach(x => { x.ForEach(y => Console.Write($"{(char)y} ")); Console.WriteLine(); }); */

var graph = new List<(int, int)> { (5, 11), (2, 11), (11, 10), (11, 9), (11, 7), (7, 8), (9, 8), (10, 3), (3, 8), /*(3,3)*/ };
var ret = FindPaths(graph, 5, 8);
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


