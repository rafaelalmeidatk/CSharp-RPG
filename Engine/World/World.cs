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
			int id, mindamage, maxdamage, power;
			string name, nameplural;
			
            foreach (XmlNode node in xmlFile.SelectNodes("//*"))
            {
                if(node.Name == "weapon")
                {
					id 			= Int32.Parse(node.Attributes["id"].Value);
					name 		= childNode.SelectSingleNode("//name");
					nameplural 	= childNode.SelectSingleNode("//nameplural");
					mindamage	= childNode.SelectSingleNode("//mindamage");
					maxdamage	= childNode.SelectSingleNode("//maxdamage");

                    Console.WriteLine("ID: " + id);
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Name Plural: " + nameplural);
                    Console.WriteLine("Min. Damage:" + mindamage);
                    Console.WriteLine("Max. Damage: " + maxdamage);

                    // Weapon tag
                    Items.Add(new Weapon(id, name, nameplural, mindamage, maxdamage));
                } else if(node.Name == "item")
                {
					id 			= Int32.Parse(node.Attributes["id"].Value);
					name 		= childNode.SelectSingleNode("//name");
					nameplural 	= childNode.SelectSingleNode("//nameplural");
                    
                    Console.WriteLine("ID: " + id));
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Name Plural: " + nameplural);
					
					// Item tag
                    Items.Add(new Item(Int32.Parse(id), name, nameplural));
                } else if (node.Name == "potion")
                {
					id 			= Int32.Parse(node.Attributes["id"].Value);
					power		= Int32.Parse(childNode.SelectSingleNode("//power"));
					name 		= childNode.SelectSingleNode("//name");
					nameplural 	= childNode.SelectSingleNode("//nameplural");
                    
					Console.WriteLine("ID: " + Int32.Parse(id));
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Name Plural: " + nameplural);
                    Console.WriteLine("Power: " + power);

                    // Potion tag
                    Items.Add(new Potion(Int32.Parse(id), name, nameplural, power)));
                }
				
                Console.WriteLine(Items.Count);
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
