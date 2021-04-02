using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class OldStudentLB : LessonBuilder
    {
        // Burada nesne çağırma işlemleri gerçekleştirilmektedir.
        // Nasıl çağrılacağı tamamen geliştiriciye kalmıştır.
        // Çıktıyı görmek amacıyla 1-2 değer ataması yapılacaktır.
        public override void GetLesson()
        {
            lesson = new Lesson();
            lesson.id = 1;
            lesson.name = "Artificial Intelligence -  Beginner to Advanced in 10 Minute.";
            lesson.price = 49.99;
        }

        // Burada eski öğrenciler için geçerli derste herhangi bir indirim yapılmadı.
        public override void ApplyDiscount()
        {
            lesson.discountedPrice = lesson.price;
            lesson.discountApplied = false;
        }

        public override void AddLessonNote()
        {
            lesson.lessonNote = "";
        }

        public override Lesson GetResult()
        {
            return lesson;
        }
    }
}
