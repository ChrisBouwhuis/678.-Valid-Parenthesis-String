namespace ClassLib
{
    public class Solution
    {
        public bool CheckValidString(string s)
        {
            Stack<int> left = new Stack<int>();
            Stack<int> star = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    left.Push(i);
                }
                else if (s[i] == '*')
                {
                    star.Push(i);
                }
                else
                {
                    if (left.Count > 0)
                    {
                        left.Pop();
                    }
                    else if (star.Count > 0)
                    {
                        star.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            while (left.Count > 0 && star.Count > 0)
            {
                if (left.Pop() > star.Pop())
                {
                    return false;
                }
            }

            return left.Count == 0;
        }
    }
}
