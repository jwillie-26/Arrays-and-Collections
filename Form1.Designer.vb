<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookStore1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        SearchButton = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        QuantityTextBox = New TextBox()
        PriceTextBox = New TextBox()
        DescriptionTextBox = New TextBox()
        ProductIDTextBox = New TextBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        TotalSalesByProductToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        PurchaseToolStripMenuItem = New ToolStripMenuItem()
        ResetToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        PurchaseListBox = New ListBox()
        Label6 = New Label()
        TotalDueTextBox = New TextBox()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SearchButton)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(QuantityTextBox)
        GroupBox1.Controls.Add(PriceTextBox)
        GroupBox1.Controls.Add(DescriptionTextBox)
        GroupBox1.Controls.Add(ProductIDTextBox)
        GroupBox1.Location = New Point(13, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1034, 205)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Product Information"
        ' 
        ' SearchButton
        ' 
        SearchButton.BackColor = SystemColors.ActiveBorder
        SearchButton.Location = New Point(551, 49)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(147, 34)
        SearchButton.TabIndex = 2
        SearchButton.Text = "Search"
        SearchButton.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(79, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 25)
        Label5.TabIndex = 1
        Label5.Text = "Price:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(551, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 25)
        Label4.TabIndex = 1
        Label4.Text = "Quantity On Hand:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 25)
        Label2.TabIndex = 1
        Label2.Text = "Description:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(79, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 1
        Label1.Text = "Product ID:"
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(747, 149)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.ReadOnly = True
        QuantityTextBox.Size = New Size(165, 31)
        QuantityTextBox.TabIndex = 0
        ' 
        ' PriceTextBox
        ' 
        PriceTextBox.Location = New Point(186, 149)
        PriceTextBox.Name = "PriceTextBox"
        PriceTextBox.ReadOnly = True
        PriceTextBox.Size = New Size(165, 31)
        PriceTextBox.TabIndex = 0
        ' 
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.Location = New Point(186, 96)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.ReadOnly = True
        DescriptionTextBox.Size = New Size(726, 31)
        DescriptionTextBox.TabIndex = 0
        ' 
        ' ProductIDTextBox
        ' 
        ProductIDTextBox.CharacterCasing = CharacterCasing.Upper
        ProductIDTextBox.Location = New Point(186, 49)
        ProductIDTextBox.MaxLength = 4
        ProductIDTextBox.Name = "ProductIDTextBox"
        ProductIDTextBox.Size = New Size(335, 31)
        ProductIDTextBox.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ToolStripMenuItem1, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(1060, 33)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TotalSalesByProductToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' TotalSalesByProductToolStripMenuItem
        ' 
        TotalSalesByProductToolStripMenuItem.Name = "TotalSalesByProductToolStripMenuItem"
        TotalSalesByProductToolStripMenuItem.Size = New Size(288, 34)
        TotalSalesByProductToolStripMenuItem.Text = "&Total Sales by Product"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        ExitToolStripMenuItem.Size = New Size(288, 34)
        ExitToolStripMenuItem.Text = "&Exit"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {SearchToolStripMenuItem, PurchaseToolStripMenuItem, ResetToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(90, 29)
        ToolStripMenuItem1.Text = "Product"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SearchToolStripMenuItem.Size = New Size(270, 34)
        SearchToolStripMenuItem.Text = "&Search"
        ' 
        ' PurchaseToolStripMenuItem
        ' 
        PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        PurchaseToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.U
        PurchaseToolStripMenuItem.Size = New Size(270, 34)
        PurchaseToolStripMenuItem.Text = "&Purchase"
        ' 
        ' ResetToolStripMenuItem
        ' 
        ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        ResetToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.R
        ResetToolStripMenuItem.Size = New Size(270, 34)
        ResetToolStripMenuItem.Text = "Reset"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 29)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(270, 34)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' PurchaseListBox
        ' 
        PurchaseListBox.FormattingEnabled = True
        PurchaseListBox.ItemHeight = 25
        PurchaseListBox.Location = New Point(13, 262)
        PurchaseListBox.Name = "PurchaseListBox"
        PurchaseListBox.Size = New Size(1034, 254)
        PurchaseListBox.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(712, 540)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 25)
        Label6.TabIndex = 1
        Label6.Text = "Total Due:"
        ' 
        ' TotalDueTextBox
        ' 
        TotalDueTextBox.Location = New Point(828, 537)
        TotalDueTextBox.Name = "TotalDueTextBox"
        TotalDueTextBox.ReadOnly = True
        TotalDueTextBox.Size = New Size(218, 31)
        TotalDueTextBox.TabIndex = 0
        ' 
        ' BookStore1
        ' 
        AcceptButton = SearchButton
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1060, 587)
        Controls.Add(PurchaseListBox)
        Controls.Add(GroupBox1)
        Controls.Add(Label6)
        Controls.Add(MenuStrip1)
        Controls.Add(TotalDueTextBox)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Name = "BookStore1"
        Text = "KCA University-Bookstore"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PurchaseListBox As ListBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalSalesByProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalDueTextBox As TextBox

End Class
