using System;

//ref link:https://www.youtube.com/watch?v=S8hkZTCtyrc&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=7
//

/*----------------------------------CMD------------------------------------
 * 
C:\Users\sunny\source\repos\Assembly Manifest>cd Assembly Manifest

C:\Users\sunny\source\repos\Assembly Manifest\Assembly Manifest>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assembly Manifest\Assembly Manifest

22/09/2023  05:17 am    <DIR>          .
22/09/2023  05:17 am    <DIR>          ..
22/09/2023  05:17 am               189 App.config
22/09/2023  05:17 am             2,384 Assembly Manifest.csproj
22/09/2023  05:17 am    <DIR>          bin
22/09/2023  05:17 am    <DIR>          obj
22/09/2023  05:17 am               266 Program.cs
22/09/2023  05:16 am    <DIR>          Properties
               3 File(s)          2,839 bytes
               5 Dir(s)  489,881,288,704 bytes free

C:\Users\sunny\source\repos\Assembly Manifest\Assembly Manifest>csc /t:library /out:MeDll.dll
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

warning CS2008: No source files specified.

C:\Users\sunny\source\repos\Assembly Manifest\Assembly Manifest>csc /t:library /out:MeDll.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.
 
 C:\Users\sunny\source\repos\Assembly Manifest\Assembly Manifest>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Assembly Manifest\Assembly Manifest

22/09/2023  05:26 am    <DIR>          .
22/09/2023  05:26 am    <DIR>          ..
22/09/2023  05:17 am               189 App.config
22/09/2023  05:17 am             2,384 Assembly Manifest.csproj
22/09/2023  05:17 am    <DIR>          bin
22/09/2023  05:25 am             3,584 MeDll.dll
22/09/2023  05:17 am    <DIR>          obj
22/09/2023  05:26 am             1,528 Program.cs
22/09/2023  05:16 am    <DIR>          Properties
               4 File(s)          7,685 bytes
               5 Dir(s)  489,881,624,576 bytes free

C:\Users\sunny\source\repos\Assembly Manifest\Assembly Manifest>ildasm /out:moo.txt MeDll.dll

C:\Users\sunny\source\repos\Assembly Manifest\Assembly Manifest>moo.txt
------------------------NOTEPAD: moo.txt--------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly MeDll  <----------------------------The MANiFEST-------------|
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module MeDll.dll
// MVID: {63219306-5072-4C77-875D-196E94555BA6}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x070A0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit Assembly_Manifest.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class Assembly_Manifest.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res

-------------------------------------------------------------------------



 
 
 
 
 * 
 */