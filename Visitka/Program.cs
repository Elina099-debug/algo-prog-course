string fullName = "Игнашова Эллина";
string groupName = "ИСП-254";
int courseNumber = 2;
string specialty = "09.02.07";
int weeksPassed = 2;
const int SemesterWeeks = 16;

int grade1 = 5;
int grade2 = 5;
int grade3 = 4;

// Приводим сумму к double до деления
double averageGrade = (double)(grade1 + grade2 + grade3) / 3;
// Стипендия положена при среднем балле от 4.0
bool hasScholarship = averageGrade >= 4.0;
int weeksLeft = SemesterWeeks - weeksPassed;

Console.WriteLine("====================================");
Console.WriteLine("      ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.WriteLine();
Console.WriteLine($"ФИО:           {fullName}");
Console.WriteLine($"Группа:        {groupName}");
Console.WriteLine($"Курс:          {courseNumber}");
Console.WriteLine($"Специальность: {specialty}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {averageGrade:F2}");
Console.WriteLine($"Стипендия положена (>= 4.0): {hasScholarship}");
Console.WriteLine();
Console.WriteLine($"Учебных недель осталось в семестре: {weeksLeft}");