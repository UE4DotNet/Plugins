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


namespace UE4.Engine{
        ///<summary>Exposed Value Copy Record</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct ExposedValueCopyRecord {
            [FieldOffset(8)] public Name SourcePropertyName;

            [FieldOffset(20)] public Name SourceSubPropertyName;

            [FieldOffset(32)] public int SourceArrayIndex;

            [FieldOffset(40)] 
            private IntPtr  DestProperty_field;
            ///<summary>Dest Property</summary>
            public Property DestProperty {
                get {return DestProperty_field;}
                set {DestProperty_field = value;}
            }

            [FieldOffset(48)] public int DestArrayIndex;

            [FieldOffset(52)] public int Size;

            [FieldOffset(56)] public bool bInstanceIsTarget;

            [FieldOffset(57)] byte PostCopyOperation; //TODO: enum EPostCopyOperation PostCopyOperation

            [FieldOffset(58)] byte CopyType; //TODO: enum ECopyType CopyType

            [FieldOffset(64)] 
            private IntPtr  CachedSourceProperty_field;
            ///<summary>cached source property</summary>
            public Property CachedSourceProperty {
                get {return CachedSourceProperty_field;}
                set {CachedSourceProperty_field = value;}
            }

            [FieldOffset(72)] 
            private IntPtr  CachedSourceStructSubProperty_field;
            ///<summary>Cached Source Struct Sub Property</summary>
            public Property CachedSourceStructSubProperty {
                get {return CachedSourceStructSubProperty_field;}
                set {CachedSourceStructSubProperty_field = value;}
            }

        }
}
