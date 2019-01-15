using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UE4.Native {
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// This struct must have the same layout as SharedDotNet in CLRHost.cpp
    /// </remarks>
    [StructLayout( LayoutKind.Sequential, Pack = 0 )]
    struct Shared {
        UInt32 StartGuardian;
        UInt32 SizeOfShared;

        IntPtr LogFunction;
        IntPtr GetNameFunction;
        IntPtr ProcessEventFunction;
        IntPtr GetUFunctionFunction;
        IntPtr GetUClassFunction;
        IntPtr GetDefaultObjectFunction;
        IntPtr GetBoolPropertyValueFunction;
        IntPtr SetBoolPropertyValueFunction;
        IntPtr GetMethodUFunctionFunction;
        IntPtr NewObjectFunction;
        IntPtr GetTransientPackageFunction;
        IntPtr ShareObjectFunction;
        IntPtr ReleaseObjectFunction;

        IntPtr PushNameFunction;
        IntPtr PushInterfaceFunction;
        IntPtr PushUObjectFunction;
        IntPtr TestFunction;
        IntPtr DotNetCallFunction;

        UInt32 EndGuardian;

        internal LogDelegate Log =>
            Marshal.GetDelegateForFunctionPointer<LogDelegate>( LogFunction );

        internal GetNameDelegate GetName =>
            Marshal.GetDelegateForFunctionPointer<GetNameDelegate>( GetNameFunction );

        internal GetUFunctionDelegate GetUFunction =>
            Marshal.GetDelegateForFunctionPointer<GetUFunctionDelegate>( GetUFunctionFunction );

        internal GetUClassDelegate GetUClass =>
            Marshal.GetDelegateForFunctionPointer<GetUClassDelegate>( GetUClassFunction );

        internal GetDefaultObjectDelegate GetDefaultObject =>
            Marshal.GetDelegateForFunctionPointer<GetDefaultObjectDelegate>( GetDefaultObjectFunction );

        internal GetBoolPropertyByNameDelegate GetBoolPropertyByName =>
            Marshal.GetDelegateForFunctionPointer<GetBoolPropertyByNameDelegate>( GetBoolPropertyValueFunction );

        internal SetBoolPropertyByNameDelegate SetBoolPropertyByName =>
            Marshal.GetDelegateForFunctionPointer<SetBoolPropertyByNameDelegate>( SetBoolPropertyValueFunction );

        internal GetMethodUFunctionDelegate GetMethodUFunction =>
            Marshal.GetDelegateForFunctionPointer<GetMethodUFunctionDelegate>( GetMethodUFunctionFunction );

        internal NewObjectDelegate NewObject =>
            Marshal.GetDelegateForFunctionPointer<NewObjectDelegate>( NewObjectFunction );

        internal GetTransientPackageDelegate GetTransientPackage =>
            Marshal.GetDelegateForFunctionPointer<GetTransientPackageDelegate>( GetTransientPackageFunction );

        internal ProcessEventDelegate ProcessEvent =>
            Marshal.GetDelegateForFunctionPointer<ProcessEventDelegate>( ProcessEventFunction );

        internal ShareOjectDelegate ShareObject =>
            Marshal.GetDelegateForFunctionPointer<ShareOjectDelegate>( ShareObjectFunction );

        internal ReleaseObjectDelegate ReleaseObject =>
            Marshal.GetDelegateForFunctionPointer<ReleaseObjectDelegate>( ReleaseObjectFunction );



        internal void SetPushNameFunction( IntPtr funcPtr ) {
            PushNameFunction = funcPtr;
        }

        internal void SetTestFunction( IntPtr funcPtr ) {
            TestFunction = funcPtr;
        }

        internal void SetPushInterfaceFunction( IntPtr funcPtr ) {
            PushInterfaceFunction = funcPtr;
        }

        internal void SetPushUObjectFunction( IntPtr funcPtr ) {
            PushUObjectFunction = funcPtr;
        }

        internal void SetDotNetCallFunction( IntPtr funcPtr ) {
            DotNetCallFunction = funcPtr;
        }

        internal void Validate() {
            var size = Marshal.SizeOf<Shared>();
            Debug.Assert( StartGuardian == 0x12345678 &&
                EndGuardian == 0x87654321 &&
                SizeOfShared == Marshal.SizeOf<Shared>() );
        }
    }

}
