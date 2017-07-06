namespace CodeRepository
{
  using System;
  using System.IO;
  using System.Text.RegularExpressions;
  using System.Windows.Forms;

  public partial class FormOutilsOptions : Form
  {
    public FormOutilsOptions()
    {
      this.InitializeComponent();
    }

    private static bool IsEmail(string email)
    {
      const string MatchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                       + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
        [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                       + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
        [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                       + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
      return email != null && Regex.IsMatch(email, MatchEmailPattern);
    }

    private void ButtonOutilsOptionsAnnulerClick(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ButtonOutilsOptionsOkClick(object sender, EventArgs e)
    {
      // on enregistre toutes les options et on ferme la fenêtre.
      // ou met-on les options?
      if (IsEmail(this.textBoxEmailAddress.Text))
      {
        this.buttonValidateEmailAddress.Text = string.Format("Email validated");
        this.Close();
      }
      else
      {
        MessageBox.Show(string.Format("Email address is incorrect"));
      }
    }

    private void FormOutilsOptionsLoad(object sender, EventArgs e)
    {
      this.radioButtonFichierLocalText.Checked = true;
      this.textBoxCheminSource.Text = Path.GetDirectoryName(Application.ExecutablePath);
    }

    private void ButtonGetCheminSourceClick(object sender, EventArgs e)
    {
      if (this.radioButtonRepertoireFichiers.Checked)
      {
        if (this.folderBrowserDialogOptions.ShowDialog() == DialogResult.OK)
        {
          this.textBoxCheminSource.Text = this.folderBrowserDialogOptions.SelectedPath;
        }
      }

      if (this.radioButtonFichierLocalText.Checked)
      {
        this.openFileDialogOutilsOptions.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        this.openFileDialogOutilsOptions.Multiselect = false;
        this.openFileDialogOutilsOptions.Filter = string.Format("Fichiers textes *.txt|*.txt");
        this.openFileDialogOutilsOptions.CheckFileExists = true;
        if (this.openFileDialogOutilsOptions.ShowDialog() == DialogResult.OK)
        {
          this.textBoxCheminSource.Text = this.openFileDialogOutilsOptions.FileName;
        }
      }
    }

    private void RadioButtonFichierLocalTextCheckedChanged(object sender, EventArgs e)
    {
      this.OnChangedRadioButton();
    }

    private void RadioButtonLocalDataBaseCheckedChanged(object sender, EventArgs e)
    {
      this.OnChangedRadioButton();
    }

    private void RadioButtonRepertoireFichiersCheckedChanged(object sender, EventArgs e)
    {
      this.OnChangedRadioButton();
    }

    private void OnChangedRadioButton()
    {
      if (this.radioButtonRepertoireFichiers.Checked)
      {
        this.textBoxCheminSource.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      }

      if (this.radioButtonFichierLocalText.Checked)
      {
        this.textBoxCheminSource.Text = Path.GetDirectoryName(Application.ExecutablePath);
      }

      if (this.radioButtonLocalDataBase.Checked)
      {
        this.textBoxCheminSource.Text = Path.GetDirectoryName(Application.ExecutablePath);
      }
    }

    private void ButtonValidateEmailAddressClick(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.textBoxEmailAddress.Text))
      {
        MessageBox.Show(string.Format("Email address should not be empty"));
        return;
      }

      if (IsEmail(this.textBoxEmailAddress.Text))
      {
        this.buttonValidateEmailAddress.Text = string.Format("Email validated");
      }
      else
      {
        MessageBox.Show(string.Format("Email address is incorrect"));
      }
    }

    private void TextBoxEmailAddressTextChanged(object sender, EventArgs e)
    {
      this.buttonValidateEmailAddress.Text = string.Format("Email not validated yet");
    }

    private void TabPageFichierSourceClick(object sender, EventArgs e)
    {
      // loading last config before loading app
    }
  }
}