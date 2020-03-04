using System.Windows.Forms;

namespace View
{
    partial class KD
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KD));
            this.historyBox = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.meanButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.stdDevButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.progressBox = new System.Windows.Forms.TextBox();
            this.repeatButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.cloneButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SimpleButton = new System.Windows.Forms.Button();
            this.MoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyBox
            // 
            this.historyBox.FormattingEnabled = true;
            this.historyBox.ItemHeight = 15;
            this.historyBox.Location = new System.Drawing.Point(16, 87);
            this.historyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(530, 454);
            this.historyBox.TabIndex = 0;
            this.historyBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Location = new System.Drawing.Point(570, 87);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(141, 134);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(570, 244);
            this.plusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(74, 33);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(570, 330);
            this.squareButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(74, 33);
            this.squareButton.TabIndex = 3;
            this.squareButton.Text = "x²";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(734, 373);
            this.logButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(74, 33);
            this.logButton.TabIndex = 4;
            this.logButton.Text = "log[a]";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // factorialButton
            // 
            this.factorialButton.Location = new System.Drawing.Point(652, 416);
            this.factorialButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(74, 33);
            this.factorialButton.TabIndex = 7;
            this.factorialButton.Text = "x!";
            this.factorialButton.UseVisualStyleBackColor = true;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Location = new System.Drawing.Point(570, 373);
            this.powerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(74, 33);
            this.powerButton.TabIndex = 6;
            this.powerButton.Text = "xⁿ";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(652, 244);
            this.minusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(74, 33);
            this.minusButton.TabIndex = 5;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // meanButton
            // 
            this.meanButton.Location = new System.Drawing.Point(570, 416);
            this.meanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meanButton.Name = "meanButton";
            this.meanButton.Size = new System.Drawing.Size(74, 33);
            this.meanButton.TabIndex = 10;
            this.meanButton.Text = "mean";
            this.meanButton.UseVisualStyleBackColor = true;
            this.meanButton.Click += new System.EventHandler(this.meanButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Location = new System.Drawing.Point(652, 330);
            this.sqrtButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(74, 33);
            this.sqrtButton.TabIndex = 9;
            this.sqrtButton.Text = "²√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(570, 287);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(74, 33);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // stdDevButton
            // 
            this.stdDevButton.Location = new System.Drawing.Point(734, 416);
            this.stdDevButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stdDevButton.Name = "stdDevButton";
            this.stdDevButton.Size = new System.Drawing.Size(74, 33);
            this.stdDevButton.TabIndex = 13;
            this.stdDevButton.Text = "StdDev";
            this.stdDevButton.UseVisualStyleBackColor = true;
            this.stdDevButton.Click += new System.EventHandler(this.stdDevButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.Location = new System.Drawing.Point(652, 373);
            this.rootButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(74, 33);
            this.rootButton.TabIndex = 12;
            this.rootButton.Text = "ⁿ√ ";
            this.rootButton.UseVisualStyleBackColor = true;
            this.rootButton.Click += new System.EventHandler(this.rootButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(652, 287);
            this.divideButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(74, 33);
            this.divideButton.TabIndex = 11;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(1053, 244);
            this.assignButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(114, 33);
            this.assignButton.TabIndex = 16;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.button13_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(1192, 114);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(114, 33);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.button14_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1053, 114);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 33);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button15_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 14);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(274, 26);
            this.progressBar.TabIndex = 17;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // progressBox
            // 
            this.progressBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBox.Location = new System.Drawing.Point(329, 14);
            this.progressBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBox.Multiline = true;
            this.progressBox.Name = "progressBox";
            this.progressBox.ReadOnly = true;
            this.progressBox.Size = new System.Drawing.Size(977, 63);
            this.progressBox.TabIndex = 19;
            this.progressBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // repeatButton
            // 
            this.repeatButton.Location = new System.Drawing.Point(1192, 188);
            this.repeatButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(114, 33);
            this.repeatButton.TabIndex = 22;
            this.repeatButton.Text = "Repeat";
            this.repeatButton.UseVisualStyleBackColor = true;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(1053, 188);
            this.undoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(114, 33);
            this.undoButton.TabIndex = 21;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1192, 244);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(114, 33);
            this.resetButton.TabIndex = 20;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(1192, 297);
            this.cloneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(114, 33);
            this.cloneButton.TabIndex = 23;
            this.cloneButton.Text = "Clone";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1053, 297);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 33);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SimpleButton
            // 
            this.SimpleButton.BackColor = System.Drawing.Color.White;
            this.SimpleButton.Location = new System.Drawing.Point(31, 54);
            this.SimpleButton.Name = "SimpleButton";
            this.SimpleButton.Size = new System.Drawing.Size(75, 23);
            this.SimpleButton.TabIndex = 25;
            this.SimpleButton.Text = "Simple";
            this.SimpleButton.UseVisualStyleBackColor = false;
            this.SimpleButton.Click += new System.EventHandler(this.ChangeButtonS_Click);
            // 
            // MoreButton
            // 
            this.MoreButton.BackColor = System.Drawing.Color.LightGreen;
            this.MoreButton.Location = new System.Drawing.Point(151, 54);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(75, 23);
            this.MoreButton.TabIndex = 26;
            this.MoreButton.Text = "More";
            this.MoreButton.UseVisualStyleBackColor = false;
            this.MoreButton.Click += new System.EventHandler(this.ChangeButtonM_Click);
            // 
            // KD
            // 
            this.AccessibleName = "KD";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1319, 563);
            this.Controls.Add(this.MoreButton);
            this.Controls.Add(this.SimpleButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.repeatButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.progressBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stdDevButton);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.meanButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.factorialButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.historyBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.KD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button meanButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button stdDevButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox progressBox;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button SimpleButton;
        private System.Windows.Forms.Button MoreButton;
    }
}

