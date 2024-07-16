Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BookStore1

    'Structures
    'Create a Product Structure

    Structure Product
        Dim ProductIDString As String
        Dim DescriptionString As String
        Dim QuantityInteger As Integer
        Dim PriceDecimal As Decimal
    End Structure

    Structure Sale
        Dim SaleIDString As String
        Dim SaleDate As Date
        Dim SaleDecimal() As Decimal
    End Structure

    'Module-level variables/constants/arrays
    Private NumberProductsInteger As Integer = 7
    Private InventoryProduct(NumberProductsInteger) As Product
    Private TotalDueDecimal As Decimal


    Private Sub BookStore1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim InventoryProduct(45000) As Product

        InventoryProduct(0).ProductIDString = "A402"
        InventoryProduct(0).DescriptionString = "History of America Textbook"
        InventoryProduct(0).QuantityInteger = 10
        InventoryProduct(0).PriceDecimal = 65.55D
        InventoryProduct(1).ProductIDString = "A804"
        InventoryProduct(1).DescriptionString = "College Logo Tshirt"
        InventoryProduct(1).QuantityInteger = 15
        InventoryProduct(1).PriceDecimal = 18.99D
        InventoryProduct(2).ProductIDString = "C344"
        InventoryProduct(2).DescriptionString = "College Logo Sweat Pants"
        InventoryProduct(2).QuantityInteger = 25
        InventoryProduct(2).PriceDecimal = 25.99D
        InventoryProduct(3).ProductIDString = "F554"
        InventoryProduct(3).DescriptionString = "Drinking Mug"
        InventoryProduct(3).QuantityInteger = 8
        InventoryProduct(3).PriceDecimal = 5.49D
        InventoryProduct(4).ProductIDString = "G302"
        InventoryProduct(4).DescriptionString = "Pencil and Pen Set"
        InventoryProduct(4).QuantityInteger = 15
        InventoryProduct(4).PriceDecimal = 35.5D
        InventoryProduct(5).ProductIDString = "M302"
        InventoryProduct(5).DescriptionString = "College Logo Sweat Shirt"
        InventoryProduct(5).QuantityInteger = 25
        InventoryProduct(5).PriceDecimal = 22.99D
        InventoryProduct(6).ProductIDString = "S499"
        InventoryProduct(6).DescriptionString = "Intro to Philosophy Textbook"
        InventoryProduct(6).QuantityInteger = 50
        InventoryProduct(6).PriceDecimal = 85D
        InventoryProduct(7).ProductIDString = "X599"
        InventoryProduct(7).DescriptionString = "Intro to CMIS Textbook"
        InventoryProduct(7).QuantityInteger = 75
        InventoryProduct(7).PriceDecimal = 79.4D



    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        'Search the productIDString property of the invetoryProduct array to see if the value ofProductIDTextBox matches an ID in the array
        'Start variables to control the search


        Dim FoundBoolean As Boolean = False
        Dim RowInteger As Integer = 0

        'Loop through the array to control the search
        Do Until FoundBoolean = True Or RowInteger > NumberProductsInteger
            'Compare textBox to array
            If ProductIDTextBox.Text =
        InventoryProduct(RowInteger).ProductIDString Then
                'found a match - display other data to the readonly textboxes
                DescriptionTextBox.Text =
        InventoryProduct(RowInteger).DescriptionString
                QuantityTextBox.Text =
        InventoryProduct(RowInteger).QuantityInteger.ToString
                PriceTextBox.Text =
        InventoryProduct(RowInteger).PriceDecimal

                FoundBoolean = True

            Else

                RowInteger += 1



            End If
        Loop

        If FoundBoolean = False Then

            DescriptionTextBox.Clear()
            QuantityTextBox.Clear()
            PriceTextBox.Clear()

            'Display message that the ProductID is not valid
            MessageBox.Show("Reenter a valid product ID.", "Invalid
        Identifier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ProductIDTextBox.Focus()
            ProductIDTextBox.SelectAll()
        End If
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        'Test to determine if a product was found.
        If DescriptionTextBox.Text = String.Empty Then
            'Cannot purchase, product was not found
            MessageBox.Show("You must select a valid product before
purchasing.", "Cannot Purchase", MessageBoxButtons.OK,
           MessageBoxIcon.Exclamation)
            ProductIDTextBox.Focus()
            ProductIDTextBox.SelectAll()
        Else
            'Can purchase the product
            'Build a string to display in the listbox control
            Dim ProductString As String = ProductIDTextBox.Text & " - " &
           DescriptionTextBox.Text & " - " & PriceTextBox.Text

            'Add the product to the purchase listbox
            PurchaseListBox.Items.Add(ProductString)

            'Display the total to the textbox (TotalDueTextBox)
            TotalDueDecimal += Decimal.Parse(PriceTextBox.Text,
                    Globalization.NumberStyles.Currency)
            TotalDueTextBox.Text = TotalDueDecimal.ToString("C2")

            ProductIDTextBox.Clear()
            DescriptionTextBox.Clear()
            PriceTextBox.Clear()
            QuantityTextBox.Clear()
            ProductIDTextBox.Focus()

        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        'Clear all text box controls
        ProductIDTextBox.Clear()
        DescriptionTextBox.Clear()
        PriceTextBox.Clear()
        QuantityTextBox.Clear()
        TotalDueTextBox.Clear()

        'Clear the list box control
        PurchaseListBox.Items.Clear()

        'Reset the total due module-level variable to zero
        TotalDueDecimal = 0

        'Set the focus to the product ID text box
        ProductIDTextBox.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        'Call the Click event for the Search button control
        SearchButton.PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Dim MessageString As String = "Version 1 of the Book Store  Project" & ControlChars.NewLine & "Today's date/time: " & Date.Now
        Dim TitleString As String = "About Version 1"
        MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
