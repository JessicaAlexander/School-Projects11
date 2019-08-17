Public Class Customer
    Public Shared adapter As New Winter_Sports_RentalsDataSetTableAdapters.CustomerTableAdapter
    Public Shared rentalData As New Winter_Sports_RentalsDataSet

    Public CustomeId As Integer
    Public FirstName As String
    Public LastName As String
    Public StreetAddress As String
    Public City As String
    Public State As String
    Public ZipCode As String
    Public PhoneNunmber As String

    Sub New()
        CustomeId = adapter.GetData.Count + 1
        FirstName = String.Empty
        LastName = String.Empty
        StreetAddress = String.Empty
        City = String.Empty
        State = String.Empty
        ZipCode = String.Empty
        PhoneNunmber = String.Empty
    End Sub

    Sub New(fName As String, lName As String, stAdd As String, cName As String, stName As String, zipcode As String, phonenumber As String)
        CustomeId = adapter.GetData.Count + 1
        FirstName = fName
        LastName = lName
        StreetAddress = stAdd
        City = cName
        State = stName
        zipcode = zipcode
        PhoneNunmber = phonenumber
    End Sub

    Public Shared Sub addCustomerToDatabase(cust As Customer)
        adapter.Insert(cust.FirstName, cust.LastName, cust.StreetAddress, cust.City, cust.State, cust.ZipCode, cust.PhoneNunmber)
    End Sub
End Class
