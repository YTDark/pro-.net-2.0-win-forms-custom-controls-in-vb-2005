'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50215.44
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
<Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope := "member", Target := "My.Resources.Resources.get_ResourceManager():System.Resources.ResourceManager")>
<Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope := "member", Target := "My.Resources.Resources.get_Culture():System.Globalization.CultureInfo")>
<Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope := "member", Target := "My.Resources.Resources.set_Culture(System.Globalization.CultureInfo):Void")>

Namespace My


	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' This class was auto-generated by the StronglyTypedResourceBuilder
	' class via a tool like ResGen or Visual Studio.
	' To add or remove a member, edit your .ResX file then rerun ResGen
	' with the /str option, or rebuild your VS project.
	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
	Friend Class Resources

		Private Shared resourceMan As Global.System.Resources.ResourceManager

		Private Shared resourceCulture As Global.System.Globalization.CultureInfo

		<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
		Friend Sub New()
		End Sub

		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If (resourceMan Is Nothing) Then
					Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DocumentView.Properties.Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Overrides the current thread's CurrentUICulture property for all
		'''   resource lookups using this strongly typed resource class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set
				resourceCulture = Value
			End Set
		End Property
	End Class
End Namespace
