using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodesApp.BLL.Playground
{
    public class DisposeExample : IDisposable
    {
        private FileStream _fileStream = File.Open("TextFile1.txt", FileMode.Open);

        public void Dispose()
        {
            _fileStream.Dispose();
        }

        public void Main() { }


    }
}
