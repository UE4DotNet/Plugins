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
        ///<summary>Material input structs.</summary>
        ///<remarks>
        ///@warning: manually mirrored in MaterialShared.h
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct MaterialInput {
            [FieldOffset(0)] 
            private IntPtr  Expression_field;
            ///<summary>Material expression that this input is connected to, or NULL if not connected.</summary>
            public MaterialExpression Expression {
                get {return Expression_field;}
                set {Expression_field = value;}
            }

            [FieldOffset(8)] public int OutputIndex;

            [FieldOffset(12)] public Name InputName;

            [FieldOffset(24)] public int Mask;

            [FieldOffset(28)] public int MaskR;

            [FieldOffset(32)] public int MaskG;

            [FieldOffset(36)] public int MaskB;

            [FieldOffset(40)] public int MaskA;

            [FieldOffset(44)] public Name ExpressionName;

        }
}
