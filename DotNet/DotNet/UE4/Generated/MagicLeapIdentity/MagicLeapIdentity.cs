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
using UE4.MagicLeapIdentity.Native;

namespace UE4.MagicLeapIdentity {
    ///<summary>Class which provides functions to read and update the user's Magic Leap profile.</summary>
    public unsafe partial class MagicLeapIdentity : UObject  {

        ///<summary>Get the attributes available for the user's Magic Leap profile.</summary>
        ///<remarks>
        ///Note that this does not request the values for these attribtues.
        ///This function makes a blocking call to the cloud. You can alternatively use GetAllAvailableAttributesAsync() to request the attributes asynchronously.
        ///@param AvailableAttributes Output parameter populated with the list of attributes available for the user's Magic Leap profile.
        ///@return Error code when getting the list of available attributes.
        ///</remarks>
        public (IReadOnlyCollection<EMagicLeapIdentityKey>, EMagicLeapIdentityError) GetAllAvailableAttributes()  => 
            MagicLeapIdentity_methods.GetAllAvailableAttributes_method.Invoke(ObjPointer);

        ///<summary>Asynchronous call to get the attributes available for the user's Magic Leap profile.</summary>
        ///<remarks>
        ///Note that this does not request the values for these attribtues.
        ///@param ResultDelegate Callback which reports the list of available attributes.
        ///@return Error code when getting the list of available attributes.
        ///</remarks>
        public void GetAllAvailableAttributesAsync(byte ResultDelegate /*TODO: delegate FAvailableIdentityAttributesDelegate */)  => 
            MagicLeapIdentity_methods.GetAllAvailableAttributesAsync_method.Invoke(ObjPointer, ResultDelegate);

        ///<summary>Get the values for the attributes of the user's Magic Leap profile.</summary>
        ///<remarks>
        ///This function makes a blocking call to the cloud. You can alternatively use RequestAttributeValueAsync() to request the attribute values asynchronously.
        ///@param RequestedAttributeList List of attributes to request the value for.
        ///@param RequestedAttributeValues Output parameter populated with the list of attributes and their values.
        ///@return Error code when getting the attribute values.
        ///</remarks>
        public (IReadOnlyCollection<MagicLeapIdentityAttribute>, EMagicLeapIdentityError) RequestAttributeValue(byte RequestedAttributeList /*TODO: array TArray */)  => 
            MagicLeapIdentity_methods.RequestAttributeValue_method.Invoke(ObjPointer, RequestedAttributeList);

        ///<summary>Asynchronous call to get the values for the attributes of the user's Magic Leap profile.</summary>
        ///<remarks>
        ///@param RequestedAttributeList List of attributes to request the value for.
        ///@param ResultDelegate Callback which reports the list of attributes and their values.
        ///@return Error code when getting the attribute values.
        ///</remarks>
        public EMagicLeapIdentityError RequestAttributeValueAsync(byte RequestedAttributeList /*TODO: array TArray */, byte ResultDelegate /*TODO: delegate FRequestIdentityAttributeValueDelegate */)  => 
            MagicLeapIdentity_methods.RequestAttributeValueAsync_method.Invoke(ObjPointer, RequestedAttributeList, ResultDelegate);
        static MagicLeapIdentity() {
            StaticClass = Main.GetClass("MagicLeapIdentity");
        }
        internal unsafe MagicLeapIdentity_fields* MagicLeapIdentity_ptr => (MagicLeapIdentity_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapIdentity(IntPtr p) => UObject.Make<MagicLeapIdentity>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapIdentity DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapIdentity New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
