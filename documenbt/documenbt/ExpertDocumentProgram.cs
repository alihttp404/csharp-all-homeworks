using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documenbt
{
    internal class ExpertDocumentProgram : ProDocumentProgram
    {
        public override void SaveDocument() => Console.WriteLine("Document saved in pdf format");

        public new void Run() { OpenDocument(); EditDocument(); SaveDocument(); }
    }
}
