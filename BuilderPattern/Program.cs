using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LessonBuilder lessonBuilder = new NewStudentLB();

            LessonDirector lessonDirector = new LessonDirector(lessonBuilder);
            lessonDirector.Make();

            Lesson lesson = lessonBuilder.GetResult();

            Console.WriteLine($"{lesson.name} - {lesson.price} - {lesson.discountedPrice}");
            Console.WriteLine("Hello World!");
        }
    }
}
