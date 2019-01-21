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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct Factory_fields {
        [FieldOffset(56)] public bool bCreateNew;
        [FieldOffset(64)] public IntPtr SupportedClass;
        [FieldOffset(72)] public IntPtr ContextClass;
        [FieldOffset(80)] public NativeArray Formats;
        [FieldOffset(96)] public bool bEditAfterNew;
        [FieldOffset(96)] public bool bEditorImport;
        [FieldOffset(96)] public bool bText;
        [FieldOffset(100)] public int ImportPriority;
        [FieldOffset(104)]  public IntPtr  AutomatedImportData;
        [FieldOffset(112)]  public IntPtr  AssetImportTask;
        [FieldOffset(120)] public int OverwriteYesOrNoToAllState;
    }
    internal unsafe struct Factory_methods {
    }
    internal unsafe struct Factory_events {
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct ScriptFactoryCanImport_event {
            private static DelegateHolder<NativeFuncDelegate> ScriptFactoryCanImport_link;
            private static unsafe void ScriptFactoryCanImport_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Factory>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ScriptFactoryCanImport(FString.Get(b+0), *(bool*)(b+16));
            }
            internal static void Setup() {
                ScriptFactoryCanImport_link = new DelegateHolder<NativeFuncDelegate>(ScriptFactoryCanImport_process_event);
                var uf = Main.GetUFunction("ScriptFactoryCanImport");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ScriptFactoryCanImport_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ScriptFactoryCreateFile_event {
            private static DelegateHolder<NativeFuncDelegate> ScriptFactoryCreateFile_link;
            private static unsafe void ScriptFactoryCreateFile_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Factory>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ScriptFactoryCreateFile(UObject.Make<AssetImportTask>(*(IntPtr*)(b+0)), *(bool*)(b+8));
            }
            internal static void Setup() {
                ScriptFactoryCreateFile_link = new DelegateHolder<NativeFuncDelegate>(ScriptFactoryCreateFile_process_event);
                var uf = Main.GetUFunction("ScriptFactoryCreateFile");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ScriptFactoryCreateFile_link.Delegate));
            }
        }
    }
}
