﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("44")>  _
        Public Property HKey1() As Integer
            Get
                Return CType(Me("HKey1"),Integer)
            End Get
            Set
                Me("HKey1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Print Screen")>  _
        Public Property HKey1Text() As String
            Get
                Return CType(Me("HKey1Text"),String)
            End Get
            Set
                Me("HKey1Text") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property Animate() As Boolean
            Get
                Return CType(Me("Animate"),Boolean)
            End Get
            Set
                Me("Animate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Debug() As Boolean
            Get
                Return CType(Me("Debug"),Boolean)
            End Get
            Set
                Me("Debug") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("7.0.0")>  _
        Public Property Version() As String
            Get
                Return CType(Me("Version"),String)
            End Get
            Set
                Me("Version") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Fullscreen() As Boolean
            Get
                Return CType(Me("Fullscreen"),Boolean)
            End Get
            Set
                Me("Fullscreen") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LocStorage() As String
            Get
                Return CType(Me("LocStorage"),String)
            End Get
            Set
                Me("LocStorage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property LastFile() As String
            Get
                Return CType(Me("LastFile"),String)
            End Get
            Set
                Me("LastFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SteamSettings() As String
            Get
                Return CType(Me("SteamSettings"),String)
            End Get
            Set
                Me("SteamSettings") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property NewStyle() As Boolean
            Get
                Return CType(Me("NewStyle"),Boolean)
            End Get
            Set
                Me("NewStyle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15, 15, 15")>  _
        Public Property cTitleBar() As Global.System.Drawing.Color
            Get
                Return CType(Me("cTitleBar"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cTitleBar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("27, 27, 27")>  _
        Public Property cBackground() As Global.System.Drawing.Color
            Get
                Return CType(Me("cBackground"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cBackground") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("23, 23, 23")>  _
        Public Property cSideBar() As Global.System.Drawing.Color
            Get
                Return CType(Me("cSideBar"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cSideBar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("177, 208, 217")>  _
        Public Property cText() As Global.System.Drawing.Color
            Get
                Return CType(Me("cText"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cText") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("23, 23, 23")>  _
        Public Property cTray() As Global.System.Drawing.Color
            Get
                Return CType(Me("cTray"),Global.System.Drawing.Color)
            End Get
            Set
                Me("cTray") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property TreeOne() As Boolean
            Get
                Return CType(Me("TreeOne"),Boolean)
            End Get
            Set
                Me("TreeOne") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property EqmtOne() As Boolean
            Get
                Return CType(Me("EqmtOne"),Boolean)
            End Get
            Set
                Me("EqmtOne") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SortType() As Integer
            Get
                Return CType(Me("SortType"),Integer)
            End Get
            Set
                Me("SortType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property EqmtSort() As Integer
            Get
                Return CType(Me("EqmtSort"),Integer)
            End Get
            Set
                Me("EqmtSort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property ScaleType() As Integer
            Get
                Return CType(Me("ScaleType"),Integer)
            End Get
            Set
                Me("ScaleType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property Scaling() As Integer
            Get
                Return CType(Me("Scaling"),Integer)
            End Get
            Set
                Me("Scaling") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property RelicWinLoc() As Global.System.Drawing.Point
            Get
                Return CType(Me("RelicWinLoc"),Global.System.Drawing.Point)
            End Get
            Set
                Me("RelicWinLoc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property EqmtWinLoc() As Global.System.Drawing.Point
            Get
                Return CType(Me("EqmtWinLoc"),Global.System.Drawing.Point)
            End Get
            Set
                Me("EqmtWinLoc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property MainLoc() As Global.System.Drawing.Point
            Get
                Return CType(Me("MainLoc"),Global.System.Drawing.Point)
            End Get
            Set
                Me("MainLoc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ExpandedRelics() As String
            Get
                Return CType(Me("ExpandedRelics"),String)
            End Get
            Set
                Me("ExpandedRelics") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SSCount() As Integer
            Get
                Return CType(Me("SSCount"),Integer)
            End Get
            Set
                Me("SSCount") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property EtcCount() As Integer
            Get
                Return CType(Me("EtcCount"),Integer)
            End Get
            Set
                Me("EtcCount") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.WFInfo.My.MySettings
            Get
                Return Global.WFInfo.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
