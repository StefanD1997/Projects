namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screenNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timesButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.clearNumsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.screenNumClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.operationsSign = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalSum = new System.Windows.Forms.Label();
            this.dot = new System.Windows.Forms.Button();
            this.backSpace = new System.Windows.Forms.Button();
            this.precentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screenNumber
            // 
            this.screenNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.screenNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenNumber.Location = new System.Drawing.Point(12, 23);
            this.screenNumber.Name = "screenNumber";
            this.screenNumber.Size = new System.Drawing.Size(410, 35);
            this.screenNumber.TabIndex = 1;
            this.screenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(93, 186);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 3;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(174, 157);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // timesButton
            // 
            this.timesButton.Location = new System.Drawing.Point(348, 157);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(75, 23);
            this.timesButton.TabIndex = 12;
            this.timesButton.Text = "x";
            this.timesButton.UseVisualStyleBackColor = true;
            this.timesButton.Click += new System.EventHandler(this.newOperations);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(267, 157);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 13;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.newOperations);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(348, 128);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 14;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.newOperations);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(267, 128);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.newOperations);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(89, 239);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(13, 13);
            this.num1.TabIndex = 18;
            this.num1.Text = "0";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(108, 285);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(13, 13);
            this.num2.TabIndex = 19;
            this.num2.Text = "0";
            // 
            // clearNumsBtn
            // 
            this.clearNumsBtn.Location = new System.Drawing.Point(267, 99);
            this.clearNumsBtn.Name = "clearNumsBtn";
            this.clearNumsBtn.Size = new System.Drawing.Size(75, 23);
            this.clearNumsBtn.TabIndex = 20;
            this.clearNumsBtn.Text = "CC";
            this.clearNumsBtn.UseVisualStyleBackColor = true;
            this.clearNumsBtn.Click += new System.EventHandler(this.clearNums);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "First Number =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Second Number =";
            // 
            // screenNumClear
            // 
            this.screenNumClear.AutoSize = true;
            this.screenNumClear.Location = new System.Drawing.Point(347, 99);
            this.screenNumClear.Name = "screenNumClear";
            this.screenNumClear.Size = new System.Drawing.Size(75, 23);
            this.screenNumClear.TabIndex = 23;
            this.screenNumClear.Text = "C";
            this.screenNumClear.UseVisualStyleBackColor = true;
            this.screenNumClear.Click += new System.EventHandler(this.clearNumOnScreen);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Operation :";
            // 
            // operationsSign
            // 
            this.operationsSign.AutoSize = true;
            this.operationsSign.Location = new System.Drawing.Point(108, 263);
            this.operationsSign.Name = "operationsSign";
            this.operationsSign.Size = new System.Drawing.Size(0, 13);
            this.operationsSign.TabIndex = 25;
            // 
            // sum1
            // 
            this.sum1.Location = new System.Drawing.Point(174, 186);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(75, 23);
            this.sum1.TabIndex = 0;
            this.sum1.Text = "=";
            this.sum1.UseVisualStyleBackColor = true;
            this.sum1.Click += new System.EventHandler(this.onEquals);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Result =";
            // 
            // totalSum
            // 
            this.totalSum.AutoSize = true;
            this.totalSum.Location = new System.Drawing.Point(61, 307);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(13, 13);
            this.totalSum.TabIndex = 28;
            this.totalSum.Text = "0";
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(12, 186);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 23);
            this.dot.TabIndex = 29;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.numAddOnScreen);
            // 
            // backSpace
            // 
            this.backSpace.Location = new System.Drawing.Point(347, 61);
            this.backSpace.Name = "backSpace";
            this.backSpace.Size = new System.Drawing.Size(75, 23);
            this.backSpace.TabIndex = 30;
            this.backSpace.Text = "BackSpace";
            this.backSpace.UseVisualStyleBackColor = true;
            this.backSpace.Click += new System.EventHandler(this.backSpace_Click);
            // 
            // precentButton
            // 
            this.precentButton.Location = new System.Drawing.Point(267, 186);
            this.precentButton.Name = "precentButton";
            this.precentButton.Size = new System.Drawing.Size(75, 23);
            this.precentButton.TabIndex = 32;
            this.precentButton.Text = "%";
            this.precentButton.UseVisualStyleBackColor = true;
            this.precentButton.Click += new System.EventHandler(this.newOperations);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(434, 329);
            this.Controls.Add(this.precentButton);
            this.Controls.Add(this.backSpace);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.totalSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.operationsSign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.screenNumClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearNumsBtn);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.timesButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.screenNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label screenNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button timesButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Button clearNumsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button screenNumClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label operationsSign;
        private System.Windows.Forms.Button sum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalSum;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button backSpace;
        private System.Windows.Forms.Button precentButton;
    }
}

