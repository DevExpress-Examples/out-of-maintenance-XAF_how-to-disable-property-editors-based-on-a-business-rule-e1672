Imports System
Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.ConditionalAppearance
Imports DevExpress.ExpressApp.Editors

Namespace EditorStateExample.Module
    <DefaultClassOptions, ImageName("BO_Person")> _
    Public Class Contact
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Name() As String
            Get
                Return GetPropertyValue(Of String)("Name")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", value)
            End Set
        End Property
        <ImmediatePostData> _
        Public Property IsMarried() As Boolean
            Get
                Return GetPropertyValue(Of Boolean)("IsMarried")
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsMarried", value)
            End Set
        End Property
        <Appearance("Single", Visibility := ViewItemVisibility.Hide, Criteria := "!IsMarried", Context:="DetailView")> _
        Public Property SpouseName() As String
            Get
                Return GetPropertyValue(Of String)("SpouseName")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("SpouseName", value)
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
        <Appearance("AddressOneIsEmpty", Enabled := False, Criteria := "IsNullOrEmpty(Address1)")> _
        Public Property Address2() As String
            Get
                Return GetPropertyValue(Of String)("Address2")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address2", value)
            End Set
        End Property
    End Class
End Namespace
