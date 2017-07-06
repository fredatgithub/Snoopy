namespace CodeRepository
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Drawing;
  using System.IO;
  using System.Linq;
  using System.Text.RegularExpressions;
  using System.Windows.Forms;

  using FastColoredTextBoxNS;

  /// <summary>
  /// classe de la Form Principale.
  /// </summary>
  public partial class FormMain : Form
  {
    /// <summary>
    /// Langage utilisé.
    /// </summary>
    private const string Lang = "CSharp";

    /// <summary>
    /// Nom du fichier de code.
    /// </summary>
    private const string FichierCodeRepo = "CodeRepository.txt";

    /// <summary>
    /// Dernière version du fichier code repo.
    /// </summary>
    private const string DerniereVersion = "v1";

    /// <summary>
    /// dictionary dicoLangue.
    /// </summary>
    private readonly Dictionary<string, Language> dicoLangue = new Dictionary<string, Language>();

    /// <summary>
    /// Le fichier Code Repo lu dans la string LeCode.
    /// </summary>
    private string codeSource;

    /// <summary>
    /// source Has Changed
    /// </summary>
    private bool sourceHasChanged = false;

    /// <summary>
    /// caseSensitive for the imput searched words.
    /// </summary>
    private bool caseSensitive = false;

    #region styles

    /// <summary>
    /// Style de texte BlueStyle.
    /// </summary>
    private readonly TextStyle blueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);

    /// <summary>
    /// Style de texte BoldStyle.
    /// </summary>
    private readonly TextStyle boldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);

    /// <summary>
    /// Style de texte GrayStyle.
    /// </summary>
    private readonly TextStyle grayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);

    /// <summary>
    /// Style de texte MagentaStyle.
    /// </summary>
    private readonly TextStyle magentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);

    /// <summary>
    /// Style de texte GreenStyle.
    /// </summary>
    private readonly TextStyle greenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);

    /// <summary>
    /// Style de texte BrownStyle.
    /// </summary>
    private readonly TextStyle brownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);

    /// <summary>
    /// Style de texte MaroonStyle.
    /// </summary>
    private readonly TextStyle maroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);

    /// <summary>
    /// Style de texte SameWordsStyle.
    /// </summary>
    private readonly MarkerStyle sameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

    #endregion styles

    private bool progressBarGoingForward = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormMain"/> class.
    /// </summary>
    public FormMain()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Quitter l'application.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void QuitterToolStripMenuItemClick(object sender, EventArgs e)
    {
      Application.Exit();
    }

    /// <summary>
    /// Recherche de code.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ButtonChercherClick(object sender, EventArgs e)
    {
      progressBarGoingForward = true;
      timer1.Enabled = true;

      if (string.IsNullOrEmpty(textBoxChercher.Text))
      {
        MessageBox.Show(string.Format("Vous devez entrez au moins un mot clef à chercher.\n\n Entrez un ou plusieurs mots clefs séparés par des espaces."), string.Format("Attention"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      if (NumberOfCheckBoxChecked() == 0)
      {
        MessageBox.Show(string.Format("Vous devez cocher au moins un langage."), string.Format("Attention"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      // récupération des options cochées
      // est-ce que le pc est connecté à internet ?
      // On parcours le fichier ou bien on charge tout le fichier en RAM (depending on the length of the file)
      if (!File.Exists(FichierCodeRepo))
      {
        CreateNewFile(FichierCodeRepo);
      }

      // var sr = new StreamReader(FichierCodeRepo);
      // leCode = string.Empty;
      // leCode = sr.ReadToEnd();
      // sr.Close();
      fctb.Text = string.Empty;
      listBoxResult.Items.Clear();

      // Recherche des mots clefs dans la chaine LeCode
      var contenuFichier = new List<string>();
      using (var sr2 = new StreamReader(FichierCodeRepo))
      {
        while (!sr2.EndOfStream)
        {
          // On copie le fichier source texte dans une liste de string ligne par ligne.
          contenuFichier.Add(sr2.ReadLine());
        }
      }

      string[] listMotClef = textBoxChercher.Text.Split(' ');
      var listLangageCoches = new List<string>();

      // or var listLangageCoches = (from Control controle in groupBoxLangage.Controls where controle is CheckBox && ((CheckBox)controle).Checked select ((CheckBox)controle).Name).ToList();
      foreach (Control controle in groupBoxLangage.Controls)
      {
        if (controle is CheckBox && ((CheckBox)controle).Checked)
        {
          listLangageCoches.Add(controle.Name);
        }
      }

      // Séparation des codes par langages
      var listCSharp = new List<string>();
      var listVbNet = new List<string>();
      var listPhp = new List<string>();
      var listVba = new List<string>();
      var listHtml = new List<string>();
      var listCss = new List<string>();
      var listSql = new List<string>();
      var listJscript = new List<string>();
      var listPython = new List<string>();
      var listRuby = new List<string>();
      var listJava = new List<string>();
      var listDelphi = new List<string>();
      var listVbs = new List<string>();
      var listCpp = new List<string>();
      var listPowerShell = new List<string>();
      bool codeEnCours = false;
      string codeTemp = string.Empty;
      Langage langageEnCours = Langage.Nothing;
      foreach (string ligneCode in contenuFichier)
      {
        if (codeEnCours && ligneCode != "[end]")
        {
          codeTemp += ligneCode + "\r\n";
        }

        if (ligneCode == "[end]")
        {
          switch (langageEnCours)
          {
            case Langage.Csharp:
              listCSharp.Add(codeTemp);
              break;
            case Langage.Powershell:
              listPowerShell.Add(codeTemp);
              break;
            case Langage.Vba:
              listVba.Add(codeTemp);
              break;
            case Langage.Vbnet:
              listVbNet.Add(codeTemp);
              break;
            case Langage.Php:
              listPhp.Add(codeTemp);
              break;
            case Langage.Html:
              listHtml.Add(codeTemp);
              break;
            case Langage.Css:
              listCss.Add(codeTemp);
              break;
            case Langage.Sql:
              listSql.Add(codeTemp);
              break;
            case Langage.Js:
              listJscript.Add(codeTemp);
              break;
            case Langage.Python:
              listPython.Add(codeTemp);
              break;
            case Langage.Ruby:
              listRuby.Add(codeTemp);
              break;
            case Langage.Java:
              listJava.Add(codeTemp);
              break;
            case Langage.Delphi:
              listDelphi.Add(codeTemp);
              break;
            case Langage.Cpp:
              listCpp.Add(codeTemp);
              break;
            case Langage.Vbs:
              listVbs.Add(codeTemp);
              break;
          }

          codeEnCours = false;
          codeTemp = string.Empty;
          langageEnCours = Langage.Nothing;
        }

        if (ligneCode == "[start]")
        {
          codeEnCours = true;
        }

        Langage langueTmp = WhatLanguageFor(ligneCode);
        if (langueTmp != Langage.Nothing)
        {
          codeTemp = string.Empty;
          langageEnCours = langueTmp;
        }
      }

      // Recherche du mot clef dans les listes.
      // On a des mots clefs dans listLangageCoches
      FillListBoxResultIfNotEmpty(listCSharp, listLangageCoches.Contains("checkBox" + Language.CSharp), Language.CSharp);
      FillListBoxResultIfNotEmpty(listVbNet, listLangageCoches.Contains("checkBox" + Langage.Vbnet.ToString().ToUpper()), Language.VB);
      FillListBoxResultIfNotEmpty(listVba, listLangageCoches.Contains("checkBox" + Langage.Vba.ToString().ToUpper()), Language.VBA);
      FillListBoxResultIfNotEmpty(listPowerShell, listLangageCoches.Contains("checkBox" + Langage.Powershell), Language.Powershell);
      FillListBoxResultIfNotEmpty(listPhp, listLangageCoches.Contains("checkBox" + Langage.Php), Language.PHP);
      FillListBoxResultIfNotEmpty(listHtml, listLangageCoches.Contains("checkBox" + Langage.Html.ToString().ToUpper()), Language.HTML);
      FillListBoxResultIfNotEmpty(listCss, listLangageCoches.Contains("checkBox" + Langage.Css.ToString().ToUpper()), Language.CSS);
      FillListBoxResultIfNotEmpty(listJscript, listLangageCoches.Contains("checkBox" + Langage.Js.ToString().ToUpper()), Language.JS);
      FillListBoxResultIfNotEmpty(listSql, listLangageCoches.Contains("checkBox" + Langage.Sql.ToString().ToUpper()), Language.SQL);
      FillListBoxResultIfNotEmpty(listPython, listLangageCoches.Contains("checkBox" + Langage.Python), Language.Python);
      FillListBoxResultIfNotEmpty(listRuby, listLangageCoches.Contains("checkBox" + Langage.Ruby), Language.Ruby);
      FillListBoxResultIfNotEmpty(listCpp, listLangageCoches.Contains("checkBox" + Langage.Cpp), Language.Cpp);
      FillListBoxResultIfNotEmpty(listJava, listLangageCoches.Contains("checkBox" + Langage.Java), Language.Java);
      FillListBoxResultIfNotEmpty(listDelphi, listLangageCoches.Contains("checkBox" + Langage.Delphi), Language.Delphi);
      FillListBoxResultIfNotEmpty(listVbs, listLangageCoches.Contains("checkBox" + Langage.Vbs.ToString().ToUpper()), Language.Vbs);
      
      if (listBoxResult.Items.Count != 0)
      {
        listBoxResult.SetSelected(0, true);
      }
      
      labelResultat.Text = string.Format("Résultat: " + listBoxResult.Items.Count);
      toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
      timer1.Enabled = false;
    }

    /// <summary>
    /// Fill listBoxResult if it is not empty.
    /// </summary>
    /// <param name="listLangage">
    /// The list langage.
    /// </param>
    /// <param name="contenuOk">
    /// The contenu ok.
    /// </param>
    /// <param name="theLanguage">
    /// The the language.
    /// </param>
    private void FillListBoxResultIfNotEmpty(IEnumerable<string> listLangage, bool contenuOk,  Language theLanguage)
    {
      if (((List<string>)listLangage).Count != 0 && contenuOk)
      {
        FillListBoxResultWith(listLangage, theLanguage);
      }
    }

    /// <summary>
    /// Fill listBoxResult with list of code with a specific language.
    /// </summary>
    /// <param name="listDeCode">
    /// The list de code.
    /// </param>
    /// <param name="langue">
    /// The langue.
    /// </param>
    private void FillListBoxResultWith(IEnumerable<string> listDeCode, Language langue)
    {
      foreach (string ligne in listDeCode)
      {
        listBoxResult.Items.Add(ligne);
      }

      fctb.Language = langue;
    }

    /// <summary>
    /// What is the language for this line of code.
    /// </summary>
    /// <param name="ligneCode">
    /// The ligne code.
    /// </param>
    /// <returns>
    /// Returns the language for this line of code.
    /// </returns>
    private Langage WhatLanguageFor(string ligneCode)
    {
      if (ligneCode == "[C#]" || ligneCode.ToUpper() == "[CSHARP]")
      {
        return Langage.Csharp;
      }

      if (ligneCode.ToUpper() == "[VBA]")
      {
        return Langage.Vba;
      }

      if (ligneCode.ToUpper() == "[VBNET]")
      {
        return Langage.Vbnet;
      }

      if (ligneCode.ToUpper() == "[PHP]")
      {
        return Langage.Php;
      }

      if (ligneCode.ToUpper() == "[HTML]")
      {
        return Langage.Html;
      }

      if (ligneCode.ToUpper() == "[CSS]")
      {
        return Langage.Css;
      }

      if (ligneCode.ToUpper() == "[SQL]")
      {
        return Langage.Sql;
      }

      if (ligneCode.ToUpper() == "[JS]")
      {
        return Langage.Js;
      }

      if (ligneCode.ToUpper() == "[PYTHON]")
      {
        return Langage.Python;
      }

      if (ligneCode.ToUpper() == "[RUBY]")
      {
        return Langage.Ruby;
      }

      if (ligneCode.ToUpper() == "[JAVA]")
      {
        return Langage.Java;
      }

      if (ligneCode.ToUpper() == "[DELPHI]")
      {
        return Langage.Delphi;
      }

      if (ligneCode.ToUpper() == "[VBS]")
      {
       return Langage.Vbs;
      }

      if (ligneCode.ToUpper() == "[CPP]")
      {
        return Langage.Cpp;
      }

      if (ligneCode.ToUpper() == "[POWERSHELL]")
      {
        return Langage.Powershell;
      }

      return Langage.Nothing;
    }

    /// <summary>
    /// At startup of the main form.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The event arguments.
    /// </param>
    private void FormMainLoad(object sender, EventArgs e)
    {
      // MinimumSize = new Size(990, 400);
      checkBoxCSharp.Checked = true;
      checkBoxCaseSensitive.Checked = false;

      timer1.Enabled = false;
      toolStripProgressBar1.ProgressBar.Minimum = 1;
      toolStripProgressBar1.ProgressBar.Maximum = 100;
      timer1.Interval = 50;

      // menuStrip2.Enabled = false;

      // comboBoxLangage.Items.Add("C#");
      // comboBoxLangage.Items.Add("VB.NET");
      // comboBoxLangage.Items.Add("PHP");
      // comboBoxLangage.Items.Add("VBA");
      // comboBoxLangage.Items.Add("HTML");
      // comboBoxLangage.Items.Add("CSS");
      // comboBoxLangage.Items.Add("SQL");
      // comboBoxLangage.Items.Add("JS");
      // comboBoxLangage.Items.Add("Python");
      // comboBoxLangage.Items.Add("Ruby");
      // comboBoxLangage.Items.Add("Java");
      // comboBoxLangage.Items.Add("Delphi");
      // comboBoxLangage.Items.Add("VBS");
      // comboBoxLangage.Items.Add("C++");
      // comboBoxLangage.Items.Add("PowerShell");

      // better code
      foreach (var langage in Enum.GetNames(typeof(Langage)).Where(langage => langage != "Nothing"))
      {
        comboBoxLangage.Items.Add(langage);
      }

      dicoLangue.Add("Csharp", Language.CSharp);
      dicoLangue.Add("Vbnet", Language.VB);
      dicoLangue.Add("Php", Language.PHP);
      dicoLangue.Add("Vba", Language.VBA);
      dicoLangue.Add("Html", Language.HTML);
      dicoLangue.Add("Css", Language.CSS);
      dicoLangue.Add("Sql", Language.SQL);
      dicoLangue.Add("Js", Language.JS);
      dicoLangue.Add("Python", Language.Python);
      dicoLangue.Add("Ruby", Language.Ruby);
      dicoLangue.Add("Java", Language.Java);
      dicoLangue.Add("Delphi", Language.Delphi);
      dicoLangue.Add("vbs", Language.Vbs);
      dicoLangue.Add("Cpp", Language.Cpp);
      dicoLangue.Add("Powershell", Language.Powershell);
      comboBoxLangage.SelectedIndex = 0;
    }

    /// <summary>
    /// Méthode FctbTextChanged.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void FctbTextChanged(object sender, TextChangedEventArgs e)
    {
      switch (Lang)
      {
        case "CSharp":
          // For sample, we will highlight the syntax of C# manually, although could use built-in highlighter
          CSharpSyntaxHighlight(e); // custom highlighting
          break;
      }
    }

    /// <summary>
    /// méthode CSharpSyntaxHighlight.
    /// </summary>
    /// <param name="e">
    /// The e.
    /// </param>
    private void CSharpSyntaxHighlight(TextChangedEventArgs e)
    {
      fctb.LeftBracket = '(';
      fctb.RightBracket = ')';
      fctb.LeftBracket2 = '\x0';
      fctb.RightBracket2 = '\x0';

      // clear style of changed range
      e.ChangedRange.ClearStyle(blueStyle, boldStyle, grayStyle, magentaStyle, greenStyle, brownStyle);

      // string highlighting
      e.ChangedRange.SetStyle(brownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");

      // comment highlighting
      e.ChangedRange.SetStyle(greenStyle, @"//.*$", RegexOptions.Multiline);
      e.ChangedRange.SetStyle(greenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
      e.ChangedRange.SetStyle(greenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);

      // number highlighting
      e.ChangedRange.SetStyle(magentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");

      // attribute highlighting
      e.ChangedRange.SetStyle(grayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);

      // class name highlighting
      e.ChangedRange.SetStyle(boldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");

      // keyword highlighting
      e.ChangedRange.SetStyle(blueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b");

      // clear folding markers
      e.ChangedRange.ClearFoldingMarkers();

      // set folding markers
      // allow to collapse brackets block
      e.ChangedRange.SetFoldingMarkers("{", "}");

      // allow to collapse #region blocks
      e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");

      // allow to collapse comment block
      e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");
    }

    /// <summary>
    /// Ajouter du code.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ButtonAddCodeClick(object sender, EventArgs e)
    {
      if (fctb.Text == string.Empty)
      {
        MessageBox.Show(string.Format("Vous devez avoir du code à enregistrer."));
      }
      else
      {
        sourceHasChanged = true;
        if (!FileExists(FichierCodeRepo))
        {
          CreateNewFile(FichierCodeRepo);
        }

        using (var sw = new StreamWriter(FichierCodeRepo, true))
        {
          sw.WriteLine();
          sw.WriteLine("[" + comboBoxLangage.SelectedItem + "]");
          sw.WriteLine("[" + "start" + "]");
          sw.Write(fctb.Text);
          sw.WriteLine(string.Empty);
          sw.WriteLine("[" + "end" + "]");
          sw.Flush();
        }

        MessageBox.Show(string.Format("Le code a été ajouté."), string.Format("Code ajouté"), MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    /// <summary>
    /// Determine if source code file exists.
    /// </summary>
    /// <param name="file">
    /// The file.
    /// </param>
    /// <returns>
    /// return a boolean if source code file exists.
    /// </returns>
    private bool FileExists(string file)
    {
      return File.Exists(file);
    }

    /// <summary>
    /// Create a new source file if it doesn't exist.
    /// </summary>
    /// <param name="file">
    /// The file.
    /// </param>
    private void CreateNewFile(string file)
    {
      if (!File.Exists(file))
      {
        var sw = new StreamWriter(FichierCodeRepo);
        sw.WriteLine(DerniereVersion);
        sw.WriteLine(string.Empty);
        sw.Flush();
        sw.Close();
      }
    }

    /// <summary>
    /// Efface le texte.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ButtonClearTextClick(object sender, EventArgs e)
    {
      fctb.Text = string.Empty;
    }

    /// <summary>
    /// coller le press papier.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void CollerToolStripMenuItemClick(object sender, EventArgs e)
    {
      if (fctb.Selection != null)
      {
        fctb.Paste();
      }
    }

    /// <summary>
    /// copier le texte.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void CopierToolStripMenuItemClick(object sender, EventArgs e)
    {
      if (fctb.Selection != null)
      {
        fctb.Copy();
      }
    }

    /// <summary>
    /// Sélectionne tout le texte.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void SelectionnertoutToolStripMenuItemClick(object sender, EventArgs e)
    {
      fctb.SelectAll();
    }

    /// <summary>
    /// Display option form.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void OptionsToolStripMenuItemClick(object sender, EventArgs e)
    {
      // ouverture de la form Options
      var fm = new FormOutilsOptions();
      fm.ShowDialog();
    }

    /// <summary>
    /// display a selected code.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ListBoxResultSelectedIndexChanged(object sender, EventArgs e)
    {
      fctb.Clear();
      fctb.Language = NumberOfCheckBoxChecked() == 0 ? Language.CSharp : PremiereCheckBoxChecked();
      if (NumberOfCheckBoxChecked() == 1)
      {
        comboBoxLangage.SelectedItem = PremiereCheckBoxChecked().ToString();
        comboBoxLangage.SelectedItem = CamelCase(RetournePremiereCheckBoxchecked().Name.Substring(8, RetournePremiereCheckBoxchecked().Name.Length - 8));
      }
      else
      {
        // comboBoxLangage.SelectedItem(PremiereCheckBoxChecked().ToString()); pas completement exacte.
        // TODO: chercher un moyen pour afficher/indexer la langage
      }

      fctb.AcceptsReturn = true;
      fctb.AutoScroll = true;
      fctb.BorderStyle = BorderStyle.Fixed3D;
      fctb.LeftPadding = 3;
      fctb.Selection.Start = Place.Empty;
      fctb.DoCaretVisible();
      fctb.IsChanged = false;
      fctb.ClearUndo();
      fctb.Text = listBoxResult.SelectedItem.ToString();
    }

    /// <summary>
    /// First language checkbox or Language.CSharp by default.
    /// </summary>
    /// <returns>
    /// Returns first language checkbox or Language.CSharp by default.
    /// </returns>
    private Language PremiereCheckBoxChecked()
    {
      // 8 caracters due to checkBox's name
      if (dicoLangue.ContainsKey(CamelCase(RetournePremiereCheckBoxchecked().Name.Substring(8, RetournePremiereCheckBoxchecked().Name.Length - 8))))
      {
        return dicoLangue[CamelCase(RetournePremiereCheckBoxchecked().Name.Substring(8, RetournePremiereCheckBoxchecked().Name.Length - 8))];
      }

      return Language.CSharp;
    }

    /// <summary>
    /// CamelCase the string passed as argument.
    /// </summary>
    /// <param name="theString">
    /// The string to be Camelcased.
    /// </param>
    /// <returns>
    /// Sends a string CamelCased.
    /// </returns>
    private string CamelCase(string theString)
    {
      if (string.IsNullOrEmpty(theString))
      {
        return string.Empty;
      }

      if (theString.Length == 1)
      {
        return theString.ToUpper();
      }

      return theString.Substring(0, 1).ToUpper() + theString.Substring(1, theString.Length - 1).ToLower();
    }

    /// <summary>
    /// When user changes language selection.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ComboBoxLangageSelectedIndexChanged(object sender, EventArgs e)
    {
      switch (comboBoxLangage.SelectedItem.ToString())
      {
        case "CSharp":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.CSharp);
          break;
        case "VbNet":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.VB);
          break;
        case "Vba":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.VBA);
          break;
        case "Php":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.PHP);
          break;
        case "HTML":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.HTML);
          break;
        case "Css":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.CSS);
          break;
        case "SQL":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.SQL);
          break;
        case "Js":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.JS);
          break;
        case "Python":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.Python);
          break;
        case "Ruby":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.Ruby);
          break;
        case "Java":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.Java);
          break;
        case "Delphi":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.Delphi);
          break;
        case "Vbs":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.Vbs);
          break;
        case "Cpp":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.Cpp);
          break;
        case "PowerShell":
          ChangeLangage(comboBoxLangage.SelectedItem.ToString(), Language.Powershell);
          break;
      }
    }

    /// <summary>
    /// Change language
    /// </summary>
    /// <param name="selectedLangage">
    /// The selected langage.
    /// </param>
    /// <param name="langage">
    /// The langage.
    /// </param>
    private void ChangeLangage(string selectedLangage, Language langage)
    {
      fctb.Language = langage;
      fctb.Range.ClearStyle(StyleIndex.All);
      fctb.OnSyntaxHighlight(new TextChangedEventArgs(fctb.Range));
    }

    /// <summary>
    /// Number of language checkboxes checked.
    /// </summary>
    /// <returns>
    /// Returns number of language checkboxes checked.
    /// </returns>
    private int NumberOfCheckBoxChecked()
    {
      return groupBoxLangage.Controls.Cast<Control>().Count(control => control is CheckBox && ((CheckBox)control).Checked);
    }

    /// <summary>
    /// Function that returns first language checkbox checked.
    /// </summary>
    /// <returns>
    /// Returns first language checkbox checked.
    /// </returns>
    private Control RetournePremiereCheckBoxchecked()
    {
      return groupBoxLangage.Controls.Cast<Control>().First(control => control is CheckBox && ((CheckBox)control).Checked);
    }

    /// <summary>
    /// Check all language checkboxes.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void CheckBoxCheckAllLanguagesCheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxCheckAllLanguages.Checked)
      {
        foreach (Control controle in groupBoxLangage.Controls)
        {
          if (controle is CheckBox)
          {
            ((CheckBox)controle).Checked = true;
          }
        }

        checkBoxCheckNoLanguage.Checked = false;
      }
    }

    /// <summary>
    /// Uncheck all language checkboxes.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void CheckBoxCheckNoLanguageCheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxCheckNoLanguage.Checked)
      {
        foreach (Control controle in groupBoxLangage.Controls)
        {
          if (controle is CheckBox)
          {
            ((CheckBox)controle).Checked = false;
          } 
        }

        checkBoxCheckAllLanguages.Checked = false;
      }
    }

    /// <summary>
    /// Display context menu.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void FctbClick(object sender, MouseEventArgs e)
    {
      // if right click then we display context Menu
      var c = sender as Control;
      if (e.Button == MouseButtons.Right)
      {
        if (c != null)
        {
          contextMenuStripFCTB.Show(c, e.Location);
        }
      }
    }

    /// <summary>
    /// Copy text.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ToolStripMenuItemFctbCopyClick(object sender, EventArgs e)
    {
      CopierToolStripMenuItemClick(sender, e);
    }

    /// <summary>
    /// Cut text
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ToolStripMenuItemFctbCutClick(object sender, EventArgs e)
    {
      CouperToolStripMenuItemClick(sender, e);
    }

    /// <summary>
    /// Paste text.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ToolStripMenuItemFctbPasteClick(object sender, EventArgs e)
    {
      CollerToolStripMenuItemClick(sender, e);
    }

    /// <summary>
    /// Select all text.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ToolStripMenuItemFctbSelectAllClick(object sender, EventArgs e)
    {
      SelectionnertoutToolStripMenuItemClick(sender, e);
    }

    /// <summary>
    /// cut text selected.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void CouperToolStripMenuItemClick(object sender, EventArgs e)
    {
      if (fctb.Selection != null)
      {
        fctb.Cut();
      }
    }

    /// <summary>
    /// clear source text box.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void ToolStripMenuItemFctbClearAllClick(object sender, EventArgs e)
    {
      fctb.Text = string.Empty;
    }

    /// <summary>
    /// Personnaliser, get email address and if valid then send coderepository.txt via mail.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void PersonnaliserToolStripMenuItemClick(object sender, EventArgs e)
    {
      // get email address and if valid then send coderepository.txt via mail
    }

    /// <summary>
    /// Aller Au Repertoire Source.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void AllerAuRepertoireSourceToolStripMenuItemClick(object sender, EventArgs e)
    {
      // Open Explorer.exe with source file path
      string appPath = Path.GetDirectoryName(Application.ExecutablePath);
      Process.Start("Explorer.exe", appPath);
    }

    /// <summary>
    /// About the application.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void AproposdeToolStripMenuItemClick(object sender, EventArgs e)
    {
      AboutBoxcodeRepository ab = new AboutBoxcodeRepository();
      ab.ShowDialog();
    }

    /// <summary>
    /// At every tick of the timer.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void Timer1Tick(object sender, EventArgs e)
    {
      if (timer1.Enabled)
      {
        ProgressBarMove();
      }
    }

    /// <summary>
    /// Execute ProgressBar move.
    /// </summary>
    private void ProgressBarMove()
    {
      if (toolStripProgressBar1.ProgressBar.Value == toolStripProgressBar1.ProgressBar.Maximum)
      {
        progressBarGoingForward = false;
      }

      if (toolStripProgressBar1.ProgressBar.Value == toolStripProgressBar1.ProgressBar.Minimum)
      {
        progressBarGoingForward = true;
      }

      if (progressBarGoingForward)
      {
        toolStripProgressBar1.ProgressBar.Value++;
      }
      else
      {
        toolStripProgressBar1.ProgressBar.Value--;
      }

      toolStripProgressBar1.ProgressBar.Refresh();
    }

    private void fctb_Load(object sender, EventArgs e)
    {

    }
  }
}