//------------------------------------------------------------------------------
// <copyright file="ModuleClassifierFormat.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace modules
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ModuleClassifier")]
    [Name("ModuleClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(Before = Priority.High)] // Set the priority to be after the default classifiers
    internal sealed class ModuleClassifierFormat : ClassificationFormatDefinition
    {
        public ModuleClassifierFormat()
        {
            this.DisplayName = "ModuleClassifier"; // Human readable version of the name
            this.ForegroundColor = Color.FromRgb(86, 156, 214);
        }
    }
}