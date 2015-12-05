//------------------------------------------------------------------------------
// <copyright file="ModuleClassifierProvider.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace modules
{
    [Export(typeof(IClassifierProvider))]
    [ContentType("cppModules")]
    internal class ModuleClassifierProvider : IClassifierProvider
    {
        [Import]
        private IClassificationTypeRegistryService classificationRegistry;

        #region IClassifierProvider
        public IClassifier GetClassifier(ITextBuffer buffer)
        {
            return buffer.Properties.GetOrCreateSingletonProperty<ModuleClassifier>(creator: () => new ModuleClassifier(this.classificationRegistry));
        }
        #endregion
    }
}
