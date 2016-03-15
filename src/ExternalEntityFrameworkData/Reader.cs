using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTModels.Interfaces;
using Models.DTModels;

namespace DocuTrackerEF7.DAL
{
    public class Reader : IDTReader
    {

        private DTContext _context;
        public Reader(DTContext context)
        {
            _context = context;
        }

        public List<Answer> GetAllAnswers()
        {
            var list = _context.Answers.ToList();
            var item = list.Where(x => x.ID == 1).SingleOrDefault();
            var qa = _context.QuestionAnswers.ToList();
            var questions = _context.Questions.ToList();

            var newlist = item.QuestionAnswer.Select(y => y.Question);
            //var qanda = _context.Questions.SelectMany(a => a.QuestionAnswer).ToList();
            //var ansList = item.QuestionAnswers.Select(c => c.Question);

            return list;
        }

        public List<Question> GetAllQuestions()
        {
            var list = _context.Questions.ToList();
            return list;
        }

        public List<QuestionAnswer> GetAllQuestionAnswers()
        {
            var list = _context.QuestionAnswers.ToList();
            return list;
        }

        public List<AnswerType> GetAllAnswerTypes()
        {
            var list = _context.AnswerTypes.ToList();
            return list;
        }

        public List<InternalAnswer> GetAllInternalAnswers()
        {
            var list = _context.InternalAnswers.ToList();
            return list;

        }
    }
}
