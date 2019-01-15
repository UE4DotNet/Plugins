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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=280 )]
    internal unsafe struct AIPerceptionStimuliSourceComponent_fields {
        [FieldOffset(256)] public bool bAutoRegisterAsSource;
        [FieldOffset(264)] public NativeArray RegisterAsSourceForSenses;
    }
    internal unsafe struct AIPerceptionStimuliSourceComponent_methods {
        internal struct RegisterForSense_method {
            static internal IntPtr RegisterForSense_ptr;
            static RegisterForSense_method() {
                RegisterForSense_ptr = Main.GetMethodUFunction(AIPerceptionStimuliSourceComponent.StaticClass, "RegisterForSense");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<AISense> SenseClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SenseClass;
                Main.GetProcessEvent(obj, RegisterForSense_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RegisterWithPerceptionSystem_method {
            static internal IntPtr RegisterWithPerceptionSystem_ptr;
            static RegisterWithPerceptionSystem_method() {
                RegisterWithPerceptionSystem_ptr = Main.GetMethodUFunction(AIPerceptionStimuliSourceComponent.StaticClass, "RegisterWithPerceptionSystem");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RegisterWithPerceptionSystem_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnregisterFromPerceptionSystem_method {
            static internal IntPtr UnregisterFromPerceptionSystem_ptr;
            static UnregisterFromPerceptionSystem_method() {
                UnregisterFromPerceptionSystem_ptr = Main.GetMethodUFunction(AIPerceptionStimuliSourceComponent.StaticClass, "UnregisterFromPerceptionSystem");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UnregisterFromPerceptionSystem_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnregisterFromSense_method {
            static internal IntPtr UnregisterFromSense_ptr;
            static UnregisterFromSense_method() {
                UnregisterFromSense_ptr = Main.GetMethodUFunction(AIPerceptionStimuliSourceComponent.StaticClass, "UnregisterFromSense");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<AISense> SenseClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SenseClass;
                Main.GetProcessEvent(obj, UnregisterFromSense_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AIPerceptionStimuliSourceComponent_events {
    }
}
