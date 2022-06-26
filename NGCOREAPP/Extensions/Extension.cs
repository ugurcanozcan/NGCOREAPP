namespace NGCOREAPP.Extensions
{
    public static class Extension
    {
        public static string NextString(this Random random)
        {
            return ((char)random.Next('A', 'Z')).ToString();
        }
    }
}
