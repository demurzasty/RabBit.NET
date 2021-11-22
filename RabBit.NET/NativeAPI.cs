using System;
using System.Runtime.InteropServices;

namespace RabBit.NET {
    public static class NativeAPI {
        public const string DllName = "rabbit-interop.dll";

        [DllImport(DllName, EntryPoint = "app_setup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void AppSetup();

        [DllImport(DllName, EntryPoint = "app_run", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void AppRun(string initialScene);
    }
}
