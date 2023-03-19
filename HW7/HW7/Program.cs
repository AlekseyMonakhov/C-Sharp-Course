// See https://aka.ms/new-console-template for more information
using HW7;
using System.ComponentModel;
using System.Globalization;

var student = new Student("Aleksey", "Monakhov", "EU21", 4.02);
var student1 = new Student("Aleksey", "Monakhov", "EU21", 5);
var student2 = new Student("Aleksey", "Monakhov", "EU21", 2.02);
var aspirant = new Aspirant("Aleksey", "Monakhov", "EU21", 5);
var aspirant1 = new Aspirant("Aleksey", "Monakhov", "EU21", 2);
var aspirant2 = new Aspirant("Aleksey", "Monakhov", "EU21", 3);

List<Student> students = new List<Student> { student, aspirant, student1, student2, aspirant1, aspirant2 };

for (int i = 0; i < students.Count; i++)
{
    students[i].GetScholarship();

}


var res = NumConverter.ConvertDoubleToArray(123.234321341234134);
for (int i = 0; i < res.Count; i++)
{
    Console.WriteLine(res[i]);
}