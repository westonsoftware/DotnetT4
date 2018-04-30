using System;
using System.Collections.Generic;
using System.Text;

namespace System.CodeDom.Compiler
{
    // HACK:  it is necessary to fake this class in dotnet core since it isn't available yet
    //
    public class CompilerError
    {
        public string ErrorText { get; set; }
        public bool IsWarning { get; set; }
    }

    public class CompilerErrorCollection : List<CompilerError>
    {
    }
}
