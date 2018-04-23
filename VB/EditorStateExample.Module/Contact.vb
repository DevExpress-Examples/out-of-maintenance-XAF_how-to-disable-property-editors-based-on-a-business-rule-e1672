Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Imports DevExpress.ExpressApp.ConditionalEditorState

Namespace EditorStateExample.Module
	<DefaultClassOptions, ImageName("BO_Person"), EditorStateRuleAttribute("Single", "SpouseName", EditorState.Hidden, "!Married", ViewType.DetailView), EditorStateRuleAttribute("AddressOneIsEmpty", "Address2", EditorState.Disabled, "IsNullOrEmpty(Address1)", ViewType.DetailView)> _
	Public Class Contact
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Property SpouseName() As String
			Get
				Return GetPropertyValue(Of String)("SpouseName")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("SpouseName", value)
			End Set
		End Property

		<ImmediatePostData> _
		Public Property Married() As Boolean
			Get
				Return GetPropertyValue(Of Boolean)("Married")
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("Married", value)
			End Set
		End Property

		Public Property Name() As String
			Get
				Return GetPropertyValue(Of String)("Name")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Name", value)
			End Set
		End Property

		Public Property Address2() As String
			Get
				Return GetPropertyValue(Of String)("Address2")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Address2", value)
			End Set
		End Property

		<ImmediatePostData> _
		Public Property Address1() As String
			Get
				Return GetPropertyValue(Of String)("Address1")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Address1", value)
			End Set
		End Property
	End Class
End Namespace
