namespace GradeCalculator
{
    partial class From1
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.grpMarks = new System.Windows.Forms.GroupBox();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.lblAssignmentWeight = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lblTestWeight = new System.Windows.Forms.Label();
            this.lblFinalExam = new System.Windows.Forms.Label();
            this.lblFinalWeight = new System.Windows.Forms.Label();
            this.txtFinalExam = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblFinalMark = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpMarks.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(782, 110);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(161, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STUDENT GRADE CALCULATOR";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(210, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(219, 16);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Calculate and review student results";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.txtStudentID);
            this.grpStudent.Controls.Add(this.lblStudentID);
            this.grpStudent.Controls.Add(this.txtStudentName);
            this.grpStudent.Controls.Add(this.lblStudentName);
            this.grpStudent.Location = new System.Drawing.Point(11, 116);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(759, 119);
            this.grpStudent.TabIndex = 1;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Information";
            this.grpStudent.Enter += new System.EventHandler(this.grpStudent_Enter);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(24, 39);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(92, 16);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(153, 36);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 22);
            this.txtStudentName.TabIndex = 1;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(440, 42);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(68, 16);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID";
            this.lblStudentID.Click += new System.EventHandler(this.lblStudentID_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(545, 36);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 3;
            // 
            // grpMarks
            // 
            this.grpMarks.Controls.Add(this.txtFinalExam);
            this.grpMarks.Controls.Add(this.lblFinalWeight);
            this.grpMarks.Controls.Add(this.lblFinalExam);
            this.grpMarks.Controls.Add(this.lblTestWeight);
            this.grpMarks.Controls.Add(this.txtTest);
            this.grpMarks.Controls.Add(this.lblTest);
            this.grpMarks.Controls.Add(this.lblAssignmentWeight);
            this.grpMarks.Controls.Add(this.txtAssignment);
            this.grpMarks.Controls.Add(this.lblAssignment);
            this.grpMarks.Location = new System.Drawing.Point(12, 241);
            this.grpMarks.Name = "grpMarks";
            this.grpMarks.Size = new System.Drawing.Size(758, 140);
            this.grpMarks.TabIndex = 4;
            this.grpMarks.TabStop = false;
            this.grpMarks.Text = "Assessment Marks";
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Location = new System.Drawing.Point(23, 40);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(77, 16);
            this.lblAssignment.TabIndex = 0;
            this.lblAssignment.Text = "Assignment";
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(152, 33);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(100, 22);
            this.txtAssignment.TabIndex = 1;
            // 
            // lblAssignmentWeight
            // 
            this.lblAssignmentWeight.AutoSize = true;
            this.lblAssignmentWeight.Location = new System.Drawing.Point(314, 39);
            this.lblAssignmentWeight.Name = "lblAssignmentWeight";
            this.lblAssignmentWeight.Size = new System.Drawing.Size(33, 16);
            this.lblAssignmentWeight.TabIndex = 2;
            this.lblAssignmentWeight.Text = "30%";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(23, 66);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(34, 16);
            this.lblTest.TabIndex = 3;
            this.lblTest.Text = "Test";
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(152, 66);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 22);
            this.txtTest.TabIndex = 4;
            // 
            // lblTestWeight
            // 
            this.lblTestWeight.AutoSize = true;
            this.lblTestWeight.Location = new System.Drawing.Point(314, 69);
            this.lblTestWeight.Name = "lblTestWeight";
            this.lblTestWeight.Size = new System.Drawing.Size(33, 16);
            this.lblTestWeight.TabIndex = 5;
            this.lblTestWeight.Text = "20%";
            // 
            // lblFinalExam
            // 
            this.lblFinalExam.AutoSize = true;
            this.lblFinalExam.Location = new System.Drawing.Point(23, 95);
            this.lblFinalExam.Name = "lblFinalExam";
            this.lblFinalExam.Size = new System.Drawing.Size(73, 16);
            this.lblFinalExam.TabIndex = 6;
            this.lblFinalExam.Text = "Final Exam";
            // 
            // lblFinalWeight
            // 
            this.lblFinalWeight.AutoSize = true;
            this.lblFinalWeight.Location = new System.Drawing.Point(314, 101);
            this.lblFinalWeight.Name = "lblFinalWeight";
            this.lblFinalWeight.Size = new System.Drawing.Size(33, 16);
            this.lblFinalWeight.TabIndex = 7;
            this.lblFinalWeight.Text = "50%";
            this.lblFinalWeight.Click += new System.EventHandler(this.lblFinalWeight_Click);
            // 
            // txtFinalExam
            // 
            this.txtFinalExam.Location = new System.Drawing.Point(152, 95);
            this.txtFinalExam.Name = "txtFinalExam";
            this.txtFinalExam.Size = new System.Drawing.Size(100, 22);
            this.txtFinalExam.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(189, 397);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 40);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Result";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(435, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblStatus);
            this.grpResult.Controls.Add(this.lblGrade);
            this.grpResult.Controls.Add(this.lblFinalMark);
            this.grpResult.Location = new System.Drawing.Point(11, 457);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(759, 110);
            this.grpResult.TabIndex = 7;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result Summary";
            // 
            // lblFinalMark
            // 
            this.lblFinalMark.AutoSize = true;
            this.lblFinalMark.Location = new System.Drawing.Point(24, 40);
            this.lblFinalMark.Name = "lblFinalMark";
            this.lblFinalMark.Size = new System.Drawing.Size(83, 16);
            this.lblFinalMark.TabIndex = 0;
            this.lblFinalMark.Text = "Final Mark: --";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(315, 40);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(68, 16);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "  Grade: -- ";
            this.lblGrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(579, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 16);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: --";
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpMarks);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "From1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grade Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpMarks.ResumeLayout(false);
            this.grpMarks.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.GroupBox grpMarks;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblAssignmentWeight;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.Label lblFinalExam;
        private System.Windows.Forms.Label lblTestWeight;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtFinalExam;
        private System.Windows.Forms.Label lblFinalWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblFinalMark;
    }
}

