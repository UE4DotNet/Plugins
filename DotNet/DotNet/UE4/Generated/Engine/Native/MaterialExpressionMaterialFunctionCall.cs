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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct MaterialExpressionMaterialFunctionCall_fields {
        [FieldOffset(176)]  public IntPtr  MaterialFunction;
        [FieldOffset(184)] public NativeArray FunctionInputs;
        [FieldOffset(200)] public NativeArray FunctionOutputs;
        [FieldOffset(216)] public MaterialParameterInfo FunctionParameterInfo;
    }
    internal unsafe struct MaterialExpressionMaterialFunctionCall_methods {
        internal struct SetMaterialFunction_method {
            static internal IntPtr SetMaterialFunction_ptr;
            static SetMaterialFunction_method() {
                SetMaterialFunction_ptr = Main.GetMethodUFunction(MaterialExpressionMaterialFunctionCall.StaticClass, "SetMaterialFunction");
            }

            internal static unsafe bool Invoke(IntPtr obj, MaterialFunctionInterface NewMaterialFunction) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewMaterialFunction;
                Main.GetProcessEvent(obj, SetMaterialFunction_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
    }
    internal unsafe struct MaterialExpressionMaterialFunctionCall_events {
    }
}
