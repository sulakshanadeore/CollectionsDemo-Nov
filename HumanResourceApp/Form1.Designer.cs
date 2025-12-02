namespace HumanResourceApp
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
            label1 = new Label();
            txtEmpid = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtDeptno = new TextBox();
            btnAdd = new Button();
            listBox1 = new ListBox();
            btnshow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 76);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter EmployeeID:";
            // 
            // txtEmpid
            // 
            txtEmpid.Location = new Point(329, 73);
            txtEmpid.Name = "txtEmpid";
            txtEmpid.Size = new Size(125, 27);
            txtEmpid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 123);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter EmployeeNAme";
            // 
            // txtName
            // 
            txtName.Location = new Point(351, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 167);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 4;
            label3.Text = "Entter Deptno";
            // 
            // txtDeptno
            // 
            txtDeptno.Location = new Point(339, 167);
            txtDeptno.Name = "txtDeptno";
            txtDeptno.Size = new Size(125, 27);
            txtDeptno.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 228);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(167, 49);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(520, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(245, 204);
            listBox1.TabIndex = 7;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(190, 228);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(116, 49);
            btnshow.TabIndex = 8;
            btnshow.Text = "Show All Employees";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnshow);
            Controls.Add(listBox1);
            Controls.Add(btnAdd);
            Controls.Add(txtDeptno);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtEmpid);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmpid;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtDeptno;
        private Button btnAdd;
        private ListBox listBox1;
        private Button btnshow;
    }
}
