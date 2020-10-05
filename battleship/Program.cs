using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int hit= generator.Next(1,11); // random generator mellan 1 och 10
            Console.WriteLine("Chose a number between 1-10!");
            int result = PlayerInput();
            
           while (result!= hit){
                if (hit > result){
                    if (hit-2 == result || hit-1 == result){ //om hit är 4 och skrivaren skriver 2 ellr 3 så triggas detta meddelande igång 
                        System.Console.WriteLine("Too low! Near miss");
                        result = PlayerInput();
                    }
                    else {
                        System.Console.WriteLine("miss");
                        result = PlayerInput();
                    }
                }
                if (result > hit){
                    if( hit+2 == result || hit+1 == result){ // samma princip fast med ett högre tal än hit
                        System.Console.WriteLine("Too high! Near miss");
                        result = PlayerInput();
                    }
                    else {
                        System.Console.WriteLine("miss");
                        result = PlayerInput();
                    }
                }

            }

            System.Console.WriteLine("right number!"); //eftersom man bara kommer ut ur while loopen efter man gissat rätt så behöver ja ej en if statement, utan kan skriva direkt "right answer"

            Console.ReadLine();

        }

        static int PlayerInput(){ //metod så man slipper skriva detta varje gång spelaren gissar igen. nu skriver man det ba i result = playerinput
            string playerAnswer = Console.ReadLine();
            int result = TryParse(playerAnswer);
            return result;
        }

        static int TryParse (string playerAnswer){ //tryparse som returnerar playeranswer i en int, i detta fall i form av result
            int result;
            bool lyckad = int.TryParse(playerAnswer,out result);
            while (lyckad == false || result > 10){
                Console.WriteLine("please input valid answer");
                playerAnswer = Console.ReadLine();
                lyckad = int.TryParse(playerAnswer, out result);
            }

            return result; 



        }
    }
}
