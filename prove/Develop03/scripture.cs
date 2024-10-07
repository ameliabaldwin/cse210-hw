using System;

using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    Random rnd = new Random();
    public Scripture()
    {
        _words = new List<Word>();
    }
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>(); 
        string[] textSplit = text.Split(' ', ',');
        foreach (var word in textSplit)
        {
            _words.Add(new Word(word));
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = rnd.Next(_words.Count);  // Randomly selects an index
            Word word = _words[randomIndex];
            word.Hide();  // Hides the word at the random index
        }
    }
    public string GetDisplayText()
    {
        List<string> displayedWords = new List<string>();
        foreach (var word in _words)
        {
            displayedWords.Add(word.GetDisplayText()); 
        }
        return string.Join(" ", displayedWords);
    }
    public bool isCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
