using System;
using System.Collections.Generic;

namespace L04
{
    //sum type
    [AsChoice]
    public static partial class AskQuestionResult
    {
        public interface IAskQuestionResult
        {
            void Match(Func<QuestionAdded, string> processQuestionAdded, Func<QuestionNotAdded, string> processQuestionNotAdded, Func<QuestionValidationFailed, string> processQuestionValidationFailed);
        }

        public class QuestionAdded : IAskQuestionResult
        {
            public Guid Id { get; private set; }
            public string Title { get; private set; }
            public string Text { get; private set; }
            public List<string> Tags { get; private set; }

            public QuestionAdded(Guid _id, string _title, string _text, List<string> _tags)
            {
                Id = _id;
                Title = _title;
                Text = _text;
                Tags = _tags;
            }

            public void Match(Func<QuestionAdded, string> processQuestionAdded, Func<QuestionNotAdded, string> processQuestionNotAdded, Func<QuestionValidationFailed, string> processQuestionValidationFailed)
            {
                throw new NotImplementedException();
            }
        }

        public class QuestionNotAdded : IAskQuestionResult
        {
            public string ErrorMessage { get; set; }

            public QuestionNotAdded(string _errorMessage)
            {
                ErrorMessage = _errorMessage;
            }

            public void Match(Func<QuestionAdded, string> processQuestionAdded, Func<QuestionNotAdded, string> processQuestionNotAdded, Func<QuestionValidationFailed, string> processQuestionValidationFailed)
            {
                throw new NotImplementedException();
            }
        }

        public class QuestionValidationFailed : IAskQuestionResult
        {
            public List<string> ValidationErrros { get; set; }

            public QuestionValidationFailed(List<string> errors)
            {
                ValidationErrros = errors;
            }

            public void Match(Func<QuestionAdded, string> processQuestionAdded, Func<QuestionNotAdded, string> processQuestionNotAdded, Func<QuestionValidationFailed, string> processQuestionValidationFailed)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class AsChoiceAttribute : Attribute
    {
    }
}