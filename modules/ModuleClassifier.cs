//------------------------------------------------------------------------------
// <copyright file="ModuleClassifier.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace modules
{
    internal class ModuleClassifier : IClassifier
    {
        private List<string> keywords = new List<string> { "import", "export", "module" };
        private readonly IClassificationType classificationType;

        internal ModuleClassifier(IClassificationTypeRegistryService registry)
        {
            this.classificationType = registry.GetClassificationType("ModuleClassifier");
        }

        #region IClassifier
        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;
        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            var line = span.Start.GetContainingLine().GetText();
            var lineSplit = line.Split(' ');
            if (lineSplit.Length > 0) {
                var potentialKeyword = lineSplit[0].ToLower();
                if (keywords.Contains(potentialKeyword)) {
                    var result = new List<ClassificationSpan>()
                    {
                        new ClassificationSpan(
                            new SnapshotSpan(span.Snapshot, new Span(span.Start.Position + line.IndexOf(potentialKeyword), potentialKeyword.Length)),
                            this.classificationType)
                    };
                    return result;
                }
            }
            return new List<ClassificationSpan>();
        }
        #endregion
    }
}
