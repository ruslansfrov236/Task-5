
Student student = new Student();
student.Grades = new int[] { 2, 3, 4, 5, 6, 7, 8, 8 };

int[] evenGrades = student.Grades;
foreach (var item in evenGrades)

    Console.WriteLine($"cut olan ededler:{item} ");
public class Student
{
  

    private int[] grades;

    public int[] Grades
    {
        get
        {
            if (grades == null)
            {
                return new int[0];
            }

            return grades.Where(grade => grade % 2 == 0).ToArray();
        }
        set
        {
            if (value == null)
            {
                grades = new int[0];
            }
            else
            {
                grades = value.Where(grade => grade % 2 == 0).ToArray();
            }
        }
    }
}
