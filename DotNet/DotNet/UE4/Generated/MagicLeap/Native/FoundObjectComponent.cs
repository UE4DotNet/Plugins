// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=720 )]
    internal unsafe struct FoundObjectComponent_fields {
        [FieldOffset(624)] byte QueryObjectID; //TODO: string FString QueryObjectID
        [FieldOffset(640)] public NativeArray QueryLabels;
        [FieldOffset(656)] public NativeArray QueryTypes;
        [FieldOffset(672)] public NativeArray QueryProperties;
        [FieldOffset(688)] public int MaxResults;
        [FieldOffset(696)]  public IntPtr  SearchVolume;
    }
    internal unsafe struct FoundObjectComponent_methods {
        internal struct SubmitQuery_method {
            static internal IntPtr SubmitQuery_ptr;
            static SubmitQuery_method() {
                SubmitQuery_ptr = Main.GetMethodUFunction(FoundObjectComponent.StaticClass, "SubmitQuery");
            }

            internal static unsafe (int, bool) Invoke(IntPtr obj, byte ResultDelegate /*TODO: delegate FFoundObjectResultDelegate */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: delegate FFoundObjectResultDelegate ResultDelegate
                Main.GetProcessEvent(obj, SubmitQuery_ptr, new IntPtr(p)); ;
                 //TODO: delegate FFoundObjectResultDelegate ResultDelegate
                return (*((int*)(b+0)),*((bool*)(b+24)));
            }
        }
    }
    internal unsafe struct FoundObjectComponent_events {
    }
}
