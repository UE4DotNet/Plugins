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
        ///<summary>Class Redirect</summary>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct ClassRedirect {
            [FieldOffset(0)] public Name ObjectName;

            [FieldOffset(12)] public Name OldClassName;

            [FieldOffset(24)] public Name NewClassName;

            [FieldOffset(36)] public Name OldSubobjName;

            [FieldOffset(48)] public Name NewSubobjName;

            [FieldOffset(60)] public Name NewClassClass;

            [FieldOffset(72)] public Name NewClassPackage;

            [FieldOffset(84)] public bool InstanceOnly;

        }
}
