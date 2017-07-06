namespace CodeRepository
{
  partial class FormOutilsOptions
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonOutilsOptionsOK = new System.Windows.Forms.Button();
      this.buttonOutilsOptionsAnnuler = new System.Windows.Forms.Button();
      this.folderBrowserDialogOptions = new System.Windows.Forms.FolderBrowserDialog();
      this.openFileDialogOutilsOptions = new System.Windows.Forms.OpenFileDialog();
      this.tabPageFichierSource = new System.Windows.Forms.TabPage();
      this.buttonGetCheminSource = new System.Windows.Forms.Button();
      this.textBoxCheminSource = new System.Windows.Forms.TextBox();
      this.labelChemin = new System.Windows.Forms.Label();
      this.groupBoxSourceFile = new System.Windows.Forms.GroupBox();
      this.radioButtonLocalDataBase = new System.Windows.Forms.RadioButton();
      this.radioButtonRepertoireFichiers = new System.Windows.Forms.RadioButton();
      this.radioButtonFichierLocalText = new System.Windows.Forms.RadioButton();
      this.tabControlOptions = new System.Windows.Forms.TabControl();
      this.tabPageBackup = new System.Windows.Forms.TabPage();
      this.buttonValidateEmailAddress = new System.Windows.Forms.Button();
      this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
      this.labelEmailAddress = new System.Windows.Forms.Label();
      this.groupBoxBackup = new System.Windows.Forms.GroupBox();
      this.radioButtonBackupByMail = new System.Windows.Forms.RadioButton();
      this.tabPageFichierSource.SuspendLayout();
      this.groupBoxSourceFile.SuspendLayout();
      this.tabControlOptions.SuspendLayout();
      this.tabPageBackup.SuspendLayout();
      this.groupBoxBackup.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonOutilsOptionsOK
      // 
      this.buttonOutilsOptionsOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOutilsOptionsOK.Location = new System.Drawing.Point(497, 520);
      this.buttonOutilsOptionsOK.Name = "buttonOutilsOptionsOK";
      this.buttonOutilsOptionsOK.Size = new System.Drawing.Size(75, 23);
      this.buttonOutilsOptionsOK.TabIndex = 1;
      this.buttonOutilsOptionsOK.Text = "OK";
      this.buttonOutilsOptionsOK.UseVisualStyleBackColor = true;
      this.buttonOutilsOptionsOK.Click += new System.EventHandler(this.ButtonOutilsOptionsOkClick);
      // 
      // buttonOutilsOptionsAnnuler
      // 
      this.buttonOutilsOptionsAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOutilsOptionsAnnuler.Location = new System.Drawing.Point(595, 520);
      this.buttonOutilsOptionsAnnuler.Name = "buttonOutilsOptionsAnnuler";
      this.buttonOutilsOptionsAnnuler.Size = new System.Drawing.Size(75, 23);
      this.buttonOutilsOptionsAnnuler.TabIndex = 2;
      this.buttonOutilsOptionsAnnuler.Text = "Annuler";
      this.buttonOutilsOptionsAnnuler.UseVisualStyleBackColor = true;
      this.buttonOutilsOptionsAnnuler.Click += new System.EventHandler(this.ButtonOutilsOptionsAnnulerClick);
      // 
      // openFileDialogOutilsOptions
      // 
      this.openFileDialogOutilsOptions.FileName = "openFileDialog1";
      // 
      // tabPageFichierSource
      // 
      this.tabPageFichierSource.BackColor = System.Drawing.Color.Gray;
      this.tabPageFichierSource.Controls.Add(this.buttonGetCheminSource);
      this.tabPageFichierSource.Controls.Add(this.textBoxCheminSource);
      this.tabPageFichierSource.Controls.Add(this.labelChemin);
      this.tabPageFichierSource.Controls.Add(this.groupBoxSourceFile);
      this.tabPageFichierSource.Location = new System.Drawing.Point(4, 25);
      this.tabPageFichierSource.Name = "tabPageFichierSource";
      this.tabPageFichierSource.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageFichierSource.Size = new System.Drawing.Size(674, 526);
      this.tabPageFichierSource.TabIndex = 0;
      this.tabPageFichierSource.Text = "Fichier Source";
      this.tabPageFichierSource.Click += new System.EventHandler(this.TabPageFichierSourceClick);
      // 
      // buttonGetCheminSource
      // 
      this.buttonGetCheminSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonGetCheminSource.Location = new System.Drawing.Point(631, 247);
      this.buttonGetCheminSource.Name = "buttonGetCheminSource";
      this.buttonGetCheminSource.Size = new System.Drawing.Size(33, 23);
      this.buttonGetCheminSource.TabIndex = 3;
      this.buttonGetCheminSource.Text = "...";
      this.buttonGetCheminSource.UseVisualStyleBackColor = true;
      this.buttonGetCheminSource.Click += new System.EventHandler(this.ButtonGetCheminSourceClick);
      // 
      // textBoxCheminSource
      // 
      this.textBoxCheminSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxCheminSource.Location = new System.Drawing.Point(75, 247);
      this.textBoxCheminSource.Name = "textBoxCheminSource";
      this.textBoxCheminSource.Size = new System.Drawing.Size(550, 22);
      this.textBoxCheminSource.TabIndex = 2;
      this.textBoxCheminSource.Text = "C:\\";
      // 
      // labelChemin
      // 
      this.labelChemin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.labelChemin.AutoSize = true;
      this.labelChemin.Location = new System.Drawing.Point(9, 247);
      this.labelChemin.Name = "labelChemin";
      this.labelChemin.Size = new System.Drawing.Size(59, 17);
      this.labelChemin.TabIndex = 1;
      this.labelChemin.Text = "Chemin:";
      // 
      // groupBoxSourceFile
      // 
      this.groupBoxSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxSourceFile.Controls.Add(this.radioButtonLocalDataBase);
      this.groupBoxSourceFile.Controls.Add(this.radioButtonRepertoireFichiers);
      this.groupBoxSourceFile.Controls.Add(this.radioButtonFichierLocalText);
      this.groupBoxSourceFile.Location = new System.Drawing.Point(11, 26);
      this.groupBoxSourceFile.Name = "groupBoxSourceFile";
      this.groupBoxSourceFile.Size = new System.Drawing.Size(214, 200);
      this.groupBoxSourceFile.TabIndex = 0;
      this.groupBoxSourceFile.TabStop = false;
      this.groupBoxSourceFile.Text = "Source";
      // 
      // radioButtonLocalDataBase
      // 
      this.radioButtonLocalDataBase.AutoSize = true;
      this.radioButtonLocalDataBase.Location = new System.Drawing.Point(24, 111);
      this.radioButtonLocalDataBase.Name = "radioButtonLocalDataBase";
      this.radioButtonLocalDataBase.Size = new System.Drawing.Size(166, 21);
      this.radioButtonLocalDataBase.TabIndex = 2;
      this.radioButtonLocalDataBase.TabStop = true;
      this.radioButtonLocalDataBase.Text = "Base de donnée local";
      this.radioButtonLocalDataBase.UseVisualStyleBackColor = true;
      this.radioButtonLocalDataBase.CheckedChanged += new System.EventHandler(this.RadioButtonLocalDataBaseCheckedChanged);
      // 
      // radioButtonRepertoireFichiers
      // 
      this.radioButtonRepertoireFichiers.AutoSize = true;
      this.radioButtonRepertoireFichiers.Location = new System.Drawing.Point(24, 75);
      this.radioButtonRepertoireFichiers.Name = "radioButtonRepertoireFichiers";
      this.radioButtonRepertoireFichiers.Size = new System.Drawing.Size(165, 21);
      this.radioButtonRepertoireFichiers.TabIndex = 1;
      this.radioButtonRepertoireFichiers.TabStop = true;
      this.radioButtonRepertoireFichiers.Text = "Repertoire de fichiers";
      this.radioButtonRepertoireFichiers.UseVisualStyleBackColor = true;
      this.radioButtonRepertoireFichiers.CheckedChanged += new System.EventHandler(this.RadioButtonRepertoireFichiersCheckedChanged);
      // 
      // radioButtonFichierLocalText
      // 
      this.radioButtonFichierLocalText.AutoSize = true;
      this.radioButtonFichierLocalText.Checked = true;
      this.radioButtonFichierLocalText.Location = new System.Drawing.Point(24, 37);
      this.radioButtonFichierLocalText.Name = "radioButtonFichierLocalText";
      this.radioButtonFichierLocalText.Size = new System.Drawing.Size(138, 21);
      this.radioButtonFichierLocalText.TabIndex = 0;
      this.radioButtonFichierLocalText.TabStop = true;
      this.radioButtonFichierLocalText.Text = "Fichier texte local";
      this.radioButtonFichierLocalText.UseVisualStyleBackColor = true;
      this.radioButtonFichierLocalText.CheckedChanged += new System.EventHandler(this.RadioButtonFichierLocalTextCheckedChanged);
      // 
      // tabControlOptions
      // 
      this.tabControlOptions.Controls.Add(this.tabPageFichierSource);
      this.tabControlOptions.Controls.Add(this.tabPageBackup);
      this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
      this.tabControlOptions.Name = "tabControlOptions";
      this.tabControlOptions.SelectedIndex = 0;
      this.tabControlOptions.Size = new System.Drawing.Size(682, 555);
      this.tabControlOptions.TabIndex = 0;
      // 
      // tabPageBackup
      // 
      this.tabPageBackup.Controls.Add(this.buttonValidateEmailAddress);
      this.tabPageBackup.Controls.Add(this.textBoxEmailAddress);
      this.tabPageBackup.Controls.Add(this.labelEmailAddress);
      this.tabPageBackup.Controls.Add(this.groupBoxBackup);
      this.tabPageBackup.Location = new System.Drawing.Point(4, 25);
      this.tabPageBackup.Name = "tabPageBackup";
      this.tabPageBackup.Size = new System.Drawing.Size(674, 526);
      this.tabPageBackup.TabIndex = 1;
      this.tabPageBackup.Text = "Backup";
      this.tabPageBackup.UseVisualStyleBackColor = true;
      // 
      // buttonValidateEmailAddress
      // 
      this.buttonValidateEmailAddress.Location = new System.Drawing.Point(308, 289);
      this.buttonValidateEmailAddress.Name = "buttonValidateEmailAddress";
      this.buttonValidateEmailAddress.Size = new System.Drawing.Size(178, 26);
      this.buttonValidateEmailAddress.TabIndex = 3;
      this.buttonValidateEmailAddress.Text = "Email not validated yet";
      this.buttonValidateEmailAddress.UseVisualStyleBackColor = true;
      this.buttonValidateEmailAddress.Click += new System.EventHandler(this.ButtonValidateEmailAddressClick);
      // 
      // textBoxEmailAddress
      // 
      this.textBoxEmailAddress.Location = new System.Drawing.Point(88, 291);
      this.textBoxEmailAddress.Name = "textBoxEmailAddress";
      this.textBoxEmailAddress.Size = new System.Drawing.Size(196, 22);
      this.textBoxEmailAddress.TabIndex = 2;
      this.textBoxEmailAddress.TextChanged += new System.EventHandler(this.TextBoxEmailAddressTextChanged);
      // 
      // labelEmailAddress
      // 
      this.labelEmailAddress.AutoSize = true;
      this.labelEmailAddress.Location = new System.Drawing.Point(35, 291);
      this.labelEmailAddress.Name = "labelEmailAddress";
      this.labelEmailAddress.Size = new System.Drawing.Size(46, 17);
      this.labelEmailAddress.TabIndex = 1;
      this.labelEmailAddress.Text = "Email:";
      // 
      // groupBoxBackup
      // 
      this.groupBoxBackup.Controls.Add(this.radioButtonBackupByMail);
      this.groupBoxBackup.Location = new System.Drawing.Point(35, 45);
      this.groupBoxBackup.Name = "groupBoxBackup";
      this.groupBoxBackup.Size = new System.Drawing.Size(249, 217);
      this.groupBoxBackup.TabIndex = 0;
      this.groupBoxBackup.TabStop = false;
      this.groupBoxBackup.Text = "Backup";
      // 
      // radioButtonBackupByMail
      // 
      this.radioButtonBackupByMail.AutoSize = true;
      this.radioButtonBackupByMail.Checked = true;
      this.radioButtonBackupByMail.Location = new System.Drawing.Point(27, 47);
      this.radioButtonBackupByMail.Name = "radioButtonBackupByMail";
      this.radioButtonBackupByMail.Size = new System.Drawing.Size(113, 21);
      this.radioButtonBackupByMail.TabIndex = 0;
      this.radioButtonBackupByMail.TabStop = true;
      this.radioButtonBackupByMail.Text = "Send via Mail";
      this.radioButtonBackupByMail.UseVisualStyleBackColor = true;
      // 
      // FormOutilsOptions
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(682, 555);
      this.Controls.Add(this.buttonOutilsOptionsAnnuler);
      this.Controls.Add(this.buttonOutilsOptionsOK);
      this.Controls.Add(this.tabControlOptions);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(700, 600);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(700, 600);
      this.Name = "FormOutilsOptions";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Options";
      this.Load += new System.EventHandler(this.FormOutilsOptionsLoad);
      this.tabPageFichierSource.ResumeLayout(false);
      this.tabPageFichierSource.PerformLayout();
      this.groupBoxSourceFile.ResumeLayout(false);
      this.groupBoxSourceFile.PerformLayout();
      this.tabControlOptions.ResumeLayout(false);
      this.tabPageBackup.ResumeLayout(false);
      this.tabPageBackup.PerformLayout();
      this.groupBoxBackup.ResumeLayout(false);
      this.groupBoxBackup.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonOutilsOptionsOK;
    private System.Windows.Forms.Button buttonOutilsOptionsAnnuler;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOptions;
    private System.Windows.Forms.OpenFileDialog openFileDialogOutilsOptions;
    private System.Windows.Forms.TabPage tabPageFichierSource;
    private System.Windows.Forms.Button buttonGetCheminSource;
    private System.Windows.Forms.TextBox textBoxCheminSource;
    private System.Windows.Forms.Label labelChemin;
    private System.Windows.Forms.GroupBox groupBoxSourceFile;
    private System.Windows.Forms.RadioButton radioButtonLocalDataBase;
    private System.Windows.Forms.RadioButton radioButtonRepertoireFichiers;
    private System.Windows.Forms.RadioButton radioButtonFichierLocalText;
    private System.Windows.Forms.TabControl tabControlOptions;
    private System.Windows.Forms.TabPage tabPageBackup;
    private System.Windows.Forms.Button buttonValidateEmailAddress;
    private System.Windows.Forms.TextBox textBoxEmailAddress;
    private System.Windows.Forms.Label labelEmailAddress;
    private System.Windows.Forms.GroupBox groupBoxBackup;
    private System.Windows.Forms.RadioButton radioButtonBackupByMail;
  }
}