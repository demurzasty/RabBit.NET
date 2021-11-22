using System;

namespace RabBit.NET {
    public static class App {
        public static void Setup() {
            NativeAPI.AppSetup();
        }

        public static void Run(string initialSceneName = "") {
            NativeAPI.AppRun(initialSceneName);
        }
    }
}
