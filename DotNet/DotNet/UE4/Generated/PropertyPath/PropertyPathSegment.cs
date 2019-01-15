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


namespace UE4.PropertyPath{
        ///<summary>Base class for cached property path segments</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct PropertyPathSegment {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(12)] public int ArrayIndex;

            [FieldOffset(16)] 
            private IntPtr  Struct_field;
            ///<summary>The cached Class or ScriptStruct that was used last to resolve Name to a property.</summary>
            public Struct Struct {
                get {return Struct_field;}
                set {Struct_field = value;}
            }

            [FieldOffset(24)] 
            private IntPtr  Field_field;
            ///<summary>
            ///The cached property on the Struct that this Name resolved to on it last time Resolve was called, if
            ///the Struct doesn't change, this value is returned to avoid performing another Field lookup.
            ///</summary>
            public Field Field {
                get {return Field_field;}
                set {Field_field = value;}
            }

        }
}
