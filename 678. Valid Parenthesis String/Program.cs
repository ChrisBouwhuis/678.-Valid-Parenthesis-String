using ClassLib;
namespace _678._Valid_Parenthesis_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "((((()(()()()*()(((((*)()*(**(())))))(())()())(((())())())))))))(((((())*)))()))(()((*()*(*)))(*)()";
            var sol = new Solution();
            bool result = sol.CheckValidString(s);
            Console.WriteLine(result);
        }
    }
}
