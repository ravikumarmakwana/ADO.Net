namespace MyFirstUIApplication
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
            this.ename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mgr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hiredate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deptno = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.empno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ename
            // 
            this.ename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ename.Location = new System.Drawing.Point(276, 109);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(169, 26);
            this.ename.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mgr";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mgr
            // 
            this.mgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgr.Location = new System.Drawing.Point(276, 199);
            this.mgr.Name = "mgr";
            this.mgr.Size = new System.Drawing.Size(169, 26);
            this.mgr.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Job";
            // 
            // job
            // 
            this.job.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job.Location = new System.Drawing.Point(276, 153);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(169, 26);
            this.job.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hiredate";
            // 
            // hiredate
            // 
            this.hiredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiredate.Location = new System.Drawing.Point(276, 247);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(169, 26);
            this.hiredate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salary";
            // 
            // sal
            // 
            this.sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal.Location = new System.Drawing.Point(276, 293);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(169, 26);
            this.sal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Commission";
            // 
            // comm
            // 
            this.comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comm.Location = new System.Drawing.Point(276, 341);
            this.comm.Name = "comm";
            this.comm.Size = new System.Drawing.Size(169, 26);
            this.comm.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Deptartment Number";
            // 
            // deptno
            // 
            this.deptno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptno.Location = new System.Drawing.Point(276, 390);
            this.deptno.Name = "deptno";
            this.deptno.Size = new System.Drawing.Size(169, 26);
            this.deptno.TabIndex = 17;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(597, 139);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(99, 44);
            this.submit.TabIndex = 19;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Crimson;
            this.result.Location = new System.Drawing.Point(541, 221);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Employee No.";
            // 
            // empno
            // 
            this.empno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empno.Location = new System.Drawing.Point(276, 62);
            this.empno.Name = "empno";
            this.empno.Size = new System.Drawing.Size(169, 26);
            this.empno.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(227, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Employee Data Entry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.empno);
            this.Controls.Add(this.result);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deptno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.job);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mgr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ename);
            this.Name = "Form1";
            this.Text = "Employee Data Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mgr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hiredate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox comm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deptno;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empno;
        private System.Windows.Forms.Label label9;
    }
}

