namespace InternshipTest
{
    public class Knowledge
    {
        public int Level { get; }
        public Knowledge(int level)
        {
            Level = level;
        }
        //for overloading operator >,<
        public int CompareTo(Knowledge other)
        {
            if (other == null)
                return 1;
            return Level.CompareTo(other.Level);
        }
        public static bool operator >(Knowledge k1, Knowledge k2)
        {
            return k1.CompareTo(k2) > 0 ? true : false;
        }
        public static bool operator <(Knowledge k1, Knowledge k2)
        {
            return k1.CompareTo(k2) < 0 ? true : false;
        }
    }
}
