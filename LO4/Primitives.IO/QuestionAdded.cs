using System;

namespace AskQuestionResult
{
    public class QuestionAdded
    {
        private Guid id;
        private object title;
        private object text;
        private object tags;

        public QuestionAdded(Guid id, object title, object text, object tags)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.tags = tags;
        }
    }
}