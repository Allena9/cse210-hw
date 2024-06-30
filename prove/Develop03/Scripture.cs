using System;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<int> _randNum;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = [];
        _randNum =[];

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word tempWord = new Word(word);
            _words.Add(tempWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int availableWords = _words.Count();
        int counter = 0;

        //Picks which words to hide.
        while(counter < numberToHide && _randNum.Count() != availableWords)
        {
            int temp = random.Next(0, availableWords);

            if (!_randNum.Contains(temp))
            {
                _randNum.Add(temp);
                _words[temp].Hide();
                counter++;
            }
        }
    }
    public string GetDisplayText()
    {
        StringBuilder verses = new StringBuilder();
        verses.Append(_reference.GetDisplayText());

        foreach (Word word in _words)
        {
            verses.Append(' ');
            verses.Append(word.GetDisplayText());
        }

        return verses.ToString();
    }
    public bool IsCompletelyHidden()
    {
        bool checker = true;

        foreach (Word word in _words)
        {
            if (word.GetDisplayText() != "_____")
            {
                checker = false;
            }
        }

        return checker;
    }
}