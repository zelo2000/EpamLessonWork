using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Core.Interfaces
{
    /// <summary>
    /// Interface for independent input / output.
    /// </summary>
    public interface ILog
    {
        void Write(string log);

        string Read();

        void ReadKey();
    }
}
