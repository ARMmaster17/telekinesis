using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace telekinesis_lib
{
    class ProcessUtil
    {
        public static Process GetProcessByName(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length == 0)
            {
                throw new Exception($"No processes found with the name {processName}.");
            }
            else if (processes.Length > 1)
            {
                throw new Exception($"Expected to find one process of {processName}, found {processes.Length}.");
            }
            else
            {
                return processes[0];
            }
        }
    }
}
