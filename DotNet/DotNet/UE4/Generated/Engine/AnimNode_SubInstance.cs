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
        ///<summary>Anim Node Sub Instance</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct AnimNode_SubInstance {
            ///<summary>Input pose for the node, intentionally not accessible because if there's no input</summary>
            ///<remarks>Node in the target class we don't want to show this as a pin</remarks>
            [FieldOffset(56)] PoseLink InPose;

            ///<summary>Instance Class</summary>
            public SubclassOf<AnimInstance> InstanceClass {
                get {return InstanceClass_class; }
                set {InstanceClass_class = value; }
            }
            [FieldOffset(80)] private IntPtr InstanceClass_class;

            [FieldOffset(88)] 
            private IntPtr  InstanceToRun_field;
            ///<summary>This is the actual instance allocated at runtime that will run</summary>
            public AnimInstance InstanceToRun {
                get {return InstanceToRun_field;}
                set {InstanceToRun_field = value;}
            }

            [FieldOffset(96)] byte InstanceProperties; //TODO: array TArray InstanceProperties

            [FieldOffset(112)] byte SubInstanceProperties; //TODO: array TArray SubInstanceProperties

            [FieldOffset(128)] byte SourcePropertyNames; //TODO: array TArray SourcePropertyNames

            [FieldOffset(144)] byte DestPropertyNames; //TODO: array TArray DestPropertyNames

        }
}
