using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
namespace StudentValidationLibrary
{
    public class ValidationService
    {
        // =====================================================
        // VALIDATE STUDENT NAME
        // =====================================================
        
        public static bool IsValidName(string studentName)
        {
            if (string.IsNullOrWhiteSpace(studentName))
            {
                return false;
            }

            studentName = studentName.Trim();

            return studentName.All(c =>
                char.IsLetter(c) ||
                char.IsWhiteSpace(c) ||
                c == '-' ||
                c == '\'' ||
                c == '/');
        }

        // =====================================================
        // VALIDATE STUDENT ID
        // =====================================================
        
        public static bool IsValidStudentId(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
            {
                return false;
            }

            studentId = studentId.Trim();

            // Format 1:
            // Numbers only
            if (studentId.All(char.IsDigit))
            {
                return true;
            }

            // Format 2:
            // First character is a letter
            // Remaining characters are numbers
            if (studentId.Length >= 2 &&
                char.IsLetter(studentId[0]) &&
                studentId.Skip(1).All(char.IsDigit))
            {
                return true;
            }

            return false;
        }

        // =====================================================
        // VALIDATE ASSESSMENT MARK
        // =====================================================
        // Mark must be between 0 and 100
        // =====================================================
        public static bool IsValidMark(double mark)
        {
            return mark >= 0 && mark <= 100;
        }
    }
}