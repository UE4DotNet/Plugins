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

namespace UE4.ViewportInteraction{
        ///<summary>Displays measurements along the bounds of selected objects</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct TransformGizmoMeasurement {
            [FieldOffset(0)] 
            private IntPtr  MeasurementText_field;
            ///<summary>The text that displays the actual measurement and units</summary>
            public TextRenderComponent MeasurementText {
                get {return MeasurementText_field;}
                set {MeasurementText_field = value;}
            }

        }
}
