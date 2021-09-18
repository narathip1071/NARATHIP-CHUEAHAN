using System;
using System.Collections.Generic;
namespace Quiz
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int Total_Rose;
            int Total_Sum_Fiower;
            Total_Rose = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Rose: {0}", Total_Rose);
            Total_Sum_Fiower = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Rose: {0}", Total_Sum_Fiower);

            Rose roses = new Rose(1, "ดอกกุหลาบขาว", "สวยงามมาก", 2, "10.5", "6");
            Sunflower sunflower = new Sunflower(1, "ดอกทานตะวันเล็ก", "สวยงาม", 1, "2", "2.0");

            
            
        }
    
    }
    class Data_Flower
    {
        public int ID;
        public string NameFlower;
        public string FlowerDescription;
        public int TreeTotai;
        public string TreeHeight;
        public string TreeCircumference;

        public Data_Flower(int ID, string NameFlower, string FlowerDescription, int TreeTotai, string TreeHeight, string TreeCircumference)
            
        {
            this.ID = ID;
            this.NameFlower = NameFlower;
            this.FlowerDescription = FlowerDescription;
            this.TreeTotai = TreeTotai;
            this.TreeHeight = TreeHeight;
            this.TreeCircumference = TreeCircumference;
        }
       
    }
    class Rose : Data_Flower
    {
        public Rose(int ID, string NameFlower, string FlowerDescription, int TreeTotai, string TreeHeight, string TreeCircumference)
            : base(ID, NameFlower, FlowerDescription, TreeTotai, TreeHeight, TreeCircumference) { }

        public List<Rose> roses;
        
    }
    class Sunflower : Data_Flower
    {
        public Sunflower(int ID, string NameFlower, string FlowerDescription, int TreeTotai, string TreeHeight, string TreeCircumference)
            : base(ID, NameFlower, FlowerDescription, TreeTotai, TreeHeight, TreeCircumference) { }
        public List<Sunflower> sunflower;
    }



}
