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
using UE4.SourceControl.Native;

namespace UE4.SourceControl {
    ///<summary>Editor source control common functionality.</summary>
    ///<remarks>
    ///@note Many of these source control methods use *smart* file strings which can be one of:
    ///  - fully qualified path
    ///  - relative path
    ///  - long package name
    ///  - asset path
    ///  - export text path (often stored on clipboard)
    ///
    ///  For example:
    ///     - D:\Epic\Dev-Ent\Projects\Python3rdBP\Content\Mannequin\Animations\ThirdPersonIdle.uasset
    ///     - Content\Mannequin\Animations\ThirdPersonIdle.uasset
    ///     - /Game/Mannequin/Animations/ThirdPersonIdle
    ///     - /Game/Mannequin/Animations/ThirdPersonIdle.ThirdPersonIdle
    ///     - AnimSequence'/Game/Mannequin/Animations/ThirdPersonIdle.ThirdPersonIdle'
    ///</remarks>
    public unsafe partial class SourceControlHelpers : UObject  {

        ///<summary>Use currently set source control provider to check in a file.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFile                  The file to check in - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       InDescription   Description for check in
        ///@param       bSilent                 if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool CheckInFile(string InFile, string InDescription, bool bSilent)  => 
            SourceControlHelpers_methods.CheckInFile_method.Invoke(InFile, InDescription, bSilent);

        ///<summary>Use currently set source control provider to check in specified files.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFiles                 Files to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       InDescription   Description for check in
        ///@param       bSilent                 if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool CheckInFiles(byte InFiles /*TODO: array TArray */, string InDescription, bool bSilent)  => 
            SourceControlHelpers_methods.CheckInFiles_method.Invoke(InFiles, InDescription, bSilent);

        ///<summary>Use currently set source control provider to check out a file.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFile          The file to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent         if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool CheckOutFile(string InFile, bool bSilent)  => 
            SourceControlHelpers_methods.CheckOutFile_method.Invoke(InFile, bSilent);

        ///<summary>Use currently set source control provider to check out specified files.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFiles         Files to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent         if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool CheckOutFiles(byte InFiles /*TODO: array TArray */, bool bSilent)  => 
            SourceControlHelpers_methods.CheckOutFiles_method.Invoke(InFiles, bSilent);

        ///<summary>Use currently set source control provider to check out file or mark it for add.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFile          The file to check out/add - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent         if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool CheckOutOrAddFile(string InFile, bool bSilent)  => 
            SourceControlHelpers_methods.CheckOutOrAddFile_method.Invoke(InFile, bSilent);

        ///<summary>Use currently set source control provider to copy a file.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InSourceFile    Source file string to copy from - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       InDestFile              Source file string to copy to - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard). If package, then uses same extension as source file.
        ///@param       bSilent                 if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool CopyFile(string InSourceFile, string InDestFile, bool bSilent)  => 
            SourceControlHelpers_methods.CopyFile_method.Invoke(InSourceFile, InDestFile, bSilent);

        ///<summary>Determine the name of the current source control provider.</summary>
        ///<remarks>
        ///@return      the name of the current source control provider. If one is not set then "None" is returned.
        ///</remarks>
        public static string CurrentProvider()  => 
            SourceControlHelpers_methods.CurrentProvider_method.Invoke();

        ///<summary>
        ///Quick check if currently set source control provider is enabled and available for use
        ///(server-based providers can use this to return whether the server is available or not)
        ///@
        ///</summary>
        ///<remarks>return      true if source control is available, false if it is not</remarks>
        public static bool IsAvailable()  => 
            SourceControlHelpers_methods.IsAvailable_method.Invoke();

        ///<summary>
        ///Determine if there is a source control system enabled
        ///@
        ///</summary>
        ///<remarks>return      true if enabled, false if not</remarks>
        public static bool IsEnabled()  => 
            SourceControlHelpers_methods.IsEnabled_method.Invoke();

        ///<summary>Get status text set by SourceControl system if an error occurs regardless whether bSilent is set or not.</summary>
        ///<remarks>Only set if there was an error.</remarks>
        public static byte /*TODO: text FText*/ LastErrorMsg()  => 
            SourceControlHelpers_methods.LastErrorMsg_method.Invoke();

        ///<summary>Use currently set source control provider to mark a file for add.</summary>
        ///<remarks>
        ///Does nothing (and returns true) if the file is already under SC
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFile          The file to add - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent         if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool MarkFileForAdd(string InFile, bool bSilent)  => 
            SourceControlHelpers_methods.MarkFileForAdd_method.Invoke(InFile, bSilent);

        ///<summary>
        ///Use currently set source control provider to remove file from source control and
        ///delete the file.
        ///</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFile          The file to delete - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent         if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool MarkFileForDelete(string InFile, bool bSilent)  => 
            SourceControlHelpers_methods.MarkFileForDelete_method.Invoke(InFile, bSilent);

        ///<summary>Use currently set source control provider to mark files for add.</summary>
        ///<remarks>
        ///Does nothing (and returns true) for any file that is already under SC
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFiles         Files to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent         if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool MarkFilesForAdd(byte InFiles /*TODO: array TArray */, bool bSilent)  => 
            SourceControlHelpers_methods.MarkFilesForAdd_method.Invoke(InFiles, bSilent);

        ///<summary>Use currently set source control provider to query a file's source control state.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFile                  The file to query - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent                 if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      Source control state - see USourceControlState. It will have bIsValid set to false if
        ///                     it could not have its values set.
        ///</remarks>
        public static SourceControlState QueryFileState(string InFile, bool bSilent)  => 
            SourceControlHelpers_methods.QueryFileState_method.Invoke(InFile, bSilent);

        ///<summary>Use currently set source control provider to revert a file regardless whether any changes will be lost or not.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFile  The file to revert - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool RevertFile(string InFile, bool bSilent)  => 
            SourceControlHelpers_methods.RevertFile_method.Invoke(InFile, bSilent);

        ///<summary>Use currently set source control provider to revert files regardless whether any changes will be lost or not.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFiles Files to revert - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool RevertFiles(byte InFiles /*TODO: array TArray */, bool bSilent)  => 
            SourceControlHelpers_methods.RevertFiles_method.Invoke(InFiles, bSilent);

        ///<summary>Use currently set source control provider to revert a file provided no changes have been made.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFile  File to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool RevertUnchangedFile(string InFile, bool bSilent)  => 
            SourceControlHelpers_methods.RevertUnchangedFile_method.Invoke(InFile, bSilent);

        ///<summary>Use currently set source control provider to revert files provided no changes have been made.</summary>
        ///<remarks>
        ///@note        Blocks until action is complete.
        ///
        ///@param       InFiles Files to check out - can be either fully qualified path, relative path, long package name, asset path or export text path (often stored on clipboard)
        ///@param       bSilent if false (default) then write out any error info to the Log. Any error text can be retrieved by LastErrorMsg() regardless.
        ///@return      true if succeeded, false if failed and can call LastErrorMsg() for more info.
        ///</remarks>
        public static bool RevertUnchangedFiles(byte InFiles /*TODO: array TArray */, bool bSilent)  => 
            SourceControlHelpers_methods.RevertUnchangedFiles_method.Invoke(InFiles, bSilent);
        static SourceControlHelpers() {
            StaticClass = Main.GetClass("SourceControlHelpers");
        }
        internal unsafe SourceControlHelpers_fields* SourceControlHelpers_ptr => (SourceControlHelpers_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SourceControlHelpers(IntPtr p) => UObject.Make<SourceControlHelpers>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SourceControlHelpers DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SourceControlHelpers New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
