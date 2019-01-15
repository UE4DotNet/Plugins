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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct Exporter_fields {
        [FieldOffset(56)] public IntPtr SupportedClass;
        [FieldOffset(64)]  public IntPtr  ExportRootScope;
        [FieldOffset(72)] public NativeArray FormatExtension;
        [FieldOffset(88)] public NativeArray FormatDescription;
        [FieldOffset(104)] public int PreferredFormatIndex;
        [FieldOffset(108)] public int TextIndent;
        [FieldOffset(112)] public bool bText;
        [FieldOffset(112)] public bool bSelectedOnly;
        [FieldOffset(112)] public bool bForceFileOperations;
        [FieldOffset(120)]  public IntPtr  ExportTask;
    }
    internal unsafe struct Exporter_methods {
        internal struct RunAssetExportTask_method {
            static internal IntPtr RunAssetExportTask_ptr;
            static RunAssetExportTask_method() {
                RunAssetExportTask_ptr = Main.GetMethodUFunction(Exporter.StaticClass, "RunAssetExportTask");
            }

            internal static unsafe bool Invoke(AssetExportTask Task) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Task;
                Main.GetProcessEvent(Exporter.DefaultObject, RunAssetExportTask_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct RunAssetExportTasks_method {
            static internal IntPtr RunAssetExportTasks_ptr;
            static RunAssetExportTasks_method() {
                RunAssetExportTasks_ptr = Main.GetMethodUFunction(Exporter.StaticClass, "RunAssetExportTasks");
            }

            internal static unsafe bool Invoke(byte ExportTasks /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ExportTasks
                Main.GetProcessEvent(Exporter.DefaultObject, RunAssetExportTasks_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ExportTasks
                return *((bool*)(b+16));
            }
        }
    }
    internal unsafe struct Exporter_events {
    }
}
