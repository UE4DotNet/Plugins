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

using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>Evaluates a point in an anim sequence, using a specific time input rather than advancing time internally.</summary>
        ///<remarks>
        ///Typically the playback position of the animation for this node will represent something other than time, like jump height.
        ///This node will not trigger any notifies present in the associated sequence.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct AnimNode_PoseBlendNode {
            ///<summary>Source Pose</summary>
            [FieldOffset(168)] PoseLink SourcePose;

            [FieldOffset(192)] byte BlendOption; //TODO: enum EAlphaBlendOption BlendOption

            [FieldOffset(200)] 
            private IntPtr  CustomCurve_field;
            ///<summary>If you're using Custom BlendOption, you can specify curve</summary>
            public CurveFloat CustomCurve {
                get {return CustomCurve_field;}
                set {CustomCurve_field = value;}
            }

        }
}
