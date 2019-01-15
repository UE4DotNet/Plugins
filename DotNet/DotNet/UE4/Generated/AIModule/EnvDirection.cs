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


namespace UE4.AIModule{
        ///<summary>Env Direction</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct EnvDirection {
            ///<summary>line: start context</summary>
            public SubclassOf<EnvQueryContext> LineFrom {
                get {return LineFrom_class; }
                set {LineFrom_class = value; }
            }
            [FieldOffset(0)] private IntPtr LineFrom_class;

            ///<summary>line: finish context</summary>
            public SubclassOf<EnvQueryContext> LineTo {
                get {return LineTo_class; }
                set {LineTo_class = value; }
            }
            [FieldOffset(8)] private IntPtr LineTo_class;

            ///<summary>rotation: direction context</summary>
            public SubclassOf<EnvQueryContext> Rotation {
                get {return Rotation_class; }
                set {Rotation_class = value; }
            }
            [FieldOffset(16)] private IntPtr Rotation_class;

            [FieldOffset(24)] public byte DirMode;

        }
}
