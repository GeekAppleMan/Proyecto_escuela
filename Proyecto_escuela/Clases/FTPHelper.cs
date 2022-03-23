using System;
using System.IO;

namespace Proyecto_escuela
{
    internal class FTPHelper
    {
        private string v1;
        private string v2;
        private string v3;

        public FTPHelper(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal string Upload(MemoryStream memoryStream, string v)
        {
            throw new NotImplementedException();
        }
    }
}