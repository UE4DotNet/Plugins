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


namespace UE4.FunctionalTesting{
        ///<summary>Automation Screenshot Options</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct AutomationScreenshotOptions {
            ///<summary>
            ///The desired resolution of the screenshot, if none is provided, it will use the default for the
            ///platform setup in the automation settings.
            ///</summary>
            [FieldOffset(0)] Vector2D Resolution;

            [FieldOffset(8)] public float Delay;

            [FieldOffset(12)] public bool bOverride_OverrideTimeTo;

            [FieldOffset(16)] public float OverrideTimeTo;

            [FieldOffset(20)] public bool bDisableNoisyRenderingFeatures;

            [FieldOffset(21)] public bool bDisableTonemapping;

            [FieldOffset(24)] 
            private IntPtr  ViewSettings_field;
            ///<summary>
            ///Assign custom view settings to control which rendering options we allow on while taking the
            ///screenshot.
            ///</summary>
            public AutomationViewSettings ViewSettings {
                get {return ViewSettings_field;}
                set {ViewSettings_field = value;}
            }

            [FieldOffset(32)] public Name VisualizeBuffer;

            [FieldOffset(44)] byte Tolerance; //TODO: enum EComparisonTolerance Tolerance

            ///<summary>
            ///For each channel and brightness levels you can control a region where the colors are found to be
            ///essentially the same.
            ///</summary>
            ///<remarks>
            ///Generally this is necessary as modern rendering techniques tend to introduce
            ///noise constantly to hide aliasing.
            ///</remarks>
            [FieldOffset(45)] ComparisonToleranceAmount ToleranceAmount;

            [FieldOffset(52)] public float MaximumLocalError;

            [FieldOffset(56)] public float MaximumGlobalError;

            [FieldOffset(60)] public bool bIgnoreAntiAliasing;

            [FieldOffset(61)] public bool bIgnoreColors;

        }
}
