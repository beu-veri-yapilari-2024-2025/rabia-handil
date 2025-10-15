        int[,] a = new int[3, 3];
        int[,] b = new int[3, 3];
        int[,] toplam = new int[3, 3];

        Random rnd = new Random();

        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                a[i, j] = rnd.Next(1, 10);
                b[i, j] = rnd.Next(1, 10);
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                toplam[i, j] = a[i, j] + b[i, j];
            }
        }
        Console.WriteLine("A Matrisi:");
        Yazdir(a);

        Console.WriteLine("B Matrisi:");
        Yazdir(b);

        Console.WriteLine("\nToplam Matrisi:");
        Yazdir(toplam);
   static void Yazdir(int[,] matris)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matris[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
