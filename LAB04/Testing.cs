using System;

namespace LAB04
{
    public abstract class Testing
    {
        public string question { get; set; }
        public string complexity { get; set; }

        public virtual void AskQestion()
        {
            Console.WriteLine("Сдал");
        }

        public abstract void GetQuestionType();
    }

    // тест
    public class Test : Testing, IGetQuestion
    {
        public Test()
        {
            question = "Тест";
        }

        public Test(string Qestion)
        {
            question = Qestion;
        }

        public override void AskQestion()
        {
            Console.WriteLine("Тест сдан");
        }

        public void AskQest()
        {
            Console.WriteLine("Вы сделали тест");
        }

        public override void GetQuestionType()
        {
            Console.WriteLine("Тест сдан");
        }

        void IGetQuestion.GetQuestionType()
        {
            Console.WriteLine("Тест профукан");
        }

        public override string ToString()
        {
            return $"Тип {this.GetType()}, название {this.question}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Экзамен
        public class Exam : Testing, IGetQuestion
        {
            public Exam()
            {
                question = "Экзамен";
            }

            public Exam(string Qestion)
            {
                question = Qestion;
            }

            public override void AskQestion()
            {
                Console.WriteLine("Экзамен сдан");
            }

            public void AskQest()
            {
                Console.WriteLine("Экзамен сдан");
            }

            public override void GetQuestionType()
            {
                Console.WriteLine("Экзамен");
            }

            void IGetQuestion.GetQuestionType()
            {
                Console.WriteLine("Экзамен профукан");
            }

            public override string ToString()
            {
                return $"Тип {this.GetType()}, название {this.question}";
            }
        }
        //Экзамен
        public class FinalExam : Testing, IGetQuestion
        {
            public FinalExam()
            {
                question = "Экзамен";
            }

            public FinalExam(string Qestion)
            {
                question = Qestion;
            }

            public override void AskQestion()
            {
                Console.WriteLine("Выпускной экзамен сдан");
            }

            public void AskQest()
            {
                Console.WriteLine("Выпускной экзамен сдан");
            }

            public override void GetQuestionType()
            {
                Console.WriteLine("Выпускной экзамен");
            }

            void IGetQuestion.GetQuestionType()
            {
                Console.WriteLine("Выпускной экзамен профукан");
            }

            public override string ToString()
            {
                return $"Тип {this.GetType()}, название {this.question}";
            }
        }

        public class Question : Testing, IGetQuestion
        {
            public Question()
            {
                question = "Экзамен";
                complexity = "сложный";
            }

            public Question(string Qestion, string Complexity)
            {
                question = Qestion;
                complexity = Complexity;
            }

            public Question(string v)
            {
                complexity = complexity;
            }

            public override void AskQestion()
            {
                Console.WriteLine("Вопрос сдан");
            }

            public void AskQest()
            {
                Console.WriteLine("Вопрос сдан");
            }

            public override void GetQuestionType()
            {
                Console.WriteLine("Вопрос");
            }

            void IGetQuestion.GetQuestionType()
            {
                Console.WriteLine("Вопрос профукан");
            }

            public override string ToString()
            {
                return $"Тип {this.GetType()}, название {this.question} {complexity}";
            }
        }
    }
}
