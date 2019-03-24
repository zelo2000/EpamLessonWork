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
            return ViewData["InputData"].ToString();
        }

        public void Write(string log)
        {
            ViewData["OutputData"] += log;
            //File.AppendAllText(Directory.GetCurrentDirectory() + "/Views/Task/Content.cshtml", $"<pre>\n{log}\n</pre>\n");
        }
    }
}
