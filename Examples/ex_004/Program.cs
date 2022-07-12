Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
int i = 1;

 while (i <= number)
            {
                int result = i % 2;
                if (result != 1)
                {
                    Console.WriteLine("четное " + i);
                    i++;
                }
                else
                {
                    i++;
                }
            }
        
