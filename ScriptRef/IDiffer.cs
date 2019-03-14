using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                                                                /// Provides methods for generate differences between texts script1
                                                                /// </summary>
                                                                /// <description>
                                                                /// [5c8a470c0c6ec2070cd6c3f9](script1_5c8a470c0c6ec2070cd6c3f9.cs)
                                                                /// </description>
                                                                                                                            public interface IDiffer
    {
        
        /// <summary>
                                /// script2
                                /// </summary>
                                /// <description>
                                /// [5c8a47170c6ec2070cd6c468](Script2_5c8a47170c6ec2070cd6c468.cs)
                                /// </description>
                                /// <returns>
                                /// Script3<br>  [5c8a47240c6ec2070cd6c606](Script3_5c8a47240c6ec2070cd6c606.cs)
                                /// </returns>
                                                        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        
        /// <summary>
        /// script4
        /// </summary>
        /// <description>
        /// [5c8a47300c6ec2070cd6c65e](script4_5c8a47300c6ec2070cd6c65e.cs)
        /// </description>
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        
        
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}