using System;
using System.Diagnostics;

namespace LAB04
{
    class TestException : Exception
    {
        public string ErrorInClass { get;}
        public TestException(string massege, string errorInClass) : base(massege)
        {
            Debug.Assert(errorInClass != null, "ErrorInClass null");
            ErrorInClass = errorInClass;
        }
    }

    class ExamExcaption : TestException
    {
        public string Exam { get;} 
        public ExamExcaption(string errorInClass, string exam, string massege = null) : base(massege, errorInClass)
        {
            Exam = exam;
        }
    }

    class QuetionException : TestException
    {
        public int numberQuestion { get;}
        public QuetionException(string massege, string errorInClass, int numberQuestion) : base(massege, errorInClass)
        {
            this.numberQuestion = numberQuestion;
        }
    }


}
