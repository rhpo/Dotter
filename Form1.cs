using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Drawing.Color;
using static ScintillaNET.Style;
using CefSharp.WinForms;
using CefSharp;
using CefSharp.Internals;
namespace Dotterl
{
    public partial class Form1 : Form
    {
        public string currentLineString = "";
        public int currentLine = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);
        public Previem preview;
        public Form1()
        {
            InitializeComponent();
            preview = new Previem();
            preview.Show();
            preview.changeText(scintilla1.Text);
        }

            // Preview(scintilla1.Text, false);
            // browser.LoadHtml();
            //browser.ExecuteScriptAsyncWhenPageLoaded("waitForElm('notice-3bPHh- colorDefault-22HBa0').then(elm => alert('form_loaded'));");
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_NCPAINT = 0x85;
            if (m.Msg == WM_NCPAINT)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if ((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 4800, 23));
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private CSharpLexer sharpLexer = new CSharpLexer("isnt");
        private void Form1_Load(object sender, EventArgs e)
        {
            caretAnimator.Start();
            ScintillaNET.Scintilla scintilla = scintilla1;
            ResizeAll();
            scintilla.StyleResetDefault();
            scintilla.Styles[ScintillaNET.Style.Default].Font = "Consolas";
            scintilla.Styles[ScintillaNET.Style.Default].Size = 14;
            scintilla.Styles[ScintillaNET.Style.Default].BackColor = Color.FromArgb(27, 27, 27);
            scintilla.StyleClearAll();
            scintilla.Styles[CSharpLexer.StyleDefault].ForeColor = Color.White;
            scintilla.Styles[CSharpLexer.StyleKeyword].ForeColor = Color.FromArgb(255, 84, 110);
            scintilla.Styles[CSharpLexer.StyleKeyword].Underline = true;
            scintilla.Styles[CSharpLexer.StyleIdentifier].ForeColor = Color.FromArgb(117, 199, 109);//
            scintilla.Styles[CSharpLexer.StyleNumber].ForeColor = Color.Red;
            scintilla.Styles[CSharpLexer.StyleString].ForeColor = Color.Orange;
            scintilla.Styles[CSharpLexer.StyleString].Italic = true;
            scintilla.Styles[CSharpLexer.CPropreties].ForeColor = Color.FromArgb(123, 219, 198);
            scintilla.Styles[CSharpLexer.CTags].ForeColor = Color.FromArgb(255, 84, 110);
            scintilla.Styles[CSharpLexer.CTags].Underline = true;
            scintilla.Styles[CSharpLexer.CClasses].ForeColor = Purple;
            scintilla.Styles[CSharpLexer.CKeyWords].ForeColor = LightPink;
            scintilla.Styles[CSharpLexer.CKeyWords].Hotspot = true;
            scintilla.Styles[CSharpLexer.CValues].ForeColor = Color.LightGreen;
            scintilla.Styles[CSharpLexer.CValues].Italic = true;
            scintilla.Styles[CSharpLexer.CComment].ForeColor = Color.DarkGreen;
            scintilla.Styles[CSharpLexer.CSharp].ForeColor = Gray;
            // scintilla.Styles[CSharpLexer.StyleCustom].ForeColor = Black;
            scintilla.Margins[0].Width = 5;

            scintilla.Lexer = ScintillaNET.Lexer.Container;
            scintilla1.CaretStyle = ScintillaNET.CaretStyle.Block;
            scintilla.CaretLineVisible = false;
            scintilla.CaretPeriod = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void scintilla1_Click(object sender, EventArgs e)
        {
            titleChange();
        }

        private void titleChange()
        {
            this.Text = "Dotter | Editing Line: " + GetCurrentLineNumber().ToString();
            _colorCounter = 250;
            scintilla1.CaretForeColor = White;
        }

        private void scintilla1_StyleNeeded(object sender, ScintillaNET.StyleNeededEventArgs e)
        {
            var startPos = scintilla1.GetEndStyled();
            var endPos = e.Position;
            sharpLexer.Style(scintilla1, startPos, endPos);
        }
        private int maxLineNumberCharLength;
        public string wordTyping = "";
        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            PrvwTimer.Stop();
            PrvwTimer.Start();
            titleChange();
            ScintillaNET.Scintilla scintilla = scintilla1;
            wordTyping = scintilla.GetWordFromPosition(scintilla.SelectionStart);
            /*if (wordTyping.StartsWith("i"))
            {
                scintilla.AutoCShow(1, "is");
            }*/
            /*switch (wordTyping)
            {
                case string f when wordTyping.StartsWith("c") && !wordTyping.EndsWith(" "):
                    scintilla.AutoCShow(0, "color case");
                    break;
                case string fr when wordTyping.StartsWith("co") && !wordTyping.EndsWith(" "):
                    scintilla.AutoCShow(1, "color");
                    break;
                case string frr when wordTyping.StartsWith("ca") && !wordTyping.EndsWith(" "):
                    scintilla.AutoCShow(1, "case");
                    break;
                case string frrr when wordTyping.StartsWith("i") && !wordTyping.EndsWith(" "):
                    //scintilla.AutoCShow(0, "is");
                    break;
                case string frrrr when wordTyping.StartsWith("t") && !wordTyping.EndsWith(" "):
                    scintilla.AutoCShow(2, "text textAlign");
                    break;
            }*/
            int cadetPos = scintilla1.SelectionStart;
            if (!scintilla1.Text.EndsWith(" "))
            {
                scintilla1.Text += " ";
                scintilla1.SelectionStart = cadetPos;
            }
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(ScintillaNET.Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }
        private int GetCurrentLineNumber()
        {
            var curPos = scintilla1.CurrentPosition;
            return scintilla1.LineFromPosition(curPos) + 1;
        }
        private bool authoriseTab = true;
        private void scintilla1_KeyDown(object sender, KeyEventArgs e)
        {
            titleChange();
            try
            {
                char tab = '	';
                bool addTab = false;
                bool _addTab = false;
                bool tag_input = false;
                bool tag_button = false;
                bool tag_panel = false;
                bool tag_main = false;
                bool tag_lbl = false;
                int tabCount = 0;
                if (e.KeyCode == Keys.Enter)
                {
                    if (scintilla1.AutoCActive) return;
                    int lineCount = GetCurrentLineNumber();
                    string[] lines = scintilla1.Text.Split('\n');
                    string currentLine = lines[lineCount - 1];
                    //Text = currentLine;
                    try
                    {
                        string lastChar = scintilla1.Text.Substring(scintilla1.SelectionStart - 1, 1);
                        string nextChar = scintilla1.Text.Substring(scintilla1.SelectionStart, 1);
                        if (lastChar == "{" && nextChar == "}")
                        {
                            addTab = true;
                        }
                        else if (lastChar == "{")
                        {
                            _addTab = true;
                        }
                        else if (wordTyping == "input" && lastChar == ">")
                        {
                            tag_input = true;
                        }
                        else if (wordTyping == "button" && lastChar == ">")
                        {
                            tag_button = true;
                        }
                        else if (wordTyping == "panel" && lastChar == ">")
                        {
                            tag_panel = true;
                        }
                        else if (wordTyping == "main" && lastChar == ">")
                        {
                            tag_main = true;
                        }
                        else if (wordTyping == "label" && lastChar == ">")
                        {
                            tag_lbl = true;
                        }
                        else if (lastChar == ">")
                        {
                            if (authoriseTab)
                            {
                                _addTab = true;
                            }
                        }
                        tabCount = currentLine.Where(x => (x == tab)).Count();
                        if (addTab)
                        {
                            SendKeys.Send("{Enter}");
                            for (int o = 0; o < tabCount; o++)
                            {
                                SendKeys.Send(tab.ToString());
                            }
                            SendKeys.Send("{UP}");
                            for (int o = 0; o < tabCount + 1; o++)
                            {
                                SendKeys.Send(tab.ToString());

                            }
                        }
                        else if (_addTab)
                        {
                            for (int o = 0; o < tabCount + 1; o++)
                            {
                                SendKeys.Send(tab.ToString());
                            }
                        }
                        else if (tag_input)
                        {
                            if (gunaCheckBox1.Checked)
                            {
                                SendKeys.Send("{Enter}");
                                for (int o = 0; o < tabCount; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = false;
                                SendKeys.Send("<input{UP}");
                                for (int o = 0; o < tabCount + 1; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = true;
                            }
                        }
                        else if (tag_button)
                        {
                            if (gunaCheckBox1.Checked)
                            {
                                SendKeys.Send("{Enter}");
                                for (int o = 0; o < tabCount; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = false;
                                SendKeys.Send("<button{UP}");
                                for (int o = 0; o < tabCount + 1; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = true;
                            }
                        }
                        else if (tag_panel)
                        {
                            if (gunaCheckBox1.Checked)
                            {
                                SendKeys.Send("{Enter}");
                                for (int o = 0; o < tabCount; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = false;
                                SendKeys.Send("<panel{UP}");
                                for (int o = 0; o < tabCount + 1; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = true;
                            }
                        }
                        else if (tag_main)
                        {
                            if (gunaCheckBox1.Checked)
                            {
                                SendKeys.Send("{Enter}");
                                for (int o = 0; o < tabCount; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = false;
                                SendKeys.Send("<main{UP}");
                                for (int o = 0; o < tabCount + 1; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = true;
                            }
                        }
                        else if (tag_lbl)
                        {
                            if (gunaCheckBox1.Checked)
                            {
                                SendKeys.Send("{Enter}");
                                for (int o = 0; o < tabCount; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = false;
                                SendKeys.Send("<label{UP}");
                                for (int o = 0; o < tabCount + 1; o++)
                                {
                                    SendKeys.Send(tab.ToString());
                                }
                                authoriseTab = true;
                            }
                        }
                        else
                        {
                            for (int o = 0; o < tabCount; o++)
                            {
                                SendKeys.Send(tab.ToString());
                            }
                        }
                        /*if (addTab)
                        {
                           SendKeys.Send("{Enter}{UP}");
                        }*/
                    }
                    catch { }
                }
            }
            catch
            {

            }

            if (e.KeyCode == Keys.Space)
            {
                wordTyping = "";
            }
        }
        public static Boolean isCurslyBracesKeyPressed = false;
        private ScintillaNET.Scintilla richTextBox1;
        private void scintilla1_KeyPress(object sender, KeyPressEventArgs e)
        {
            richTextBox1 = scintilla1;
            String s = e.KeyChar.ToString();
            int sel = richTextBox1.SelectionStart;
            if (true) // allow permission to auto-complete
            {
                switch (s)
                {
                    case "(":
                        richTextBox1.Text = richTextBox1.Text.Insert(sel, "()");
                        e.Handled = true;
                        richTextBox1.SelectionStart = sel + 1;
                        break;

                    case "{":
                        String t = "{}";
                        richTextBox1.Text = richTextBox1.Text.Insert(sel, t);
                        e.Handled = true;
                        richTextBox1.SelectionStart = sel + t.Length - 1;
                        isCurslyBracesKeyPressed = true;
                        break;

                    case "[":
                        richTextBox1.Text = richTextBox1.Text.Insert(sel, "[]");
                        e.Handled = true;
                        richTextBox1.SelectionStart = sel + 1;
                        break;
                    case ")":
                        try
                        {
                            string lastC = scintilla1.Text.Substring(scintilla1.SelectionStart, 1);
                            if (lastC == ")")
                            {
                                SendKeys.Send("{RIGHT}{BSP}");
                            }
                        }
                        catch{}
                        break;
                    case "\"":
                        richTextBox1.Text = richTextBox1.Text.Insert(sel, "\"\"");
                        e.Handled = true;
                        richTextBox1.SelectionStart = sel + 1;
                        break;

                    case "'":
                        char[] _counter = null;
                        string __counter = scintilla1.Text.Substring(0, scintilla1.CurrentPosition);
                        _counter = __counter.ToCharArray();
                        int count = 0;
                        foreach (char i in _counter)
                        {
                            try
                            {
                                if (i.ToString() == "'")
                                {
                                    count++;
                                }
                            }
                            catch (Exception rrr)
                            {
                                MessageBox.Show(rrr.Message);
                            }
                        }
                        if ((count % 2) == 0)
                        {
                            richTextBox1.Text = richTextBox1.Text.Insert(sel, "''");
                            e.Handled = true;
                            richTextBox1.SelectionStart = sel + 1;
                        }
                        break;
                }
            }
        }
       public static string errorCode = "";
       public static string lastTag = "";
       public static string btnTexte = "button";
       public static string tagText = "Hello, World!";
       public static bool   EmergencyCloseTag = false;
       public static string compiled = "<html>\n<body>";
       public static List<string> LTArray = new List<string>();
        public void Preview(string code, bool errs)
        {
            string tab = "	";
            int regItem = 0;
            string[] Lines = code.Split('\n');
            int lineCount = Lines.Length;
            /// <summary>
            ///     START OF DOTTER
            /// </summary>
            #region
            for (int current = 0; current < lineCount; current++)
            {
                string l = Lines[current].Replace(tab, "");
                if (l.StartsWith("!")) { return; }
                else if (!code.Contains("main>"))
                {
                    errorCode = "1";
                    if (errs)
                    {
                        Error($"Your Dotter code doesn't contain any main method!\nError code: {errorCode}", "TypeError");
                        return;
                    }
                    else
                    {
                        preview.changeText(BuildErrorhtml($"Your Dotter code doesn't contain any main method!<br>Error code: <strong>{errorCode}</strong>"));
                        return;
                    }
                }
                else if (!code.Contains("<main"))
                {
                    errorCode = "2";
                    if (errs)
                    {
                        Error($"Your Dotter code doesn't have an end for the 'main>' tag!\nError code: {errorCode}", "TypeError");
                        return;
                    }
                    else
                    {
                        preview.changeText(BuildErrorhtml($"Your Dotter code doesn't have an end for the 'main>' tag!<br>Error code: <strong>{errorCode}</strong>"));
                        return;
                    }
                }
                // opening Tags

                if (l.StartsWith("button>"))
                    #region add Tags
                {
                    if (LTArray.Count > 0)
                    {
                        string __;
                        regItem++;
                        switch (LTArray.Last())
                        {
                            default:
                                __ = "";
                                break;
                            case "Button":
                                __ = "button";
                                break;
                            case "Panel":
                                __ = "div";
                                break;
                            case "Input":
                                __ = "input";
                                break;
                        }
                        if (__=="")
                        {
                           compiled += "\">";
                        }
                        else if (__=="button")
                        {
                           compiled += $"\">{btnTexte}<" + __ + ">";
                        }
                        else
                        {
                           compiled += "\"><" + __ + ">";
                        }
                        //EmergencyCloseTag = true;
                    }
                    lastTag = "Button";
                    LTArray.Add("Button");
                    compiled += "\n<button style=\"";
                }
                if (l.StartsWith("input>"))
                {
                    lastTag = "Input";
                    LTArray.Add("Input");
                    compiled += "\n<input style=\"";
                    regItem++;
                }
                if (l.StartsWith("label>"))
                {
                    lastTag = "Label";
                    LTArray.Add("Label");
                    compiled += "\n<h1 style=\"	font-family: Segoe UI, Frutiger, Frutiger Linotype, Dejavu Sans, Helvetica Neue, Arial, sans-serif;";
                    regItem++;
                }
                if (l.StartsWith("panel>"))
                {
                    lastTag = "Panel";
                    LTArray.Add("Panel");
                    compiled += "\n<div style=\"";
                    regItem++;
                }
                if (l.StartsWith("#newline"))
                {
                    compiled += "\n<br>";
                }
                if (l.StartsWith("#center"))
                {
                    compiled += "\n<center>";
                }
                if (l.StartsWith("#endcenter"))
                {
                    compiled += "\n</center>";
                }

                #endregion
                #region close Tags
                if (l.StartsWith("<button"))
                {
                    lastTag = "";
                    if (LTArray.Count <= 0) { }
                    else
                    {
                        try
                        {
                            LTArray.RemoveAt(LTArray.Count);
                        }
                        catch
                        {

                        }

                    }
                    if (!EmergencyCloseTag)
                    {
                        compiled += $"\">{btnTexte}</button>\n";
                    }
                }
                if (l.StartsWith("<input"))
                {
                    lastTag = "";
                    if (LTArray.Count <= 0) { }
                    else
                    {
                        try
                        {
                            LTArray.RemoveAt(LTArray.Count);
                        }
                        catch (Exception)
                        {

                        }
                    }
                   /* if (LTArray.Count % 2 != 0) */
                        compiled += $"\" value=\"{tagText}\"></input>\n";
                }
                if (l.StartsWith("<label"))
                {
                    lastTag = "";
                    if (LTArray.Count <= 0) { }
                    else
                    {
                        try
                        {
                            LTArray.RemoveAt(LTArray.Count);
                        }
                        catch (Exception)
                        {

                        }
                    }
/*                    if (LTArray.Count % 2 != 0)               */
                        compiled += $"\">{tagText}</h1>\n";
                }

                #endregion
                // style Tags
                #region The Dotter Propreties

                if (l.StartsWith("color"))
                {
                    PropBuild(l, "color", "Color", "color", "3", current, errs);
                }
                else if (l.StartsWith("text is"))
                {
                    string btnText = l.Replace("text", "").Replace(" is ", "");
                    if (btnText == "")
                    {
                        errorCode = "3";
                        Error($"The text proprety value of '${LTArray.Last()}' cannot be empty!\nAt: Line ${current}\nError Code: ${errorCode}", "NullProprety Error");
                        return;
                    }
                    else
                    {
                        compiled += $"content:{btnText.Replace("\n", "")};";
                        tagText = btnText;
                        btnTexte = btnText;
                    }
                }
                else if (l.StartsWith("borderRadius"))
                {
                    PropBuild(l, "borderRadius", "borderRadius", "border-radius", "3", current, errs);
                }
                else if (l.StartsWith("bgColor"))
                {
                    PropBuild(l, "bgColor", "bgColor", "background-color", "3", current, errs);
                }
                else if (l.StartsWith("textAlign"))
                {
                    PropBuild(l, "textAlign", "textAlign", "text-align", "3", current, errs);
                }
                else if (l.StartsWith("width"))
                {
                    PropBuild(l, "width", "Width", "width", "3", current, errs);
                }
                else if (l.StartsWith("height"))
                {
                    PropBuild(l, "height", "Height", "height", "3", current, errs);
                }
                else if (l.StartsWith("textSize"))
                {
                    PropBuild(l, "textSize", "textSize", "font-size", "3", current, errs);
                }
                else if (l.StartsWith("borderColor"))
                {
                    PropBuild(l, "borderColor", "borderColor", "border-color", "3", current, errs);
                }
                else if (l.StartsWith("borderSize"))
                {
                    PropBuild(l, "borderSize", "borderSize", "border-width", "3", current, errs);
                }
                else if (l.StartsWith("borderStyle"))
                {
                    PropBuild(l, "borderStyle", "BorderStyle", "border-style", "3", current, errs);
                }

                #endregion

                // check all tags closed :
            }
            if (LTArray.Count < 0)
            {
                errorCode = "4";
                if (errs)
                {
                    Error($"You have some tags that are not closed. Please close them all to continue!\nError Code: {errorCode}", "MissingClosingTags Error");
                    return;
                }
                else
                {
                    this.preview.changeText(BuildErrorhtml($"You have some tags that are not closed. Please close them all to continue!<br>Error code: <strong>{errorCode}</strong>"));
                    return;
                }
            }
            else
            {
                compiled += /*\"*/"</body>\n<style>*{font-family: Segoe UI, Frutiger, Frutiger Linotype, Dejavu Sans, Helvetica Neue, Arial, sans-serif;}</style></html>";
                compiled = compiled.Replace("\n", "").Replace(tab, "");
                while (compiled.Contains(">\">"))
                {
                    compiled = compiled.Replace(">\"", ">");
                }
                while (compiled.Contains(">>"))
                {
                    compiled = compiled.Replace(">>", ">");
                }
                while (compiled.Contains("<input>"))
                {
                    compiled = compiled.Replace("<input>", "");
                }
                if (errs)
                {
                    MessageBox.Show(compiled);
                }
                preview.changeText(compiled);
            }
            compiled = "<html>\n<body>";
            btnTexte = "button";
            tagText = "Hello, World!";
            LTArray = new List<string>();
            EmergencyCloseTag = false;
        }

        public void PropBuild(string l, string p, string pe, string responce, string errCode, int line, bool errors)
        {
            string rep = l.Replace(p, "").Replace("is", "").Replace(" ", "");
            if (rep == "" || rep.Replace(" ", "") == "\n")
            {
                errorCode = errCode;
                if (errors)
                {
                    Error($"The {pe} proprety of '${LTArray.Last()}' cannot be empty!\nAt: Line ${line}\nError Code: ${errCode}", "NullProprety Error");
                    return;
                }
                else
                {
                    preview.changeText(BuildErrorhtml($"The {pe} proprety of '${LTArray.Last()}' cannot be empty!\nAt: Line ${line}<br>Error code: <strong>{errCode}</strong>"));
                    return;
                }
            }
            else
            {
                compiled += $"{responce}:{rep};";
            }
        }
        public static void Error(string err, string title)
        {
            MessageBox.Show(err, "Dotter | " + title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string BuildErrorhtml(string err)
        {
            #region code
            string brack = "\"";
            if (err == "")
            {
                err = "There was a Dotter problem<br>Please check your Dotter code...";
            }
            err = err.Replace("\n", "<br>");
            string html = @"<!DOCTYPE html>
<body style=" + brack + @"background-color: rgb(255, 53, 53);" + brack + @">
      <h1 class=" + brack + @"error" + brack + @" style=" + brack + @"font-style:normal;
    font-size: xx-large;
    color: white;
    font-weight: 600;" + brack + @">Error</h1>
    <h1 class=" + brack + @"error" + brack + @">" + err + @"</h1>
    <div class=" + brack + @"p" + brack + @">
        <div class=" + brack + @"p" + brack + @" style=" + brack + @"
        animation: infinite;
        animation-name: makeDB2;
        animation-duration: 1500ms;
            width: 90px; height: 90px; background-color: rgb(255, 53, 53);" + brack + @">
            <h1 style=" + brack + @"left: 0;
    line-height: 200px;
    margin-top: -100px;
    position: absolute;
    text-align: center;
    top: 50%;
    width: 100%;
    color: white;
    font-size: 50px;
    font-weight:550;
    font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    animation: infinite;
    animation-name: makeTB;
    animation-duration: 1500ms;" + brack + @" class=" + brack + @"ma" + brack + @">!</h1>
        </div>
    </div>
    <h1 class=" + brack + @"desc" + brack + @"></h1>
</body>


<style>
    *{
font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}
    .error
    {
        text-align: center;
        font-size: 17px;
        color: white;
        font-weight: 300;
        font-style: italic;
    }
    .ma
    {

    }
    .p
{
    position: absolute;
    margin: auto;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    width: 100px;
    height: 100px;
    background-color: white;
    border-radius: 1000px;
    padding: 10px;
    animation: infinite;
    animation-name: makeDB;
    animation-duration: 1500ms;
}
@keyframes makeTB
{
        0%
        {
        font-size: 50px;
    }
        50%
        {
        font-size: 70px;
    }
}
@keyframes makeDB
{
        0%
        {
        width: 100px;
        height: 100px;
    }
        50%
        {
        width: 120px;
        height: 120px;
    }
}
@keyframes makeDB2
{
        0%
        {
        width: 90px;
        height: 90px;
    }
        50%
        {
        width: 110px;
        height: 110px;
    }
}
</style> ";
            //MessageBox.Show(html);
            return html;
            #endregion
        }

        #region syntax hlt
        public class CSharpLexer
        {
            #region constants
            public const char commentChar = ';';

            public const int StyleDefault = 0;
            public const int StyleKeyword = 1;
            public const int StyleIdentifier = 2;
            public const int StyleNumber = 3;
            public const int StyleString = 4;
            public const int CTags = 5;
            public const int CKeyWords = 6;
            public const int CPropreties = 7;
            public const int CValues = 8;
            public const int CClasses = 9;
            public const int CComment = 10;
            public const int CSharp = 10;

            private const int STATE_UNKNOWN = 0;
            private const int STATE_IDENTIFIER = 1;
            private const int STATE_NUMBER = 2;
            private const int STATE_STRING = 3;
            private const int STATE_COMMENT = 4;
            private const int STATE_SHARP = 5;

            private HashSet<string> keywords;
            #endregion

            public void Style(ScintillaNET.Scintilla scintilla, int startPos, int endPos)
            {
                // Back up to the line start
                var line = scintilla.LineFromPosition(startPos);
                startPos = scintilla.Lines[line].Position;

                var length = 0;
                var state = STATE_UNKNOWN;

                // Start styling
                scintilla.StartStyling(startPos);
                while (startPos < endPos)
                {
                    var c = (char)scintilla.GetCharAt(startPos);
                    REPROCESS:
                    switch (state)
                    {
                        case STATE_UNKNOWN:
                            if (c == Convert.ToChar("'"))
                            {
                                // Start of "string"
                                scintilla.SetStyling(1, StyleString);
                                state = STATE_STRING;
                            }
                            else if (c == commentChar)
                            {
                                // Start of !comment!
                                scintilla.SetStyling(1, CComment);
                                state = STATE_COMMENT;
                            }
                            else if (c=='#')
                            {
                                scintilla.SetStyling(1, CSharp);
                                state = STATE_SHARP;
                            }
                            else if (Char.IsDigit(c))
                            {
                                state = STATE_NUMBER;
                                goto REPROCESS;
                            }
                            else if (Char.IsLetter(c))
                            {
                                state = STATE_IDENTIFIER;
                                goto REPROCESS;
                            }
                            else
                            {
                                // Everything else
                                scintilla.SetStyling(1, StyleDefault);
                            }
                            break;
                        case STATE_COMMENT:
                            if (c == commentChar)
                            {
                                length++;
                                scintilla.SetStyling(length, CComment);
                                length = 0;
                                state = STATE_UNKNOWN;
                            }
                            else
                            {
                                length++;
                            }
                            break;

                        case STATE_SHARP:
                            if (c == '\n')
                            {
                                length++;
                                scintilla.SetStyling(length, CSharp);
                                length = 0;
                                state = STATE_UNKNOWN;
                            }
                            else
                            {
                                length++;
                            }
                            break;

                        case STATE_STRING:
                            if (c == Convert.ToChar("'"))
                            {
                                length++;
                                scintilla.SetStyling(length, StyleString);
                                length = 0;
                                state = STATE_UNKNOWN;
                            }
                            else
                            {
                                length++;
                            }
                            break;
                        case STATE_NUMBER:
                            if (Char.IsDigit(c) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F') || c == 'x')
                            {
                                length++;
                            }
                            else
                            {
                                scintilla.SetStyling(length, StyleNumber);
                                length = 0;
                                state = STATE_UNKNOWN;
                                goto REPROCESS;
                            }
                            break;

                        case STATE_IDENTIFIER:
                            if (Char.IsLetterOrDigit(c))
                            {
                                length++;
                            }
                            else
                            {
                                var style = StyleIdentifier;
                                var identifier = scintilla.GetTextRange(startPos - length, length);
                                if (keywords.Contains(identifier))
                                    style = StyleKeyword;
                                switch (identifier)
                                {
                                    default:
                                        style = StyleDefault;
                                        break;
                                    case "is": 
                                    case "not": 
                                    case "as": 
                                    case "use":
                                        style = CKeyWords;
                                        break;
                                    case "button":
                                    case "main":
                                    case "input":
                                    case "image":
                                    case "panel":
                                    case "label":
                                        style = CTags;
                                        break;
                                    case "black":
                                    case "yellow":
                                    case "orange":
                                    case "white":
                                    case "blue":
                                    case "green":
                                    case "indigo":
                                    case "cyan":
                                    case "whitesmoke":
                                    case "pink":
                                    case "purple":
                                    case "red":

                                    case "center":
                                    case "left":
                                    case "right":
                                    case "dotted":
                                    case "dashed":
                                    case "solid":
                                    case "double":
                                    case "groove":
                                    case "ridge":
                                    case "inset":
                                    case "outset":

                                    case "none":
                                        style = CValues;
                                        break;
                                    case "color":
                                    case "foreColor":
                                    case "bgColor":
                                    case "font":
                                    case "text":
                                    case "textAlign":
                                    case "width":
                                    case "height":
                                    case "borderRadius":
                                    case "clickedEvent":
                                    case "textSize":
                                    case "borderStyle":
                                    case "borderColor":
                                    case "borderSize":
                                        style = CPropreties;
                                        break;
                                    case "jsFunction":
                                    case "csharpFunction":
                                        style = CClasses;
                                        break;
                                }
                                if (identifier.EndsWith("px") ||
                                    identifier.EndsWith("%") ||
                                    identifier.EndsWith("pt") ||
                                    identifier.EndsWith("vw") ||
                                    identifier.EndsWith("wh"))
                                {
                                    style = CValues;
                                }
                                scintilla.SetStyling(length, style);
                                length = 0;
                                state = STATE_UNKNOWN;
                                goto REPROCESS;
                            }
                            break;
                    }
                    startPos++;
                }
            }

            public CSharpLexer(string keywords)
            {
                var list = Regex.Split(keywords ?? string.Empty, @"\s+").Where(l => !string.IsNullOrEmpty(l));
                this.keywords = new HashSet<string>(list);
            }
        }
        #endregion

        #region Useless Code
        private void scintilla1_Painted(object sender, EventArgs e)
        {
            
        }

        private void scintilla1_Validated(object sender, EventArgs e)
        {
            SendKeys.Send("{INSERT}");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            Preview(scintilla1.Text, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region caretAnimationTrigger
            scintilla1.CaretPeriod = 0;
            scintilla1.CaretLineBackColorAlpha++;
            scintilla1.Focus();
            #endregion
        }
        public int _colorCounter = 250;
        private async void caretAnimator_Tick(object sender, EventArgs e)
        {
            #region caretAnimation
            await Task.Run(() => {
                _colorCounter -= 25;

                if (_colorCounter == 0)
                {
                    _colorCounter = 250;
                }
                else
                {
                    scintilla1.Invoke((MethodInvoker)delegate
                    {
                        scintilla1.CaretForeColor = System.Drawing.Color.FromArgb(_colorCounter, _colorCounter, _colorCounter);
                    });
                }
            });
            #endregion
        }

        private void guna2GradientPanel1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeAll();
        }

        private void ResizeAll()
        {
            /*await Task.Run(() => 
            {*/
                scintilla1.Invoke((MethodInvoker) delegate 
                {
                    scintilla1.Height = Height - downBar.Height;
                });
                int half = Width / 2;
                int toPutIn = half - (guna2HtmlLabel1.Width / 2);
                guna2HtmlLabel1.Invoke((MethodInvoker)delegate
                {
                    guna2HtmlLabel1.Location = new Point(toPutIn, guna2HtmlLabel1.Location.Y);
                });
                titleBar.Invoke((MethodInvoker)delegate
                {
                    titleBar.Width = Width;
                });
                BarButtons.Invoke((MethodInvoker)delegate
                {
                    BarButtons.Location = new Point((Width/* + Width*/ - BarButtons.Width), BarButtons.Location.Y);
                });
            scintilla1.Width = Width;

        }
        private void EnablePreview(object sender, EventArgs e)
        {
            Preview(scintilla1.Text, false);
            PrvwTimer.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
                gunaCheckBox1.Checked = false;
            else
                gunaCheckBox1.Checked = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        int Mx;
        int My;
        int Sw;
        int Sh;
        bool mov;
        private void _Moved(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        private void guna2Button4_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        private void guna2Button4_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void guna2Button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        private void guna2Button1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void guna2Button1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
#endregion