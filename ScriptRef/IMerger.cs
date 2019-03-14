//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    
    /// <summary>
    /// codeblock5
    /// </summary>
    /// <description>
    /// [5c8a4ba40c6ec2070cd6d895](codeblock5_5c8a4ba40c6ec2070cd6d895.cs)
    /// </description>
    public interface IMerger
    {
        
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        /// <summary>
        /// codeblock6
        /// </summary>
        /// <description>
        /// [5c8a4bbc0c6ec2070cd6d8d8](codeblock6_5c8a4bbc0c6ec2070cd6d8d8.cs)
        /// </description>
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}
