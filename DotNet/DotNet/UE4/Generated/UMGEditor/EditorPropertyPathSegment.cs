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


namespace UE4.UMGEditor{
        ///<summary>Editor Property Path Segment</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct EditorPropertyPathSegment {
            [FieldOffset(0)] 
            private IntPtr  Struct_field;
            ///<summary>The owner of the path segment (ie. What class or structure was this property from)</summary>
            public Struct Struct {
                get {return Struct_field;}
                set {Struct_field = value;}
            }

            [FieldOffset(8)] public Name MemberName;

            ///<summary>The member guid in this structure this segment represents.</summary>
            ///<remarks>
            ///If this is valid it should
            ///be used instead of Name to get the true name.
            ///</remarks>
            [FieldOffset(20)] FGuid MemberGuid;

            [FieldOffset(36)] public bool IsProperty;

        }
}
