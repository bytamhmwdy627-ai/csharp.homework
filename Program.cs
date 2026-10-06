using OopExercise;

var student = new Student { Name = "Sara", StudentId = 1001, Major = "Computer", Grade = 18.5 };
var dog = new Dog { Name = "Rex", Breed = "German Shepherd", Age = 3, Weight = 30 };

Console.WriteLine($"Student: {student.Name}, ID: {student.StudentId}");
Console.WriteLine($"Dog: {dog.Name}, Breed: {dog.Breed}");
