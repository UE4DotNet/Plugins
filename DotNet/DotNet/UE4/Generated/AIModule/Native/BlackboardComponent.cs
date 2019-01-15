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
    [StructLayout( LayoutKind.Explicit, Size=504 )]
    internal unsafe struct BlackboardComponent_fields {
        [FieldOffset(256)]  public IntPtr  BrainComp;
        [FieldOffset(264)]  public IntPtr  BlackboardAsset;
        [FieldOffset(304)] public NativeArray KeyInstances;
    }
    internal unsafe struct BlackboardComponent_methods {
        internal struct ClearValue_method {
            static internal IntPtr ClearValue_ptr;
            static ClearValue_method() {
                ClearValue_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "ClearValue");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, ClearValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetLocationFromEntry_method {
            static internal IntPtr GetLocationFromEntry_ptr;
            static GetLocationFromEntry_method() {
                GetLocationFromEntry_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetLocationFromEntry");
            }

            internal static unsafe (Vector, bool) Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetLocationFromEntry_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+12)),*((bool*)(b+24)));
            }
        }
        internal struct GetRotationFromEntry_method {
            static internal IntPtr GetRotationFromEntry_ptr;
            static GetRotationFromEntry_method() {
                GetRotationFromEntry_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetRotationFromEntry");
            }

            internal static unsafe (Rotator, bool) Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetRotationFromEntry_ptr, new IntPtr(p)); ;
                return (*((Rotator*)(b+12)),*((bool*)(b+24)));
            }
        }
        internal struct GetValueAsBool_method {
            static internal IntPtr GetValueAsBool_ptr;
            static GetValueAsBool_method() {
                GetValueAsBool_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsBool");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsBool_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct GetValueAsClass_method {
            static internal IntPtr GetValueAsClass_ptr;
            static GetValueAsClass_method() {
                GetValueAsClass_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsClass");
            }

            internal static unsafe SubclassOf<UObject> Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetValueAsEnum_method {
            static internal IntPtr GetValueAsEnum_ptr;
            static GetValueAsEnum_method() {
                GetValueAsEnum_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsEnum");
            }

            internal static unsafe byte Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsEnum_ptr, new IntPtr(p)); ;
                return *(b+12);
            }
        }
        internal struct GetValueAsFloat_method {
            static internal IntPtr GetValueAsFloat_ptr;
            static GetValueAsFloat_method() {
                GetValueAsFloat_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsFloat");
            }

            internal static unsafe float Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsFloat_ptr, new IntPtr(p)); ;
                return *((float*)(b+12));
            }
        }
        internal struct GetValueAsInt_method {
            static internal IntPtr GetValueAsInt_ptr;
            static GetValueAsInt_method() {
                GetValueAsInt_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsInt");
            }

            internal static unsafe int Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsInt_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct GetValueAsName_method {
            static internal IntPtr GetValueAsName_ptr;
            static GetValueAsName_method() {
                GetValueAsName_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsName");
            }

            internal static unsafe Name Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+12));
            }
        }
        internal struct GetValueAsObject_method {
            static internal IntPtr GetValueAsObject_ptr;
            static GetValueAsObject_method() {
                GetValueAsObject_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsObject");
            }

            internal static unsafe UObject Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsObject_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct GetValueAsRotator_method {
            static internal IntPtr GetValueAsRotator_ptr;
            static GetValueAsRotator_method() {
                GetValueAsRotator_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsRotator");
            }

            internal static unsafe Rotator Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+12));
            }
        }
        internal struct GetValueAsString_method {
            static internal IntPtr GetValueAsString_ptr;
            static GetValueAsString_method() {
                GetValueAsString_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsString");
            }

            internal static unsafe string Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsString_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct GetValueAsVector_method {
            static internal IntPtr GetValueAsVector_ptr;
            static GetValueAsVector_method() {
                GetValueAsVector_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "GetValueAsVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, GetValueAsVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct IsVectorValueSet_method {
            static internal IntPtr IsVectorValueSet_ptr;
            static IsVectorValueSet_method() {
                IsVectorValueSet_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "IsVectorValueSet");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name KeyName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                Main.GetProcessEvent(obj, IsVectorValueSet_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct SetValueAsBool_method {
            static internal IntPtr SetValueAsBool_ptr;
            static SetValueAsBool_method() {
                SetValueAsBool_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsBool");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, bool BoolValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *((bool*)(b+12)) = BoolValue;
                Main.GetProcessEvent(obj, SetValueAsBool_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValueAsClass_method {
            static internal IntPtr SetValueAsClass_ptr;
            static SetValueAsClass_method() {
                SetValueAsClass_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsClass");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, SubclassOf<UObject> ClassValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *((IntPtr*)(b+16)) = ClassValue;
                Main.GetProcessEvent(obj, SetValueAsClass_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValueAsEnum_method {
            static internal IntPtr SetValueAsEnum_ptr;
            static SetValueAsEnum_method() {
                SetValueAsEnum_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsEnum");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, byte EnumValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *(b+12) = EnumValue;
                Main.GetProcessEvent(obj, SetValueAsEnum_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValueAsFloat_method {
            static internal IntPtr SetValueAsFloat_ptr;
            static SetValueAsFloat_method() {
                SetValueAsFloat_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsFloat");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, float FloatValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *((float*)(b+12)) = FloatValue;
                Main.GetProcessEvent(obj, SetValueAsFloat_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValueAsInt_method {
            static internal IntPtr SetValueAsInt_ptr;
            static SetValueAsInt_method() {
                SetValueAsInt_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsInt");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, int IntValue) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *((int*)(b+12)) = IntValue;
                Main.GetProcessEvent(obj, SetValueAsInt_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValueAsName_method {
            static internal IntPtr SetValueAsName_ptr;
            static SetValueAsName_method() {
                SetValueAsName_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, Name NameValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *((Name*)(b+12)) = NameValue;
                Main.GetProcessEvent(obj, SetValueAsName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValueAsObject_method {
            static internal IntPtr SetValueAsObject_ptr;
            static SetValueAsObject_method() {
                SetValueAsObject_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsObject");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, UObject ObjectValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *((IntPtr*)(b+16)) = ObjectValue;
                Main.GetProcessEvent(obj, SetValueAsObject_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValueAsRotator_method {
            static internal IntPtr SetValueAsRotator_ptr;
            static SetValueAsRotator_method() {
                SetValueAsRotator_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsRotator");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, Rotator VectorValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *((Rotator*)(b+12)) = VectorValue;
                Main.GetProcessEvent(obj, SetValueAsRotator_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetValueAsString_method {
            static internal IntPtr SetValueAsString_ptr;
            static SetValueAsString_method() {
                SetValueAsString_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsString");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, string StringValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                var StringValue_handle = GCHandle.Alloc(StringValue, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = StringValue_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = StringValue.Length;
                *(int*)(b+IntPtr.Size+4+16) = StringValue.Length;
                Main.GetProcessEvent(obj, SetValueAsString_ptr, new IntPtr(p)); ;
                StringValue_handle.Free();
            }
        }
        internal struct SetValueAsVector_method {
            static internal IntPtr SetValueAsVector_ptr;
            static SetValueAsVector_method() {
                SetValueAsVector_ptr = Main.GetMethodUFunction(BlackboardComponent.StaticClass, "SetValueAsVector");
            }

            internal static unsafe void Invoke(IntPtr obj, Name KeyName, Vector VectorValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = KeyName;
                *((Vector*)(b+12)) = VectorValue;
                Main.GetProcessEvent(obj, SetValueAsVector_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct BlackboardComponent_events {
    }
}
