using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class LessonDirector
    {
        private LessonBuilder lessonBuilder;

        public LessonDirector(LessonBuilder lessonBuilder)
        {
            this.lessonBuilder = lessonBuilder;
        }

        public void Make()
        {
            lessonBuilder.GetLesson();
            lessonBuilder.ApplyDiscount();
            lessonBuilder.AddLessonNote();
        }
    }
}
