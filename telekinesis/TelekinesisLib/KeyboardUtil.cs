using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace telekinesis_lib
{
    class KeyboardUtil
    {
        public static void SendKeysBlocking(string keys)
        {
            SetForegroundWindow(proc.MainWindowHandle);
            SendKeys.SendWait("{up}");
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
