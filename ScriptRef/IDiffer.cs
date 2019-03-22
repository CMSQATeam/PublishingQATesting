using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                /// Testing the publishing issues
                /// </summary>
                /// <description>
                /// ![](moon_5c74fc03bf9f0a0194bb1e30.jpeg)
                /// </description>
                            public interface IDiffer
    {
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        /// <summary>
        /// [5c752255bf9f0a0194bc0ae5](code_2_5c752255bf9f0a0194bc0ae5.cs)
        /// </summary>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}