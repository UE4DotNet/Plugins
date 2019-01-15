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
        ///<summary>BTComposite Child</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct BTCompositeChild {
            [FieldOffset(0)] 
            private IntPtr  ChildComposite_field;
            ///<summary>child node</summary>
            public BTCompositeNode ChildComposite {
                get {return ChildComposite_field;}
                set {ChildComposite_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  ChildTask_field;
            ///<summary>Child Task</summary>
            public BTTaskNode ChildTask {
                get {return ChildTask_field;}
                set {ChildTask_field = value;}
            }

            [FieldOffset(16)] byte Decorators; //TODO: array TArray Decorators

            [FieldOffset(32)] byte DecoratorOps; //TODO: array TArray DecoratorOps

        }
}
