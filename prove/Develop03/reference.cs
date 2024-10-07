public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    // private int _endVerse;

    public Reference()
    {
        _book = "placeholder";

        _chapter = 1;

        _verse = 1;

    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;

        _chapter = chapter;

        _verse = verse;
    }
    public void SetReference(string book, int chapter, int verse)
    {
        _book = book;

        _verse = verse;

        _chapter = chapter;
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

}