'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version:2.0.40607.85
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
    Imports System
    Imports System.IO
    Imports System.Resources
Namespace My


    ''' <summary>
    '''    A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the Strongly Typed Resource Builder
    ' class via a tool like ResGen or Visual Studio.NET.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    Friend Class Resources

        Private Shared _resMgr As System.Resources.ResourceManager

        Private Shared _resCulture As System.Globalization.CultureInfo

'INSTANT VB NOTE: Beginning of line comments are not maintained by Instant VB
'ORIGINAL LINE: /*FamANDAssem*/ internal Resources() {
        Friend Sub New()
        End Sub

        ''' <summary>
        '''    Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Shared ReadOnly Property ResourceManager() As System.Resources.ResourceManager
            Get
                If (_resMgr Is Nothing) Then
                    Dim temp As New System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    _resMgr = temp
                End If
                Return _resMgr
            End Get
        End Property

        ''' <summary>
        '''    Overrides the current thread's CurrentUICulture property for all
        '''    resource lookups using this strongly typed resource class.
        ''' </summary>
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Shared Property Culture() As System.Globalization.CultureInfo
            Get
                Return _resCulture
            End Get
            Set
                _resCulture = Value
            End Set
        End Property
    End Class
End Namespace
