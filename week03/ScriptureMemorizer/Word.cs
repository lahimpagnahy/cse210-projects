/// <summary>
/// The Word class represents a single word in a scripture
/// </summary>
class Word
{
    private string _text;
    private bool _isHidden;
    
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    /// <summary>
    /// Hides the word by setting isHidden to true
    /// </summary>
    public void Hide()
    {
        _isHidden = true;
    }
    
    /// <summary>
    /// Shows the word by setting isHidden to false
    /// </summary>
    public void Show()
    {
        _isHidden = false;
    }
    
    /// <summary>
    /// Returns whether the word is currently hidden
    /// </summary>
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    /// <summary>
    /// Returns the word text or a series of underscores if the word is hidden
    /// </summary>
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Create a string of underscores matching the length of the word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}