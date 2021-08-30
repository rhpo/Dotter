namespace Dotterl
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.downBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.gunaResizeControl1 = new Guna.UI.WinForms.GunaResizeControl();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.debug = new System.Windows.Forms.Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.caretAnimator = new System.Windows.Forms.Timer(this.components);
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.PrvwTimer = new System.Windows.Forms.Timer(this.components);
            this.titleBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BarButtons = new System.Windows.Forms.Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.downBar.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.BarButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scintilla1
            // 
            this.scintilla1.AdditionalSelAlpha = 158;
            this.scintilla1.AdditionalSelectionTyping = true;
            this.scintilla1.AnnotationVisible = ScintillaNET.Annotation.Boxed;
            this.scintilla1.AutoCDropRestOfWord = true;
            this.scintilla1.AutoCIgnoreCase = true;
            this.scintilla1.AutoCMaxHeight = 10;
            this.scintilla1.AutoCMaxWidth = 5;
            this.scintilla1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scintilla1.BufferedDraw = false;
            this.scintilla1.CaretForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.scintilla1.CaretLineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.scintilla1.CaretLineBackColorAlpha = 12;
            this.scintilla1.CaretLineVisible = true;
            this.scintilla1.CaretPeriod = 500;
            this.scintilla1.CaretStyle = ScintillaNET.CaretStyle.Block;
            this.scintilla1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.scintilla1.EdgeMode = ScintillaNET.EdgeMode.Line;
            this.scintilla1.ExtraAscent = 1;
            this.scintilla1.FontQuality = ScintillaNET.FontQuality.AntiAliased;
            this.scintilla1.IdleStyling = ScintillaNET.IdleStyling.AfterVisible;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Python;
            this.scintilla1.Location = new System.Drawing.Point(0, 26);
            this.scintilla1.Margin = new System.Windows.Forms.Padding(15, 4, 3, 3);
            this.scintilla1.Margins.Capacity = 15;
            this.scintilla1.Margins.Left = 15;
            this.scintilla1.Margins.Right = 5;
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Overtype = true;
            this.scintilla1.Size = new System.Drawing.Size(895, 388);
            this.scintilla1.TabIndex = 4;
            this.scintilla1.Technology = ScintillaNET.Technology.DirectWrite;
            this.scintilla1.Text = "main>\r\n\t#newline\r\n\t#center\r\n\tlabel>\r\n\t\ttext is Hello, World!\r\n\t\tcolor is black\r\n\t" +
    "<label\r\n\tbutton>\r\n\t\ttext is Welcome !\r\n\t<button\r\n\t#endcenter\r\n<main ";
            this.scintilla1.UseTabs = true;
            this.scintilla1.Painted += new System.EventHandler<System.EventArgs>(this.scintilla1_Painted);
            this.scintilla1.StyleNeeded += new System.EventHandler<ScintillaNET.StyleNeededEventArgs>(this.scintilla1_StyleNeeded);
            this.scintilla1.TextChanged += new System.EventHandler(this.scintilla1_TextChanged);
            this.scintilla1.Click += new System.EventHandler(this.scintilla1_Click);
            this.scintilla1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scintilla1_KeyDown);
            this.scintilla1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scintilla1_KeyPress);
            this.scintilla1.Validated += new System.EventHandler(this.scintilla1_Validated);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(383, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(115, 16);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "<span style=\"color:rgb(255, 128, 0);\">Editing Line:</span> <span style=\"color:whi" +
    "tesmoke;\">12</span>";
            // 
            // downBar
            // 
            this.downBar.BackColor = System.Drawing.Color.Transparent;
            this.downBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.downBar.BorderThickness = 2;
            this.downBar.Controls.Add(this.gunaResizeControl1);
            this.downBar.Controls.Add(this.label1);
            this.downBar.Controls.Add(this.gunaCheckBox1);
            this.downBar.Controls.Add(this.debug);
            this.downBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.downBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.downBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.downBar.Location = new System.Drawing.Point(0, 413);
            this.downBar.Name = "downBar";
            this.downBar.ShadowDecoration.Parent = this.downBar;
            this.downBar.Size = new System.Drawing.Size(907, 29);
            this.downBar.TabIndex = 5;
            this.downBar.Resize += new System.EventHandler(this.guna2GradientPanel1_Resize);
            // 
            // gunaResizeControl1
            // 
            this.gunaResizeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaResizeControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaResizeControl1.ForeColorDepth = 255;
            this.gunaResizeControl1.Location = new System.Drawing.Point(884, 6);
            this.gunaResizeControl1.Name = "gunaResizeControl1";
            this.gunaResizeControl1.Size = new System.Drawing.Size(23, 23);
            this.gunaResizeControl1.TabIndex = 7;
            this.gunaResizeControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(111, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auto-Tag Completion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Checked = true;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCheckBox1.ForeColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Location = new System.Drawing.Point(90, 5);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.gunaCheckBox1.TabIndex = 1;
            // 
            // debug
            // 
            this.debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.debug.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.debug.FlatAppearance.BorderSize = 2;
            this.debug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.debug.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.ForeColor = System.Drawing.Color.Black;
            this.debug.Location = new System.Drawing.Point(7, 4);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(71, 21);
            this.debug.TabIndex = 0;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = false;
            this.debug.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 0;
            this.guna2Elipse2.TargetControl = this.scintilla1;
            // 
            // caretAnimator
            // 
            this.caretAnimator.Interval = 70;
            this.caretAnimator.Tick += new System.EventHandler(this.caretAnimator_Tick);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "is",
        "not",
        "color",
        "text",
        "foreColor",
        "bgColor",
        "font",
        "main>",
        "<main",
        "input>",
        "<input",
        "button>",
        "<button",
        "clickedEvent",
        "csharpFunction",
        "jsFunction"};
            this.autocompleteMenu1.TargetControlWrapper = null;
            this.autocompleteMenu1.ToolTipDuration = 1000;
            // 
            // PrvwTimer
            // 
            this.PrvwTimer.Interval = 2000;
            this.PrvwTimer.Tick += new System.EventHandler(this.EnablePreview);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.titleBar.Controls.Add(this.BarButtons);
            this.titleBar.Controls.Add(this.guna2HtmlLabel1);
            this.titleBar.Controls.Add(this.Title);
            this.titleBar.Controls.Add(this.pictureBox1);
            this.titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.titleBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.titleBar.Location = new System.Drawing.Point(0, -1);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(907, 27);
            this.titleBar.TabIndex = 6;
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // BarButtons
            // 
            this.BarButtons.BackColor = System.Drawing.Color.Transparent;
            this.BarButtons.Controls.Add(this.guna2Button5);
            this.BarButtons.Controls.Add(this.guna2Button6);
            this.BarButtons.Controls.Add(this.guna2Button7);
            this.BarButtons.Location = new System.Drawing.Point(783, 1);
            this.BarButtons.Name = "BarButtons";
            this.BarButtons.Size = new System.Drawing.Size(124, 27);
            this.BarButtons.TabIndex = 7;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button5.BorderRadius = 3;
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(3, 4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(36, 19);
            this.guna2Button5.TabIndex = 6;
            this.guna2Button5.Text = "_";
            this.guna2Button5.TextOffset = new System.Drawing.Point(0, -5);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button6.BorderRadius = 3;
            this.guna2Button6.BorderThickness = 1;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Location = new System.Drawing.Point(44, 4);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(36, 19);
            this.guna2Button6.TabIndex = 5;
            this.guna2Button6.Text = "▢";
            this.guna2Button6.TextOffset = new System.Drawing.Point(0, 1);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button7.BorderRadius = 3;
            this.guna2Button7.BorderThickness = 1;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Location = new System.Drawing.Point(85, 4);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(35, 19);
            this.guna2Button7.TabIndex = 4;
            this.guna2Button7.Text = "x";
            this.guna2Button7.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Title.Location = new System.Drawing.Point(29, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(49, 15);
            this.Title.TabIndex = 1;
            this.Title.Text = "Dotter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 4;
            this.guna2Elipse3.TargetControl = this.debug;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(907, 442);
            this.ControlBox = false;
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.downBar);
            this.Controls.Add(this.scintilla1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editing Line: 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.downBar.ResumeLayout(false);
            this.downBar.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.BarButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla scintilla1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel downBar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.Timer caretAnimator;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private System.Windows.Forms.Timer PrvwTimer;
        private Guna.UI2.WinForms.Guna2GradientPanel titleBar;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Panel BarButtons;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI.WinForms.GunaResizeControl gunaResizeControl1;
    }
}

