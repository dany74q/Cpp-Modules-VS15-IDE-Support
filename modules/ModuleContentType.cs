using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modules
{
    public class ModuleContentType
    {
        [Export]
        [Name("cppModules")]
        [BaseDefinition("C/C++")]
        [BaseDefinition("Code")]
        internal static ContentTypeDefinition TestContentTypeDefinition;

        [Export]
        [FileExtension(".ixx")]
        [ContentType("cppModules")]
        internal static FileExtensionToContentTypeDefinition TestFileExtensionDefinition;

        [Export]
        [FileExtension(".cpp")]
        [ContentType("cppModules")]
        internal static FileExtensionToContentTypeDefinition TestFileExtensionDefinition2;

        [Export]
        [FileExtension(".cxx")]
        [ContentType("cppModules")]
        internal static FileExtensionToContentTypeDefinition TestFileExtensionDefinition3;

        [Export]
        [FileExtension(".hpp")]
        [ContentType("cppModules")]
        internal static FileExtensionToContentTypeDefinition TestFileExtensionDefinition4;

        [Export]
        [FileExtension(".hxx")]
        [ContentType("cppModules")]
        internal static FileExtensionToContentTypeDefinition TestFileExtensionDefinition5;

        [Export]
        [FileExtension(".h")]
        [ContentType("cppModules")]
        internal static FileExtensionToContentTypeDefinition TestFileExtensionDefinition6;
    }
}
