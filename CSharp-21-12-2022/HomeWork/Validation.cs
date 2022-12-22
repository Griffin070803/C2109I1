namespace HomeWork;
internal class Validation
{
    public static bool checkRegex(String regex, String message)
    {
        Regex re = new Regex(regex);
        while (true)
        {
            if (re.IsMatch(message))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
