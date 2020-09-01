using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace AutoClicker
{
    class Clicker
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static System.Timers.Timer clickTimer = new System.Timers.Timer();
        private static bool disposed = false;
        public  static int BetweenClickMin { get; set; }
        public  static int BetweenClickMax { get; set; }
        public  static int HoldDownMin { get; set; }
        public  static int HoldDownMax { get; set; }
        public static Keys ActivationKey { get; set; }
        public static int currentHoldDown;
        private static int MOUSEEVENTF_LEFTDOWN = 0x02;
        private static int MOUSEEVENTF_LEFTUP = 0x04;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        public Clicker(int betweenClickMin, int betweenClickMax, int holdDownMin, int holdDownMax, Keys activationKey)
        {
            Clicker.HoldDownMin = holdDownMin;
            Clicker.HoldDownMax = holdDownMax;
            Clicker.BetweenClickMin = betweenClickMin;
            Clicker.BetweenClickMax = betweenClickMax;
            Clicker.ActivationKey = activationKey;

            Random rand = new Random((int)DateTime.Now.Ticks);
            clickTimer.Interval = rand.Next(Clicker.BetweenClickMin, Clicker.BetweenClickMax);
            clickTimer.Elapsed += ClickTimerElapsed;
            Start();
        }

        public static void Dispose()
        {
            Dispose(true);
        }

        private static void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    clickTimer.Elapsed -= ClickTimerElapsed;
                    clickTimer.Dispose();
                }

                disposed = true;
            }
        }

        private static void Start()
        {
            new Thread(() =>
            {
                _hookID = SetHook(_proc);
                Application.Run();
                UnhookWindowsHookEx(_hookID);
            }).Start();
        }

        private static void ClickTimerElapsed(object Sender, ElapsedEventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            clickTimer.Interval = rand.Next(BetweenClickMin, BetweenClickMax);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            currentHoldDown = rand.Next(HoldDownMin, HoldDownMax);
            Thread.Sleep(currentHoldDown);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            int vkCode = Marshal.ReadInt32(lParam);

            if (nCode >= 0 && (Keys)vkCode == ActivationKey)
            {
                if (wParam == (IntPtr)WM_KEYDOWN && !clickTimer.Enabled)
                {
                    clickTimer.Start();
                }
                else if (wParam == (IntPtr)WM_KEYUP && clickTimer.Enabled)
                {
                    clickTimer.Stop();
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
    }
}
