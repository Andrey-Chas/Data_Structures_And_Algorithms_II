using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Init();
            InitializeComponent();
        }

        private void FindPath_Click(object sender, EventArgs e)
        {
            Refresh();
            Graphics gr = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            string start = startCity.Text;
            string end = endCity.Text;
            double totalDistance = 0;
            if (start == end)
            {
                message.BackColor = Color.Red;
                message.Text = "You are going to the same city";
                timeBox.Text = null;
                distance.Text = null;
            }
            else if (startCity.Text == "Select start city" || endCity.Text == "Select destination")
            {
                message.BackColor = Color.Red;
                message.Text = "Please choose start and destination";
                timeBox.Text = null;
                distance.Text = null;
            }
            else
            {
                List<Label> labels = new List<Label>()
            {
                lblBurgas,
                lblDobrich,
                lblKazanlyk,
                lblRazgrad,
                lblShumen,
                lblSilistra,
                lblSliven,
                lblStaraZagora,
                lblTyrgowishte,
                lblVarna,
                lblVelikoTyrnovo,
                lblYambol
            };
                List<string> path = Path(start, end, timeBox);
                List<Label> draw = new List<Label>();
                foreach (string city in path)
                {
                    foreach (Label label in labels)
                    {
                        if (label.Text == city)
                        {
                            draw.Add(label);
                        }
                    }
                }
                foreach (Link node in links)
                {
                    for (int i = 0; i < path.Count; i++)
                    {
                        if (i + 1 == path.Count)
                        {
                            break;
                        }
                        if (node.Node1 == path[i] && node.Node2 == path[i + 1])
                        {
                            totalDistance = totalDistance + node.Distance;
                        }
                        else if (node.Node1 == path[i + 1] && node.Node2 == path[i])
                        {
                            totalDistance = totalDistance + node.Distance;
                        }
                    }
                }
                for (int i = 0; i < draw.Count; i++)
                {
                    gr.DrawLine(pen, draw[i].Location.X, draw[i].Location.Y,
                        draw[i + 1].Location.X, draw[i + 1].Location.Y);
                    if (i + 1 == draw.Count - 1)
                    {
                        break;
                    }
                }
                message.BackColor = Color.White;
                message.Text = "Path found";
                distance.Text = Convert.ToString($"{totalDistance} km");
            }
        }

        static List<Link> links = new List<Link>();

        static void Init()
        {
            links.Add(new Link("Varna", "Dobrich", 52, 60));
            links.Add(new Link("Varna", "Burgas", 116, 60));
            links.Add(new Link("Varna", "Shumen", 90, 60));
            links.Add(new Link("Dobrich", "Silistra", 90, 60));
            links.Add(new Link("Silistra", "Shumen", 113, 60));
            links.Add(new Link("Silistra", "Razgrad", 119, 60));
            links.Add(new Link("Silistra", "Veliko Tyrnovo", 230, 60));
            links.Add(new Link("Shumen", "Razgrad", 50, 60));
            links.Add(new Link("Shumen", "Tyrgowishte", 42, 60));
            links.Add(new Link("Shumen", "Sliven", 135, 60));
            links.Add(new Link("Tyrgowishte", "Razgrad", 37, 60));
            links.Add(new Link("Tyrgowishte", "Veliko Tyrnovo", 100, 60));
            links.Add(new Link("Tyrgowishte", "Sliven", 110, 60));
            links.Add(new Link("Veliko Tyrnovo", "Kazanlyk", 100, 60));
            links.Add(new Link("Veliko Tyrnovo", "Sliven", 112, 60));
            links.Add(new Link("Veliko Tyrnovo", "Razgrad", 117, 60));
            links.Add(new Link("Kazanlyk", "Sliven", 87, 60));
            links.Add(new Link("Kazanlyk", "Stara Zagora", 35, 60));
            links.Add(new Link("Stara Zagora", "Yambol", 87, 60));
            links.Add(new Link("Yambol", "Sliven", 29, 60));
            links.Add(new Link("Yambol", "Burgas", 93, 60));
            links.Add(new Link("Sliven", "Burgas", 115, 60));
        }

        private static Dictionary<string, double> GetNeighbors(string node)
        {
            Dictionary<string, double> citiesTime = new Dictionary<string, double>();

            foreach (Link city in links)
            {
                if (city.Node1 == node)
                {
                    citiesTime.Add(city.Node2, city.Distance / city.Speed);
                }
                else if (city.Node2 == node)
                {
                    citiesTime.Add(city.Node1, city.Distance / city.Speed);
                }
            }
            return citiesTime;
        }

        private static List<string> Path(string start, string end, TextBox timeBox)
        {
            Dictionary<string, double> smallestCost = new Dictionary<string, double>();
            Dictionary<string, string> prevPath = new Dictionary<string, string>();
            List<string> visited = new List<string>();
            Queue<string> nodesToVisit = new Queue<string>();
            
            smallestCost.Add(start, 0);
            visited.Add(start);

            string currentNode = start;

            while (true)
            {
                double time = smallestCost[currentNode];

                Dictionary<string, double> next = GetNeighbors(currentNode);

                foreach (KeyValuePair<string, double> value in next)
                {
                    string neighbor = value.Key;
                    double cost = value.Value;

                    if (!visited.Contains(neighbor))
                    {
                        nodesToVisit.Enqueue(neighbor);
                    }

                    double thisTime = time + cost;

                    if (prevPath.ContainsKey(neighbor))
                    {
                        double anotherTime = smallestCost[neighbor];

                        if (thisTime < anotherTime)
                        {
                            prevPath[neighbor] = currentNode;
                            smallestCost[neighbor] = thisTime;
                        }
                    }
                    else
                    {
                        prevPath[neighbor] = currentNode;
                        smallestCost[neighbor] = thisTime;
                    }
                }
                visited.Add(currentNode);

                if (nodesToVisit.Count == 0)
                {
                    break;
                }

                currentNode = nodesToVisit.Dequeue();
            }

            List<string> path = new List<string>();

            currentNode = end;

            while (currentNode != start)
            {
                path.Add(currentNode);

                currentNode = prevPath[currentNode];
            }

            path.Add(start);

            double costToDisplay = smallestCost[end];
            double decimalPart = costToDisplay - Math.Truncate(costToDisplay);
            double decimalPartMin = decimalPart * 60;

            if (Math.Truncate(costToDisplay) == 0)
            {
                timeBox.Text = Convert.ToString($"{Math.Round(decimalPartMin)} min");
            }
            else
            {
                timeBox.Text = Convert.ToString($"{Math.Truncate(costToDisplay)} h {Math.Round(decimalPartMin)} min");
            }

            return path;
        }
    }
}
