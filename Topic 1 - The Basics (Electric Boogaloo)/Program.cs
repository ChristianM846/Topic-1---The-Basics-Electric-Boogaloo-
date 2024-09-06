namespace Topic_1___The_Basics__Electric_Boogaloo_
{
    // Christian - Topic 1 assignment
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            string firstName = "Christian";
            string favMovie = "The Matrix";

            Console.WriteLine($"Hello user, my name is {firstName}, and my favorite movie is {favMovie}.".ToLower());

            favMovie = favMovie.ToUpper();

            Console.WriteLine("Part 1");
            Console.WriteLine();
            Console.WriteLine($"{favMovie}");
            Console.WriteLine();
            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine();

            favMovie = favMovie.Replace("A", "@").Replace("E", "3");

            Console.WriteLine(favMovie);
            Console.WriteLine();

            // Part 2
            string quote = "Never gonna give you up. Never gonna let you down. Never gonna run around and desert you.";

            Console.WriteLine("Part 2");
            Console.WriteLine($"'{quote}' without any vowels (including y) is:");

            quote = quote.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("y", "");

            Console.WriteLine(quote);
            Console.WriteLine("(Yes, you did just get rick rolled)");
            Console.WriteLine();

            //Part 3
            Console.WriteLine("Part 3");
            Console.WriteLine();
            Console.WriteLine("                   ,,,,                            |");
            Console.WriteLine("             ,;) .';;;;',                          |");
            Console.WriteLine(" ;;,,_,-.-.,;;'_,|(\\;;;/),,_                       |");
            Console.WriteLine("  `';;/:|:);{ ;;;|| \\;/ /;;;\\__                    |");
            Console.WriteLine("      L;/-';/ \\;;\\',/;\\/;;;.') \\                   |");
            Console.WriteLine("      .:`''` - \\;;'.__/;;;/  . _'-._               |");
            Console.WriteLine("    .'/   \\     \\;;;;;;/.'_7:.  '). \\_             |");
            Console.WriteLine("  .''/     | '._ );}{;//.'    '-:  '.,\\            |");
            Console.WriteLine(".'. /       \\  ( |;;;/_/         \\._./;\\   _,      |");
            Console.WriteLine(" . /        |\\ ( /;;/_/             ';;;\\,;;_,     |");
            Console.WriteLine(". /         )__(/;;/_/                (;;'''''     |");
            Console.WriteLine(" /        _;:':;;;;:';-._             );           |");
            Console.WriteLine("/        /   \\  `'`   --.'-._         \\/           |");
            Console.WriteLine("       .'     '.  ,'         '-,                   |");
            Console.WriteLine("      /    /   r--,..__       '.\\                  |");
            Console.WriteLine("    .'    '  .'        '--._     ]                 |");
            Console.WriteLine("    (     :.(;>        _ .' '- ;/                  |");
            Console.WriteLine("    |      /:;(    ,_.';(   __.'                   |");
            Console.WriteLine("     '- -'\"|;:/    (;;;;-'--'                      |");
            Console.WriteLine("           |;/      ;;(                            |");
            Console.WriteLine("           ''      /;;|                            |");
            Console.WriteLine("                   \\;;|                            |");
            Console.WriteLine("                    \\/                             |");

            Console.WriteLine("              _.--\"\"`-..");
            Console.WriteLine("            ,'          `.");
            Console.WriteLine("          ,'          __  `.");
            Console.WriteLine("         /|          \" __   \\");
            Console.WriteLine("        , |           / |.   .");
            Console.WriteLine("        |,'          !_.'|   |");
            Console.WriteLine("      ,'             '   |   |");
            Console.WriteLine("     /              |`--'|   |");
            Console.WriteLine("    |                `---'   |");
            Console.WriteLine("     .   ,                   |                       ,\".");
            Console.WriteLine("      ._     '           _'  |                    , ' \\ `");
            Console.WriteLine("  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|");
            Console.WriteLine("  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\");
            Console.WriteLine("-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .");
            Console.WriteLine("  `,         \"\"\"\"'     `.              ,'         |   |  ',,");
            Console.WriteLine("    `.      '            '            /          '    |'. |/");
            Console.WriteLine("      `.   |              \\       _,-'           |       ''");
            Console.WriteLine("        `._'               \\   '\"\\                .      |");
            Console.WriteLine("           |                '     \\                `._  ,'");
            Console.WriteLine("           |                 '     \\                 .'|");
            Console.WriteLine("           |                 .      \\                | |");
            Console.WriteLine("           |                 |       L              ,' |");
            Console.WriteLine("           `                 |       |             /   '");
            Console.WriteLine("            \\                |       |           ,'   /");
            Console.WriteLine("          ,' \\               |  _.._ ,-..___,..-'    ,'");
            Console.WriteLine("         /     .             .      `!             ,/'");
            Console.WriteLine("        /       `.          /        .           .'/");
            Console.WriteLine("       .          `.       /         |        _.'.'");
            Console.WriteLine("        `.          7`'---'          |------\"'_.'");
            Console.WriteLine("       _,.`,_     _'                ,''-----\"'");
            Console.WriteLine("   _,-_    '       `.     .'      ,\\");
            Console.WriteLine("   -\" /`.         _,'     | _  _  _.|");
            Console.WriteLine("    \"\"--'---\"\"\"\"\"'        `' '! |! /");
            Console.WriteLine("                            `\" \" -'");
            Console.WriteLine("");

        }
    }
}
