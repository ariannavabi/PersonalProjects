
namespace LexicalAnalyzer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.button_Analyze = new System.Windows.Forms.Button();
            this.checkBox_RealTime = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Highlits = new System.Windows.Forms.Label();
            this.button_ClearOutput = new System.Windows.Forms.Button();
            this.checkBox_History = new System.Windows.Forms.CheckBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.numericUpDown_FontSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Errors = new System.Windows.Forms.TextBox();
            this.richTextBox_Input = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.label_About = new System.Windows.Forms.Label();
            this.numericUpDown_OutputSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip_Main = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).BeginInit();
            this.groupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OutputSize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Input.Location = new System.Drawing.Point(146, 27);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.PlaceholderText = "Write a code here...";
            this.textBox_Input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Input.Size = new System.Drawing.Size(448, 622);
            this.textBox_Input.TabIndex = 0;
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            // 
            // textBox_Output
            // 
            this.textBox_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox_Output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Output.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Output.Location = new System.Drawing.Point(600, 418);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Output.Size = new System.Drawing.Size(629, 231);
            this.textBox_Output.TabIndex = 3;
            this.textBox_Output.Text = ">>";
            // 
            // button_Analyze
            // 
            this.button_Analyze.Location = new System.Drawing.Point(15, 105);
            this.button_Analyze.Name = "button_Analyze";
            this.button_Analyze.Size = new System.Drawing.Size(75, 24);
            this.button_Analyze.TabIndex = 1;
            this.button_Analyze.Text = "Analyze";
            this.button_Analyze.UseVisualStyleBackColor = true;
            this.button_Analyze.Click += new System.EventHandler(this.button_Analyze_Click);
            // 
            // checkBox_RealTime
            // 
            this.checkBox_RealTime.AutoSize = true;
            this.checkBox_RealTime.Checked = true;
            this.checkBox_RealTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RealTime.Location = new System.Drawing.Point(15, 80);
            this.checkBox_RealTime.Name = "checkBox_RealTime";
            this.checkBox_RealTime.Size = new System.Drawing.Size(74, 19);
            this.checkBox_RealTime.TabIndex = 3;
            this.checkBox_RealTime.Text = "RealTime";
            this.checkBox_RealTime.UseVisualStyleBackColor = true;
            this.checkBox_RealTime.CheckedChanged += new System.EventHandler(this.checkBox_RealTime_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input:";
            // 
            // label_Highlits
            // 
            this.label_Highlits.AutoSize = true;
            this.label_Highlits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Highlits.Location = new System.Drawing.Point(600, 9);
            this.label_Highlits.Name = "label_Highlits";
            this.label_Highlits.Size = new System.Drawing.Size(115, 15);
            this.label_Highlits.TabIndex = 3;
            this.label_Highlits.Text = "Syntax Highlighting:";
            // 
            // button_ClearOutput
            // 
            this.button_ClearOutput.Location = new System.Drawing.Point(15, 155);
            this.button_ClearOutput.Name = "button_ClearOutput";
            this.button_ClearOutput.Size = new System.Drawing.Size(75, 24);
            this.button_ClearOutput.TabIndex = 2;
            this.button_ClearOutput.Text = "Clear";
            this.button_ClearOutput.UseVisualStyleBackColor = true;
            this.button_ClearOutput.Click += new System.EventHandler(this.button_ClearOutput_Click);
            // 
            // checkBox_History
            // 
            this.checkBox_History.AutoSize = true;
            this.checkBox_History.Location = new System.Drawing.Point(14, 36);
            this.checkBox_History.Name = "checkBox_History";
            this.checkBox_History.Size = new System.Drawing.Size(93, 19);
            this.checkBox_History.TabIndex = 3;
            this.checkBox_History.Text = "Keep History";
            this.checkBox_History.UseVisualStyleBackColor = true;
            this.checkBox_History.CheckedChanged += new System.EventHandler(this.checkBox_History_CheckedChanged);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(16, 207);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 24);
            this.button_Load.TabIndex = 4;
            this.button_Load.Text = "Import...";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // numericUpDown_FontSize
            // 
            this.numericUpDown_FontSize.DecimalPlaces = 1;
            this.numericUpDown_FontSize.Location = new System.Drawing.Point(17, 287);
            this.numericUpDown_FontSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_FontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_FontSize.Name = "numericUpDown_FontSize";
            this.numericUpDown_FontSize.Size = new System.Drawing.Size(74, 23);
            this.numericUpDown_FontSize.TabIndex = 5;
            this.numericUpDown_FontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_FontSize.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDown_FontSize.ValueChanged += new System.EventHandler(this.numericUpDown_FontSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Font Size:";
            // 
            // textBox_Errors
            // 
            this.textBox_Errors.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Errors.Location = new System.Drawing.Point(1174, 400);
            this.textBox_Errors.Multiline = true;
            this.textBox_Errors.Name = "textBox_Errors";
            this.textBox_Errors.PlaceholderText = "Hidden";
            this.textBox_Errors.Size = new System.Drawing.Size(55, 15);
            this.textBox_Errors.TabIndex = 4;
            this.textBox_Errors.Visible = false;
            // 
            // richTextBox_Input
            // 
            this.richTextBox_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.richTextBox_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Input.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_Input.ForeColor = System.Drawing.Color.White;
            this.richTextBox_Input.Location = new System.Drawing.Point(600, 27);
            this.richTextBox_Input.Name = "richTextBox_Input";
            this.richTextBox_Input.ReadOnly = true;
            this.richTextBox_Input.Size = new System.Drawing.Size(629, 370);
            this.richTextBox_Input.TabIndex = 6;
            this.richTextBox_Input.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(600, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output:";
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.label_About);
            this.groupBox_Settings.Controls.Add(this.checkBox_History);
            this.groupBox_Settings.Controls.Add(this.button_Analyze);
            this.groupBox_Settings.Controls.Add(this.button_ClearOutput);
            this.groupBox_Settings.Controls.Add(this.numericUpDown_OutputSize);
            this.groupBox_Settings.Controls.Add(this.numericUpDown_FontSize);
            this.groupBox_Settings.Controls.Add(this.checkBox_RealTime);
            this.groupBox_Settings.Controls.Add(this.label2);
            this.groupBox_Settings.Controls.Add(this.button_Load);
            this.groupBox_Settings.Controls.Add(this.label3);
            this.groupBox_Settings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(118, 637);
            this.groupBox_Settings.TabIndex = 7;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.BackColor = System.Drawing.Color.DarkGray;
            this.label_About.Cursor = System.Windows.Forms.Cursors.Help;
            this.label_About.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_About.ForeColor = System.Drawing.Color.White;
            this.label_About.Location = new System.Drawing.Point(32, 586);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(50, 20);
            this.label_About.TabIndex = 6;
            this.label_About.Text = "About";
            this.toolTip_Main.SetToolTip(this.label_About, resources.GetString("label_About.ToolTip"));
            this.label_About.Click += new System.EventHandler(this.label_About_Click);
            // 
            // numericUpDown_OutputSize
            // 
            this.numericUpDown_OutputSize.DecimalPlaces = 1;
            this.numericUpDown_OutputSize.Location = new System.Drawing.Point(17, 369);
            this.numericUpDown_OutputSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_OutputSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_OutputSize.Name = "numericUpDown_OutputSize";
            this.numericUpDown_OutputSize.Size = new System.Drawing.Size(74, 23);
            this.numericUpDown_OutputSize.TabIndex = 5;
            this.numericUpDown_OutputSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_OutputSize.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDown_OutputSize.ValueChanged += new System.EventHandler(this.numericUpDown_OutputSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Size:";
            // 
            // toolTip_Main
            // 
            this.toolTip_Main.AutomaticDelay = 0;
            this.toolTip_Main.AutoPopDelay = 0;
            this.toolTip_Main.InitialDelay = 0;
            this.toolTip_Main.IsBalloon = true;
            this.toolTip_Main.ReshowDelay = 0;
            this.toolTip_Main.ShowAlways = true;
            this.toolTip_Main.StripAmpersands = true;
            this.toolTip_Main.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Main.ToolTipTitle = "About";
            this.toolTip_Main.UseAnimation = false;
            this.toolTip_Main.UseFading = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 661);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.richTextBox_Input);
            this.Controls.Add(this.textBox_Errors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Highlits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.textBox_Input);
            this.Name = "Form1";
            this.Text = "Lexical Analyzer - Arian Navabi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).EndInit();
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OutputSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Button button_Analyze;
        private System.Windows.Forms.CheckBox checkBox_RealTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Highlits;
        private System.Windows.Forms.Button button_ClearOutput;
        private System.Windows.Forms.CheckBox checkBox_History;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.NumericUpDown numericUpDown_FontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Errors;
        private System.Windows.Forms.RichTextBox richTextBox_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.NumericUpDown numericUpDown_OutputSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.ToolTip toolTip_Main;
    }
}

