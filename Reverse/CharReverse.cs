using System.Text;

namespace Reverse
{
    public class CharReverse
    {
        private HashSet<char> delimiters = new HashSet<char>() { ' ', ',', '.' };

        public string Reverse(string input)
        {
            var output = new StringBuilder();
            StringBuilder? wordBuffer = null;

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                if (delimiters.Contains(currentChar))
                {
                    if (wordBuffer != null)
                    {
                        output.Append(wordBuffer);
                        wordBuffer = null;
                    }

                    output.Append(currentChar);
                } else
                {
                    if (wordBuffer == null)
                    {
                        wordBuffer = new StringBuilder();
                    }

                    wordBuffer.Insert(0, currentChar);
                }
            }

            if (wordBuffer != null)
            {
                output.Append(wordBuffer);
            }

            return output.ToString(); ;
        }
    }
}