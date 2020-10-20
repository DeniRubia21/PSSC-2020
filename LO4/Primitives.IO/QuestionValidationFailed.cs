using System.Collections.Generic;

namespace AskQuestionResult
{
    public class QuestionValidationFailed
    {
        private List<string> _error;

        public QuestionValidationFailed(List<string> error)
        {
            _error = error;
        }
    }
}