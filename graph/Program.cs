// See https://aka.ms/new-console-template for more information

var graph = new List<(int, int)> { (1, 2), (1, 3), (2, 4), (3, 4) };

var ret = FindPaths(graph, 1, 4);

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
        if (currentPath.Contains(edge.Item2))
            continue; /* Already visited */

        DFS(graph, edge.Item2, dest, currentPath, paths);
    }
}