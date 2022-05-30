namespace 小算盤02
{
    partial class MiniCalculator
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
            this.Expression = new System.Windows.Forms.TextBox();
            this.Showcase = new System.Windows.Forms.TextBox();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEqualTo = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Expression
            // 
            this.Expression.Location = new System.Drawing.Point(15, 15);
            this.Expression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Expression.Name = "Expression";
            this.Expression.ReadOnly = true;
            this.Expression.Size = new System.Drawing.Size(316, 27);
            this.Expression.TabIndex = 0;
            this.Expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Showcase
            // 
            this.Showcase.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Showcase.Location = new System.Drawing.Point(15, 52);
            this.Showcase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Showcase.Name = "Showcase";
            this.Showcase.ReadOnly = true;
            this.Showcase.Size = new System.Drawing.Size(316, 58);
            this.Showcase.TabIndex = 1;
            this.Showcase.Text = "0";
            this.Showcase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonNegate
            // 
            this.buttonNegate.Location = new System.Drawing.Point(22, 412);
            this.buttonNegate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(71, 51);
            this.buttonNegate.TabIndex = 44;
            this.buttonNegate.Tag = "ButtonNegate";
            this.buttonNegate.Text = "-/+";
            this.buttonNegate.UseVisualStyleBackColor = true;
            this.buttonNegate.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(22, 353);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(71, 51);
            this.buttonOne.TabIndex = 43;
            this.buttonOne.Tag = "ButtonNumbers";
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(22, 295);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(71, 51);
            this.buttonFour.TabIndex = 42;
            this.buttonFour.Tag = "ButtonNumbers";
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(22, 237);
            this.buttonSeven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(71, 51);
            this.buttonSeven.TabIndex = 41;
            this.buttonSeven.Tag = "ButtonNumbers";
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(100, 412);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(71, 51);
            this.buttonZero.TabIndex = 40;
            this.buttonZero.Tag = "ButtonNumbers";
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(100, 353);
            this.buttonTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(71, 51);
            this.buttonTwo.TabIndex = 39;
            this.buttonTwo.Tag = "ButtonNumbers";
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(100, 295);
            this.buttonFive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(71, 51);
            this.buttonFive.TabIndex = 38;
            this.buttonFive.Tag = "ButtonNumbers";
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonEight
            // 
            this.buttonEight.Location = new System.Drawing.Point(100, 237);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(71, 51);
            this.buttonEight.TabIndex = 37;
            this.buttonEight.Tag = "ButtonNumbers";
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(179, 412);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(71, 51);
            this.buttonDot.TabIndex = 36;
            this.buttonDot.Tag = "ButtonDot";
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(179, 353);
            this.buttonThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(71, 51);
            this.buttonThree.TabIndex = 35;
            this.buttonThree.Tag = "ButtonNumbers";
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(179, 295);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(71, 51);
            this.buttonSix.TabIndex = 34;
            this.buttonSix.Tag = "ButtonNumbers";
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(179, 237);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(71, 51);
            this.buttonNine.TabIndex = 33;
            this.buttonNine.Tag = "ButtonNumbers";
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonEqualTo
            // 
            this.buttonEqualTo.Location = new System.Drawing.Point(257, 412);
            this.buttonEqualTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEqualTo.Name = "buttonEqualTo";
            this.buttonEqualTo.Size = new System.Drawing.Size(71, 51);
            this.buttonEqualTo.TabIndex = 32;
            this.buttonEqualTo.Tag = "ButtonEqualTo";
            this.buttonEqualTo.Text = "＝";
            this.buttonEqualTo.UseVisualStyleBackColor = true;
            this.buttonEqualTo.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Location = new System.Drawing.Point(257, 353);
            this.buttonAddition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(71, 51);
            this.buttonAddition.TabIndex = 31;
            this.buttonAddition.Tag = "ButtonAddition";
            this.buttonAddition.Text = "＋";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Location = new System.Drawing.Point(257, 295);
            this.buttonSubtraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(71, 51);
            this.buttonSubtraction.TabIndex = 30;
            this.buttonSubtraction.Tag = "ButtonSubtraction";
            this.buttonSubtraction.Text = "－";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(257, 237);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(71, 51);
            this.buttonMultiplication.TabIndex = 29;
            this.buttonMultiplication.Tag = "ButtonMultiplication";
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(257, 179);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(71, 51);
            this.buttonDivision.TabIndex = 28;
            this.buttonDivision.Tag = "ButtonDivision";
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(257, 120);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(71, 51);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Tag = "ButtonBack";
            this.buttonBack.Text = "←";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(179, 120);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(71, 51);
            this.buttonC.TabIndex = 26;
            this.buttonC.Tag = "ButtonC";
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(100, 120);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(71, 51);
            this.buttonCE.TabIndex = 25;
            this.buttonCE.Tag = "ButtonCE";
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Location = new System.Drawing.Point(179, 179);
            this.buttonSquareRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(71, 51);
            this.buttonSquareRoot.TabIndex = 45;
            this.buttonSquareRoot.Tag = "ButtonSquareRoot";
            this.buttonSquareRoot.Text = "√";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.ButtonClick);
            // 
            // MiniCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 478);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonNegate);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEqualTo);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.Showcase);
            this.Controls.Add(this.Expression);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MiniCalculator";
            this.Text = "小算盤02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Expression;
        private System.Windows.Forms.TextBox Showcase;
        private System.Windows.Forms.Button buttonNegate;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEqualTo;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonSquareRoot;
    }
}

