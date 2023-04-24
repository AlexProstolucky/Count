using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> alphabet = new Dictionary<string, int>()
            {
                {"а",0},{"б",0},{"в",0},{"г",0},{"ґ",0},{"д",0},{"е",0},{"є",0},{"ж",0},{"з",0},{"и",0}
                ,{"і",0},{"ї",0},{"й",0},{"к",0},{"л",0},{"м",0},{"н",0},
                {"о",0},{"п",0},{"р",0},{"с",0},{"т",0},{"у",0},{"ф",0},
                {"х",0},{"ц",0},{"ч",0},{"ш",0},{"щ",0},{"ь",0},{"ю",0},{"я",0}
            };
        string path = "text.txt";
        FileStream fs = File.OpenRead(path);
        string buff = new StreamReader(fs).ReadToEnd().ToLower();
        fs.Close();
        foreach (char i in buff)
        {
            if (Convert.ToString(i) == "\n")
            {
                continue;
            }
            if (alphabet.ContainsKey(Convert.ToString(i)))
            {
                alphabet[Convert.ToString(i)] += 1;
            }
            else
            {
                alphabet.Add(Convert.ToString(i), 1);
            }
        }
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Згідно теексту у ньому перебуває:");
        foreach (var i in alphabet)
        {
            Console.WriteLine($"Елемент {i.Key} зустрічається {i.Value} разів");
        }
    }
}