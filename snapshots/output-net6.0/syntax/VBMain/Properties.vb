  Imports System.Diagnostics.CodeAnalysis

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
      <SuppressMessage("ReSharper", "all")>
      Public Class Properties
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#
'                             documentation ```vb\nClass Properties\n```
          Private ReadOnly Property [Get] As Byte
'                                   ^^^^^ definition scip-dotnet nuget . . VBMain/Properties#Get.
'                                         documentation ```vb\nPrivate ReadOnly Property Properties.Get As Byte\n```

          Private WriteOnly Property [Set] As Char
'                                    ^^^^^ definition scip-dotnet nuget . . VBMain/Properties#Set.
'                                          documentation ```vb\nPrivate WriteOnly Property Properties.Set As Char\n```
              Set(ByVal value As Char)
'                       ^^^^^ definition local 0
'                             documentation ```vb\nvalue As Char\n```
                  Throw New NotImplementedException()
              End Set
          End Property

          Private Property GetSet As UInteger
'                          ^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#GetSet.
'                                 documentation ```vb\nPrivate Property Properties.GetSet As UInteger\n```
          Private Property SetGet As Long
'                          ^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#SetGet.
'                                 documentation ```vb\nPrivate Property Properties.SetGet As Long\n```
      End Class
  End Namespace
