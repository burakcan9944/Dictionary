<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.auto_load_checkBox2 = New System.Windows.Forms.CheckBox()
        Me.auto_search_checkBox1 = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.search_textBox1 = New System.Windows.Forms.TextBox()
        Me.search_type_comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.En_dic_tableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.En_dic_tableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.progress_Panel2 = New System.Windows.Forms.Panel()
        Me.prog_label_Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.En_dic_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.En_dic_ds = New english_dictionary.en_dic_ds()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.En_dic_tableTableAdapter = New english_dictionary.en_dic_dsTableAdapters.en_dic_tableTableAdapter()
        Me.TableAdapterManager = New english_dictionary.en_dic_dsTableAdapters.TableAdapterManager()
        Me.panel1.SuspendLayout()
        CType(Me.En_dic_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.En_dic_tableBindingNavigator.SuspendLayout()
        Me.progress_Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.En_dic_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.En_dic_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.auto_load_checkBox2)
        Me.panel1.Controls.Add(Me.auto_search_checkBox1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.search_textBox1)
        Me.panel1.Controls.Add(Me.search_type_comboBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(642, 90)
        Me.panel1.TabIndex = 1
        '
        'auto_load_checkBox2
        '
        Me.auto_load_checkBox2.AutoSize = True
        Me.auto_load_checkBox2.Location = New System.Drawing.Point(264, 61)
        Me.auto_load_checkBox2.Name = "auto_load_checkBox2"
        Me.auto_load_checkBox2.Size = New System.Drawing.Size(139, 19)
        Me.auto_load_checkBox2.TabIndex = 5
        Me.auto_load_checkBox2.Text = "Auto Load Last Word"
        Me.auto_load_checkBox2.UseVisualStyleBackColor = True
        '
        'auto_search_checkBox1
        '
        Me.auto_search_checkBox1.AutoSize = True
        Me.auto_search_checkBox1.Location = New System.Drawing.Point(98, 61)
        Me.auto_search_checkBox1.Name = "auto_search_checkBox1"
        Me.auto_search_checkBox1.Size = New System.Drawing.Size(144, 19)
        Me.auto_search_checkBox1.TabIndex = 4
        Me.auto_search_checkBox1.Text = "Auto Search the Word"
        Me.auto_search_checkBox1.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Image = Global.english_dictionary.My.Resources.Resources.search_24
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(329, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(88, 33)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Search"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button1.UseVisualStyleBackColor = True
        '
        'search_textBox1
        '
        Me.search_textBox1.Location = New System.Drawing.Point(203, 17)
        Me.search_textBox1.Name = "search_textBox1"
        Me.search_textBox1.Size = New System.Drawing.Size(120, 21)
        Me.search_textBox1.TabIndex = 2
        '
        'search_type_comboBox1
        '
        Me.search_type_comboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_type_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.search_type_comboBox1.FormattingEnabled = True
        Me.search_type_comboBox1.Items.AddRange(New Object() {"=", "Starts with", "Ends with", "Every where"})
        Me.search_type_comboBox1.Location = New System.Drawing.Point(98, 17)
        Me.search_type_comboBox1.Name = "search_type_comboBox1"
        Me.search_type_comboBox1.Size = New System.Drawing.Size(99, 23)
        Me.search_type_comboBox1.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(27, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "The Word:"
        '
        'En_dic_tableBindingNavigator
        '
        Me.En_dic_tableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.En_dic_tableBindingNavigator.AutoSize = False
        Me.En_dic_tableBindingNavigator.BindingSource = Me.En_dic_tableBindingSource
        Me.En_dic_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.En_dic_tableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.En_dic_tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.En_dic_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.En_dic_tableBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripSeparator1})
        Me.En_dic_tableBindingNavigator.Location = New System.Drawing.Point(0, 533)
        Me.En_dic_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.En_dic_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.En_dic_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.En_dic_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.En_dic_tableBindingNavigator.Name = "En_dic_tableBindingNavigator"
        Me.En_dic_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.En_dic_tableBindingNavigator.Size = New System.Drawing.Size(642, 37)
        Me.En_dic_tableBindingNavigator.TabIndex = 2
        Me.En_dic_tableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 34)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 37)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 34)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'En_dic_tableBindingNavigatorSaveItem
        '
        Me.En_dic_tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.En_dic_tableBindingNavigatorSaveItem.Image = CType(resources.GetObject("En_dic_tableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.En_dic_tableBindingNavigatorSaveItem.Name = "En_dic_tableBindingNavigatorSaveItem"
        Me.En_dic_tableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 34)
        Me.En_dic_tableBindingNavigatorSaveItem.Text = "Save Data"
        Me.En_dic_tableBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.english_dictionary.My.Resources.Resources.load_all
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 34)
        Me.ToolStripButton1.Text = "Show All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'progress_Panel2
        '
        Me.progress_Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.progress_Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.progress_Panel2.Controls.Add(Me.prog_label_Label3)
        Me.progress_Panel2.Controls.Add(Me.Label2)
        Me.progress_Panel2.Location = New System.Drawing.Point(225, 201)
        Me.progress_Panel2.Name = "progress_Panel2"
        Me.progress_Panel2.Size = New System.Drawing.Size(200, 100)
        Me.progress_Panel2.TabIndex = 3
        Me.progress_Panel2.Visible = False
        '
        'prog_label_Label3
        '
        Me.prog_label_Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.prog_label_Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.prog_label_Label3.Location = New System.Drawing.Point(3, 57)
        Me.prog_label_Label3.Name = "prog_label_Label3"
        Me.prog_label_Label3.Size = New System.Drawing.Size(196, 22)
        Me.prog_label_Label3.TabIndex = 1
        Me.prog_label_Label3.Text = "Loading Data..."
        Me.prog_label_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(44, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please Wait..."
        '
        'textBox2
        '
        Me.textBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.textBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.En_dic_tableBindingSource, "definition", True))
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.textBox2.Location = New System.Drawing.Point(1, 344)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ReadOnly = True
        Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox2.Size = New System.Drawing.Size(641, 180)
        Me.textBox2.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.DataSource = Me.En_dic_tableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(641, 253)
        Me.DataGridView1.TabIndex = 5
        '
        'En_dic_tableBindingSource
        '
        Me.En_dic_tableBindingSource.DataMember = "en_dic_table"
        Me.En_dic_tableBindingSource.DataSource = Me.En_dic_ds
        '
        'En_dic_ds
        '
        Me.En_dic_ds.DataSetName = "en_dic_ds"
        Me.En_dic_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "word"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Word"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "wordtype"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Word Type"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "definition"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Definition"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'En_dic_tableTableAdapter
        '
        Me.En_dic_tableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.en_dic_tableTableAdapter = Me.En_dic_tableTableAdapter
        Me.TableAdapterManager.UpdateOrder = english_dictionary.en_dic_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(642, 570)
        Me.Controls.Add(Me.progress_Panel2)
        Me.Controls.Add(Me.En_dic_tableBindingNavigator)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KSG English Dictionary"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.En_dic_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.En_dic_tableBindingNavigator.ResumeLayout(False)
        Me.En_dic_tableBindingNavigator.PerformLayout()
        Me.progress_Panel2.ResumeLayout(False)
        Me.progress_Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.En_dic_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.En_dic_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents auto_load_checkBox2 As CheckBox
    Private WithEvents auto_search_checkBox1 As CheckBox
    Private WithEvents button1 As Button
    Private WithEvents search_textBox1 As TextBox
    Private WithEvents search_type_comboBox1 As ComboBox
    Private WithEvents label1 As Label
    Friend WithEvents En_dic_ds As en_dic_ds
    Friend WithEvents En_dic_tableBindingSource As BindingSource
    Friend WithEvents En_dic_tableTableAdapter As en_dic_dsTableAdapters.en_dic_tableTableAdapter
    Friend WithEvents TableAdapterManager As en_dic_dsTableAdapters.TableAdapterManager
    Friend WithEvents En_dic_tableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents En_dic_tableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents progress_Panel2 As Panel
    Friend WithEvents prog_label_Label3 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents textBox2 As TextBox
    Private WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
