using System;
using Bundler.Framework.Utilities;

namespace Bundler.Tests.Stubs
{
    public class StubFileWriter: IFileWriter
    {
        private readonly string file;
        private readonly Action<string,string> writeDelegate;

        public StubFileWriter(string file, Action<string,string> writeDelegate)
        {
            this.file = file;
            this.writeDelegate = writeDelegate;
        }

        public void Dispose()
        {
        }

        public void Write(string value)
        {
            writeDelegate(file, value);
        }

        public void WriteLine(string value)
        {
            writeDelegate(file, value + Environment.NewLine);
        }
    }
}