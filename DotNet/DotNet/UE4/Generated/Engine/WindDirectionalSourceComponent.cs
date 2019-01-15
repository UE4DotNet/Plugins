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
    ///<summary>Component that provides a directional wind source. Only affects SpeedTree assets.</summary>
    public unsafe partial class WindDirectionalSourceComponent : SceneComponent  {

        ///<summary>Set maximum deviation for wind gusts</summary>
        public void SetMaximumGustAmount(float InNewMaxGust)  => 
            WindDirectionalSourceComponent_methods.SetMaximumGustAmount_method.Invoke(ObjPointer, InNewMaxGust);

        ///<summary>Set minimum deviation for wind gusts</summary>
        public void SetMinimumGustAmount(float InNewMinGust)  => 
            WindDirectionalSourceComponent_methods.SetMinimumGustAmount_method.Invoke(ObjPointer, InNewMinGust);

        ///<summary>Set the effect radius for point wind</summary>
        public void SetRadius(float InNewRadius)  => 
            WindDirectionalSourceComponent_methods.SetRadius_method.Invoke(ObjPointer, InNewRadius);

        ///<summary>Sets the windspeed of the generated wind</summary>
        public void SetSpeed(float InNewSpeed)  => 
            WindDirectionalSourceComponent_methods.SetSpeed_method.Invoke(ObjPointer, InNewSpeed);

        ///<summary>Sets the strength of the generated wind</summary>
        public void SetStrength(float InNewStrength)  => 
            WindDirectionalSourceComponent_methods.SetStrength_method.Invoke(ObjPointer, InNewStrength);

        ///<summary>Set the type of wind generator to use</summary>
        public void SetWindType(EWindSourceType InNewType)  => 
            WindDirectionalSourceComponent_methods.SetWindType_method.Invoke(ObjPointer, InNewType);
        ///<summary>Strength</summary>
        public unsafe float Strength {
            get {return WindDirectionalSourceComponent_ptr->Strength;}
            set {WindDirectionalSourceComponent_ptr->Strength = value;}
        }
        ///<summary>Speed</summary>
        public unsafe float Speed {
            get {return WindDirectionalSourceComponent_ptr->Speed;}
            set {WindDirectionalSourceComponent_ptr->Speed = value;}
        }
        ///<summary>Min Gust Amount</summary>
        public unsafe float MinGustAmount {
            get {return WindDirectionalSourceComponent_ptr->MinGustAmount;}
        }
        ///<summary>Max Gust Amount</summary>
        public unsafe float MaxGustAmount {
            get {return WindDirectionalSourceComponent_ptr->MaxGustAmount;}
        }
        ///<summary>Radius</summary>
        public unsafe float Radius {
            get {return WindDirectionalSourceComponent_ptr->Radius;}
            set {WindDirectionalSourceComponent_ptr->Radius = value;}
        }
        public bool bPointWind {
            get {return Main.GetGetBoolPropertyByName(this, "bPointWind"); }
        }
        static WindDirectionalSourceComponent() {
            StaticClass = Main.GetClass("WindDirectionalSourceComponent");
        }
        internal unsafe WindDirectionalSourceComponent_fields* WindDirectionalSourceComponent_ptr => (WindDirectionalSourceComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WindDirectionalSourceComponent(IntPtr p) => UObject.Make<WindDirectionalSourceComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WindDirectionalSourceComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WindDirectionalSourceComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
