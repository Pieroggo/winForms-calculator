using System.Threading;

namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.number8 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.changeSign = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(64, 165);
            this.number8.Margin = new System.Windows.Forms.Padding(2);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(49, 52);
            this.number8.TabIndex = 0;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(64, 53);
            this.number2.Margin = new System.Windows.Forms.Padding(2);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(49, 52);
            this.number2.TabIndex = 1;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(168, 109);
            this.subtraction.Margin = new System.Windows.Forms.Padding(2);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(49, 52);
            this.subtraction.TabIndex = 2;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.operationsClick);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(168, 165);
            this.multiplication.Margin = new System.Windows.Forms.Padding(2);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(49, 52);
            this.multiplication.TabIndex = 3;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.operationsClick);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(168, 53);
            this.addition.Margin = new System.Windows.Forms.Padding(2);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(49, 52);
            this.addition.TabIndex = 4;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.operationsClick);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(117, 109);
            this.number6.Margin = new System.Windows.Forms.Padding(2);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(49, 52);
            this.number6.TabIndex = 5;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(11, 165);
            this.number7.Margin = new System.Windows.Forms.Padding(2);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(49, 52);
            this.number7.TabIndex = 6;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(64, 109);
            this.number5.Margin = new System.Windows.Forms.Padding(2);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(49, 52);
            this.number5.TabIndex = 7;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(117, 165);
            this.number9.Margin = new System.Windows.Forms.Padding(2);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(49, 52);
            this.number9.TabIndex = 8;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(168, 220);
            this.division.Margin = new System.Windows.Forms.Padding(2);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(49, 52);
            this.division.TabIndex = 9;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operationsClick);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(11, 53);
            this.number1.Margin = new System.Windows.Forms.Padding(2);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(49, 52);
            this.number1.TabIndex = 10;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(117, 53);
            this.number3.Margin = new System.Windows.Forms.Padding(2);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(49, 52);
            this.number3.TabIndex = 11;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(64, 220);
            this.number0.Margin = new System.Windows.Forms.Padding(2);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(49, 52);
            this.number0.TabIndex = 12;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(11, 109);
            this.number4.Margin = new System.Windows.Forms.Padding(2);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(49, 52);
            this.number4.TabIndex = 13;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(221, 53);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(108, 52);
            this.clear.TabIndex = 14;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clearClick);
            // 
            // changeSign
            // 
            this.changeSign.Location = new System.Drawing.Point(11, 221);
            this.changeSign.Margin = new System.Windows.Forms.Padding(2);
            this.changeSign.Name = "changeSign";
            this.changeSign.Size = new System.Drawing.Size(50, 51);
            this.changeSign.TabIndex = 15;
            this.changeSign.Text = "+/-";
            this.changeSign.UseVisualStyleBackColor = true;
            this.changeSign.Click += new System.EventHandler(this.signChangeClick);
            // 
            // separator
            // 
            this.separator.Location = new System.Drawing.Point(117, 220);
            this.separator.Margin = new System.Windows.Forms.Padding(2);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(49, 52);
            this.separator.TabIndex = 16;
            this.separator.Text = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            this.separator.UseVisualStyleBackColor = true;
            this.separator.Click += new System.EventHandler(this.separatorClick);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(222, 109);
            this.backspace.Margin = new System.Windows.Forms.Padding(2);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(107, 52);
            this.backspace.TabIndex = 17;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspaceClick);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(222, 165);
            this.result.Margin = new System.Windows.Forms.Padding(2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(107, 104);
            this.result.TabIndex = 18;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.resultClick);
            // 
            // displayBox
            // 
            this.displayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.displayBox.Location = new System.Drawing.Point(11, 11);
            this.displayBox.Margin = new System.Windows.Forms.Padding(2);
            this.displayBox.Name = "displayBox";
            this.displayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayBox.Size = new System.Drawing.Size(318, 38);
            this.displayBox.TabIndex = 21;
            this.displayBox.Text = "0";
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 280);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.result);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.changeSign);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number8);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button changeSign;
        private System.Windows.Forms.Button separator;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.TextBox displayBox;
    }
}

