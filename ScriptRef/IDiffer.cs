using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                /// Provides methods for generate differences between texts
                /// </summary>
                /// <description>
                /// Testing publishing in scriptref
                /// </description>
                            public interface IDiffer
    {
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        /// <summary>
        /// ![The Project View displays all source files and created prefabs](Editor-Project_5c74fe3fa66a08177c1c0ade.png)
        /// </summary>
        /// <returns>
        /// [5c75240dbf9f0a0194bc1071](code_2_5c75240dbf9f0a0194bc1071.cs)
        /// </returns>
        /// <param name="newText">
        /// []()
        /// </param>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}