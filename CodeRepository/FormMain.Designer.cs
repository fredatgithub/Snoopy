using FastColoredTextBoxNS;

namespace CodeRepository
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allerAuRepertoireSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.aproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBoxChercher = new System.Windows.Forms.TextBox();
      this.labelRechercher = new System.Windows.Forms.Label();
      this.buttonChercher = new System.Windows.Forms.Button();
      this.groupBoxLangage = new System.Windows.Forms.GroupBox();
      this.checkBoxJava = new System.Windows.Forms.CheckBox();
      this.checkBoxCpp = new System.Windows.Forms.CheckBox();
      this.checkBoxVBS = new System.Windows.Forms.CheckBox();
      this.checkBoxDelphi = new System.Windows.Forms.CheckBox();
      this.checkBoxPowershell = new System.Windows.Forms.CheckBox();
      this.checkBoxRuby = new System.Windows.Forms.CheckBox();
      this.checkBoxPython = new System.Windows.Forms.CheckBox();
      this.checkBoxSQL = new System.Windows.Forms.CheckBox();
      this.checkBoxJS = new System.Windows.Forms.CheckBox();
      this.checkBoxCSS = new System.Windows.Forms.CheckBox();
      this.checkBoxHTML = new System.Windows.Forms.CheckBox();
      this.checkBoxVBA = new System.Windows.Forms.CheckBox();
      this.checkBoxVBNET = new System.Windows.Forms.CheckBox();
      this.checkBoxPhp = new System.Windows.Forms.CheckBox();
      this.checkBoxCSharp = new System.Windows.Forms.CheckBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelSourceFileVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
      this.buttonAddCode = new System.Windows.Forms.Button();
      this.comboBoxLangage = new System.Windows.Forms.ComboBox();
      this.buttonClearText = new System.Windows.Forms.Button();
      this.labelResultat = new System.Windows.Forms.Label();
      this.listBoxResult = new System.Windows.Forms.ListBox();
      this.labelExemple = new System.Windows.Forms.Label();
      this.checkBoxCaseSensitive = new System.Windows.Forms.CheckBox();
      this.checkBoxCheckAllLanguages = new System.Windows.Forms.CheckBox();
      this.checkBoxCheckNoLanguage = new System.Windows.Forms.CheckBox();
      this.contextMenuStripFCTB = new System.Windows.Forms.ContextMenuStrip();
      this.toolStripMenuItemFCTBCut = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemFCTBCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemFCTBPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparatorFCTBSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItemFCTBSelectAll = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparatorFCTBSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItemFCTBClearAll = new System.Windows.Forms.ToolStripMenuItem();
      this.timer1 = new System.Windows.Forms.Timer();
      this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
      this.menuStrip1.SuspendLayout();
      this.groupBoxLangage.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.contextMenuStripFCTB.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fctb)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1627, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem,
            this.aperçuavantimpressionToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(238, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItemClick);
      // 
      // editionToolStripMenuItem
      // 
      this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator3,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator4,
            this.sélectionnertoutToolStripMenuItem});
      this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(240, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
      this.couperToolStripMenuItem.Text = "&Couper";
      this.couperToolStripMenuItem.Click += new System.EventHandler(this.CouperToolStripMenuItemClick);
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
      this.copierToolStripMenuItem.Text = "Co&pier";
      this.copierToolStripMenuItem.Click += new System.EventHandler(this.CopierToolStripMenuItemClick);
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
      this.collerToolStripMenuItem.Text = "Co&ller";
      this.collerToolStripMenuItem.Click += new System.EventHandler(this.CollerToolStripMenuItemClick);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(240, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      this.sélectionnertoutToolStripMenuItem.Click += new System.EventHandler(this.SelectionnertoutToolStripMenuItemClick);
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.allerAuRepertoireSourceToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
      this.personnaliserToolStripMenuItem.Text = "&Backup";
      this.personnaliserToolStripMenuItem.Click += new System.EventHandler(this.PersonnaliserToolStripMenuItemClick);
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
      this.optionsToolStripMenuItem.Text = "&Options";
      this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItemClick);
      // 
      // allerAuRepertoireSourceToolStripMenuItem
      // 
      this.allerAuRepertoireSourceToolStripMenuItem.Name = "allerAuRepertoireSourceToolStripMenuItem";
      this.allerAuRepertoireSourceToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
      this.allerAuRepertoireSourceToolStripMenuItem.Text = "Aller au Repertoire source";
      this.allerAuRepertoireSourceToolStripMenuItem.Click += new System.EventHandler(this.AllerAuRepertoireSourceToolStripMenuItemClick);
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.toolStripSeparator5,
            this.aproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(166, 6);
      // 
      // aproposdeToolStripMenuItem
      // 
      this.aproposdeToolStripMenuItem.Name = "aproposdeToolStripMenuItem";
      this.aproposdeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
      this.aproposdeToolStripMenuItem.Text = "À &propos de...";
      this.aproposdeToolStripMenuItem.Click += new System.EventHandler(this.AproposdeToolStripMenuItemClick);
      // 
      // textBoxChercher
      // 
      this.textBoxChercher.AcceptsReturn = true;
      this.textBoxChercher.AcceptsTab = true;
      this.textBoxChercher.AllowDrop = true;
      this.textBoxChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxChercher.Location = new System.Drawing.Point(96, 31);
      this.textBoxChercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBoxChercher.Name = "textBoxChercher";
      this.textBoxChercher.Size = new System.Drawing.Size(480, 23);
      this.textBoxChercher.TabIndex = 1;
      this.textBoxChercher.Text = "a";
      // 
      // labelRechercher
      // 
      this.labelRechercher.AutoSize = true;
      this.labelRechercher.Location = new System.Drawing.Point(17, 34);
      this.labelRechercher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelRechercher.Name = "labelRechercher";
      this.labelRechercher.Size = new System.Drawing.Size(70, 17);
      this.labelRechercher.TabIndex = 2;
      this.labelRechercher.Text = "Chercher:";
      // 
      // buttonChercher
      // 
      this.buttonChercher.Location = new System.Drawing.Point(603, 31);
      this.buttonChercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonChercher.Name = "buttonChercher";
      this.buttonChercher.Size = new System.Drawing.Size(100, 28);
      this.buttonChercher.TabIndex = 3;
      this.buttonChercher.Text = "Chercher";
      this.buttonChercher.UseVisualStyleBackColor = true;
      this.buttonChercher.Click += new System.EventHandler(this.ButtonChercherClick);
      // 
      // groupBoxLangage
      // 
      this.groupBoxLangage.Controls.Add(this.checkBoxJava);
      this.groupBoxLangage.Controls.Add(this.checkBoxCpp);
      this.groupBoxLangage.Controls.Add(this.checkBoxVBS);
      this.groupBoxLangage.Controls.Add(this.checkBoxDelphi);
      this.groupBoxLangage.Controls.Add(this.checkBoxPowershell);
      this.groupBoxLangage.Controls.Add(this.checkBoxRuby);
      this.groupBoxLangage.Controls.Add(this.checkBoxPython);
      this.groupBoxLangage.Controls.Add(this.checkBoxSQL);
      this.groupBoxLangage.Controls.Add(this.checkBoxJS);
      this.groupBoxLangage.Controls.Add(this.checkBoxCSS);
      this.groupBoxLangage.Controls.Add(this.checkBoxHTML);
      this.groupBoxLangage.Controls.Add(this.checkBoxVBA);
      this.groupBoxLangage.Controls.Add(this.checkBoxVBNET);
      this.groupBoxLangage.Controls.Add(this.checkBoxPhp);
      this.groupBoxLangage.Controls.Add(this.checkBoxCSharp);
      this.groupBoxLangage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxLangage.Location = new System.Drawing.Point(21, 127);
      this.groupBoxLangage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBoxLangage.Name = "groupBoxLangage";
      this.groupBoxLangage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBoxLangage.Size = new System.Drawing.Size(556, 155);
      this.groupBoxLangage.TabIndex = 4;
      this.groupBoxLangage.TabStop = false;
      this.groupBoxLangage.Text = "Langages :";
      // 
      // checkBoxJava
      // 
      this.checkBoxJava.AutoSize = true;
      this.checkBoxJava.Location = new System.Drawing.Point(324, 25);
      this.checkBoxJava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxJava.Name = "checkBoxJava";
      this.checkBoxJava.Size = new System.Drawing.Size(64, 21);
      this.checkBoxJava.TabIndex = 16;
      this.checkBoxJava.Text = "Java";
      this.checkBoxJava.UseVisualStyleBackColor = true;
      // 
      // checkBoxCpp
      // 
      this.checkBoxCpp.AutoSize = true;
      this.checkBoxCpp.Location = new System.Drawing.Point(205, 110);
      this.checkBoxCpp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxCpp.Name = "checkBoxCpp";
      this.checkBoxCpp.Size = new System.Drawing.Size(58, 21);
      this.checkBoxCpp.TabIndex = 15;
      this.checkBoxCpp.Text = "C++";
      this.checkBoxCpp.UseVisualStyleBackColor = true;
      // 
      // checkBoxVBS
      // 
      this.checkBoxVBS.AutoSize = true;
      this.checkBoxVBS.Location = new System.Drawing.Point(324, 81);
      this.checkBoxVBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxVBS.Name = "checkBoxVBS";
      this.checkBoxVBS.Size = new System.Drawing.Size(60, 21);
      this.checkBoxVBS.TabIndex = 14;
      this.checkBoxVBS.Text = "VBS";
      this.checkBoxVBS.UseVisualStyleBackColor = true;
      // 
      // checkBoxDelphi
      // 
      this.checkBoxDelphi.AutoSize = true;
      this.checkBoxDelphi.Location = new System.Drawing.Point(324, 53);
      this.checkBoxDelphi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxDelphi.Name = "checkBoxDelphi";
      this.checkBoxDelphi.Size = new System.Drawing.Size(76, 21);
      this.checkBoxDelphi.TabIndex = 13;
      this.checkBoxDelphi.Text = "Delphi";
      this.checkBoxDelphi.UseVisualStyleBackColor = true;
      // 
      // checkBoxPowershell
      // 
      this.checkBoxPowershell.AutoSize = true;
      this.checkBoxPowershell.Location = new System.Drawing.Point(205, 80);
      this.checkBoxPowershell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxPowershell.Name = "checkBoxPowershell";
      this.checkBoxPowershell.Size = new System.Drawing.Size(110, 21);
      this.checkBoxPowershell.TabIndex = 12;
      this.checkBoxPowershell.Text = "PowerShell";
      this.checkBoxPowershell.UseVisualStyleBackColor = true;
      // 
      // checkBoxRuby
      // 
      this.checkBoxRuby.AutoSize = true;
      this.checkBoxRuby.Location = new System.Drawing.Point(208, 53);
      this.checkBoxRuby.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxRuby.Name = "checkBoxRuby";
      this.checkBoxRuby.Size = new System.Drawing.Size(67, 21);
      this.checkBoxRuby.TabIndex = 9;
      this.checkBoxRuby.Text = "Ruby";
      this.checkBoxRuby.UseVisualStyleBackColor = true;
      // 
      // checkBoxPython
      // 
      this.checkBoxPython.AutoSize = true;
      this.checkBoxPython.Location = new System.Drawing.Point(208, 25);
      this.checkBoxPython.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxPython.Name = "checkBoxPython";
      this.checkBoxPython.Size = new System.Drawing.Size(80, 21);
      this.checkBoxPython.TabIndex = 8;
      this.checkBoxPython.Text = "Python";
      this.checkBoxPython.UseVisualStyleBackColor = true;
      // 
      // checkBoxSQL
      // 
      this.checkBoxSQL.AutoSize = true;
      this.checkBoxSQL.Location = new System.Drawing.Point(121, 110);
      this.checkBoxSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxSQL.Name = "checkBoxSQL";
      this.checkBoxSQL.Size = new System.Drawing.Size(61, 21);
      this.checkBoxSQL.TabIndex = 7;
      this.checkBoxSQL.Text = "SQL";
      this.checkBoxSQL.UseVisualStyleBackColor = true;
      // 
      // checkBoxJS
      // 
      this.checkBoxJS.AutoSize = true;
      this.checkBoxJS.Location = new System.Drawing.Point(121, 81);
      this.checkBoxJS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxJS.Name = "checkBoxJS";
      this.checkBoxJS.Size = new System.Drawing.Size(48, 21);
      this.checkBoxJS.TabIndex = 6;
      this.checkBoxJS.Text = "JS";
      this.checkBoxJS.UseVisualStyleBackColor = true;
      // 
      // checkBoxCSS
      // 
      this.checkBoxCSS.AutoSize = true;
      this.checkBoxCSS.Location = new System.Drawing.Point(121, 53);
      this.checkBoxCSS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxCSS.Name = "checkBoxCSS";
      this.checkBoxCSS.Size = new System.Drawing.Size(60, 21);
      this.checkBoxCSS.TabIndex = 5;
      this.checkBoxCSS.Text = "CSS";
      this.checkBoxCSS.UseVisualStyleBackColor = true;
      // 
      // checkBoxHTML
      // 
      this.checkBoxHTML.AutoSize = true;
      this.checkBoxHTML.Location = new System.Drawing.Point(121, 25);
      this.checkBoxHTML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxHTML.Name = "checkBoxHTML";
      this.checkBoxHTML.Size = new System.Drawing.Size(72, 21);
      this.checkBoxHTML.TabIndex = 4;
      this.checkBoxHTML.Text = "HTML";
      this.checkBoxHTML.UseVisualStyleBackColor = true;
      // 
      // checkBoxVBA
      // 
      this.checkBoxVBA.AutoSize = true;
      this.checkBoxVBA.Location = new System.Drawing.Point(23, 110);
      this.checkBoxVBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxVBA.Name = "checkBoxVBA";
      this.checkBoxVBA.Size = new System.Drawing.Size(60, 21);
      this.checkBoxVBA.TabIndex = 3;
      this.checkBoxVBA.Text = "VBA";
      this.checkBoxVBA.UseVisualStyleBackColor = true;
      // 
      // checkBoxVBNET
      // 
      this.checkBoxVBNET.AutoSize = true;
      this.checkBoxVBNET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxVBNET.Location = new System.Drawing.Point(23, 81);
      this.checkBoxVBNET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxVBNET.Name = "checkBoxVBNET";
      this.checkBoxVBNET.Size = new System.Drawing.Size(86, 21);
      this.checkBoxVBNET.TabIndex = 2;
      this.checkBoxVBNET.Text = "VB.NET";
      this.checkBoxVBNET.UseVisualStyleBackColor = true;
      // 
      // checkBoxPhp
      // 
      this.checkBoxPhp.AutoSize = true;
      this.checkBoxPhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxPhp.Location = new System.Drawing.Point(23, 53);
      this.checkBoxPhp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxPhp.Name = "checkBoxPhp";
      this.checkBoxPhp.Size = new System.Drawing.Size(61, 21);
      this.checkBoxPhp.TabIndex = 1;
      this.checkBoxPhp.Text = "PHP";
      this.checkBoxPhp.UseVisualStyleBackColor = true;
      // 
      // checkBoxCSharp
      // 
      this.checkBoxCSharp.AutoSize = true;
      this.checkBoxCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxCSharp.Location = new System.Drawing.Point(23, 25);
      this.checkBoxCSharp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBoxCSharp.Name = "checkBoxCSharp";
      this.checkBoxCSharp.Size = new System.Drawing.Size(49, 21);
      this.checkBoxCSharp.TabIndex = 0;
      this.checkBoxCSharp.Text = "C#";
      this.checkBoxCSharp.UseVisualStyleBackColor = true;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSourceFileVersion,
            this.toolStripProgressBar1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 965);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
      this.statusStrip1.Size = new System.Drawing.Size(1627, 26);
      this.statusStrip1.TabIndex = 5;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabelSourceFileVersion
      // 
      this.toolStripStatusLabelSourceFileVersion.Name = "toolStripStatusLabelSourceFileVersion";
      this.toolStripStatusLabelSourceFileVersion.Size = new System.Drawing.Size(160, 21);
      this.toolStripStatusLabelSourceFileVersion.Text = "Source File Version: 1.0";
      // 
      // toolStripProgressBar1
      // 
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 20);
      // 
      // buttonAddCode
      // 
      this.buttonAddCode.Location = new System.Drawing.Point(960, 31);
      this.buttonAddCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonAddCode.Name = "buttonAddCode";
      this.buttonAddCode.Size = new System.Drawing.Size(100, 28);
      this.buttonAddCode.TabIndex = 8;
      this.buttonAddCode.Text = "Ajouter";
      this.buttonAddCode.UseVisualStyleBackColor = true;
      this.buttonAddCode.Click += new System.EventHandler(this.ButtonAddCodeClick);
      // 
      // comboBoxLangage
      // 
      this.comboBoxLangage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.comboBoxLangage.FormattingEnabled = true;
      this.comboBoxLangage.Location = new System.Drawing.Point(839, 34);
      this.comboBoxLangage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.comboBoxLangage.Name = "comboBoxLangage";
      this.comboBoxLangage.Size = new System.Drawing.Size(100, 24);
      this.comboBoxLangage.TabIndex = 9;
      this.comboBoxLangage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLangageSelectedIndexChanged);
      // 
      // buttonClearText
      // 
      this.buttonClearText.Location = new System.Drawing.Point(731, 31);
      this.buttonClearText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonClearText.Name = "buttonClearText";
      this.buttonClearText.Size = new System.Drawing.Size(100, 28);
      this.buttonClearText.TabIndex = 10;
      this.buttonClearText.Text = "Effacer";
      this.buttonClearText.UseVisualStyleBackColor = true;
      this.buttonClearText.Click += new System.EventHandler(this.ButtonClearTextClick);
      // 
      // labelResultat
      // 
      this.labelResultat.AutoSize = true;
      this.labelResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelResultat.Location = new System.Drawing.Point(21, 290);
      this.labelResultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelResultat.Name = "labelResultat";
      this.labelResultat.Size = new System.Drawing.Size(73, 17);
      this.labelResultat.TabIndex = 11;
      this.labelResultat.Text = "Résultat:";
      // 
      // listBoxResult
      // 
      this.listBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.listBoxResult.FormattingEnabled = true;
      this.listBoxResult.HorizontalScrollbar = true;
      this.listBoxResult.ItemHeight = 16;
      this.listBoxResult.Location = new System.Drawing.Point(24, 315);
      this.listBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.listBoxResult.Name = "listBoxResult";
      this.listBoxResult.Size = new System.Drawing.Size(552, 628);
      this.listBoxResult.TabIndex = 12;
      this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.ListBoxResultSelectedIndexChanged);
      // 
      // labelExemple
      // 
      this.labelExemple.AutoSize = true;
      this.labelExemple.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelExemple.Location = new System.Drawing.Point(17, 64);
      this.labelExemple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelExemple.Name = "labelExemple";
      this.labelExemple.Size = new System.Drawing.Size(218, 17);
      this.labelExemple.TabIndex = 15;
      this.labelExemple.Text = "Exemple: using file stream reader";
      // 
      // checkBoxCaseSensitive
      // 
      this.checkBoxCaseSensitive.AutoSize = true;
      this.checkBoxCaseSensitive.Location = new System.Drawing.Point(20, 92);
      this.checkBoxCaseSensitive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxCaseSensitive.Name = "checkBoxCaseSensitive";
      this.checkBoxCaseSensitive.Size = new System.Drawing.Size(121, 21);
      this.checkBoxCaseSensitive.TabIndex = 17;
      this.checkBoxCaseSensitive.Text = "Case sensitive";
      this.checkBoxCaseSensitive.UseVisualStyleBackColor = true;
      // 
      // checkBoxCheckAllLanguages
      // 
      this.checkBoxCheckAllLanguages.AutoSize = true;
      this.checkBoxCheckAllLanguages.Location = new System.Drawing.Point(141, 92);
      this.checkBoxCheckAllLanguages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxCheckAllLanguages.Name = "checkBoxCheckAllLanguages";
      this.checkBoxCheckAllLanguages.Size = new System.Drawing.Size(146, 21);
      this.checkBoxCheckAllLanguages.TabIndex = 18;
      this.checkBoxCheckAllLanguages.Text = "Tous les langages";
      this.checkBoxCheckAllLanguages.UseVisualStyleBackColor = true;
      this.checkBoxCheckAllLanguages.CheckedChanged += new System.EventHandler(this.CheckBoxCheckAllLanguagesCheckedChanged);
      // 
      // checkBoxCheckNoLanguage
      // 
      this.checkBoxCheckNoLanguage.AutoSize = true;
      this.checkBoxCheckNoLanguage.Location = new System.Drawing.Point(345, 92);
      this.checkBoxCheckNoLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.checkBoxCheckNoLanguage.Name = "checkBoxCheckNoLanguage";
      this.checkBoxCheckNoLanguage.Size = new System.Drawing.Size(125, 21);
      this.checkBoxCheckNoLanguage.TabIndex = 19;
      this.checkBoxCheckNoLanguage.Text = "Aucun langage";
      this.checkBoxCheckNoLanguage.UseVisualStyleBackColor = true;
      this.checkBoxCheckNoLanguage.CheckedChanged += new System.EventHandler(this.CheckBoxCheckNoLanguageCheckedChanged);
      // 
      // contextMenuStripFCTB
      // 
      this.contextMenuStripFCTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFCTBCut,
            this.toolStripMenuItemFCTBCopy,
            this.toolStripMenuItemFCTBPaste,
            this.toolStripSeparatorFCTBSeparator,
            this.toolStripMenuItemFCTBSelectAll,
            this.toolStripSeparatorFCTBSeparator2,
            this.toolStripMenuItemFCTBClearAll});
      this.contextMenuStripFCTB.Name = "contextMenuStripFCTB";
      this.contextMenuStripFCTB.Size = new System.Drawing.Size(193, 136);
      // 
      // toolStripMenuItemFCTBCut
      // 
      this.toolStripMenuItemFCTBCut.Name = "toolStripMenuItemFCTBCut";
      this.toolStripMenuItemFCTBCut.Size = new System.Drawing.Size(192, 24);
      this.toolStripMenuItemFCTBCut.Text = "Couper";
      this.toolStripMenuItemFCTBCut.Click += new System.EventHandler(this.ToolStripMenuItemFctbCutClick);
      // 
      // toolStripMenuItemFCTBCopy
      // 
      this.toolStripMenuItemFCTBCopy.Name = "toolStripMenuItemFCTBCopy";
      this.toolStripMenuItemFCTBCopy.Size = new System.Drawing.Size(192, 24);
      this.toolStripMenuItemFCTBCopy.Text = "Copier";
      this.toolStripMenuItemFCTBCopy.Click += new System.EventHandler(this.ToolStripMenuItemFctbCopyClick);
      // 
      // toolStripMenuItemFCTBPaste
      // 
      this.toolStripMenuItemFCTBPaste.Name = "toolStripMenuItemFCTBPaste";
      this.toolStripMenuItemFCTBPaste.Size = new System.Drawing.Size(192, 24);
      this.toolStripMenuItemFCTBPaste.Text = "Coller";
      this.toolStripMenuItemFCTBPaste.Click += new System.EventHandler(this.ToolStripMenuItemFctbPasteClick);
      // 
      // toolStripSeparatorFCTBSeparator
      // 
      this.toolStripSeparatorFCTBSeparator.Name = "toolStripSeparatorFCTBSeparator";
      this.toolStripSeparatorFCTBSeparator.Size = new System.Drawing.Size(189, 6);
      // 
      // toolStripMenuItemFCTBSelectAll
      // 
      this.toolStripMenuItemFCTBSelectAll.Name = "toolStripMenuItemFCTBSelectAll";
      this.toolStripMenuItemFCTBSelectAll.Size = new System.Drawing.Size(192, 24);
      this.toolStripMenuItemFCTBSelectAll.Text = "Tout sélectionner";
      this.toolStripMenuItemFCTBSelectAll.Click += new System.EventHandler(this.ToolStripMenuItemFctbSelectAllClick);
      // 
      // toolStripSeparatorFCTBSeparator2
      // 
      this.toolStripSeparatorFCTBSeparator2.Name = "toolStripSeparatorFCTBSeparator2";
      this.toolStripSeparatorFCTBSeparator2.Size = new System.Drawing.Size(189, 6);
      // 
      // toolStripMenuItemFCTBClearAll
      // 
      this.toolStripMenuItemFCTBClearAll.Name = "toolStripMenuItemFCTBClearAll";
      this.toolStripMenuItemFCTBClearAll.Size = new System.Drawing.Size(192, 24);
      this.toolStripMenuItemFCTBClearAll.Text = "Effacer tout";
      this.toolStripMenuItemFCTBClearAll.Click += new System.EventHandler(this.ToolStripMenuItemFctbClearAllClick);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
      // 
      // fctb
      // 
      this.fctb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fctb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.fctb.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
      this.fctb.AutoScrollMinSize = new System.Drawing.Size(29, 19);
      this.fctb.BackBrush = null;
      this.fctb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.fctb.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
      this.fctb.CharHeight = 19;
      this.fctb.CharWidth = 9;
      this.fctb.CommentPrefix = "--";
      this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.fctb.DelayedEventsInterval = 200;
      this.fctb.DelayedTextChangedInterval = 500;
      this.fctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.fctb.Font = new System.Drawing.Font("Consolas", 9.75F);
      this.fctb.IsReplaceMode = false;
      this.fctb.Language = FastColoredTextBoxNS.Language.Lua;
      this.fctb.LeftBracket = '(';
      this.fctb.LeftBracket2 = '{';
      this.fctb.Location = new System.Drawing.Point(603, 92);
      this.fctb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.fctb.Name = "fctb";
      this.fctb.Paddings = new System.Windows.Forms.Padding(0);
      this.fctb.RightBracket = ')';
      this.fctb.RightBracket2 = '}';
      this.fctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.fctb.Size = new System.Drawing.Size(1007, 851);
      this.fctb.TabIndex = 6;
      this.fctb.Zoom = 100;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1627, 991);
      this.Controls.Add(this.fctb);
      this.Controls.Add(this.checkBoxCheckNoLanguage);
      this.Controls.Add(this.checkBoxCheckAllLanguages);
      this.Controls.Add(this.checkBoxCaseSensitive);
      this.Controls.Add(this.labelExemple);
      this.Controls.Add(this.listBoxResult);
      this.Controls.Add(this.labelResultat);
      this.Controls.Add(this.buttonClearText);
      this.Controls.Add(this.comboBoxLangage);
      this.Controls.Add(this.buttonAddCode);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.groupBoxLangage);
      this.Controls.Add(this.buttonChercher);
      this.Controls.Add(this.labelRechercher);
      this.Controls.Add(this.textBoxChercher);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MinimumSize = new System.Drawing.Size(1127, 482);
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Code Repository v1.0";
      this.Load += new System.EventHandler(this.FormMainLoad);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBoxLangage.ResumeLayout(false);
      this.groupBoxLangage.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.contextMenuStripFCTB.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.fctb)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aproposdeToolStripMenuItem;
    private System.Windows.Forms.TextBox textBoxChercher;
    private System.Windows.Forms.Label labelRechercher;
    private System.Windows.Forms.Button buttonChercher;
    private System.Windows.Forms.GroupBox groupBoxLangage;
    private System.Windows.Forms.CheckBox checkBoxSQL;
    private System.Windows.Forms.CheckBox checkBoxJS;
    private System.Windows.Forms.CheckBox checkBoxCSS;
    private System.Windows.Forms.CheckBox checkBoxHTML;
    private System.Windows.Forms.CheckBox checkBoxVBA;
    private System.Windows.Forms.CheckBox checkBoxVBNET;
    private System.Windows.Forms.CheckBox checkBoxPhp;
    private System.Windows.Forms.CheckBox checkBoxCSharp;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.Button buttonAddCode;
    private System.Windows.Forms.ComboBox comboBoxLangage;
    private System.Windows.Forms.Button buttonClearText;
    private System.Windows.Forms.CheckBox checkBoxJava;
    private System.Windows.Forms.CheckBox checkBoxCpp;
    private System.Windows.Forms.CheckBox checkBoxVBS;
    private System.Windows.Forms.CheckBox checkBoxDelphi;
    private System.Windows.Forms.CheckBox checkBoxPowershell;
    private System.Windows.Forms.CheckBox checkBoxRuby;
    private System.Windows.Forms.CheckBox checkBoxPython;
    private System.Windows.Forms.Label labelResultat;
    private System.Windows.Forms.ListBox listBoxResult;
    private System.Windows.Forms.Label labelExemple;
    private System.Windows.Forms.CheckBox checkBoxCaseSensitive;
    private System.Windows.Forms.CheckBox checkBoxCheckAllLanguages;
    private System.Windows.Forms.CheckBox checkBoxCheckNoLanguage;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripFCTB;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFCTBCopy;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFCTBCut;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFCTBPaste;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFCTBSeparator;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFCTBSelectAll;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFCTBSeparator2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFCTBClearAll;
    private System.Windows.Forms.ToolStripMenuItem allerAuRepertoireSourceToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSourceFileVersion;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    private System.Windows.Forms.Timer timer1;
    private FastColoredTextBox fctb;
  }
}