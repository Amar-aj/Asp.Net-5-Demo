using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_5_TestDemo.Models
{
    public class FileManagerModel
    {
        public static FileInfo[] fileInfos { get; set; }
        //public IFormFile formFile { get; set; }
        //public List<IFormFile> formFiles { get; set; }
    }
}
