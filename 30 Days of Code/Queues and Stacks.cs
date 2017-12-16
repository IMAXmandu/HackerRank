class Solution {
    List<char> stack;
    List<char> queue;

    public Solution()
    {
        stack = new List<char>();
        queue = new List<char>();
    }

    public void pushCharacter(char c)
    {
        stack.Add(c);
    }

    public void enqueueCharacter(char c)
    {
        queue.Add(c);
    }

    public char popCharacter()
    {
        char ret = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return ret;
    }

    public char dequeueCharacter()
    {
        char ret = queue[0];
        queue.RemoveAt(0);
        return ret;
    }