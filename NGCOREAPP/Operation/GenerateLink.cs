namespace NGCOREAPP.Operation
{
    public class GenerateLink
    {
        public string Generate()
        {
            string url = "";

            Random random = new Random();

            url += ((char)random.Next('A', 'Z')).ToString() + random.Next(999) + ((char)random.Next('A', 'Z')).ToString();

            return url;
        }
    }
}
