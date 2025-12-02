namespace HumanResourceApp
{
    partial class Form2
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
            txtfno = new TextBox();
            txtsno = new TextBox();
            button1 = new Button();
            txtans = new TextBox();
            SuspendLayout();
            // 
            // txtfno
            // 
            txtfno.Location = new Point(311, 61);
            txtfno.Name = "txtfno";
            txtfno.Size = new Size(125, 27);
            txtfno.TabIndex = 0;
            // 
            // txtsno
            // 
            txtsno.Location = new Point(311, 111);
            txtsno.Name = "txtsno";
            txtsno.Size = new Size(125, 27);
            txtsno.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(329, 229);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Divide Nos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtans
            // 
            txtans.Location = new Point(311, 166);
            txtans.Name = "txtans";
            txtans.Size = new Size(125, 27);
            txtans.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtans);
            Controls.Add(button1);
            Controls.Add(txtsno);
            Controls.Add(txtfno);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtfno;
        private TextBox txtsno;
        private Button button1;
        private TextBox txtans;
    }
}