namespace NewCalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonseven = new Button();
            buttoneight = new Button();
            buttonnine = new Button();
            buttondivision = new Button();
            buttonfour = new Button();
            buttonfive = new Button();
            buttonsix = new Button();
            buttonmultiplication = new Button();
            buttonone = new Button();
            buttontwo = new Button();
            buttonthree = new Button();
            buttonzero = new Button();
            buttonpoint = new Button();
            buttonequalsto = new Button();
            buttonclearall = new Button();
            buttonclear = new Button();
            buttonsubtraction = new Button();
            buttonaddition = new Button();
            textBox_Result = new TextBox();
            labelCurrentOperation = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonseven
            // 
            buttonseven.BackColor = SystemColors.ControlLight;
            buttonseven.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonseven.Location = new Point(21, 108);
            buttonseven.Name = "buttonseven";
            buttonseven.Size = new Size(75, 75);
            buttonseven.TabIndex = 0;
            buttonseven.Text = "7";
            buttonseven.UseVisualStyleBackColor = false;
            buttonseven.Click += button_click;
            // 
            // buttoneight
            // 
            buttoneight.BackColor = SystemColors.ControlLight;
            buttoneight.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoneight.Location = new Point(97, 108);
            buttoneight.Name = "buttoneight";
            buttoneight.Size = new Size(75, 75);
            buttoneight.TabIndex = 1;
            buttoneight.Text = "8";
            buttoneight.UseVisualStyleBackColor = false;
            buttoneight.Click += button_click;
            // 
            // buttonnine
            // 
            buttonnine.BackColor = SystemColors.ControlLight;
            buttonnine.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonnine.Location = new Point(173, 108);
            buttonnine.Name = "buttonnine";
            buttonnine.Size = new Size(75, 75);
            buttonnine.TabIndex = 2;
            buttonnine.Text = "9";
            buttonnine.UseVisualStyleBackColor = false;
            buttonnine.Click += button_click;
            // 
            // buttondivision
            // 
            buttondivision.BackColor = SystemColors.ControlLight;
            buttondivision.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondivision.Location = new Point(249, 108);
            buttondivision.Name = "buttondivision";
            buttondivision.Size = new Size(75, 75);
            buttondivision.TabIndex = 3;
            buttondivision.Text = "/";
            buttondivision.UseVisualStyleBackColor = false;
            buttondivision.Click += operator_click;
            // 
            // buttonfour
            // 
            buttonfour.BackColor = SystemColors.ControlLight;
            buttonfour.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonfour.Location = new Point(21, 184);
            buttonfour.Name = "buttonfour";
            buttonfour.Size = new Size(75, 75);
            buttonfour.TabIndex = 4;
            buttonfour.Text = "4";
            buttonfour.UseVisualStyleBackColor = false;
            buttonfour.Click += button_click;
            // 
            // buttonfive
            // 
            buttonfive.BackColor = SystemColors.ControlLight;
            buttonfive.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonfive.Location = new Point(97, 184);
            buttonfive.Name = "buttonfive";
            buttonfive.Size = new Size(75, 75);
            buttonfive.TabIndex = 5;
            buttonfive.Text = "5";
            buttonfive.UseVisualStyleBackColor = false;
            buttonfive.Click += button_click;
            // 
            // buttonsix
            // 
            buttonsix.BackColor = SystemColors.ControlLight;
            buttonsix.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsix.Location = new Point(173, 184);
            buttonsix.Name = "buttonsix";
            buttonsix.Size = new Size(75, 75);
            buttonsix.TabIndex = 6;
            buttonsix.Text = "6";
            buttonsix.UseVisualStyleBackColor = false;
            buttonsix.Click += button_click;
            // 
            // buttonmultiplication
            // 
            buttonmultiplication.BackColor = SystemColors.ControlLight;
            buttonmultiplication.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonmultiplication.Location = new Point(249, 184);
            buttonmultiplication.Name = "buttonmultiplication";
            buttonmultiplication.Size = new Size(75, 75);
            buttonmultiplication.TabIndex = 7;
            buttonmultiplication.Text = "*";
            buttonmultiplication.UseVisualStyleBackColor = false;
            buttonmultiplication.Click += operator_click;
            // 
            // buttonone
            // 
            buttonone.BackColor = SystemColors.ControlLight;
            buttonone.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonone.Location = new Point(21, 260);
            buttonone.Name = "buttonone";
            buttonone.Size = new Size(75, 75);
            buttonone.TabIndex = 8;
            buttonone.Text = "1";
            buttonone.UseVisualStyleBackColor = false;
            buttonone.Click += button_click;
            // 
            // buttontwo
            // 
            buttontwo.BackColor = SystemColors.ControlLight;
            buttontwo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttontwo.Location = new Point(97, 260);
            buttontwo.Name = "buttontwo";
            buttontwo.Size = new Size(75, 75);
            buttontwo.TabIndex = 9;
            buttontwo.Text = "2";
            buttontwo.UseVisualStyleBackColor = false;
            buttontwo.Click += button_click;
            // 
            // buttonthree
            // 
            buttonthree.BackColor = SystemColors.ControlLight;
            buttonthree.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonthree.Location = new Point(173, 260);
            buttonthree.Name = "buttonthree";
            buttonthree.Size = new Size(75, 75);
            buttonthree.TabIndex = 10;
            buttonthree.Text = "3";
            buttonthree.UseVisualStyleBackColor = false;
            buttonthree.Click += button_click;
            // 
            // buttonzero
            // 
            buttonzero.BackColor = SystemColors.ControlLight;
            buttonzero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonzero.Location = new Point(22, 336);
            buttonzero.Name = "buttonzero";
            buttonzero.Size = new Size(150, 75);
            buttonzero.TabIndex = 12;
            buttonzero.Text = "0";
            buttonzero.UseVisualStyleBackColor = false;
            buttonzero.Click += button_click;
            // 
            // buttonpoint
            // 
            buttonpoint.BackColor = SystemColors.ControlLight;
            buttonpoint.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonpoint.Location = new Point(173, 336);
            buttonpoint.Name = "buttonpoint";
            buttonpoint.Size = new Size(75, 75);
            buttonpoint.TabIndex = 14;
            buttonpoint.Text = ".";
            buttonpoint.UseVisualStyleBackColor = false;
            buttonpoint.Click += button_click;
            // 
            // buttonequalsto
            // 
            buttonequalsto.BackColor = SystemColors.MenuHighlight;
            buttonequalsto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonequalsto.ForeColor = Color.White;
            buttonequalsto.Location = new Point(325, 260);
            buttonequalsto.Name = "buttonequalsto";
            buttonequalsto.Size = new Size(75, 150);
            buttonequalsto.TabIndex = 15;
            buttonequalsto.Text = " =";
            buttonequalsto.UseVisualStyleBackColor = false;
            buttonequalsto.Click += buttonequalsto_Click;
            // 
            // buttonclearall
            // 
            buttonclearall.BackColor = SystemColors.ControlLight;
            buttonclearall.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonclearall.Location = new Point(325, 108);
            buttonclearall.Name = "buttonclearall";
            buttonclearall.Size = new Size(75, 75);
            buttonclearall.TabIndex = 16;
            buttonclearall.Text = "CE";
            buttonclearall.UseVisualStyleBackColor = false;
            buttonclearall.Click += buttonclearall_Click;
            // 
            // buttonclear
            // 
            buttonclear.BackColor = SystemColors.ControlLight;
            buttonclear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonclear.Location = new Point(325, 184);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(75, 75);
            buttonclear.TabIndex = 17;
            buttonclear.Text = "C";
            buttonclear.UseVisualStyleBackColor = false;
            buttonclear.Click += buttonclear_Click;
            // 
            // buttonsubtraction
            // 
            buttonsubtraction.BackColor = SystemColors.ControlLight;
            buttonsubtraction.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsubtraction.Location = new Point(249, 260);
            buttonsubtraction.Name = "buttonsubtraction";
            buttonsubtraction.Size = new Size(75, 75);
            buttonsubtraction.TabIndex = 18;
            buttonsubtraction.Text = "-";
            buttonsubtraction.UseVisualStyleBackColor = false;
            buttonsubtraction.Click += operator_click;
            // 
            // buttonaddition
            // 
            buttonaddition.BackColor = SystemColors.ControlLight;
            buttonaddition.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonaddition.Location = new Point(249, 336);
            buttonaddition.Name = "buttonaddition";
            buttonaddition.Size = new Size(75, 75);
            buttonaddition.TabIndex = 19;
            buttonaddition.Text = "+";
            buttonaddition.UseVisualStyleBackColor = false;
            buttonaddition.Click += operator_click;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Result.Location = new Point(21, 57);
            textBox_Result.Multiline = true;
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(378, 46);
            textBox_Result.TabIndex = 20;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.BackColor = Color.White;
            labelCurrentOperation.Location = new Point(24, 22);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 32);
            labelCurrentOperation.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(423, 435);
            Controls.Add(label1);
            Controls.Add(labelCurrentOperation);
            Controls.Add(textBox_Result);
            Controls.Add(buttonaddition);
            Controls.Add(buttonsubtraction);
            Controls.Add(buttonclear);
            Controls.Add(buttonclearall);
            Controls.Add(buttonequalsto);
            Controls.Add(buttonpoint);
            Controls.Add(buttonzero);
            Controls.Add(buttonthree);
            Controls.Add(buttontwo);
            Controls.Add(buttonone);
            Controls.Add(buttonmultiplication);
            Controls.Add(buttonsix);
            Controls.Add(buttonfive);
            Controls.Add(buttonfour);
            Controls.Add(buttondivision);
            Controls.Add(buttonnine);
            Controls.Add(buttoneight);
            Controls.Add(buttonseven);
            Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonseven;
        private Button buttoneight;
        private Button buttonnine;
        private Button buttondivision;
        private Button buttonfour;
        private Button buttonfive;
        private Button buttonsix;
        private Button buttonmultiplication;
        private Button buttonone;
        private Button buttontwo;
        private Button buttonthree;
        private Button buttonzero;
        private Button buttonpoint;
        private Button buttonequalsto;
        private Button buttonclearall;
        private Button buttonclear;
        private Button buttonsubtraction;
        private Button buttonaddition;
        private TextBox textBox_Result;
        private Label labelCurrentOperation;
        private Label label1;
    }
}
