using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GC_Clicker
{
    public class BlueStacksController
    {
        // Import necessary Windows API functions
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        // Constants for ShowWindow function
        private const int SW_RESTORE = 9;
        private const int SW_SHOW = 5;

        // Method to bring BlueStacks to the front
        public static bool BringBlueStacksToFront()
        {
            // Find the BlueStacks window by its title
            IntPtr hWnd = FindWindow(null, "BlueStacks App Player");

            if (hWnd != IntPtr.Zero)
            {
                // If the window is minimized, restore it
                if (IsIconic(hWnd))
                {
                    ShowWindow(hWnd, SW_RESTORE);
                }
                else
                {
                    ShowWindow(hWnd, SW_SHOW);
                }

                // Bring the window to the foreground
                SetForegroundWindow(hWnd);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
