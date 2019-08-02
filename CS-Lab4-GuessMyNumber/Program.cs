using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab4_GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Adventure Game");
                Console.WriteLine("1. Exit\n2. Start Game\nEnter Choice: ");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Have a nice day");
                    return;
                }
                else if (choice == "2")
                {
                    PlayGame();
                }
                else continue;
            }
        }

        static void PlayGame()
        {
            string saveFile = @"C:\Projects\save.txt";
            string configFile = @"C:\Projects\config.txt";
            Game game = new Game(saveFile, configFile);
            bool success;
            int adv; //index for adventure
            int mon; //index for monster
            int hurt; //holder for adjusting health
            int gain; //holder for adjusting gold
            string choice;
            string result;
            string[] results = game.Path;

            do
            {
                choice = GetChoice(results, game.Character.Health, game.Character.Gold);
                switch (choice)
                {
                    case "1":
                        adv = RandomNumber(0, (game.Adventures.Length)); //pick a random adventure
                        result = "You decide to " + game.Adventures[adv].Name + " and " + game.Adventures[adv].Description;
                        UpdateResults(result, results);
                        for (int i = 0; i < game.Adventures[adv].NumMonsters; i++) //loop for monster encounters on adventure
                        {
                            mon = RandomNumber(0, (game.Monsters.Length)); //pick a random monster
                            hurt = RandomNumber(0, game.Monsters[mon].Damage); //random damage between 0 and monster max
                            gain = RandomNumber(1, game.Monsters[mon].Gold); //random reward between 1 and monster max
                            game.Character.Health -= hurt; //apply damage
                            game.Character.Gold += gain; //apply reward
                            result = "While " + game.Adventures[adv].Action + " you encounter a " + game.Monsters[mon].Name +
                                     ". You defeat the " + game.Monsters[mon].Name + " takeing " + hurt + 
                                     " damage and finding " + gain + " gold.";
                            UpdateResults(result, results); //update the display
                            if (game.Character.Health < 1) //death check
                            {
                                Console.Clear();
                                Console.WriteLine("You died with " + game.Character.Gold + " gold, but it's lost forever...");
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                                return;
                            }
                        }
                        gain = RandomNumber(1, game.Adventures[adv].Reward); //get random adventure reward
                        game.Character.Gold += gain;
                        result = "After you finish " + game.Adventures[adv].Action + ", you are rewarded with " + gain + " gold.";
                        UpdateResults(result, results); //update the display
                        break;
                    case "2":
                        hurt = RandomNumber(0, 5);
                        game.Character.Health += hurt;
                        if (game.Character.Health < 100)
                        {
                            result = "Time to take a break.  You have healed " + hurt + "health.";
                            UpdateResults(result, results);
                        }
                        else
                        {
                            result = "Time to take a break.  You are fully healed.";
                            UpdateResults(result, results);
                        }
                        break;
                    case "3":
                        if (game.Character.Gold < 10)
                        {
                            result = "You don't have enough gold.  Maybe you should take a break.";
                            UpdateResults(result, results);
                        }
                        else
                        {
                            game.Character.Health = 100;
                            result = "You pay the healers and are fully restored.";
                            UpdateResults(result, results);
                        }
                        break;
                    case "4":
                        if (game.Character.Gold > 10000) result = "You retire in style with everything you ever wanted in life.";
                        else if (game.Character.Gold > 5000) result = "You retire in style with most of what you wanted in life.";
                        else if (game.Character.Gold > 1000) result = "You retire in style with some of what you wanted in life.";
                        else if (game.Character.Gold > 500) result = "You have a nice retirement.";
                        else if (game.Character.Gold > 250) result = "Your money runs out after a few years and you have to go back to work.";
                        else if (game.Character.Gold > 100) result = "Your money runs out in a year and you have to go back to work.";
                        else if (game.Character.Gold > 50) result = "Your money runs out in a few months and you have to go back to work.";
                        else if (game.Character.Gold > 10) result = "Your money runs out in a week and you have to go back to work.";
                        else if (game.Character.Gold > 1) result = "You have enough for the night and it's back to work tomorrow.";
                        else result = "You don't have anything but your life, but that's something.  Right?";
                        UpdateResults(result, results);
                        Console.Clear();
                        WriteResults(results);
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return;
                    case "5":
                        success = game.SaveGame();
                        if(success)
                        {
                            result = "Game Saved.";
                            UpdateResults(result, results);
                            Console.Clear();
                            WriteResults(results);
                        }
                        else
                        {
                            result = "Could not save game.";
                            UpdateResults(result, results);
                            Console.Clear();
                            WriteResults(results);
                        }
                        break;
                    case "6":
                        success = game.LoadGame();
                        if (success)
                        {
                            result = "Game Loaded.";
                            UpdateResults(result, results);
                            Console.Clear();
                            WriteResults(results);
                        }
                        else
                        {
                            result = "Could not load game.";
                            UpdateResults(result, results);
                            Console.Clear();
                            WriteResults(results);
                        }
                        break;
                    default:
                        Console.WriteLine("You're not supposed to be here.  Back to the main menu you go.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return;
                }

            } while (choice != "4");
        }
        static string GetChoice(string[] results, int health, int gold)
        {
            while (true)
            {
                Console.Clear();
                WriteResults(results);
                Console.WriteLine("Health: " + health + "\nGold " + gold +
                                  "\n1. Go on adventure.\n2. Rest.\n3. Get Healed (10 gold).\n4. Retire." +
                                  "\n5. Save Game\n6. Load Game\nEnter Choice:");
                string str = Console.ReadLine();
                if (str == "1" || str == "2" || str == "3" || str == "4" || str == "5" || str == "6")
                {
                    return str;
                }
                else
                {
                    UpdateResults("I don't know how to do that, try a number between 1 and 6.", results);
                }
            }
        }

        static void UpdateResults(string result, string[] results)
        {
            for (int i = 0; i < results.Length - 1; i++)
            {
                results[i] = results[i + 1];
            }
            results[results.Length - 1] = result;
        }

        static void WriteResults(string[] results)
        {
            for (int i = results.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(results[i]);
            }
            Console.WriteLine("");
        }
        static int RandomNumber(int min, int max) // RNG is fun!
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }

    class Being
    {
        int health;
        int gold;
        public int Health { get => health; set => health = value; }
        public int Gold { get => gold; set => gold = value; }

        public Being()
        {
            
        }
    }
    class Monster : Being
    {
        int damage;
        string name;
        public int Damage { get => damage; set => damage = value; }
        public string Name { get => name; set => name = value; }

        public Monster()
        {
            
        }
    }

    class Game
    {
        Being character;
        string[] path;
        string savePath;
        string configPath;
        Monster[] monsters;
        Adventure[] adventures;
        
        public Being Character { get => character; set => character = value; }
        public string[] Path { get => path; set => path = value; }
        public string SavePath { get => savePath; set => savePath = value; }
        public string ConfigPath { get => configPath; set => configPath = value; }
        public Monster[] Monsters { get => monsters; set => monsters = value; }
        public Adventure[] Adventures { get => adventures; set => adventures = value; }

        public Game(string savePath, string configPath)
        {
            int numMonsters = 0;
            int numAdventures = 0;
            this.Character = new Being();
            this.Character.Health = 100;
            this.Character.Gold = 0;
            this.Path = new string[5];
            this.SavePath = savePath;
            this.ConfigPath = configPath;
            List<string> config = new List<string>();
            if(!File.Exists(this.ConfigPath)) // if there's no config file create it.
            {
                FileStream newConfigStream = new FileStream(this.ConfigPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter newConfigFile = new StreamWriter(newConfigStream);
                newConfigFile.WriteLine("Monster|Slime|2|1|3");
                newConfigFile.WriteLine("Monster|Goblin|5|2|7");
                newConfigFile.WriteLine("Monster|Wolf|3|2|3");
                newConfigFile.WriteLine("Monster|Orc|8|5|12");
                newConfigFile.WriteLine("Monster|Bandit|10|7|15");
                newConfigFile.WriteLine("Monster|Doom Cat|20|30|50");
                newConfigFile.WriteLine("Adventure|fight some monsters|head out to fight some monsters|fighting some monsters|10|3");
                newConfigFile.WriteLine("Adventure|go exploring|set out for the great unknown|exploring|5|1");
                newConfigFile.WriteLine("Adventure|explore some ruins|travel to a place you've heard rumors about|searching through the ruins|15|2");
                newConfigFile.Close();
                newConfigStream.Close();
            }
            FileStream configStream = new FileStream(this.ConfigPath, FileMode.Open, FileAccess.Read);
            StreamReader configFile = new StreamReader(configStream);
            while (!configFile.EndOfStream)
            {
                config.Add(configFile.ReadLine());
            }
            configFile.Close();
            configStream.Close();
            for (int i = 0; i < config.Count; i++)
            {
                if (config[i].StartsWith("Monster"))
                {
                    numMonsters++;
                }
                if (config[i].StartsWith("Adventure"))
                {
                    numAdventures++;
                }
            }
            Monsters = new Monster[numMonsters];
            Adventures = new Adventure[numAdventures];
            int m = 0;
            int a = 0;
            for (int i = 0; i < config.Count; i++)
            {
                if (config[i].StartsWith("Monster"))
                {
                    Monsters[m] = new Monster();
                    string[] mon = config[i].Split("|");
                    Monsters[m].Name = mon[1];
                    Monsters[m].Health = Int32.Parse(mon[2]);
                    Monsters[m].Damage = Int32.Parse(mon[3]);
                    Monsters[m].Gold = Int32.Parse(mon[4]);
                    m++;
                }
                if (config[i].StartsWith("Adventure"))
                {
                    Adventures[a] = new Adventure();
                    string[] adv = config[i].Split("|");
                    Adventures[a].Name = adv[1];
                    Adventures[a].Description = adv[2];
                    Adventures[a].Action = adv[3];
                    Adventures[a].Reward = Int32.Parse(adv[4]);
                    Adventures[a].NumMonsters = Int32.Parse(adv[5]);
                    a++;
                }
            }
        }

        public bool SaveGame()
        {
            string state = this.Character.Health.ToString() + "|" + this.Character.Gold.ToString();
            for (int i = 0; i < Path.Length; i++)
            {
                state = state + "|" + Path[i];
            }
            FileStream saveStream;
            if(File.Exists(this.SavePath))
            {
                saveStream = new FileStream(this.SavePath, FileMode.Truncate, FileAccess.ReadWrite);
            }
            else
            {
                saveStream = new FileStream(this.SavePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            StreamWriter saveFile = new StreamWriter(saveStream);
            saveFile.WriteLine(state);
            saveFile.Close();
            saveStream.Close();
            return true;
        }
        public bool LoadGame()
        {
            if (File.Exists(this.SavePath))
            {
                string state;
                string[] splitState = new string[7];
                FileStream loadStream = new FileStream(this.SavePath, FileMode.Open, FileAccess.Read);
                StreamReader loadFile = new StreamReader(loadStream);
                state = loadFile.ReadLine();
                splitState = state.Split("|");
                this.Character.Health = Int32.Parse(splitState[0]);
                this.Character.Gold = Int32.Parse(splitState[1]);
                for (int i = 0; i < Path.Length; i++)
                {
                    Path[i] = splitState[(i + 2)];
                }
                loadFile.Close();
                loadStream.Close();
                return true;
            }
            else return false;
        }
    }
    class Adventure
    {
        string name;
        string description;
        string action;
        int reward;
        int numMonsters;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Action { get => action; set => action = value; }
        public int Reward { get => reward; set => reward = value; }
        public int NumMonsters { get => numMonsters; set => numMonsters = value; }

        public Adventure()
        {
            //everything is loaded later
        }
    }
}