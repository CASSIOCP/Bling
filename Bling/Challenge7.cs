namespace Bling
{
    public static class Challenge7
    {
        private static string allPaths = "";

        /// <summary>
        /// Read a graph (an array of edges) and find all paths from a source vertex to a destination vertex.
        /// </summary>
        /// <param name="paths"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns>Return a string with all paths and their costs</returns>
        public static string FindAllPathsInGraph(Edge[] paths, char source, char destination)
        {
            string path = "";
            int cost = 0;

            CrossPath(paths, source, destination, path, cost);

            return allPaths != "" ? allPaths : "Path not found";
        }

        private static void CrossPath(Edge[] paths, char source, char destination, string path, int cost)
        {
            if (HasVertex(path, source))
                return;

            if (source == destination)
            {
                allPaths += $"path: {path + source} - cost: {cost}\n";
                return;
            }

            for (int i = 0; i < paths.Length; i++)
            {
                if (paths[i].Vertex1 == source)
                {
                    CrossPath(paths, paths[i].Vertex2, destination, path + source, cost + paths[i].Cost);
                }
                else if (paths[i].Vertex2 == source)
                {
                    CrossPath(paths, paths[i].Vertex1, destination, path + source, cost + paths[i].Cost);
                }
            }
        }

        private static bool HasVertex(string vertices, char vertex)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                if (vertices[i] == vertex)
                    return true;
            }

            return false;
        }
    }
}