namespace FunWithLinq
{
    public class LinqOverArray
    {
        public static void QueryOverStrings()
        {
            // Array of strings
            string[] currentVideoGames = ["Fallout 3", "Daxter", "Uncharted 2"];

            //IEnumerable<string> subset =
            //    from g in currentVideoGames
            //    where g.Contains(' ')
            //    orderby g
            //    select g;

            IEnumerable<string> subset = currentVideoGames
                .Where(g => g.Contains(' '))
                .OrderBy(g => g)
                .Select(g => g);

            foreach (string s in subset) {
                Console.WriteLine("Item: {0}", s);
            }
        }

    }
}
