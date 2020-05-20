using System;
using System.Collections.Generic;

namespace MaoriQuiz
    {
    class Quiz//Class called Quiz
        {

        //private lists only avaliable to this program
        private static List<string> ListUsersAnswers = new List<string>();// stores users answers to the 12 questions
        private static List<string> LIST_CORRECT_ANSWERS = new List<string> { "d", "a", "b", "d", "c", "b", "d", "a", "c", "c", "d", "b" };// stores all the correct answers to the 12 questions
        private static List<string> ListWrongAnswers = new List<string>();// stores all the users wrong answers to the 12 questions
       
        static void Main(string[] args)//main
            {
            string name = " ";
            string answer;// initalizing a string variable called answer
            int iValidCount = 0;// Initializing an integer  to store number of valid answers
            string carryOn = "yes";//Initializing a string variable, used to break the code or if the user doesn't want a second attempt(exit/continue)
            int age = 0;//Initializing an integer variable storing the user's age
            bool validAge = false;// initializing a bool variable 
            List<string> QUIZ_QUESTIONS = new List<string>();// List storing all the following 15 questions
            QUIZ_QUESTIONS.Add("Quesiton 1: What is the maori name for grandma? \na) Kura \nb) Kaiako \nc) Whare \nd) kuia");
            QUIZ_QUESTIONS.Add("Quesiton 2: What is the maori name for school? \na) Kura \nb) Kaiako \nc) Whare \nd) Kuia");
            QUIZ_QUESTIONS.Add("Quesiton 3: What is the maori name for Monday? \na) Rātū \nb) Rāhina \nc) Rāapa \nd) Rāmere");
            QUIZ_QUESTIONS.Add("Quesiton 4: What is the maori name for Friday? \na) Rātū \nb) Rāhina \nc) Rāapa \nd) Rāmere");
            QUIZ_QUESTIONS.Add("Quesiton 5: What is the maori name for the colour red? \na) Kowhai \nb) Kākāriki \nc) Whero \nd) Māwhero");
            QUIZ_QUESTIONS.Add("Quesiton 6: What is the maori name for the colour green? \na) Whero \nb) Kākāriki \nc) Kowhai \nd) Māwhero");
            QUIZ_QUESTIONS.Add("Quesiton 7: What is the maori name for the colour pink? \na) Whero \nb) Kākāriki \nc) Kowhai \nd) Māwhero");
            QUIZ_QUESTIONS.Add("Quesiton 8: What is the maori name for basket? \na) Kete \nb) Kākāriki \nc) Kowhai \nd) Tahi");
            QUIZ_QUESTIONS.Add("Quesiton 9: What is the maori name for the number 7? \na) Rua \nb) Toru \nc) Whitu \nd) Waru");
            QUIZ_QUESTIONS.Add("Quesiton 10: What is the maori name for book? \na) Whare \nb) Kaiako \nc) Pukapuka \nd) Waru");
            QUIZ_QUESTIONS.Add("Quesiton 11: What is the maori word for the season spring? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
            QUIZ_QUESTIONS.Add("Quesiton 12: What is the maori word for the season winter? \na) Ngahuru \nb) Hōtoke \nc) Raumati \nd) Kōanga");
            
            Console.Write("Kia Ora! Are you ready to learn some Te Reo Maori? (Yes or No)  ");// Asks the user a question
            string reply = (Console.ReadLine()).ToLower();//stores users reply in a string variable called reply
            while (reply != "yes" && reply != "no")// if the user puts in something other than yes or no then goes through the loop untill the user had typed something valid.
                {
                Console.WriteLine("INVALID REPLY. Please answer with Yes or No");//prompts the user with what to reply with
                reply = (Console.ReadLine()).ToLower();//overwites invalid reply
                carryOn = "no";//sets carryOn to no
                }
            if (reply == "no")// if the user replies with no...goes through loop
                {
                Console.WriteLine("\nBye! Press any key to exit");// greets goodbye
                Console.ReadKey();// user can press any key to exit , code breaks
                carryOn = "no";//carryOn is set to  no
                }
            if (reply == "yes")
                {
                carryOn = "yes";//carryOn is set to yes
                Console.Write("\nlet's begin, What is your name?  ");//Asks for users name
                name = (Console.ReadLine());//stores users name in a local string variable called name predefined at the top of the main
                Console.Write("\nHello " + name + " what is your age?  ");// greets user with its name and asks for users age
                while (validAge == false)// while the age is invalid then goes through next section in curly barckets
                    {
                    string userAge = Console.ReadLine();//stores user's age in a string variable called userAge
                    if (int.TryParse(userAge, out age))//Makes sure the user entered an integer and not a letter or a sign if not makes them correct it before proceding
                        {
                        validAge = true;//after the age has been validated as a number then only will it go the next part
                        if (age < 5)// if the age is less than 5 user is too young to participate
                            {
                            Console.WriteLine("Sorry " + name + " you are too young to particpate \nPress any key to exit");//prints message
                            Console.ReadKey();//user can press any key to exit and code breaks
                            carryOn = "no";//carry on is set to no
                            }
                        if (age > 95)//if age is greater than 95 user is too old to participate
                            {
                            Console.WriteLine("Sorry " + name + " you're a bit too late. You're not elligible to take part in this quiz as it is only for people aged 5-95 years  \nPress any key to exit");//prints message
                            Console.ReadKey();//user can press any key to exit and code breaks
                            carryOn = "no";//carry on is set to no
                            }
                        }
                    else// if the age entered is not an integer
                        {
                        Console.WriteLine("INVALID.Please enter a number between 5 - 95");// prompts user to enter a valid age that is a number
                        validAge = false;//bool is set to false
                        }
                    }
                }

                while (carryOn == "yes" && iValidCount != 15)//while loop - whild carryOn is set to yes and the user hasnt scored 100%
                    {
                    Console.WriteLine("To select an answer please type in the letter to the far left of the answer option you choose");//printd instructions
                    ListUsersAnswers.Clear();//clears the users list of answers each time the test is taken
                    for (int i = 0; i < QUIZ_QUESTIONS.Count; i++)// increases index for each question it will do all of this
                        {
                        Console.WriteLine("\n" + QUIZ_QUESTIONS[i]);//prints each quiz question on by index
                        answer = Console.ReadLine().ToLower();//stores user's answer temporarily and adds each one to the list
                        while (LIST_CORRECT_ANSWERS.Contains(answer) != true)// while the users list contains somthing that is not a valid option say the user entered a number or a sign or a letter than isnt abc or d
                            {
                            Console.WriteLine("INVALID.Please choose a letter  a b c or d");//prompts user that their selection is invalid
                            Console.WriteLine(QUIZ_QUESTIONS[i]);// prints the question with the invalid answer again
                            answer = Console.ReadLine().ToLower();//overwrites users invlaid answer with thier new one and if its not valid still it continues to go trought the for loop
                            }
                        ListUsersAnswers.Add(answer);// adds the answer that's valid to the list
                        }



                    iValidCount = CheckAnswers();//Method to check users answers
                    if (iValidCount != 12)// if the user hasn't answered all 12 questions correctly goes through next part in curly brackets
                        {
                        Console.WriteLine("I'm sure you can do better, not at a 100% yet!");
                        Console.Write("\n\nDo you wish to try again to get a better score? (Yes or No) ");//user is prompted for a second attempt each time they take the test
                        carryOn = (Console.ReadLine()).ToLower();//users response sets carryon to yes or no so that they have to option of taking the second attempt or not
                        while (carryOn != "yes" && carryOn != "no") //while the user types something that isn't yes or no its considered invalid
                            {
                            Console.WriteLine("INVALID REPLY. Please answer with Yes or No");//user is prompted to correct their reply and if they still mess it up then they have to keep trying again
                            carryOn = (Console.ReadLine()).ToLower();// reply is changed to lowercase and determines the value of carryOn
                            }
                        if (carryOn == "no")//if the user does not wish to try again goes through with next step in {}
                            {
                            Console.WriteLine("These are the questions you got wrong with the correct answers:");//Prints message
                            for (int i = 0; i < LIST_CORRECT_ANSWERS.Count; i++)// for the question the user answered incorrectly, prints all the questions the user got wrong with their answer and correct answwer
                                {
                                if (ListWrongAnswers[i] != " ")//if the list of wrong answers is not empty
                                    {
                                    Console.WriteLine("\n" + QUIZ_QUESTIONS[i]);//prints all the questions the user got wrong
                                    Console.WriteLine("Your answer: " + ListWrongAnswers[i] + "         Correct Answer: " + LIST_CORRECT_ANSWERS[i]);//prints all the asnwers the user got wrong with their answer and correct answwer
                                    }
                                }
                            }
                        }
                    else
                        {
                        Console.WriteLine("100 percent! you've done exceptionally well.");
                        carryOn = "no";
                        }
                    if (carryOn == "no")//If their age is valid greater than or equal to 5 and less then or qual to 95, that would mean they were elligible to take part in the quiz and were able to proceed
                        {
                        Console.WriteLine("\nThank you for participating " + name);//Thank you statment is printed using the users name
                        Console.WriteLine("\nPress any key to exit");//prints message
                        Console.ReadKey();//User can press any key to exit
                        }
                }   
            }   

            public static int CheckAnswers()//New static for the method called CheckAnswers
                {
                int iCtr = 0;// a variable that returns a value to the calling method
                ListWrongAnswers.Clear();// clears the list of wrong answers after each attempt of the test
                for (int i = 0; i < LIST_CORRECT_ANSWERS.Count; i++)//Checks through the entire list and checks each element
                    {
                    if (ListUsersAnswers[i] == LIST_CORRECT_ANSWERS[i])//if each element in ListUsersAnswers matches up with the coressponding elemnt in the LIST_CORRECT_ANSWERS
                        {
                        iCtr++;//incriments counter if the answer is correct
                        ListWrongAnswers.Add(" ");//Nothing gets added to the list of wrong answers
                        }
                    else//if each element in ListUsersAnswers doesn't match up with the coressponding elemnt in the LIST_CORRECT_ANSWERS
                        {
                        string wrongAnswer = ListUsersAnswers[i];//Each answer that does not match up means its incorrect so its stored temporaily in a string varible called wrongAnswer
                        ListWrongAnswers.Add(wrongAnswer);//Every wrong answer then gets added to a list called ListWrongAnswers
                        }

                    }
                Console.WriteLine("You have answered " + iCtr.ToString() + " questions correctly");//prints message along with the user's score.
                return iCtr;//Returns the number of correct answers
                }
    }
}   



