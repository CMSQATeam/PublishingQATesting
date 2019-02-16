//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    
    /// <summary>
        /// Testing the publishing
        /// </summary>
        /// <description>
        /// ![](angeler_5c6795831b16f52820f887aa.jpeg)
        /// </description>
            public interface IMerger
    {
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        
        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}
