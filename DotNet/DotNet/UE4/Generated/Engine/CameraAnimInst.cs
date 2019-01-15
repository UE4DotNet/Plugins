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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Camera Anim Inst</summary>
    public unsafe partial class CameraAnimInst : UObject  {

        ///<summary>Changes the running duration of this active anim, while maintaining playback position.</summary>
        public void SetDuration(float NewDuration)  => 
            CameraAnimInst_methods.SetDuration_method.Invoke(ObjPointer, NewDuration);

        ///<summary>Changes the scale of the animation while playing.</summary>
        public void SetScale(float NewDuration)  => 
            CameraAnimInst_methods.SetScale_method.Invoke(ObjPointer, NewDuration);

        ///<summary>Stops this instance playing whatever animation it is playing.</summary>
        public void Stop(bool bImmediate)  => 
            CameraAnimInst_methods.Stop_method.Invoke(ObjPointer, bImmediate);
        ///<summary>which CameraAnim this is an instance of</summary>
        public unsafe CameraAnim CamAnim {
            get {return CameraAnimInst_ptr->CamAnim;}
            set {CameraAnimInst_ptr->CamAnim = value;}
        }
        ///<summary>the UInterpGroupInst used to do the interpolation</summary>
        public unsafe InterpGroupInst InterpGroupInst {
            get {return CameraAnimInst_ptr->InterpGroupInst;}
            set {CameraAnimInst_ptr->InterpGroupInst = value;}
        }
        ///<summary>Multiplier for playback rate.  1.0 = normal.</summary>
        public unsafe float PlayRate {
            get {return CameraAnimInst_ptr->PlayRate;}
            set {CameraAnimInst_ptr->PlayRate = value;}
        }
        ///<summary>cached movement track from the currently playing anim so we don't have to go find it every frame</summary>
        public unsafe InterpTrackMove MoveTrack {
            get {return CameraAnimInst_ptr->MoveTrack;}
            set {CameraAnimInst_ptr->MoveTrack = value;}
        }
        ///<summary>Move Inst</summary>
        public unsafe InterpTrackInstMove MoveInst {
            get {return CameraAnimInst_ptr->MoveInst;}
            set {CameraAnimInst_ptr->MoveInst = value;}
        }
        ///<summary>Play Space</summary>
        public unsafe byte PlaySpace {
            get {return CameraAnimInst_ptr->PlaySpace;}
            set {CameraAnimInst_ptr->PlaySpace = value;}
        }
        static CameraAnimInst() {
            StaticClass = Main.GetClass("CameraAnimInst");
        }
        internal unsafe CameraAnimInst_fields* CameraAnimInst_ptr => (CameraAnimInst_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraAnimInst(IntPtr p) => UObject.Make<CameraAnimInst>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraAnimInst DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraAnimInst New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
