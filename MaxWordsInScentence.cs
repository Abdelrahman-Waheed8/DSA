using System;
using System.Collections.Generic;

public class MaxWords
{
    public MaxWords() { }

    public int MostWordsFound(string[] sentences) {
        int maxWords = 0; // 1. Track the global maximum across all sentences
        
        for(int i = 0; i < sentences.Length; i++)
        {
            // If a sentence can be empty, handle it, otherwise assume at least 1 word
            int currentSentenceWords = sentences[i].Length > 0 ? 1 : 0; 
            
            for(int j = 0; j < sentences[i].Length; j++)
            {
                if(sentences[i][j] == ' ')
                {
                    currentSentenceWords++; // Count the words (spaces + 1)
                }
            }
            
            // 2. Update maxWords if the current sentence has more words than previous ones
            if (currentSentenceWords > maxWords)
            {
                maxWords = currentSentenceWords;
            }
            
            // REMOVED: The premature return statement from here!
        }
        
        // 3. Return the ultimate maximum after checking EVERY sentence
        return maxWords;
    }
}