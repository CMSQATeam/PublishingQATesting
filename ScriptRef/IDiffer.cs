using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                /// Provides methods for generate differences between texts testing the type script code
                /// </summary>
                /// <description>
                /// [5c89f3a50c6ec2070cd5b3cf](Typescriptcode_5c89f3a50c6ec2070cd5b3cf.cs)
                /// </description>
                            public interface IDiffer
    {
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        /// <summary>
        /// Testing the php code
        /// </summary>
        /// <description>
        /// [5c89f3960c6ec2070cd5b3cb](PHPcode_5c89f3960c6ec2070cd5b3cb.cs)
        /// </description>
        /// <returns>
        /// Jquery code<br>  [5c89f38e0c6ec2070cd5b3c7](Jquerycode_5c89f38e0c6ec2070cd5b3c7.cs)
        /// </returns>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        /// <summary>
        /// C shap code testing
        /// </summary>
        /// <description>
        /// [5c89014a20d8a636bcf3f898](c sharp_5c89014a20d8a636bcf3f898.cs)
        /// </description>
        /// <returns>
        /// [5c823b1c02b404286c900262](C#code1_5c823b1c02b404286c900262.cs)
        /// </returns>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}