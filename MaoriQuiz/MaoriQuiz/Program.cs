using System;
using System.Collections.Generic;

namespace MaoriQuiz
{
    class Quiz
    {


        private static List<string> listUsersAnswers = new List<string>();
        private static List<string> listValidAnswers = new List<string> { "d", "a", "b", "d", "a", "c", "b", "d", "a", "c", "c", "d", "b", "c", "a" };
        private static List<string> ListWrongAnswers = new List<string>();

        static void Main(string[] args)
        {

            string answer;
            int iValidCount = 0;
            string carryOn = "yes";
            bool validInt = false;
            int age;
            List<string> QUIZ_QUESTIONS = new List<string>();
            QUIZ_QUESTIONS.Add("Quesiton 1: What is the maori name for grandma? \na) Kura \nb) Kaiako \nc) Whare \nd) kuia");
            QUIZ_QUESTIONS.Add("Quesiton 2: What is the maori name for school? \na) Kura \nb) Kaiako \nc) Whare \nd) Kuia");
            QUIZ_QUESTIONS.Add("Quesiton 3: What is the maori name for Monday? \na) Rātū \nb) Rāhina \nc) Rāapa \nd) Rāmere");
            QUIZ_QUESTIONS.Add("Quesiton 4: What is the maori name for Friday? \na) Rātū \nb) Rāhina \nc) Rāapa \nd) Rāmere");
            QUIZ_QUESTIONS.Add("Quesiton 5: What is the maori name for Tuesday? \na) Rātū \nb) Rāhina \nc) Rāapa \nd) Rāmere");
            QUIZ_QUESTIONS.Add("Quesiton 6: What is the maori name for the colour red? \na) Kowhai \nb) Kākāriki \nc) Whero \nd) Māwhero");
            QUIZ_QUESTIONS.Add("Quesiton 7: What is the maori name for the colour green? \na) Whero \nb) Kākāriki \nc) Kowhai \nd) Māwhero");
            QUIZ_QUESTIONS.Add("Quesiton 8: What is the maori name for the colour pink? \na) Whero \nb) Kākāriki \nc) Kowhai \nd) Māwhero");
            QUIZ_QUESTIONS.Add("Quesiton 9: What is the maori name for basket? \na) Kete \nb) Kākāriki \nc) Kowhai \nd) Tahi");
            QUIZ_QUESTIONS.Add("Quesiton 10: What is the maori name for the number 7? \na) Rua \nb) Toru \nc) Whitu \nd) Waru");
            QUIZ_QUESTIONS.Add("Quesiton 11: What is the maori name for book? \na) Whare \nb) Kaiako \nc) Pukapuka \nd) Waru");
            QUIZ_QUESTIONS.Add("Quesiton 12: What is the maori word for the season spring? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
            QUIZ_QUESTIONS.Add("Quesiton 13: What is the maori word for the season winter? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
            QUIZ_QUESTIONS.Add("Quesiton 14: What is the maori word for the season summer? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
            QUIZ_QUESTIONS.Add("Quesiton 15: What is the maori word for the season autumn? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");


            Console.Write("Kia Ora! Are you ready to learn some Te Reo Maori? (Yes or No)  ");//restrictions needed here if something else is entered
            string reply = (Console.ReadLine()).ToLower();
            if (reply == "no")
            {
                Console.WriteLine("\n\nOkay,Bye! Press any key to exit");
                Console.ReadKey();

            }
            else
            {
                Console.Write("\nlet's begin, What is your name?  ");
                string name = (Console.ReadLine()).ToLower();
                Console.Write("\nHello " + name + " what is your age?  ");
                //string userAge = Console.ReadLine();
                while (validInt == false)
                {
                    string userAge = Console.ReadLine();
                    if (int.TryParse(userAge, out age))
                    {
                        validInt = true;
                        if (age <= 4 || age >= 100)
                        {
                            Console.WriteLine("Are you sure you are " + age + " years old? \nINVALID. Please enter a number between 5 - 100 inclusive");
                            validInt = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("INVALID.Please enter a number between 5 - 100");
                    }
                }


                Console.WriteLine("To select an answer please type in the letter to the far left of the answer option you choose");
                while (carryOn == "yes" && iValidCount != 15)
                {
                    listUsersAnswers.Clear();
                    Console.WriteLine(QUIZ_QUESTIONS[0]);
                    answer = Console.ReadLine().ToLower();
                    while (listValidAnswers.Contains(answer) != true)
                    {
                        Console.WriteLine("INVALID.Please choose a letter  a b c or d");
                        Console.WriteLine("Quesiton 1: What is the maori name for grandma? \na) Kura \nb) Kaiako \nc) Whare \nd) kuia");
                        answer = Console.ReadLine().ToLower();
                    }
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 2: What is the maori name for school? \na) Kura \nb) Kaiako \nc) Whare \nd) Kuia");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 3: What is the maori name for Monday? \na) Rātū \nb) Rāhina \nc) Rāapa \nd) Rāmere");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 4: What is the maori name for Friday? \na) Rātū \nb) Rāhina \nc) Rāapa \nd) Rāmere");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 5: What is the maori name for Tuesday? \na) Rātū \nb) Rāhina \nc) Rāapa \nd) Rāmere");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 6: What is the maori name for the colour red? \na) Kowhai \nb) Kākāriki \nc) Whero \nd) Māwhero");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 7: What is the maori name for the colour green? \na) Whero \nb) Kākāriki \nc) Kowhai \nd) Māwhero");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 8: What is the maori name for the colour pink? \na) Whero \nb) Kākāriki \nc) Kowhai \nd) Māwhero");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 9: What is the maori name for basket? \na) Kete \nb) Kākāriki \nc) Kowhai \nd) Tahi");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 10: What is the maori name for the number 7? \na) Rua \nb) Toru \nc) Whitu \nd) Waru");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 11: What is the maori name for book? \na) Whare \nb) Kaiako \nc) Pukapuka \nd) Waru");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 12: What is the maori word for the season spring? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 13: What is the maori word for the season winter? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 14: What is the maori word for the season summer? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    Console.WriteLine("Quesiton 15: What is the maori word for the season autumn? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
                    answer = Console.ReadLine().ToLower();
                    listUsersAnswers.Add(answer);
                    iValidCount = CheckAnswers();
                    if (iValidCount != 15)
                    {
                        Console.Write("\n\nDo you wish to try again to get a better score? (Yes or No) ");
                        carryOn = (Console.ReadLine()).ToLower();
                        if (carryOn == "no")
                        {
                            Console.WriteLine("These are the questions you got wrong with the correct answers:");
                            for (int i = 0; i < listValidAnswers.Count; i++)
                            {
                                if (ListWrongAnswers[i] != " ")
                                {
                                    Console.WriteLine("\nYour answer: " + ListWrongAnswers[i] + "         Correct Answer: " + listValidAnswers[i]);
                                }

                            }


                        }



                    }

                }
                Console.WriteLine("\nThank you for participating");
            }
        }

        public static int CheckAnswers()
        {
            int iCtr = 0;
            ListWrongAnswers.Clear();
            for (int i = 0; i < listValidAnswers.Count; i++)
            {
                if (listUsersAnswers[i] == listValidAnswers[i])
                {
                    iCtr++;
                    Console.WriteLine(iCtr);
                    ListWrongAnswers.Add(" ");
                }
                else
                {
                    string wrongAnswer = listUsersAnswers[i];
                    ListWrongAnswers.Add(wrongAnswer);
                }

            }
            Console.WriteLine("You have answered " + iCtr.ToString() + " questions correctly");
            return iCtr;


        }
    }
}