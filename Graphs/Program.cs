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
            List<String> path = FindPath("Sofia", "Viena", visited);
            if (path == null)
            {
                Console.WriteLine("Path not found");
            }
            foreach (String city in path)
            {
                Console.WriteLine(city);
            }
        }

        static List<Link> links = new List<Link>();

        static void Init()
        {
            links.Add(new Link("Sofia", "Varna"));
            links.Add(new Link("Varna", "Burgas"));
            links.Add(new Link("Varna", "Dobrich"));
            links.Add(new Link("Sofia", "Burgas"));
            links.Add(new Link("Sofia", "Tirana"));
            links.Add(new Link("Tirana", "Duras"));
            links.Add(new Link("Tirana", "Kruja"));
            links.Add(new Link("Tirana", "Elbasan"));
            links.Add(new Link("Sofia", "Bucharest"));
            links.Add(new Link("Bucharest", "Constanca"));
            links.Add(new Link("Varna", "Constanca"));
            links.Add(new Link("Bucharest", "Timishoara"));
            links.Add(new Link("Constanca", "Braila"));
            links.Add(new Link("Bucharest", "Sinaj"));
            links.Add(new Link("Timishoara", "Budapest"));
            links.Add(new Link("Budapest", "Bratislava"));
            links.Add(new Link("Bratislava", "Viena"));
            links.Add(new Link("Budapest", "Viena"));
            links.Add(new Link("Budapest", "Debrecen"));
            //links.Add(new Link("Constanca", "Viena"));
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
                    result.Add(start);
                    result.Add(end);
                    return result;
                }
                else
                {
                    List<String> path = FindPath(city, end, vistited);
                    if (path != null)
                    {
                        path.Add(start);
                        return path;
                    }
                }
            }

            return null;
        }
    }
}
