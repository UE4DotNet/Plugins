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
        ///<summary>Struct that stores information about a function output which is needed to maintain connections and implement the function call.</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct FunctionExpressionOutput {
            [FieldOffset(0)] 
            private IntPtr  ExpressionOutput_field;
            ///<summary>Reference to the FunctionOutput in the material function.</summary>
            ///<remarks>This is a reference to a private object so it can't be saved, and must be generated by UpdateFromFunctionResource or SetMaterialFunction.</remarks>
            public MaterialExpressionFunctionOutput ExpressionOutput {
                get {return ExpressionOutput_field;}
                set {ExpressionOutput_field = value;}
            }

            ///<summary>Id of the FunctionOutput, used to link ExpressionOutput.</summary>
            [FieldOffset(8)] FGuid ExpressionOutputId;

            ///<summary>Actual output struct which stores information about how this output is connected in the material.</summary>
            [FieldOffset(24)] ExpressionOutput Output;

        }
}
