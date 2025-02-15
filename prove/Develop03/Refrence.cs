using  System;
public class Reference
{
    private string _book;
    private int _Chapter;
    private int _StartVerse;
    private int _EndVerse;

// this is for a single verse
    public Reference(string book, int Chapter, int StartVerse)
    {
        _book = book;
        _Chapter = Chapter;
        _StartVerse = StartVerse;
        _EndVerse = _StartVerse;
    }

    // this is for multiple verses
    public Reference(string book, int Chapter, int StartVerse, int endVerse)
    {
        _book = book;
        _Chapter = Chapter;
        _StartVerse = StartVerse;
        _EndVerse = endVerse;    
    }
    //Converting refrences to a readable string
    public override string ToString()
    {
        if (_StartVerse == _EndVerse)
        {
            return $"{_book} {_Chapter}: {_StartVerse}";
        }
        else
        {
            return $"{_book} {_Chapter}: {_StartVerse}-{_EndVerse}";
        }
    }
}
