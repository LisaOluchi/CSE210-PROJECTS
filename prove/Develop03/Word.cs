public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string Text
    {
        get { return _isHidden ? "*****" : _text; }
    }

    public bool IsHidden
    {
        get { return _isHidden; }
        set { _isHidden = value; }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Unhide()
    {
        _isHidden = false;
    }
}
