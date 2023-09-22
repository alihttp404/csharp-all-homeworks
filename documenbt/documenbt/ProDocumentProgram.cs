using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documenbt
{
    internal class ProDocumentProgram : DocumentProgram
    {
        public sealed override void EditDocument() { Console.WriteLine("Document edited"); }
        public override void SaveDocument() { Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet"); }
     
        public new void Run() { OpenDocument(); EditDocument(); SaveDocument(); }
    }
}
