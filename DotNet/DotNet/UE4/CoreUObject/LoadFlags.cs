using System;

namespace UE4.CoreUObject {
    /// <summary>
    /// Flags for Loading object, copied from ObjectMacros.h
    /// </summary>
    [Flags]
    public enum LoadFlags {
        LOAD_None = 0x00000000, // No flags.
        LOAD_Async = 0x00000001,    // Loads the package using async loading path/ reader
        LOAD_NoWarn = 0x00000002,   // Don't display warning if load fails.
        LOAD_EditorOnly = 0x00000004, // Load for editor-only purposes and by editor-only code
        LOAD_ResolvingDeferredExports = 0x00000008, // Denotes that we should not defer export loading (as we're resolving them)
        LOAD_Verify = 0x00000010,   // Only verify existance; don't actually load.
        LOAD_AllowDll = 0x00000020, // Allow plain DLLs.
                                    //	LOAD_Unused						= 0x00000040
        LOAD_NoVerify = 0x00000080,   // Don't verify imports yet.
        LOAD_IsVerifying = 0x00000100,      // Is verifying imports
                                            //	LOAD_Unused						= 0x00000200,
                                            //	LOAD_Unused						= 0x00000400,
                                            //	LOAD_Unused						= 0x00000800,
        LOAD_DisableDependencyPreloading = 0x00001000,  // Bypass dependency preloading system
        LOAD_Quiet = 0x00002000,   // No log warnings.
        LOAD_FindIfFail = 0x00004000,   // Tries FindObject if a linker cannot be obtained (e.g. package is currently being compiled)
        LOAD_MemoryReader = 0x00008000, // Loads the file into memory and serializes from there.
        LOAD_NoRedirects = 0x00010000,  // Never follow redirects when loading objects; redirected loads will fail
        LOAD_ForDiff = 0x00020000,  // Loading for diffing.
        LOAD_PackageForPIE = 0x00080000,   // This package is being loaded for PIE, it must be flagged as such immediately
        LOAD_DeferDependencyLoads = 0x00100000,   // Do not load external (blueprint) dependencies (instead, track them for deferred loading)
        LOAD_ForFileDiff = 0x00200000,  // Load the package (not for diffing in the editor), instead verify at the two packages serialized output are the same, if they are not then debug break so that you can get the callstack and object information
        LOAD_DisableCompileOnLoad = 0x00400000, // Prevent this load call from running compile on load for the loaded blueprint (intentionally not recursive, dependencies will still compile on load)
    };

}
