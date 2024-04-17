using Classes; // inkludiert die Klasse Student (glaube ich zumindest)

Console.Clear(); // für Ordnung am Arbeitsplatz

Student s1 = new("Anna",3); // erstellt Student s1 mit Name = "Anna" und Semester = 3 
Student s2 = new("Bert",4); // ...
Student s3 = new("Tom",1); // ...

object[] Students = [s1,s2,s3]; // steckt alle Students in ein Array

ITPlanung(Students, 3); // ruft die Methode ab mit dem Array Students und minSemester = 3


static void ITPlanung(object[] students, int minSemester) // Methode mit dem Array
{
    foreach(Student s in students) // für jedes Item im Array Students
    {
        if(s.Semester >= minSemester) // wenn das Semester größer-gleich dem minSemester ist
        {
            Console.WriteLine($"{s.Name} ist im {s.Semester}. Semester"); // outputet den Namen und das Semester des Items
        }
    }
}

/*

Das hier steht in einer separaten Datei mit dem Namen Student.cs

namespace Classes
{
    public class Student(string name, int semester)
    {
        public string Name { get; set; } = name;
        public int Semester { get; set; } = semester;
    }
}

*/