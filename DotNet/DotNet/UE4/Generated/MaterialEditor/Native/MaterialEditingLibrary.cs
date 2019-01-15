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

using UE4.Engine;

namespace UE4.MaterialEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MaterialEditingLibrary_fields {
    }
    internal unsafe struct MaterialEditingLibrary_methods {
        internal struct ClearAllMaterialInstanceParameters_method {
            static internal IntPtr ClearAllMaterialInstanceParameters_ptr;
            static ClearAllMaterialInstanceParameters_method() {
                ClearAllMaterialInstanceParameters_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "ClearAllMaterialInstanceParameters");
            }

            internal static unsafe void Invoke(MaterialInstanceConstant Instance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, ClearAllMaterialInstanceParameters_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ConnectMaterialExpressions_method {
            static internal IntPtr ConnectMaterialExpressions_ptr;
            static ConnectMaterialExpressions_method() {
                ConnectMaterialExpressions_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "ConnectMaterialExpressions");
            }

            internal static unsafe bool Invoke(MaterialExpression FromExpression, string FromOutputName, MaterialExpression ToExpression, string ToInputName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = FromExpression;
                var FromOutputName_handle = GCHandle.Alloc(FromOutputName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FromOutputName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FromOutputName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FromOutputName.Length;
                *((IntPtr*)(b+24)) = ToExpression;
                var ToInputName_handle = GCHandle.Alloc(ToInputName, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = ToInputName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = ToInputName.Length;
                *(int*)(b+IntPtr.Size+4+32) = ToInputName.Length;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, ConnectMaterialExpressions_ptr, new IntPtr(p)); ;
                FromOutputName_handle.Free();
                ToInputName_handle.Free();
                return *((bool*)(b+48));
            }
        }
        internal struct ConnectMaterialProperty_method {
            static internal IntPtr ConnectMaterialProperty_ptr;
            static ConnectMaterialProperty_method() {
                ConnectMaterialProperty_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "ConnectMaterialProperty");
            }

            internal static unsafe bool Invoke(MaterialExpression FromExpression, string FromOutputName, byte Property) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = FromExpression;
                var FromOutputName_handle = GCHandle.Alloc(FromOutputName, GCHandleType.Pinned);
                *(IntPtr*)(b+8) = FromOutputName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+8) = FromOutputName.Length;
                *(int*)(b+IntPtr.Size+4+8) = FromOutputName.Length;
                *(b+24) = Property;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, ConnectMaterialProperty_ptr, new IntPtr(p)); ;
                FromOutputName_handle.Free();
                return *((bool*)(b+25));
            }
        }
        internal struct CreateMaterialExpression_method {
            static internal IntPtr CreateMaterialExpression_ptr;
            static CreateMaterialExpression_method() {
                CreateMaterialExpression_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "CreateMaterialExpression");
            }

            internal static unsafe MaterialExpression Invoke(Material Material, SubclassOf<MaterialExpression> ExpressionClass, int NodePosX, int NodePosY) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                *((IntPtr*)(b+8)) = ExpressionClass;
                *((int*)(b+16)) = NodePosX;
                *((int*)(b+20)) = NodePosY;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, CreateMaterialExpression_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct CreateMaterialExpressionInFunction_method {
            static internal IntPtr CreateMaterialExpressionInFunction_ptr;
            static CreateMaterialExpressionInFunction_method() {
                CreateMaterialExpressionInFunction_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "CreateMaterialExpressionInFunction");
            }

            internal static unsafe MaterialExpression Invoke(MaterialFunction MaterialFunction, SubclassOf<MaterialExpression> ExpressionClass, int NodePosX, int NodePosY) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MaterialFunction;
                *((IntPtr*)(b+8)) = ExpressionClass;
                *((int*)(b+16)) = NodePosX;
                *((int*)(b+20)) = NodePosY;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, CreateMaterialExpressionInFunction_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct DeleteAllMaterialExpressions_method {
            static internal IntPtr DeleteAllMaterialExpressions_ptr;
            static DeleteAllMaterialExpressions_method() {
                DeleteAllMaterialExpressions_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "DeleteAllMaterialExpressions");
            }

            internal static unsafe void Invoke(Material Material) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, DeleteAllMaterialExpressions_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DeleteAllMaterialExpressionsInFunction_method {
            static internal IntPtr DeleteAllMaterialExpressionsInFunction_ptr;
            static DeleteAllMaterialExpressionsInFunction_method() {
                DeleteAllMaterialExpressionsInFunction_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "DeleteAllMaterialExpressionsInFunction");
            }

            internal static unsafe void Invoke(MaterialFunction MaterialFunction) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MaterialFunction;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, DeleteAllMaterialExpressionsInFunction_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DeleteMaterialExpression_method {
            static internal IntPtr DeleteMaterialExpression_ptr;
            static DeleteMaterialExpression_method() {
                DeleteMaterialExpression_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "DeleteMaterialExpression");
            }

            internal static unsafe void Invoke(Material Material, MaterialExpression Expression) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                *((IntPtr*)(b+8)) = Expression;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, DeleteMaterialExpression_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DeleteMaterialExpressionInFunction_method {
            static internal IntPtr DeleteMaterialExpressionInFunction_ptr;
            static DeleteMaterialExpressionInFunction_method() {
                DeleteMaterialExpressionInFunction_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "DeleteMaterialExpressionInFunction");
            }

            internal static unsafe void Invoke(MaterialFunction MaterialFunction, MaterialExpression Expression) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MaterialFunction;
                *((IntPtr*)(b+8)) = Expression;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, DeleteMaterialExpressionInFunction_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetMaterialInstanceScalarParameterValue_method {
            static internal IntPtr GetMaterialInstanceScalarParameterValue_ptr;
            static GetMaterialInstanceScalarParameterValue_method() {
                GetMaterialInstanceScalarParameterValue_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "GetMaterialInstanceScalarParameterValue");
            }

            internal static unsafe float Invoke(MaterialInstanceConstant Instance, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                *((Name*)(b+8)) = ParameterName;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, GetMaterialInstanceScalarParameterValue_ptr, new IntPtr(p)); ;
                return *((float*)(b+20));
            }
        }
        internal struct GetMaterialInstanceTextureParameterValue_method {
            static internal IntPtr GetMaterialInstanceTextureParameterValue_ptr;
            static GetMaterialInstanceTextureParameterValue_method() {
                GetMaterialInstanceTextureParameterValue_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "GetMaterialInstanceTextureParameterValue");
            }

            internal static unsafe Texture Invoke(MaterialInstanceConstant Instance, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                *((Name*)(b+8)) = ParameterName;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, GetMaterialInstanceTextureParameterValue_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct GetMaterialInstanceVectorParameterValue_method {
            static internal IntPtr GetMaterialInstanceVectorParameterValue_ptr;
            static GetMaterialInstanceVectorParameterValue_method() {
                GetMaterialInstanceVectorParameterValue_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "GetMaterialInstanceVectorParameterValue");
            }

            internal static unsafe LinearColor Invoke(MaterialInstanceConstant Instance, Name ParameterName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                *((Name*)(b+8)) = ParameterName;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, GetMaterialInstanceVectorParameterValue_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+20));
            }
        }
        internal struct GetNumMaterialExpressions_method {
            static internal IntPtr GetNumMaterialExpressions_ptr;
            static GetNumMaterialExpressions_method() {
                GetNumMaterialExpressions_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "GetNumMaterialExpressions");
            }

            internal static unsafe int Invoke(Material Material) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, GetNumMaterialExpressions_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetNumMaterialExpressionsInFunction_method {
            static internal IntPtr GetNumMaterialExpressionsInFunction_ptr;
            static GetNumMaterialExpressionsInFunction_method() {
                GetNumMaterialExpressionsInFunction_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "GetNumMaterialExpressionsInFunction");
            }

            internal static unsafe int Invoke(MaterialFunction MaterialFunction) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MaterialFunction;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, GetNumMaterialExpressionsInFunction_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct RecompileMaterial_method {
            static internal IntPtr RecompileMaterial_ptr;
            static RecompileMaterial_method() {
                RecompileMaterial_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "RecompileMaterial");
            }

            internal static unsafe void Invoke(Material Material) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, RecompileMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaterialInstanceParent_method {
            static internal IntPtr SetMaterialInstanceParent_ptr;
            static SetMaterialInstanceParent_method() {
                SetMaterialInstanceParent_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "SetMaterialInstanceParent");
            }

            internal static unsafe void Invoke(MaterialInstanceConstant Instance, MaterialInterface NewParent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                *((IntPtr*)(b+8)) = NewParent;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, SetMaterialInstanceParent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaterialInstanceScalarParameterValue_method {
            static internal IntPtr SetMaterialInstanceScalarParameterValue_ptr;
            static SetMaterialInstanceScalarParameterValue_method() {
                SetMaterialInstanceScalarParameterValue_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "SetMaterialInstanceScalarParameterValue");
            }

            internal static unsafe bool Invoke(MaterialInstanceConstant Instance, Name ParameterName, float Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                *((Name*)(b+8)) = ParameterName;
                *((float*)(b+20)) = Value;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, SetMaterialInstanceScalarParameterValue_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct SetMaterialInstanceTextureParameterValue_method {
            static internal IntPtr SetMaterialInstanceTextureParameterValue_ptr;
            static SetMaterialInstanceTextureParameterValue_method() {
                SetMaterialInstanceTextureParameterValue_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "SetMaterialInstanceTextureParameterValue");
            }

            internal static unsafe bool Invoke(MaterialInstanceConstant Instance, Name ParameterName, Texture Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                *((Name*)(b+8)) = ParameterName;
                *((IntPtr*)(b+24)) = Value;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, SetMaterialInstanceTextureParameterValue_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct SetMaterialInstanceVectorParameterValue_method {
            static internal IntPtr SetMaterialInstanceVectorParameterValue_ptr;
            static SetMaterialInstanceVectorParameterValue_method() {
                SetMaterialInstanceVectorParameterValue_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "SetMaterialInstanceVectorParameterValue");
            }

            internal static unsafe bool Invoke(MaterialInstanceConstant Instance, Name ParameterName, LinearColor Value) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                *((Name*)(b+8)) = ParameterName;
                *((LinearColor*)(b+20)) = Value;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, SetMaterialInstanceVectorParameterValue_ptr, new IntPtr(p)); ;
                return *((bool*)(b+36));
            }
        }
        internal struct SetMaterialUsage_method {
            static internal IntPtr SetMaterialUsage_ptr;
            static SetMaterialUsage_method() {
                SetMaterialUsage_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "SetMaterialUsage");
            }

            internal static unsafe (bool, bool) Invoke(Material Material, byte Usage) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Material;
                *(b+8) = Usage;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, SetMaterialUsage_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+9)),*((bool*)(b+10)));
            }
        }
        internal struct UpdateMaterialFunction_method {
            static internal IntPtr UpdateMaterialFunction_ptr;
            static UpdateMaterialFunction_method() {
                UpdateMaterialFunction_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "UpdateMaterialFunction");
            }

            internal static unsafe void Invoke(MaterialFunctionInterface MaterialFunction, Material PreviewMaterial) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MaterialFunction;
                *((IntPtr*)(b+8)) = PreviewMaterial;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, UpdateMaterialFunction_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UpdateMaterialInstance_method {
            static internal IntPtr UpdateMaterialInstance_ptr;
            static UpdateMaterialInstance_method() {
                UpdateMaterialInstance_ptr = Main.GetMethodUFunction(MaterialEditingLibrary.StaticClass, "UpdateMaterialInstance");
            }

            internal static unsafe void Invoke(MaterialInstanceConstant Instance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Instance;
                Main.GetProcessEvent(MaterialEditingLibrary.DefaultObject, UpdateMaterialInstance_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MaterialEditingLibrary_events {
    }
}
