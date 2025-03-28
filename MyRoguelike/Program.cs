using System;

namespace MyRoguelike
{
    public enum Toughness
    {
        VeryEasy,
        Easy,
        Normal,
        Hard,
        Nightmare
    }
    public class Program
    {
        private static void Main()
        {
            Level lvl = new Level(125, Toughness.Nightmare);

            lvl.SetEnemyInRoom(0, new Enemy("Urdnot Wrex"));
            lvl.SetEnemyInRoom(120, new Enemy("Commander Shepard"));
            lvl.SetEnemyInRoom(41, new Enemy("Liara T'Soni"));
            lvl.SetEnemyInRoom(13, new Enemy("Tali'Zorah"));
            lvl.SetEnemyInRoom(59, new Enemy("Garrus Vakarian"));
            lvl.SetEnemyInRoom(99, new Enemy("Joker"));

            Console.WriteLine($"Toughness: {lvl.GetToughness()}");

            Console.WriteLine($"Number of rooms: {lvl.GetNumRooms()}");

            Console.WriteLine($"Number of enemies: {lvl.GetNumEnemies()}");

            lvl.PrintEnemies();

            // Este programa mostra o seguinte no ecrã:
            //
            // Toughness: Nightmare
            // Number of rooms: 125
            // Number of enemies: 6
            // Zeroth room: Urdnot Wrex
            // Thirteenth room: Tali'Zorah
            // Forty-First room: Liara T'Soni
            // Fifty-Ninth room: Garrus Vakarian
            // Ninety-Ninth room: Joker
            // Hundred and Twentieth room: Commander Shepard
        }
    }
    public class Level
    {
        private int numRooms;
        private Toughness toughness;
        private Enemy[] enemies;

        public Level(int numRooms, Toughness toughness)
        {
            this.numRooms = numRooms;
            this.toughness = toughness;
            enemies = new Enemy[numRooms];
        }

        public int GetNumRooms()
        {
            return numRooms;
        }

        public Toughness GetToughness()
        {
            return toughness;
        }

        public void SetEnemyInRoom(int room, Enemy enemy)
        {
            if (room >= 0 && room < numRooms)
            {
                enemies[room] = enemy;
            }
        }

        public int GetNumEnemies()
        {
            int count = 0;
            foreach (var enemy in enemies)
            {
                if (enemy != null) count++;
            }
            return count;
        }

        
    }
}
