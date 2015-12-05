//------------------------------------------------------------------------------
// <copyright file="ModuleClassifierClassificationDefinition.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace modules
{
    internal static class ModuleClassifierClassificationDefinition
    {
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("ModuleClassifier")]
        private static ClassificationTypeDefinition typeDefinition;
    }
}
