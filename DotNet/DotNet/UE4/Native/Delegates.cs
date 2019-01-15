using System;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject.Native;

namespace UE4.Native {
    public delegate IntPtr DotNetCallDelegate( int callType, IntPtr value );

    internal delegate Name GetNameDelegate( [MarshalAs( UnmanagedType.LPWStr )] string name );

    internal delegate IntPtr GetUFunctionDelegate( [MarshalAs( UnmanagedType.LPWStr )] string functionName );

    internal delegate IntPtr GetUClassDelegate( [MarshalAs( UnmanagedType.LPWStr )] string functionName );

    internal delegate IntPtr GetDefaultObjectDelegate( IntPtr class_ );

    internal delegate void LogDelegate( int level, [MarshalAs( UnmanagedType.LPWStr )] string message );

    internal delegate bool GetBoolPropertyByNameDelegate( IntPtr uObject, [MarshalAs( UnmanagedType.LPWStr )] string propertyName );

    internal delegate void SetBoolPropertyByNameDelegate( IntPtr uObject, [MarshalAs( UnmanagedType.LPWStr )] string propertyName, bool value );

    internal delegate IntPtr GetMethodUFunctionDelegate( IntPtr uClass, [MarshalAs( UnmanagedType.LPWStr )] string funcName );

    internal delegate IntPtr NewObjectDelegate( IntPtr uClass, IntPtr outer, Name name );

    internal delegate IntPtr GetTransientPackageDelegate();


    // delegate for FNativeFuncPtr
    internal unsafe delegate void NativeFuncDelegate( IntPtr context, Frame* theStack, IntPtr result );

    public delegate void ProcessEventDelegate( IntPtr ue4Object, IntPtr function, IntPtr data );

    internal delegate void ShareOjectDelegate( IntPtr ue4Object );

    internal delegate void ReleaseObjectDelegate( IntPtr ue4Object );

    internal delegate void PushNameDelegate( Name name, [MarshalAs( UnmanagedType.LPWStr )] string text );

    internal delegate void PushInterfaceDelegate( Name number, IntPtr _interface );

    internal delegate void PushUObjectDelegate( IntPtr UObject );

    internal delegate void TestDelegate( [MarshalAs( UnmanagedType.LPWStr )] string options );

    //typedef void (*FNativeFuncPtr)(UObject* Context, FFrame& TheStack, RESULT_DECL);
    internal unsafe delegate void FNativeFuncPtr( IntPtr Context, Frame* TheStack, IntPtr returnParam );
}
