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


namespace UE4.LevelSequence.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct LevelSequenceBurnInOptions_fields {
        [FieldOffset(56)] public bool bUseBurnIn;
        [FieldOffset(64)] public SoftClassPath BurnInClass;
        [FieldOffset(96)]  public IntPtr  Settings;
    }
    internal unsafe struct LevelSequenceBurnInOptions_methods {
        internal struct SetBurnIn_method {
            static internal IntPtr SetBurnIn_ptr;
            static SetBurnIn_method() {
                SetBurnIn_ptr = Main.GetMethodUFunction(LevelSequenceBurnInOptions.StaticClass, "SetBurnIn");
            }

            internal static unsafe void Invoke(IntPtr obj, SoftClassPath InBurnInClass) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SoftClassPath*)(b+0)) = InBurnInClass;
                Main.GetProcessEvent(obj, SetBurnIn_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct LevelSequenceBurnInOptions_events {
    }
}
