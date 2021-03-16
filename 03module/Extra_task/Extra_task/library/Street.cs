using System;

namespace library
{
    [Serializable]
    public class Street
    {
        public Street(string name, int[] houses)
        {
            Name = name;
            Houses = houses;
        }
        public string Name { get; set; }
        public int[] Houses { get; set; }
        public static int operator ~(Street street)
        {
            return street.Houses.Length;
        }
        public static bool operator !(Street street)
        {
            return street.Contains7();
        }
        private bool Contains7()
        {
            bool has7 = false;
            foreach (int house in Houses)
            {
                int x = house;
                while(x != 0)
                {
                    if (x % 10 == 7)
                    {
                        has7 = true;
                        break;
                    }
                    x /= 10;
                }
                if (has7)
                    break;
            }
            return has7;
        }
        public override string ToString()
        {
            string output = "";
            output += $"{Name}\n";
            foreach (int n in Houses)
                output += n + " ";
            return output;
        }

    }
}
