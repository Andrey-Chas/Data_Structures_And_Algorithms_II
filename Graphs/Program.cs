using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();

            //List<String> neededCities = GetNeighbors("Budapest");
            //foreach (string city in neededCities)
            //{
            //    Console.WriteLine(city);
            //}

            List<String> visited = new List<String>();
            List<String> path = FindPathQ("Sofia", "Viena");
            if (path == null)
            {
                Console.WriteLine("Path not found");
            }
            else
            {
                foreach (String city in path)
                {
                    Console.WriteLine(city);
                }
            }
        }

        static List<Link> links = new List<Link>();

        static void Init()
        {
            links.Add(new Link("Sofia", "Varna", 100));
            links.Add(new Link("Varna", "Burgas", 120));
            links.Add(new Link("Varna", "Dobrich", 150));
            links.Add(new Link("Sofia", "Burgas", 90));
            links.Add(new Link("Sofia", "Tirana", 100));
            links.Add(new Link("Tirana", "Duras", 70));
            links.Add(new Link("Tirana", "Kruja", 60));
            links.Add(new Link("Tirana", "Elbasan", 50));
            links.Add(new Link("Sofia", "Bucharest", 40));
            links.Add(new Link("Bucharest", "Constanca", 100));
            links.Add(new Link("Varna", "Constanca", 90));
            links.Add(new Link("Bucharest", "Timishoara", 90));
            links.Add(new Link("Constanca", "Braila", 120));
            links.Add(new Link("Bucharest", "Sinaj", 140));
            links.Add(new Link("Timishoara", "Budapest", 40));
            links.Add(new Link("Budapest", "Bratislava", 110));
            links.Add(new Link("Bratislava", "Viena", 50));
            links.Add(new Link("Budapest", "Viena", 30));
            links.Add(new Link("Budapest", "Debrecen", 100));
            //links.Add(new Link("Viena", "Constanca", 100));
            //links.Add(new Link("Burgas", "Budapest", 900));
        }

        private static List<String> GetNeighbors(String node)
        {
            List<String> neededCities = new List<String>();

            foreach (Link city in links)
            {
               if (city.Node1 == node)
                {
                    neededCities.Add(city.Node2);
                }
               else if (city.Node2 == node)
                {
                    neededCities.Add(city.Node1);
                }
            }
            return neededCities;
        }

        private static List<String> GetNeighbors1(String node)
        {
            List<String> result = new List<String>();
            foreach (Link link in links)
            {
                if (link.GetOther(node) != null)
                {
                    result.Add(link.GetOther(node));
                }
            }
            return result;
        }

        private static List<String> FindPath(String start, String end, List<String> vistited)
        {
            if (start == end)
            {
                return null;
            }

            if (vistited.Contains(start))
            {
                return null;
            }

            List<String> neighbors = GetNeighbors(start);
            vistited.Add(start);

            foreach (String city in neighbors)
            {
                if (city == end)
                {
                    List<String> result = new List<String>();
                    result.Add(end);
                    result.Add(start);
                    return result;
                }
            }

            foreach (String city in neighbors)
            {
                List<String> path = FindPath(city, end, vistited);
                if (path != null)
                {
                    path.Add(start);
                    return path;
                }
            }

            return null;
        }

        private static String FindPathQ(String start, String end)
        {
            Queue<String> q = new Queue<String>();
            List<String> visited = new List<String>();
            List<String> paths = new List<String>();
            String delimiter = "; ";
            paths.Add(start + delimiter);
            visited.Add(start);
            q.Enqueue(start);
            while (q.Count > 0)
            {
                String node = q.Dequeue();

                List<String> neighbors = GetNeighbors(node);
                foreach (String neigbor in neighbors)
                {
                    if (neigbor == end)
                    {
                        foreach (String path in paths)
                        {
                            if (path.EndsWith(node + delimiter))
                            {
                                return path + end;
                            }
                        }
                    }
                }

                foreach (String neighbor in neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        q.Enqueue(neighbor);
                        visited.Add(neighbor);
                        for (int i = 0; i < paths.Count; i++)
                        {
                            if (paths[i].EndsWith(node + delimiter))
                            {
                                paths.Add(paths[i] + neighbor + delimiter);
                            }
                        }
                    }
                }
            }
            return null;
        }

        private static void FindPathWithCost(String start, String end)
        {
            Dictionary<String, int> distanceToStart = new Dictionary<String, int>();
            Dictionary<String, String> previous = new Dictionary<String, String>();
            List<String> nodes = new List<String>();
            List<String> visited = new List<String>();

            nodes.Add(start);
            distanceToStart.Add(start, 0);

            while (nodes.Count > 0)
            {
                String next = FindClosest(nodes[0]);
                if (next == end)
                {
                    return;
                }

                List<String> neighbors = GetNeighbors(next);
                foreach (String neighbor in neighbors)
                {
                    distanceToStart(neighbor) = distanceToStart(next) + cost(next, neighbor);

                }
            }
        }

        private static String FindClosest(String node)
        {
            String closest = null;

            foreach (Link city in links)
            {
                if (city.Node1 == node)
                {

                }
            }
        }
    }
}
