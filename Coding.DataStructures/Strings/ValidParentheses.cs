namespace Coding.DataStructures.Strings;

public abstract class ValidParentheses
{
    public static bool IsValid(string text)
    {
        var stack = new Stack<char>();
        
        for (var i = 0; i < text.Length ; i++)
        {
            if (text[i] == '(' || text[i] == '{' || text[i] == '[')
                stack.Push(text[i]);
            else if (text[i] == ')' && stack.Count > 0 && stack.Peek() == '(')
                stack.Pop();
            else if (text[i] == '}' && stack.Count > 0 && stack.Peek() == '{')
                stack.Pop();
            else if (text[i] == ']' && stack.Count > 0 && stack.Peek() == '[')
                stack.Pop();
            else
                return false;
        }

        return stack.Count == 0;
    }
}