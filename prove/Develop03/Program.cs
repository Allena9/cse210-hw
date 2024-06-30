using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("3 Nephi", 14, 8, 11);
        Scripture scripture = new Scripture(reference, "8 For every one that asketh, receiveth; and he that seeketh, findeth; and to him that knocketh, it shall be opened. 9 Or what man is there of you, who, if his son ask bread, will give him a stone? 10 Or if he ask a fish, will he give him a serpent? 11 If ye then, being evil, know how to give good gifts unto your children, how much more shall your Father who is in heaven give good things to them that ask him?");
        string tracker = "";
        
        while (tracker != "quit" && scripture.IsCompletelyHidden() != true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("");
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            tracker = Console.ReadLine();

            scripture.HideRandomWords(4);
        }
        if(scripture.IsCompletelyHidden() == true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        }
    }
}