using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace Mailing
{
    public partial class Form1 : Form
    {

        private List<string> EmailList = new List<string>();
        private Hashtable mailDatos;
        System.Threading.AutoResetEvent Ar; 

        public Form1()
        {
            InitializeComponent();
            this.Text = String.Format("{0} :: {1} v{2}", AssemblyInfo.AssemblyCompany, AssemblyInfo.AssemblyProduct, AssemblyInfo.AssemblyVersionFormat);
            this.comboBoxExcelVersion.DataSource = Enum.GetValues(typeof(ExcelOLEDB.ExcelVersion));
            this.comboBoxExcelVersion.SelectedItem = ExcelOLEDB.ExcelVersion.v2003;
            this.readSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.checkBoxCurrentUser.Checked) { this.textBoxUser.Text = Helper.CurrentWindowsUser; }

            // Hashtable con los datos del email para poder acceder desde el backgroundworker
            // que no puede acceder directamente a los controles del formulario
            this.mailDatos = new Hashtable();
            this.Ar = new System.Threading.AutoResetEvent(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show(this,"¿Estas seguro que quieres cerrar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (this.backgroundWorkerMailing.IsBusy)
                {
                    this.backgroundWorkerMailing.CancelAsync();
                }

                this.saveSettings();

                // Añadimos esta linea para poder cerrar aunque haya errores en errorProvider
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region Settings ini

        private void readSettings()
        {
            this.textBoxSMTP.Text = Properties.Settings.Default.serverSMTP;
            this.textBoxEmailFrom.Text = Properties.Settings.Default.emailFrom;
            this.textBoxUser.Text = Properties.Settings.Default.emailUser;
            this.textBoxPass.Text = Properties.Settings.Default.emailPass;
        }

        private void saveSettings()
        {
            Properties.Settings.Default.serverSMTP = this.textBoxSMTP.Text;
            Properties.Settings.Default.emailFrom = this.textBoxEmailFrom.Text;
            Properties.Settings.Default.emailUser = this.textBoxUser.Text;
            Properties.Settings.Default.emailPass = this.textBoxPass.Text;
            Properties.Settings.Default.Save();
        }

        #endregion

        private void cargaHashmailDatos()
        {
            this.mailDatos.Clear();
            this.mailDatos.Add("from", this.textBoxEmailFrom.Text);
            this.mailDatos.Add("asunto", this.textBoxAsunto.Text);
            this.mailDatos.Add("body", this.HTMLEditor.getHTML());
            this.mailDatos.Add("smtp", this.textBoxSMTP.Text);
            this.mailDatos.Add("user", this.textBoxUser.Text);
            this.mailDatos.Add("pass", this.textBoxPass.Text);
            this.mailDatos.Add("Bcc", this.checkBoxBcc.Checked);
            List<string> attachs = new List<string>();
            foreach (ListViewItem attach in this.listView1.Items)
            {
                attachs.Add(attach.Tag.ToString());
            }
            this.mailDatos.Add("attachs", attachs);

            // Campos para el log
            this.mailDatos.Add("fileExcel", this.textBoxSelectFile.Text);
            int colExcel = this.dataGridView1.SelectedColumns.Count > 0 ? this.dataGridView1.SelectedColumns[0].Index : -1;
            this.mailDatos.Add("colExcel", colExcel);
        }

        #region FicheroExcel

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.textBoxSelectFile.Text = this.openFileDialog1.FileName;
            this.dataGridView1Load();
        }

        private void dataGridView1Load()
        {
            try
            {
                ExcelOLEDB.ExcelVersion version = (ExcelOLEDB.ExcelVersion)this.comboBoxExcelVersion.SelectedValue;
                ExcelOLEDB datos = new ExcelOLEDB(this.openFileDialog1.FileName, version);
                DataTable valores = datos.readExcel();
                this.dataGridView1.DataSource = valores;
                this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al leer Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        #endregion

        #region Attachment

        private void openFileDialogAttach_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(this.openFileDialogAttach.FileName);
            string filepath = file.FullName;
            string filename = file.Name;
            if (this.checkAttachment(filepath))
            {
                this.listView1.BeginUpdate();

                ListViewItem item = new ListViewItem();
                item.Text = filename;
                item.Tag = filepath;

                // Check to see if the image collection contains an image
                // for this extension, using the extension as a key.
                if (!this.imageListIcon.Images.ContainsKey(file.Extension))
                {
                    // Set a default icon for the file.
                    Icon iconForFile = SystemIcons.WinLogo;
                    // If not, add the image to the image list.
                    iconForFile = Icon.ExtractAssociatedIcon(filepath);
                    this.imageListIcon.Images.Add(file.Extension, iconForFile);
                }

                item.ImageKey = file.Extension;
                this.listView1.Items.Add(item);

                this.listView1.EndUpdate();
            }
        }

        private bool checkAttachment(string file)
        {
            bool isOk = true;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (String.Equals(item.Tag, file))
                {
                    isOk = false;
                    break;
                }
            }
            return isOk;
        }

        private void buttonAddAttach_Click(object sender, EventArgs e)
        {
            this.openFileDialogAttach.ShowDialog();
        }

        private void buttonRemoveAttach_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                this.listView1.Items.Remove(item);
            }
        }

        #endregion

        #region botones

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            this.LoadEmailList();
            bool check = this.checkColumnaDatos();
            if (check)
            {
                // No validamos email test
                this.textBoxEmailTest.CausesValidation = false;

                if (this.ValidateChildren())
                {
                    DialogResult dr = MessageBox.Show("¿Estas seguro de iniciar el envio masivo de emails?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }

                    this.buttonSendMail.Enabled = false;

                    // Cargamos datos del formulario para que los coja el backgroundworker
                    this.cargaHashmailDatos();

                    // Lanzamos el worker
                    this.panelLog.Visible = true;
                    this.buttonOk.Visible = false;
                    this.buttonCancel.Visible = true;
                    this.backgroundWorkerMailing.RunWorkerAsync();
                    this.backgroundWorkerMailing.ReportProgress(0);
                }
                else
                {
                    MessageBox.Show("Hay errores en el formulario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("En la columna seleccionada o en la caja de texto hay emails inválidos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.buttonTest.Enabled = false;
                this.cargaHashmailDatos();
                
                try
                {
                    this.SendEmail(this.textBoxEmailTest.Text);
                    MessageBox.Show("Mensaje test enviado correctamente", "Envio Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Helper.ErrorFile(ex.ToString());
                }
                finally
                {
                    this.buttonTest.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Hay errores en el formulario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.panelLog.Visible = false;
            this.buttonSendMail.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Ar.Set();
            this.backgroundWorkerMailing.CancelAsync();
        }

        #endregion

        private void SendEmail(string To)
        {
            List<string> ListTo = new List<string>();
            ListTo.Add(To);
            this.SendEmail(ListTo);
        }

        private void SendEmail(List<string> To)
        {
            Mail mail = new Mail(this.mailDatos["from"].ToString(), To.ToArray(), this.mailDatos["asunto"].ToString(),
                                 this.mailDatos["body"].ToString(), this.mailDatos["smtp"].ToString());
            mail.TemplateFile = Config.templateFile;
            mail.TemplateMarker = Config.templateMarker;

            //mail.LinkedResources = new string[,] { 
            //                                        { "companylogo", 
            //                                          String.Format(@"{0}\{1}",Config.currentDir,Config.resourceLinkedLogo)
            //                                        }, 
            //                                        { "barra", 
            //                                          String.Format(@"{0}\{1}",Config.currentDir,Config.resourceLinkedBarra)
            //                                        } 
            //};

            mail.IsHtml = true;
            mail.IsBcc = (bool)this.mailDatos["Bcc"];

            mail.Attachments = (this.mailDatos["attachs"] as List<string>).ToArray();

            mail.buildMessage();

            if (!this.checkBoxCurrentUser.Checked)
            {
                mail.Credential = new string[] { this.mailDatos["user"].ToString(), this.mailDatos["pass"].ToString() };
            }

            mail.Send();
        }

        private void LoadEmailList()
        {
            EmailList.Clear();
            IEnumerable<string> IEmailsExcel = GetEmailsFromExcel();
            IEnumerable<string> IEmailsTextBox = GetEmailsFromTextBox();
            if (IEmailsExcel.Count() > 0)
                EmailList.AddRange(IEmailsExcel);
            if (IEmailsTextBox.Count() > 0)
                EmailList.AddRange(IEmailsTextBox);
        }

        private IEnumerable<string> GetEmailsFromExcel()
        {
            return this.dataGridView1.SelectedCells.Cast<DataGridViewCell>().Where(cell => !string.IsNullOrEmpty(cell.Value.ToString())).Select(cell => cell.Value.ToString()).Distinct();
        }

        private List<string> GetEmailsFromTextBox()
        {
            return new List<string>(this.textBoxDestinatarios.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
        }
        
        private bool checkColumnaDatos()
        {
            int maxFilasCheck = 10;
            int emailOk = 0;
            int porcentaje;

            int totalFilasCheck = Math.Min(maxFilasCheck, EmailList.Count);
            List<string> EmailsTest = EmailList.GetRange(0, totalFilasCheck);
            emailOk = EmailsTest.Where(e => Utils.Validate.isEmail(e)).Count();

            porcentaje = (int)(((float)emailOk / (float)totalFilasCheck) * 100);

            return (porcentaje > 50);
        }

        #region backgroundWorkerMailing

        private void backgroundWorkerMailing_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (this.backgroundWorkerMailing.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            // Seleccionamos emails validos
            EmailList = EmailList.Where(c => Utils.Validate.isEmail(c)).ToList();

            // Ordenamos
            EmailList.Sort(delegate(String email1, String email2) { return email1.CompareTo(email2); });

            string currentEmail;
            int total = EmailList.Count;
            int porcentaje = 0;
            List<string> emailsGroup = new List<string>();

            for (int i = 0; i < total; i++)
            {
                if (this.backgroundWorkerMailing.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                currentEmail = EmailList[i];
                porcentaje = (int)(((float)(i+1) / (float)total) * 100);

                emailsGroup.Add(currentEmail);

                // Si tenemos un paquete completo o es el último email (y no se completa el paquete)
                if (emailsGroup.Count == Convert.ToInt32(this.textBoxMailingOffset.Text) || (i+1) == total)
                {
                    // send email pasandole el List emailsGroup
                    try
                    {
                        this.SendEmail(emailsGroup);
                        this.buildLogMsg(emailsGroup, i, "working");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Helper.ErrorFile(ex.ToString());
                    }
                    finally
                    {
                        this.backgroundWorkerMailing.ReportProgress(porcentaje, emailsGroup[0] + " --> " + emailsGroup[emailsGroup.Count-1]);
                        emailsGroup.Clear();
                        // System.Threading.Thread.Sleep(Config.mailingWait * 1000);
                        // No utilizamo sleep ya que entonces si pulsamos boton cancelar (his.backgroundWorkerMailing.CancelAsync())
                        // hay que esperar los Config.mailingWait * 1000 segundos hasta que se cancela el worker
                        Ar.WaitOne(Config.mailingWait * 1000);
                    }
                }
            }

            this.backgroundWorkerMailing.ReportProgress(100, ""); 

        }

        private void backgroundWorkerMailing_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.labelLogEmail.Text = e.UserState != null ? e.UserState.ToString() : "";
            this.labelPorcentaje.Text = String.Format("{0}%",e.ProgressPercentage);
        }

        private void backgroundWorkerMailing_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.labelLogEmail.Text = "Proceso cancelado";
            }

            else if (!(e.Error == null))
            {
                this.labelLogEmail.Text = "Error, " + e.Error.Message;
            }

            else
            {
                this.labelLogEmail.Text = "Proceso finalizado correctamente.";
            }

            Helper.LogFileLine(6, "Status: " + this.labelLogEmail.Text);

            // Volvemos a permitir validación email test por si se hace un prueba tras envio
            this.textBoxEmailTest.CausesValidation = true;
            this.buttonOk.Visible = true;
            this.buttonCancel.Visible = false;

        }

        private void buildLogMsg(List<string> emailsGroup, int lastEmailIndex, string status)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Fecha: " + DateTime.Now.ToString("G"));
                sb.AppendLine("Emails: " + String.Join(", ", emailsGroup.ToArray()));
                sb.AppendLine("LastIndex: " + lastEmailIndex);
                sb.AppendLine("Excel: " + this.mailDatos["fileExcel"].ToString());
                sb.AppendLine("Columna: " + this.mailDatos["colExcel"].ToString());
                sb.AppendLine("Status: " + status);
                Helper.LogFile(sb.ToString());
            }
            catch (Exception ex)
            {
                Helper.ErrorFile(ex.ToString());
            }
        }

        #endregion

        #region usuario

        private void checkBoxCurrentUser_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitar = !this.checkBoxCurrentUser.Checked;
            this.textBoxUser.Enabled = this.textBoxPass.Enabled = habilitar;
            if (this.checkBoxCurrentUser.Checked)
            {
                this.textBoxUser.Text = Helper.CurrentWindowsUser;
                this.textBoxPass.Text = string.Empty;
            }
        }

        #endregion

        #region validaciones

        private void textBoxAsunto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.textBoxAsunto.Text == string.Empty)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.textBoxAsunto, "Introduce un asunto para el email");
            }
        }

        private void textBoxAsunto_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textBoxAsunto, "");
        }

        private void HTMLEditor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.HTMLEditor.getHTML() == null)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.HTMLEditor, "Introduce texto para el email");
            }
        }

        private void HTMLEditor_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.HTMLEditor, "");
        }

        private void textBoxSMTP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.textBoxSMTP.Text == string.Empty)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.textBoxSMTP, "Introduce un servidor SMTP");
            }
        }

        private void textBoxSMTP_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textBoxSMTP, "");
        }

        private void textBoxEmailFrom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utils.Validate.isEmail(this.textBoxEmailFrom.Text))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.textBoxEmailFrom, "Introduce un email válido desde donde se envia");
            }
        }

        private void textBoxEmailFrom_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textBoxEmailFrom, "");
        }

        private void textBoxUser_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.textBoxUser.Text == string.Empty)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.textBoxUser, "Introduce un usuario");
            }
        }

        private void textBoxUser_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textBoxUser, "");
        }

        private void textBoxPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.textBoxPass.Text == string.Empty)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.textBoxPass, "Introduce una contraseña");
            }
        }

        private void textBoxPass_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textBoxPass, "");
        }

        private void textBoxEmailTest_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utils.Validate.isEmail(this.textBoxEmailTest.Text))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.textBoxEmailTest, "Introduce un email válido para el test");
            }
        }

        private void textBoxEmailTest_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textBoxEmailTest, "");
        }

        private void textBoxMailingOffset_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int offset;
            if (int.TryParse(this.textBoxMailingOffset.Text, out offset) == false || offset > Config.mailingMaxOffset)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.textBoxMailingOffset, String.Format("Introduce nº como máximo de {0}", Config.mailingMaxOffset));
            }
        }

        private void textBoxMailingOffset_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textBoxMailingOffset, "");
        }

        #endregion

    }

}

