//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assessments
//{

    //public class Player : IComparable<Player>
    //{
    //    private string name;
    //    private int runs;
    //    public Player(string name, int runs)
    //    {
    //        this.name = name;
    //        this.runs = runs;
    //    }

    //    public int CompareTo(Player? other) // other = rohit
    //    {
    //        // this.runs --> virat >rohit
    //        if (this.runs > other.runs)
    //        {
    //            return 1;
    //        }
    //        else if (this.runs < other.runs)
    //        {
    //            return -1;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }

    //    public override string ToString()
    //    {
    //        return $"name= {name}, runs ={runs}";
    //    }
    //}

    //public class Team : IEnumerable
    //{
    //    private Player[] players;
    //    public Team()
    //    {
    //        players = new Player[3];
    //        players[0] = new Player("Virat", 3000);
    //        players[1] = new Player("Rohit", 2500);
    //        players[2] = new Player("Dhoni", 2800);
    //    }
    //    public IEnumerator GetEnumerator()
    //    {
    //        return players.GetEnumerator();// GetEnumerator() for typecasting
    //    }
    //}




//    public class Player
//    {
//        private string name;
//        private int runs;

//        public int Runs
//        {
//            get { return runs; }
//        }
//        public Player(string name, int runs)
//        {
//            this.name = name;
//            this.runs = runs;
//        }
//        public override string ToString()
//        {
//            return $"name= {name}, runs ={runs}";
//        }
//    }



//    public class PlayerCompare : IComparer<Player>
//    {
//        // x-> virat , y-> rohit
//        public int Compare(Player? x, Player? y)
//        {
//            if (x.Runs > y.Runs)
//            {
//                return 1;
//            }
//            if (x.Runs > y.Runs)
//            {
//                return 1;
//            }
//            else if (x.Runs < y.Runs)
//            {
//                return -1;
//            }
//            else
//            {
//                return 0;
//            }
//        }
//    }
//}
