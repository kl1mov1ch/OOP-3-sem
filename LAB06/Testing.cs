﻿using System;
using System.Diagnostics;
using System.Security.Authentication.ExtendedProtection.Configuration;

namespace LAB04
{
    public abstract class Testing
    {
        public string question { get; set; }
        public string complexity { get; set; }
        public int Count = 0;
        public string Name;

        enum MyTest        
        {
            Test,
            Exam, 
            FinalExam,
            Question
        }

        public virtual void AskQestion()
        {
            Console.WriteLine("Сдал");
        }

        public abstract void GetQuestionType();
    }
    ///////////////////////////////////////////////////////////ASSERT///////////////////////////////////////////////////////////
    // тест
    public class Test : Testing, IGetQuestion
    { 
        public Test(string qestion, int count, string Name)
        {
            Debug.Assert(count < 0, "count < 0");
            question = qestion;
            Count = count;
            this.Name = Name;
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
            return $"Тип {this.GetType()}, название {this.question}, кол. вопросов {Count}, имя: {Name}";
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
                Count = 15;
            }

            public Exam(string Qestion, int count)
            {
                question = Qestion;
                Count = count;
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
                return $"Тип {this.GetType()}, название {this.question}, кол. вопросов {Count}";
            }
        }
        //Экзамен
        public class FinalExam : Testing, IGetQuestion
        {
            public FinalExam()
            {
                question = "Экзамен";
                Count = 30;
            }

            public FinalExam(string Qestion, int count)
            {
                try
                {
                    question = Qestion;
                    Count = count;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Source);
                    throw new Exception("bebra");
                }
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
                return $"Тип {this.GetType()}, название {this.question},  кол. вопросов {Count}";
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
                return $"Тип {this.GetType()}, название {this.question}, сложность: {this.complexity}";
            }
        }
    }
}
