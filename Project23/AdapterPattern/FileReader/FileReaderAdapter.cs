using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.FileReader
{
    public class FileReaderAdapter : IFileReader
    {
        private readonly object _reader;
        public FileReaderAdapter(object reader)
        {
            _reader = reader;
        }
        public string ReadFile()
        {
            if(_reader is PdfReader pdf)
            {
                return pdf.ExtractPdf();
            }
            if(_reader is WordReader word)
            {
                return word.ExtractWord();
            }
            throw new NotSupportedException("Reader not supported");
        }
    }
}