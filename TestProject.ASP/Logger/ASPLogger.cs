using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net.Http;
using TestProject.Common.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace TestProject.ASP
{
    public class ASPLogger : ILog
    {
        public static ViewDataDictionary ViewData { private get; set; }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string log)
        {
            ViewData["OutputData"] += log;
        }
    }
}
