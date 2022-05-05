using System;
using System.Collections.Generic;

namespace lab2_2
{
    public class SortStation
    {
        public List<Trash> trash = new List<Trash>();
        public SortStation(params Trash[] arr)
        {
            foreach (var trashT in arr)
            {
                trash.Add(trashT);
            }
        }

        public void SortBySize()
        {
            Console.WriteLine("sorting trash");
            trash.Sort();

            foreach (Trash trashT in trash)
            {
                trashT.getTrashType();
                trashT.getTrashSize();
            }
        }

    }
    public abstract class Trash : IComparable<Trash>
    {
        public int CompareTo(Trash other)
        {
            if (this.size > other.size)
            {
                return 1;
            }
            else if (this.size < other.size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public abstract void getSize();

        public void getTrashSize()
        {
            Console.WriteLine(size);
        }

        static public void getFullSize(params Trash[] arr)
        {
            int totalSize = 0;
            foreach (var trash in arr)
            {
                totalSize += trash.size;
            }
            Console.WriteLine("Total size of your trash is:");
            Console.WriteLine(totalSize);
        }

        private int size;
        public Trash(int size)
        {
            this.size = size;
        }
        public abstract void getTrashType();
    }

    public class Plastic : Trash
    {
        private int size;
        public override void getSize()
        {
            Console.WriteLine(Size);
        }
        public int Size { get { return size; } set { size = value; } }

        public Plastic(int size) : base(size) { }

        private static string trashType = "Plastic";
        public override void getTrashType()
        {
            Console.WriteLine(trashType);
        }

    }

    public class Glass : Trash
    {
        private int size;
        public override void getSize()
        {
            Console.WriteLine(Size);
        }
        public int Size { get { return size; } set { size = value; } }

        public Glass(int size) : base(size) { }

        private static string trashType = "Glass";
        public override void getTrashType()
        {
            Console.WriteLine(trashType);
        }

    }

    public class Compost : Trash
    {
        private int size;
        public override void getSize()
        {
            Console.WriteLine(Size);
        }
        public int Size { get { return size; } set { size = value; } }

        public Compost(int size) : base(size) { }

        private static string trashType = "Compost";
        public override void getTrashType()
        {
            Console.WriteLine(trashType);
        }

    }

    public class Paper : Trash
    {
        private int size;
        public override void getSize()
        {
            Console.WriteLine(Size);
        }
        public int Size { get { return size; } set { size = value; } }

        public Paper(int size) : base(size) { }

        private static string trashType = "Recycle";
        public override void getTrashType()
        {
            Console.WriteLine(trashType);
        }

    }


    static class Programm
    {
        static void Main()
        {
            //creating trash instances
            Plastic plasticBottles = new Plastic(15);
            Glass glassBottles = new Glass(10);
            Compost vegetablesAndFruits = new Compost(45);
            Paper officePaper = new Paper(5);
            Plastic plasticBoxes = new Plastic(25);

            //sorting our trash by size
            /*Trash.sortBySize(plasticBottles, glassBottles, vegetablesAndFruits, officePaper, plasticBoxes);*/


            SortStation sortStation = new SortStation(plasticBottles, glassBottles, vegetablesAndFruits, officePaper, plasticBoxes); ;
            sortStation.SortBySize();

            /*//getting the full size of our trash
            Trash.getFullSize(plasticBottles, glassBottles, vegetablesAndFruits, officePaper, plasticBoxes);*/
        }


    }
}