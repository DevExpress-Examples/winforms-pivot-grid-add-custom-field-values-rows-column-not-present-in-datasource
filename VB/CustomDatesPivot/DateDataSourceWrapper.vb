Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Collections

Namespace CustomDatesPivot

    Friend Class DateDataSourceWrapper
        Implements ITypedList, IList

        Public ReadOnly NestedList As IList

        Public ReadOnly CustomDates As List(Of Date)

        Public ReadOnly Property NestedTypedList As ITypedList
            Get
                Return CType(NestedList, ITypedList)
            End Get
        End Property

        Public Sub New(ByVal OriginalDatasource As ITypedList, ByVal dateFields As List(Of String), ByVal customDates As List(Of Date))
            _DateFields = dateFields
            NestedList = CType(OriginalDatasource, IList)
            Me.CustomDates = customDates
        End Sub

        Private ReadOnly _DateFields As List(Of String)

        Private Class EmptyObjectPropertyDescriptor
            Inherits PropertyDescriptor

            Private ReadOnly _DateFields As List(Of String)

            Public ReadOnly NestedDescriptor As PropertyDescriptor

            Public Sub New(ByVal nestedDescriptor As PropertyDescriptor, ByVal dateFields As List(Of String))
                MyBase.New(nestedDescriptor.Name, CType(New ArrayList(nestedDescriptor.Attributes).ToArray(GetType(Attribute)), Attribute()))
                _DateFields = dateFields
                Me.NestedDescriptor = nestedDescriptor
            End Sub

            Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
                Return False
            End Function

            Public Overrides ReadOnly Property ComponentType As Type
                Get
                    Return GetType(Object)
                End Get
            End Property

            Public Overrides Function GetValue(ByVal component As Object) As Object
                If TypeOf component Is Date Then
                    If _DateFields.Contains(NestedDescriptor.Name) Then Return CDate(component)
                    Return Nothing
                Else
                    Return NestedDescriptor.GetValue(component)
                End If
            End Function

            Public Overrides ReadOnly Property IsReadOnly As Boolean
                Get
                    Return True
                End Get
            End Property

            Public Overrides ReadOnly Property PropertyType As Type
                Get
                    Return NestedDescriptor.PropertyType
                End Get
            End Property

            Public Overrides Sub ResetValue(ByVal component As Object)
                Throw New NotSupportedException("The method or operation is not implemented.")
            End Sub

            Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
                Throw New NotSupportedException("The method or operation is not implemented.")
            End Sub

            Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
                Return True
            End Function
        End Class

        Public Function GetItemProperties(ByVal listAccessors As PropertyDescriptor()) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
            Dim result As List(Of PropertyDescriptor) = New List(Of PropertyDescriptor)()
            For Each pd As PropertyDescriptor In NestedTypedList.GetItemProperties(ExtractOriginalDescriptors(listAccessors))
                result.Add(New EmptyObjectPropertyDescriptor(pd, _DateFields))
            Next

            Return New PropertyDescriptorCollection(result.ToArray())
        End Function

        Public Function GetListName(ByVal listAccessors As PropertyDescriptor()) As String Implements ITypedList.GetListName
            Return NestedTypedList.GetListName(ExtractOriginalDescriptors(listAccessors))
        End Function

        Protected Shared Function ExtractOriginalDescriptors(ByVal listAccessors As PropertyDescriptor()) As PropertyDescriptor()
            If listAccessors Is Nothing Then Return Nothing
            Dim convertedDescriptors As PropertyDescriptor() = New PropertyDescriptor(listAccessors.Length - 1) {}
            Dim i As Integer = 0
            While i < convertedDescriptors.Length
                Dim d As PropertyDescriptor = listAccessors(i)
                Dim c As EmptyObjectPropertyDescriptor = TryCast(d, EmptyObjectPropertyDescriptor)
                If c IsNot Nothing Then
                    convertedDescriptors(i) = c.NestedDescriptor
                Else
                    convertedDescriptors(i) = d
                End If

                Threading.Interlocked.Increment(i)
            End While

            Return convertedDescriptors
        End Function

        Public Function Add(ByVal value As Object) As Integer Implements IList.Add
            Throw New NotSupportedException("The method or operation is not implemented.")
        End Function

        Public Sub Clear() Implements IList.Clear
            Throw New NotSupportedException("The method or operation is not implemented.")
        End Sub

        Public Function Contains(ByVal value As Object) As Boolean Implements IList.Contains
            If TypeOf value Is Date Then Return CustomDates.Contains(CDate(value))
            Return NestedList.Contains(value)
        End Function

        Public Function IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            If TypeOf value Is Date AndAlso CustomDates.Contains(CDate(value)) Then Return CustomDates.IndexOf(CDate(value))
            Dim nres As Integer = NestedList.IndexOf(value)
            If nres < 0 Then Return nres
            Return nres + CustomDates.Count
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
            Throw New NotSupportedException("The method or operation is not implemented.")
        End Sub

        Public ReadOnly Property IsFixedSize As Boolean Implements IList.IsFixedSize
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements IList.IsReadOnly
            Get
                Return True
            End Get
        End Property

        Public Sub Remove(ByVal value As Object) Implements IList.Remove
            Throw New NotSupportedException("The method or operation is not implemented.")
        End Sub

        Public Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
            Throw New NotSupportedException("The method or operation is not implemented.")
        End Sub

        Default Public Property Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                If index < CustomDates.Count Then
                    Return CustomDates(index)
                Else
                    Return NestedList(index - CustomDates.Count)
                End If
            End Get

            Set(ByVal value As Object)
                Throw New NotSupportedException("The method or operation is not implemented.")
            End Set
        End Property

        Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
            Throw New NotSupportedException("The method or operation is not implemented.")
        End Sub

        Public ReadOnly Property Count As Integer Implements ICollection.Count
            Get
                Return NestedList.Count + CustomDates.Count
            End Get
        End Property

        Public ReadOnly Property IsSynchronized As Boolean Implements ICollection.IsSynchronized
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property SyncRoot As Object Implements ICollection.SyncRoot
            Get
                Return NestedList.SyncRoot
            End Get
        End Property

        Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Throw New NotSupportedException("The method or operation is not implemented.")
        End Function
    End Class
End Namespace
