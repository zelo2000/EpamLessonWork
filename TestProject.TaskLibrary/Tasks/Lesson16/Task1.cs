using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson16
{
    public class Task1 : IRunnable
    {
        public void Run()
        {
            var dll = Assembly.LoadFile(@"C:\Users\Acer\Source\Repos\zelo2000\EpamLessonWork\TestProject.Common.Core\bin\Debug\netcoreapp2.1\TestProject.Common.Core.dll");
            foreach (Type t in dll.GetExportedTypes())
            {
                Logger.Write($"### {t.ToString()}\n");
                foreach (MemberInfo m in t.GetMembers())
                {
                    Logger.Write($"\t&& {m.ToString()}\n");
                    if (m.MemberType == MemberTypes.Method)
                    {
                        foreach (ParameterInfo p in ((MethodInfo)m).GetParameters())
                        {
                            Logger.Write($"\t\t* { p.ToString()}\n");
                        }
                    }
                }
            }
        }
    }
}