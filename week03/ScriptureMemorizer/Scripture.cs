using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// The Scripture class represents a scripture with a reference and a collection of words.
/// </summary>
class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Remarque 13
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }
    
    /// <summary>
    /// Hides a specified number of random words in the scripture
    /// </summary>
    public void HideRandomWords(int numberToHide)
    {
        // Get a list of words that are not yet hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        
        // If all words are hidden or numberToHide is greater than available words,
        // adjust numberToHide
        if (visibleWords.Count == 0)
        {
            return;
        }
        
        if (numberToHide > visibleWords.Count)
        {
            numberToHide = visibleWords.Count;
        }
        
        // Create random number generator
        Random random = new Random();
        
        // Hide random words
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            
            // Remove the word from the list so it won't be selected again
            visibleWords.RemoveAt(index);
        }
    }
    
    /// <summary>
    /// Returns the full text display of the scripture with reference
    /// </summary>
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        
        // Append each word's display text
        for (int i = 0; i < _words.Count; i++)
        {
            displayText += _words[i].GetDisplayText();
            
            // Add a space after each word except the last one
            if (i < _words.Count - 1)
            {
                displayText += " ";
            }
        }
        
        return displayText;
    }
    
    /// <summary>
    /// Checks if all words in the scripture are hidden
    /// </summary>
    public bool IsCompletelyHidden()
    {
        // Check if all words are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        return true;
    }
}