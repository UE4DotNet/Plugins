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

namespace UE4.EditableMesh.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct EditableMeshFactory_fields {
    }
    internal unsafe struct EditableMeshFactory_methods {
        internal struct MakeEditableMesh_method {
            static internal IntPtr MakeEditableMesh_ptr;
            static MakeEditableMesh_method() {
                MakeEditableMesh_ptr = Main.GetMethodUFunction(EditableMeshFactory.StaticClass, "MakeEditableMesh");
            }

            internal static unsafe UE4.EditableMesh.EditableMesh Invoke(PrimitiveComponent PrimitiveComponent, int LODIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PrimitiveComponent;
                *((int*)(b+8)) = LODIndex;
                Main.GetProcessEvent(EditableMeshFactory.DefaultObject, MakeEditableMesh_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
    }
    internal unsafe struct EditableMeshFactory_events {
    }
}
