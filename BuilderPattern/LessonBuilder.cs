using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    abstract class LessonBuilder
    {
        public Lesson lesson;

        public abstract void GetLesson();
        public abstract void ApplyDiscount();
        public abstract void AddLessonNote();
        public abstract Lesson GetResult();
    }
}
