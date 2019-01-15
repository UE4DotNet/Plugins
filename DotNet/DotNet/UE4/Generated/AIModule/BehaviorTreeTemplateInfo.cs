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
        ///<summary>Behavior Tree Template Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct BehaviorTreeTemplateInfo {
            [FieldOffset(0)] 
            private IntPtr  Asset_field;
            ///<summary>behavior tree asset</summary>
            public BehaviorTree Asset {
                get {return Asset_field;}
                set {Asset_field = value;}
            }

            [FieldOffset(8)] 
            private IntPtr  Template_field;
            ///<summary>initialized template</summary>
            public BTCompositeNode Template {
                get {return Template_field;}
                set {Template_field = value;}
            }

        }
}
