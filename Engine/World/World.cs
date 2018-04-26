using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        // Get items, monsters, quests and locations ID
        // TODO: Implement that with JSON or XML(?)

        private static XmlDocument xmlItems = null;
        private static XmlDocument xmlMonsters = null;
        private static XmlDocument xmlQuests = null;
        private static XmlDocument xmlLocations = null;



        static World()
        {
            string _path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            try
            {
                if (xmlItems == null)
                {
                    xmlItems = new XmlDocument();
                    xmlItems.Load(_path + "/tables/Items.xml");
                }
                /*
                if (xmlMonsters == null)
                {
                    xmlMonsters = new XmlDocument();
                    xmlMonsters.Load(_path + "/tables/Monsters.xml");
                }
                if (xmlQuests == null)
                {
                    xmlQuests = new XmlDocument();
                    xmlQuests.Load(_path + "/tables/Quests.xml");
                }
                if (xmlLocations == null)
                {
                    xmlLocations = new XmlDocument();
                    xmlLocations.Load(_path + "/tables/Locations.xml");
                }*/
            }
            catch(XmlException e)
            {
                Console.WriteLine(e);
            }

            
            if(xmlItems != null)
                PopulateItems(xmlItems);
            /*
            PopulateMonsters(xmlMonsters);
            PopulateQuests(xmlQuests);
            PopulateLocations(xmlLocations);*/
        }

        private static void PopulateItems(XmlDocument xmlFile)
        {
            foreach (XmlNode node in xmlFile.SelectNodes("//*"))
            {
                if(node.Name == "weapon")
                {
                    int id = Int32.Parse(node.Attributes["id"].Value);
                    string name = null, nameplural = null;
                    int mindamage = -1, maxdamage = -1;                    

                    int i = 0; foreach(XmlNode childNode in node)
                    {
                        if (i == 0)
                            name = childNode.InnerText;
                        if (i == 1)
                            nameplural = childNode.InnerText;
                        if (i == 2)
                            mindamage = Int32.Parse(childNode.InnerText);
                        if (i == 3)
                            maxdamage = Int32.Parse(childNode.InnerText);

                        i++;
                    }

                    Console.WriteLine("ID: " + id);
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Name Plural: " + nameplural);
                    Console.WriteLine("Min. Damage:" + mindamage);
                    Console.WriteLine("Max. Damage: " + maxdamage);

                    // Weapon tag
                    Items.Add(new Weapon(id, name, nameplural, mindamage, maxdamage));

                    Console.WriteLine(Items.Count);

                } else if(node.Name == "item")
                {
                    Console.WriteLine("ID: " + Int32.Parse(node.Attributes["id"].Value));
                    Console.WriteLine("Name: " + node["name"].InnerText);
                    Console.WriteLine("Name Plural: " + node["nameplural"].InnerText);

                    // Item tag
                    Items.Add(new Item(Int32.Parse(node.Attributes["id"].Value), node["name"].InnerText, node["nameplural"].InnerText));

                    Console.WriteLine(Items.Count);

                } else if (node.Name == "potion")
                {
                    Console.WriteLine("ID: " + Int32.Parse(node.Attributes["id"].Value));
                    Console.WriteLine("Name: " + node["name"].InnerText);
                    Console.WriteLine("Name Plural: " + node["nameplural"].InnerText);
                    Console.WriteLine("Power: " + node["power"].InnerText);

                    // Potion tag
                    Items.Add(new Potion(Int32.Parse(node.Attributes["id"].Value), node["name"].InnerText, node["nameplural"].InnerText, 
                        Int32.Parse(node["power"].InnerText)));

                    Console.WriteLine(Items.Count);
                }
            }
        }

        private static void PopulateMonsters(XmlDocument xmlFile)
        {
            foreach (XmlNode node in xmlFile.DocumentElement.ChildNodes)
            {
                Console.WriteLine(node);
            }
        }

        private static void PopulateQuests(XmlDocument xmlFile)
        {
            foreach (XmlNode node in xmlFile.DocumentElement.ChildNodes)
            {
                Console.WriteLine(node);
            }
        }

        private static void PopulateLocations(XmlDocument xmlFile)
        {
            foreach (XmlNode node in xmlFile.DocumentElement.ChildNodes)
            {
                Console.WriteLine(node);
            }
        }

        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if(item.ID == id)
                {
                    return item;
                }                
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if(quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if(monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
