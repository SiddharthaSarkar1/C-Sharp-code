using System;
namespace SiddCodes{
    class Player{
        public string name = "John";
        public int healthIndex = 95;
        public void setName(string name){
            this.name = name;
        }
        public void setHealthIndex(int healthIndex){
            this.healthIndex = healthIndex;
        }
    }
    
    class CallPlayer{
        static void Main(string[] args){
            Player p = new Player();
            Player p1 = new Player();
            Player p2 = new Player();
            Console.WriteLine($"Player name is {p.name}, health index is {p.healthIndex}.");
            p1.setName("Sidd");
            p1.setHealthIndex(75);
            Console.WriteLine($"Player name is {p1.name}, health index is {p1.healthIndex}.");
            p2.setName("Saad");
            p2.setHealthIndex(82);
            Console.WriteLine($"Player name is {p2.name}, health index is {p2.healthIndex}.");
        }
    }
}