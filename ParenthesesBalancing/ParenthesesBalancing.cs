namespace ParenthesesBalancing
{
    public class ParenthesesBalancing
    {
        private const char OPEN_PARENTHESIS = '(';
        private const char CLOSE_PARENTHESIS = ')';

        public bool IsBalanced(string input)
        {
            int openParenthesisCount = 0;

            foreach (var element in input)
            {
                if (element == OPEN_PARENTHESIS)
                {
                    openParenthesisCount++;
                }
                else if (element == CLOSE_PARENTHESIS)
                {
                    if (openParenthesisCount == 0)
                    {
                        return false;
                    } else
                    {
                        openParenthesisCount--;
                    }
                }
            }

            return openParenthesisCount == 0;
        }
    }
}