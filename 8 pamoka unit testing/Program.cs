int length = Methods.GetTextLength(" test ", true);

Console.WriteLine(length);
public static class Methods
{
   public static int GetTextLength(string text, bool includeLeadSpace = false, string someParam = "")
    {
        if (!includeLeadSpace)
        {
            return text.Trim().Length;
        }
            return text.Length;
    }
}

