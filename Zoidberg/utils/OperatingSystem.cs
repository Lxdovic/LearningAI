using System.Runtime.InteropServices;

namespace Zoidberg.utils;

public static class OperatingSystem {
    public static bool IsWindows() {
        return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
    }

    public static bool IsMacOS() {
        return RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
    }

    public static bool IsLinux() {
        return RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    }
}