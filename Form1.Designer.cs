namespace Mailing
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddAttach = new System.Windows.Forms.Button();
            this.openFileDialogAttach = new System.Windows.Forms.OpenFileDialog();
            this.buttonRemoveAttach = new System.Windows.Forms.Button();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.HTMLEditor = new HTMLWYSIWYG.htmlwysiwyg();
            this.textBoxAsunto = new System.Windows.Forms.TextBox();
            this.labelAsunto = new System.Windows.Forms.Label();
            this.labelTextoEmail = new System.Windows.Forms.Label();
            this.labelAttach = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.textBoxEmailTest = new System.Windows.Forms.TextBox();
            this.labelEmailTest = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.tabPageAdress = new System.Windows.Forms.TabPage();
            this.groupBoxDatosText = new System.Windows.Forms.GroupBox();
            this.textBoxDestinatarios = new System.Windows.Forms.TextBox();
            this.groupBoxDatosExcel = new System.Windows.Forms.GroupBox();
            this.checkBoxBcc = new System.Windows.Forms.CheckBox();
            this.comboBoxExcelVersion = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxSelectFile = new System.Windows.Forms.TextBox();
            this.labelExcel = new System.Windows.Forms.Label();
            this.tabPageConf = new System.Windows.Forms.TabPage();
            this.groupBoxConexión = new System.Windows.Forms.GroupBox();
            this.labelMailingOffset = new System.Windows.Forms.Label();
            this.textBoxMailingOffset = new System.Windows.Forms.TextBox();
            this.checkBoxCurrentUser = new System.Windows.Forms.CheckBox();
            this.textBoxEmailFrom = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxSMTP = new System.Windows.Forms.TextBox();
            this.labelSMTP = new System.Windows.Forms.Label();
            this.panelLog = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelLogEmail = new System.Windows.Forms.Label();
            this.backgroundWorkerMailing = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxEmail.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.tabPageAdress.SuspendLayout();
            this.groupBoxDatosText.SuspendLayout();
            this.groupBoxDatosExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageConf.SuspendLayout();
            this.groupBoxConexión.SuspendLayout();
            this.panelLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(287, 540);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(121, 23);
            this.buttonSendMail.TabIndex = 11;
            this.buttonSendMail.Text = "Enviar";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel|*.xlsx;*.xls";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(22, 74);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(592, 50);
            this.listView1.SmallImageList = this.imageListIcon;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageListIcon
            // 
            this.imageListIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonAddAttach
            // 
            this.buttonAddAttach.Location = new System.Drawing.Point(627, 74);
            this.buttonAddAttach.Name = "buttonAddAttach";
            this.buttonAddAttach.Size = new System.Drawing.Size(33, 23);
            this.buttonAddAttach.TabIndex = 2;
            this.buttonAddAttach.Text = "+";
            this.buttonAddAttach.UseVisualStyleBackColor = true;
            this.buttonAddAttach.Click += new System.EventHandler(this.buttonAddAttach_Click);
            // 
            // openFileDialogAttach
            // 
            this.openFileDialogAttach.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogAttach_FileOk);
            // 
            // buttonRemoveAttach
            // 
            this.buttonRemoveAttach.Location = new System.Drawing.Point(627, 102);
            this.buttonRemoveAttach.Name = "buttonRemoveAttach";
            this.buttonRemoveAttach.Size = new System.Drawing.Size(33, 23);
            this.buttonRemoveAttach.TabIndex = 3;
            this.buttonRemoveAttach.Text = "-";
            this.buttonRemoveAttach.UseVisualStyleBackColor = true;
            this.buttonRemoveAttach.Click += new System.EventHandler(this.buttonRemoveAttach_Click);
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.HTMLEditor);
            this.groupBoxEmail.Controls.Add(this.textBoxAsunto);
            this.groupBoxEmail.Controls.Add(this.labelAsunto);
            this.groupBoxEmail.Controls.Add(this.labelTextoEmail);
            this.groupBoxEmail.Controls.Add(this.labelAttach);
            this.groupBoxEmail.Controls.Add(this.buttonRemoveAttach);
            this.groupBoxEmail.Controls.Add(this.listView1);
            this.groupBoxEmail.Controls.Add(this.buttonAddAttach);
            this.groupBoxEmail.Location = new System.Drawing.Point(6, 21);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(672, 383);
            this.groupBoxEmail.TabIndex = 10;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Email";
            // 
            // HTMLEditor
            // 
            this.HTMLEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HTMLEditor.Location = new System.Drawing.Point(15, 149);
            this.HTMLEditor.Name = "HTMLEditor";
            this.HTMLEditor.ShowAlignCenterButton = false;
            this.HTMLEditor.ShowAlignLeftButton = false;
            this.HTMLEditor.ShowAlignRightButton = false;
            this.HTMLEditor.ShowBackColorButton = false;
            this.HTMLEditor.ShowBolButton = false;
            this.HTMLEditor.ShowBulletButton = false;
            this.HTMLEditor.ShowCopyButton = false;
            this.HTMLEditor.ShowCutButton = false;
            this.HTMLEditor.ShowFontFamilyButton = false;
            this.HTMLEditor.ShowFontSizeButton = false;
            this.HTMLEditor.ShowIndentButton = false;
            this.HTMLEditor.ShowItalicButton = false;
            this.HTMLEditor.ShowJustifyButton = false;
            this.HTMLEditor.ShowLinkButton = false;
            this.HTMLEditor.ShowNewButton = false;
            this.HTMLEditor.ShowOrderedListButton = false;
            this.HTMLEditor.ShowOutdentButton = false;
            this.HTMLEditor.ShowPasteButton = false;
            this.HTMLEditor.ShowPrintButton = false;
            this.HTMLEditor.ShowTxtBGButton = false;
            this.HTMLEditor.ShowTxtColorButton = false;
            this.HTMLEditor.ShowUnderlineButton = false;
            this.HTMLEditor.ShowUnlinkButton = false;
            this.HTMLEditor.Size = new System.Drawing.Size(641, 220);
            this.HTMLEditor.TabIndex = 4;
            this.HTMLEditor.Validating += new System.ComponentModel.CancelEventHandler(this.HTMLEditor_Validating);
            this.HTMLEditor.Validated += new System.EventHandler(this.HTMLEditor_Validated);
            // 
            // textBoxAsunto
            // 
            this.textBoxAsunto.Location = new System.Drawing.Point(55, 27);
            this.textBoxAsunto.Name = "textBoxAsunto";
            this.textBoxAsunto.Size = new System.Drawing.Size(559, 20);
            this.textBoxAsunto.TabIndex = 1;
            this.textBoxAsunto.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAsunto_Validating);
            this.textBoxAsunto.Validated += new System.EventHandler(this.textBoxAsunto_Validated);
            // 
            // labelAsunto
            // 
            this.labelAsunto.AutoSize = true;
            this.labelAsunto.Location = new System.Drawing.Point(6, 30);
            this.labelAsunto.Name = "labelAsunto";
            this.labelAsunto.Size = new System.Drawing.Size(43, 13);
            this.labelAsunto.TabIndex = 10;
            this.labelAsunto.Text = "Asunto:";
            // 
            // labelTextoEmail
            // 
            this.labelTextoEmail.AutoSize = true;
            this.labelTextoEmail.Location = new System.Drawing.Point(6, 133);
            this.labelTextoEmail.Name = "labelTextoEmail";
            this.labelTextoEmail.Size = new System.Drawing.Size(37, 13);
            this.labelTextoEmail.TabIndex = 9;
            this.labelTextoEmail.Text = "Texto:";
            // 
            // labelAttach
            // 
            this.labelAttach.AutoSize = true;
            this.labelAttach.Location = new System.Drawing.Point(6, 58);
            this.labelAttach.Name = "labelAttach";
            this.labelAttach.Size = new System.Drawing.Size(49, 13);
            this.labelAttach.TabIndex = 9;
            this.labelAttach.Text = "Adjuntar:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageAdress);
            this.tabControl1.Controls.Add(this.tabPageConf);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 519);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tabPage1.Controls.Add(this.groupBoxTest);
            this.tabPage1.Controls.Add(this.groupBoxEmail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Email";
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.textBoxEmailTest);
            this.groupBoxTest.Controls.Add(this.labelEmailTest);
            this.groupBoxTest.Controls.Add(this.buttonTest);
            this.groupBoxTest.Location = new System.Drawing.Point(6, 419);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(672, 65);
            this.groupBoxTest.TabIndex = 15;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Prueba email";
            // 
            // textBoxEmailTest
            // 
            this.textBoxEmailTest.Location = new System.Drawing.Point(214, 25);
            this.textBoxEmailTest.Name = "textBoxEmailTest";
            this.textBoxEmailTest.Size = new System.Drawing.Size(228, 20);
            this.textBoxEmailTest.TabIndex = 5;
            this.textBoxEmailTest.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmailTest_Validating);
            this.textBoxEmailTest.Validated += new System.EventHandler(this.textBoxEmailTest_Validated);
            // 
            // labelEmailTest
            // 
            this.labelEmailTest.AutoSize = true;
            this.labelEmailTest.Location = new System.Drawing.Point(149, 28);
            this.labelEmailTest.Name = "labelEmailTest";
            this.labelEmailTest.Size = new System.Drawing.Size(59, 13);
            this.labelEmailTest.TabIndex = 11;
            this.labelEmailTest.Text = "Email Test:";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(465, 23);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 6;
            this.buttonTest.Text = "Probar";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // tabPageAdress
            // 
            this.tabPageAdress.Controls.Add(this.groupBoxDatosText);
            this.tabPageAdress.Controls.Add(this.groupBoxDatosExcel);
            this.tabPageAdress.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdress.Name = "tabPageAdress";
            this.tabPageAdress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdress.Size = new System.Drawing.Size(688, 493);
            this.tabPageAdress.TabIndex = 2;
            this.tabPageAdress.Text = "Direcciones";
            this.tabPageAdress.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatosText
            // 
            this.groupBoxDatosText.Controls.Add(this.textBoxDestinatarios);
            this.groupBoxDatosText.Location = new System.Drawing.Point(23, 295);
            this.groupBoxDatosText.Name = "groupBoxDatosText";
            this.groupBoxDatosText.Size = new System.Drawing.Size(641, 170);
            this.groupBoxDatosText.TabIndex = 11;
            this.groupBoxDatosText.TabStop = false;
            this.groupBoxDatosText.Text = "Destinatarios";
            // 
            // textBoxDestinatarios
            // 
            this.textBoxDestinatarios.Location = new System.Drawing.Point(79, 34);
            this.textBoxDestinatarios.Multiline = true;
            this.textBoxDestinatarios.Name = "textBoxDestinatarios";
            this.textBoxDestinatarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDestinatarios.Size = new System.Drawing.Size(482, 113);
            this.textBoxDestinatarios.TabIndex = 0;
            // 
            // groupBoxDatosExcel
            // 
            this.groupBoxDatosExcel.Controls.Add(this.checkBoxBcc);
            this.groupBoxDatosExcel.Controls.Add(this.comboBoxExcelVersion);
            this.groupBoxDatosExcel.Controls.Add(this.dataGridView1);
            this.groupBoxDatosExcel.Controls.Add(this.buttonSelectFile);
            this.groupBoxDatosExcel.Controls.Add(this.textBoxSelectFile);
            this.groupBoxDatosExcel.Controls.Add(this.labelExcel);
            this.groupBoxDatosExcel.Location = new System.Drawing.Point(8, 21);
            this.groupBoxDatosExcel.Name = "groupBoxDatosExcel";
            this.groupBoxDatosExcel.Size = new System.Drawing.Size(672, 238);
            this.groupBoxDatosExcel.TabIndex = 10;
            this.groupBoxDatosExcel.TabStop = false;
            this.groupBoxDatosExcel.Text = "Destinatarios Excel";
            // 
            // checkBoxBcc
            // 
            this.checkBoxBcc.AutoSize = true;
            this.checkBoxBcc.Location = new System.Drawing.Point(16, 206);
            this.checkBoxBcc.Name = "checkBoxBcc";
            this.checkBoxBcc.Size = new System.Drawing.Size(85, 17);
            this.checkBoxBcc.TabIndex = 12;
            this.checkBoxBcc.Text = "Copia oculta";
            this.checkBoxBcc.UseVisualStyleBackColor = true;
            // 
            // comboBoxExcelVersion
            // 
            this.comboBoxExcelVersion.FormattingEnabled = true;
            this.comboBoxExcelVersion.Location = new System.Drawing.Point(491, 29);
            this.comboBoxExcelVersion.Name = "comboBoxExcelVersion";
            this.comboBoxExcelVersion.Size = new System.Drawing.Size(81, 21);
            this.comboBoxExcelVersion.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 64);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(612, 124);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(581, 27);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFile.TabIndex = 3;
            this.buttonSelectFile.Text = "Abrir Fichero";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // textBoxSelectFile
            // 
            this.textBoxSelectFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSelectFile.Location = new System.Drawing.Point(76, 30);
            this.textBoxSelectFile.Name = "textBoxSelectFile";
            this.textBoxSelectFile.ReadOnly = true;
            this.textBoxSelectFile.Size = new System.Drawing.Size(409, 20);
            this.textBoxSelectFile.TabIndex = 1;
            // 
            // labelExcel
            // 
            this.labelExcel.AutoSize = true;
            this.labelExcel.Location = new System.Drawing.Point(12, 33);
            this.labelExcel.Name = "labelExcel";
            this.labelExcel.Size = new System.Drawing.Size(61, 13);
            this.labelExcel.TabIndex = 4;
            this.labelExcel.Text = "Hoja Excel:";
            // 
            // tabPageConf
            // 
            this.tabPageConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tabPageConf.Controls.Add(this.groupBoxConexión);
            this.tabPageConf.Location = new System.Drawing.Point(4, 22);
            this.tabPageConf.Name = "tabPageConf";
            this.tabPageConf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConf.Size = new System.Drawing.Size(688, 493);
            this.tabPageConf.TabIndex = 1;
            this.tabPageConf.Text = "Configuración";
            // 
            // groupBoxConexión
            // 
            this.groupBoxConexión.Controls.Add(this.labelMailingOffset);
            this.groupBoxConexión.Controls.Add(this.textBoxMailingOffset);
            this.groupBoxConexión.Controls.Add(this.checkBoxCurrentUser);
            this.groupBoxConexión.Controls.Add(this.textBoxEmailFrom);
            this.groupBoxConexión.Controls.Add(this.labelEmail);
            this.groupBoxConexión.Controls.Add(this.textBoxPass);
            this.groupBoxConexión.Controls.Add(this.labelPass);
            this.groupBoxConexión.Controls.Add(this.textBoxUser);
            this.groupBoxConexión.Controls.Add(this.labelUser);
            this.groupBoxConexión.Controls.Add(this.textBoxSMTP);
            this.groupBoxConexión.Controls.Add(this.labelSMTP);
            this.groupBoxConexión.Location = new System.Drawing.Point(8, 29);
            this.groupBoxConexión.Name = "groupBoxConexión";
            this.groupBoxConexión.Size = new System.Drawing.Size(672, 138);
            this.groupBoxConexión.TabIndex = 11;
            this.groupBoxConexión.TabStop = false;
            this.groupBoxConexión.Text = "Conexión";
            // 
            // labelMailingOffset
            // 
            this.labelMailingOffset.AutoSize = true;
            this.labelMailingOffset.Location = new System.Drawing.Point(417, 104);
            this.labelMailingOffset.Name = "labelMailingOffset";
            this.labelMailingOffset.Size = new System.Drawing.Size(129, 13);
            this.labelMailingOffset.TabIndex = 16;
            this.labelMailingOffset.Text = "Nº destinatarios por email:";
            // 
            // textBoxMailingOffset
            // 
            this.textBoxMailingOffset.Location = new System.Drawing.Point(549, 101);
            this.textBoxMailingOffset.MaxLength = 2;
            this.textBoxMailingOffset.Name = "textBoxMailingOffset";
            this.textBoxMailingOffset.Size = new System.Drawing.Size(23, 20);
            this.textBoxMailingOffset.TabIndex = 10;
            this.textBoxMailingOffset.Text = "10";
            this.textBoxMailingOffset.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMailingOffset_Validating);
            this.textBoxMailingOffset.Validated += new System.EventHandler(this.textBoxMailingOffset_Validated);
            // 
            // checkBoxCurrentUser
            // 
            this.checkBoxCurrentUser.AutoSize = true;
            this.checkBoxCurrentUser.Enabled = false;
            this.checkBoxCurrentUser.Location = new System.Drawing.Point(15, 103);
            this.checkBoxCurrentUser.Name = "checkBoxCurrentUser";
            this.checkBoxCurrentUser.Size = new System.Drawing.Size(185, 17);
            this.checkBoxCurrentUser.TabIndex = 9;
            this.checkBoxCurrentUser.Text = "Utilizar usuario actual de windows";
            this.checkBoxCurrentUser.UseVisualStyleBackColor = true;
            this.checkBoxCurrentUser.CheckedChanged += new System.EventHandler(this.checkBoxCurrentUser_CheckedChanged);
            // 
            // textBoxEmailFrom
            // 
            this.textBoxEmailFrom.Location = new System.Drawing.Point(378, 28);
            this.textBoxEmailFrom.Name = "textBoxEmailFrom";
            this.textBoxEmailFrom.Size = new System.Drawing.Size(208, 20);
            this.textBoxEmailFrom.TabIndex = 6;
            this.textBoxEmailFrom.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmailFrom_Validating);
            this.textBoxEmailFrom.Validated += new System.EventHandler(this.textBoxEmailFrom_Validated);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(338, 31);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(379, 65);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(208, 20);
            this.textBoxPass.TabIndex = 8;
            this.textBoxPass.UseSystemPasswordChar = true;
            this.textBoxPass.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPass_Validating);
            this.textBoxPass.Validated += new System.EventHandler(this.textBoxPass_Validated);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(310, 68);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(64, 13);
            this.labelPass.TabIndex = 12;
            this.labelPass.Text = "Contraseña:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(58, 65);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(208, 20);
            this.textBoxUser.TabIndex = 7;
            this.textBoxUser.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUser_Validating);
            this.textBoxUser.Validated += new System.EventHandler(this.textBoxUser_Validated);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 68);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 13);
            this.labelUser.TabIndex = 12;
            this.labelUser.Text = "Usuario:";
            // 
            // textBoxSMTP
            // 
            this.textBoxSMTP.Location = new System.Drawing.Point(58, 28);
            this.textBoxSMTP.Name = "textBoxSMTP";
            this.textBoxSMTP.Size = new System.Drawing.Size(257, 20);
            this.textBoxSMTP.TabIndex = 5;
            this.textBoxSMTP.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSMTP_Validating);
            this.textBoxSMTP.Validated += new System.EventHandler(this.textBoxSMTP_Validated);
            // 
            // labelSMTP
            // 
            this.labelSMTP.AutoSize = true;
            this.labelSMTP.Location = new System.Drawing.Point(12, 31);
            this.labelSMTP.Name = "labelSMTP";
            this.labelSMTP.Size = new System.Drawing.Size(40, 13);
            this.labelSMTP.TabIndex = 12;
            this.labelSMTP.Text = "SMTP:";
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLog.Controls.Add(this.buttonOk);
            this.panelLog.Controls.Add(this.buttonCancel);
            this.panelLog.Controls.Add(this.labelPorcentaje);
            this.panelLog.Controls.Add(this.progressBar1);
            this.panelLog.Controls.Add(this.labelLogEmail);
            this.panelLog.Location = new System.Drawing.Point(21, 237);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(653, 100);
            this.panelLog.TabIndex = 2;
            this.panelLog.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(288, 70);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Visible = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(288, 70);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.labelPorcentaje.Location = new System.Drawing.Point(315, 49);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(21, 13);
            this.labelPorcentaje.TabIndex = 3;
            this.labelPorcentaje.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.progressBar1.Location = new System.Drawing.Point(71, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(509, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // labelLogEmail
            // 
            this.labelLogEmail.AutoSize = true;
            this.labelLogEmail.Location = new System.Drawing.Point(72, 8);
            this.labelLogEmail.Name = "labelLogEmail";
            this.labelLogEmail.Size = new System.Drawing.Size(0, 13);
            this.labelLogEmail.TabIndex = 0;
            // 
            // backgroundWorkerMailing
            // 
            this.backgroundWorkerMailing.WorkerReportsProgress = true;
            this.backgroundWorkerMailing.WorkerSupportsCancellation = true;
            this.backgroundWorkerMailing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMailing_DoWork);
            this.backgroundWorkerMailing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMailing_ProgressChanged);
            this.backgroundWorkerMailing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMailing_RunWorkerCompleted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(186)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(694, 575);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mailing Solution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.tabPageAdress.ResumeLayout(false);
            this.groupBoxDatosText.ResumeLayout(false);
            this.groupBoxDatosText.PerformLayout();
            this.groupBoxDatosExcel.ResumeLayout(false);
            this.groupBoxDatosExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageConf.ResumeLayout(false);
            this.groupBoxConexión.ResumeLayout(false);
            this.groupBoxConexión.PerformLayout();
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAddAttach;
        private System.Windows.Forms.OpenFileDialog openFileDialogAttach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonRemoveAttach;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.Label labelAttach;
        private System.Windows.Forms.TextBox textBoxAsunto;
        private System.Windows.Forms.Label labelAsunto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageConf;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMailing;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Label labelLogEmail;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.GroupBox groupBoxDatosExcel;
        private System.Windows.Forms.ComboBox comboBoxExcelVersion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox textBoxSelectFile;
        private System.Windows.Forms.Label labelExcel;
        private System.Windows.Forms.GroupBox groupBoxConexión;
        private System.Windows.Forms.TextBox textBoxEmailFrom;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxSMTP;
        private System.Windows.Forms.Label labelSMTP;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxEmailTest;
        private System.Windows.Forms.Label labelEmailTest;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.Label labelTextoEmail;
        private System.Windows.Forms.CheckBox checkBoxCurrentUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxMailingOffset;
        private System.Windows.Forms.Label labelMailingOffset;
        private HTMLWYSIWYG.htmlwysiwyg HTMLEditor;
        private System.Windows.Forms.CheckBox checkBoxBcc;
        private System.Windows.Forms.TabPage tabPageAdress;
        private System.Windows.Forms.GroupBox groupBoxDatosText;
        private System.Windows.Forms.TextBox textBoxDestinatarios;
    }
}

