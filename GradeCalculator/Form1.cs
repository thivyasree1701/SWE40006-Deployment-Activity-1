using System;
using System.Drawing;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();

            // Button events
            btnCalculate.Click += btnCalculate_Click;
            btnClear.Click += btnClear_Click;

            // Apply modern design
            ApplyTheme();
        }

        // =====================================================
        // CALCULATE RESULT
        // =====================================================
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string studentID = txtStudentID.Text.Trim();

            // =================================================
            // VALIDATE STUDENT NAME USING DLL
            // =================================================
            if (!StudentValidationLibrary.ValidationService.IsValidName(studentName))
            {
                MessageBox.Show(
                    "Please enter a valid student name using letters only.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentName.Focus();
                return;
            }

            // =================================================
            // VALIDATE STUDENT ID USING DLL
            // =================================================
            if (!StudentValidationLibrary.ValidationService.IsValidStudentId(studentID))
            {
                MessageBox.Show(
                    "Please enter a valid student ID, for example J123456 or 10234567.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStudentID.Focus();
                return;
            }

            // =================================================
            // VALIDATE ASSIGNMENT
            // =================================================
            if (!double.TryParse(txtAssignment.Text, out double assignment))
            {
                ShowMarkError("Assignment");
                txtAssignment.Focus();
                return;
            }

            // =================================================
            // VALIDATE TEST
            // =================================================
            if (!double.TryParse(txtTest.Text, out double test))
            {
                ShowMarkError("Test");
                txtTest.Focus();
                return;
            }

            // =================================================
            // VALIDATE FINAL EXAM
            // =================================================
            if (!double.TryParse(txtFinalExam.Text, out double finalExam))
            {
                ShowMarkError("Final Exam");
                txtFinalExam.Focus();
                return;
            }

            // =================================================
            // VALIDATE MARK RANGES USING DLL
            // =================================================
            if (!StudentValidationLibrary.ValidationService.IsValidMark(assignment))
            {
                ShowRangeError("Assignment");
                txtAssignment.Focus();
                return;
            }

            if (!StudentValidationLibrary.ValidationService.IsValidMark(test))
            {
                ShowRangeError("Test");
                txtTest.Focus();
                return;
            }

            if (!StudentValidationLibrary.ValidationService.IsValidMark(finalExam))
            {
                ShowRangeError("Final Exam");
                txtFinalExam.Focus();
                return;
            }

            // =================================================
            // WEIGHTED FINAL MARK
            // Assignment = 30%
            // Test = 20%
            // Final Exam = 50%
            // =================================================
            double finalMark =
                (assignment * 0.30) +
                (test * 0.20) +
                (finalExam * 0.50);

            // =================================================
            // GET GRADE USING GradeCalculatorLibrary.dll
            // =================================================
            string grade =
                GradeCalculatorLibrary.GradeService.GetGrade(
                    (int)Math.Round(finalMark));

            // Pass mark = 50
            string status =
                finalMark >= 50 ? "PASS" : "FAIL";

            // =================================================
            // DISPLAY RESULTS
            // =================================================
            lblFinalMark.Text =
                "Final Mark: " + finalMark.ToString("0.00");

            lblGrade.Text =
                "Grade: " + grade;

            lblStatus.Text =
                "Status: " + status;

            // Change status colour
            if (status == "PASS")
            {
                lblStatus.ForeColor =
                    Color.FromArgb(22, 163, 74);
            }
            else
            {
                lblStatus.ForeColor =
                    Color.FromArgb(220, 38, 38);
            }
        }

        // =====================================================
        // CLEAR BUTTON
        // =====================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentID.Clear();
            txtAssignment.Clear();
            txtTest.Clear();
            txtFinalExam.Clear();

            lblFinalMark.Text =
                "Final Mark: --";

            lblGrade.Text =
                "Grade: --";

            lblStatus.Text =
                "Status: --";

            lblStatus.ForeColor =
                Color.FromArgb(71, 85, 105);

            txtStudentName.Focus();
        }

        // =====================================================
        // INVALID MARK MESSAGE
        // =====================================================
        private void ShowMarkError(string fieldName)
        {
            MessageBox.Show(
                "Please enter a valid number for " + fieldName + ".",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        // =====================================================
        // OUT OF RANGE MESSAGE
        // =====================================================
        private void ShowRangeError(string fieldName)
        {
            MessageBox.Show(
                fieldName + " mark must be between 0 and 100.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        // =====================================================
        // APPLICATION DESIGN / STYLING
        // WinForms equivalent of CSS
        // =====================================================
        private void ApplyTheme()
        {
            // =================================================
            // MAIN FORM
            // =================================================
            this.BackColor =
                Color.FromArgb(241, 245, 249);

            this.Font =
                new Font("Segoe UI", 10F);

            this.Text =
                "Student Grade Calculator";

            // =================================================
            // HEADER
            // =================================================
            pnlHeader.BackColor =
                Color.FromArgb(30, 64, 175);

            lblTitle.ForeColor =
                Color.White;

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    19F,
                    FontStyle.Bold);

            lblSubtitle.ForeColor =
                Color.FromArgb(219, 234, 254);

            lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            // =================================================
            // STUDENT INFORMATION
            // =================================================
            StyleGroupBox(grpStudent);

            lblStudentName.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            lblStudentID.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            StyleTextBox(txtStudentName);
            StyleTextBox(txtStudentID);

            // =================================================
            // ASSESSMENT MARKS
            // =================================================
            StyleGroupBox(grpMarks);

            lblAssignment.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            lblTest.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            lblFinalExam.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            StyleTextBox(txtAssignment);
            StyleTextBox(txtTest);
            StyleTextBox(txtFinalExam);

            // Weight labels
            lblAssignmentWeight.ForeColor =
                Color.FromArgb(37, 99, 235);

            lblTestWeight.ForeColor =
                Color.FromArgb(37, 99, 235);

            lblFinalWeight.ForeColor =
                Color.FromArgb(37, 99, 235);

            lblAssignmentWeight.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblTestWeight.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblFinalWeight.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            // =================================================
            // CALCULATE BUTTON
            // =================================================
            btnCalculate.BackColor =
                Color.FromArgb(37, 99, 235);

            btnCalculate.ForeColor =
                Color.White;

            btnCalculate.FlatStyle =
                FlatStyle.Flat;

            btnCalculate.FlatAppearance.BorderSize =
                0;

            btnCalculate.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            btnCalculate.Cursor =
                Cursors.Hand;

            // =================================================
            // CLEAR BUTTON
            // =================================================
            btnClear.BackColor =
                Color.FromArgb(226, 232, 240);

            btnClear.ForeColor =
                Color.FromArgb(30, 41, 59);

            btnClear.FlatStyle =
                FlatStyle.Flat;

            btnClear.FlatAppearance.BorderColor =
                Color.FromArgb(203, 213, 225);

            btnClear.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            btnClear.Cursor =
                Cursors.Hand;

            // =================================================
            // RESULT SUMMARY
            // =================================================
            StyleGroupBox(grpResult);

            lblFinalMark.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblGrade.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblFinalMark.ForeColor =
                Color.FromArgb(15, 23, 42);

            lblGrade.ForeColor =
                Color.FromArgb(37, 99, 235);

            lblStatus.ForeColor =
                Color.FromArgb(71, 85, 105);

            // Press Enter = Calculate
            this.AcceptButton =
                btnCalculate;
        }

        // =====================================================
        // GROUPBOX STYLE
        // =====================================================
        private void StyleGroupBox(GroupBox box)
        {
            box.BackColor =
                Color.White;

            box.ForeColor =
                Color.FromArgb(30, 41, 59);

            box.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);
        }

        // =====================================================
        // TEXTBOX STYLE
        // =====================================================
        private void StyleTextBox(TextBox textBox)
        {
            textBox.Font =
                new Font(
                    "Segoe UI",
                    10F);

            textBox.BackColor =
                Color.White;

            textBox.ForeColor =
                Color.FromArgb(15, 23, 42);

            textBox.BorderStyle =
                BorderStyle.FixedSingle;
        }

        // =====================================================
        // DESIGNER EVENT METHODS
        // Keep because Designer currently references them
        // =====================================================

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void grpStudent_Enter(object sender, EventArgs e)
        {
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
        }

        private void lblFinalWeight_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }
    }
}