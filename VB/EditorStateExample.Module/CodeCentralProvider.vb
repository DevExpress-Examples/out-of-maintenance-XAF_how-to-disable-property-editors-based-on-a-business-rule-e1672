Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.DB.Helpers

Namespace WinWebSolution.Module
    'For demo purposes only!!!
    Public Class CodeCentralExampleInMemoryDataStoreProvider
        Public Const XpoProviderTypeString As String = "CodeCentralExampleInMemoryDataSet"
        Public Const ConnectionString As String = "XpoProvider=CodeCentralExampleInMemoryDataSet"
        Private Shared dataSet As DataSet
        Private Shared isRegistered As Boolean

        Shared Sub New()
            If (Not isRegistered) Then
                Try
                    dataSet = New DataSet()
                    DataStoreBase.RegisterDataStoreProvider(XpoProviderTypeString, New DataStoreCreationFromStringDelegate(AddressOf CreateProviderFromString))
                    isRegistered = True
                Catch
                    Throw New Exception(String.Format("Cannot register the {0}", GetType(CodeCentralExampleInMemoryDataStoreProvider).Name))
                End Try
            End If
        End Sub
        Public Shared Function CreateProviderFromString(ByVal connectionString As String, ByVal autoCreateOption As AutoCreateOption, <System.Runtime.InteropServices.Out()> ByRef objectsToDisposeOnDisconnect() As IDisposable) As IDataStore
            Dim result As New DataSetDataStore(dataSet, autoCreateOption)
            objectsToDisposeOnDisconnect = New IDisposable() { }
            Return result
        End Function
        Public Shared Sub Register()
        End Sub
    End Class
End Namespace