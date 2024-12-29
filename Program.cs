namespace algoritma_odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student = 0;
            double classaverage = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Kaç öğrenci kaydetmek istiyorsunuz?");
                    student = int.Parse(Console.ReadLine());
                    if (student <= 0)
                    {
                        Console.WriteLine("Lütfen sadece pozitif değer giriniz");
                        continue;
                    }
                    break;

                }
                catch (FormatException)
                {

                    Console.WriteLine("Lütfen bir sayı giriniz");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu.");
                }
            }

            string[,] table = new string[student + 1, 7];

            double[] vizeNot = new double[student];
            double[] finalNot = new double[student];

            for (int i = 0; i < student; i++)
            {
                Console.WriteLine($"{i + 1}. öğrenci bilgilerini giriniz.");

                while (true)
                {
                    try
                    {
                        Console.Write("Numara: ");
                        string number = Console.ReadLine();
                        long number2 = long.Parse(number);
                        if(number2<=10000000000 || number2 >= 99999999999)
                        {
                            Console.WriteLine("Lütfen 11 haneli öğrenci numarasını giriniz");
                            continue;
                        }
                        table[i, 0] = number.ToString();
                        break;

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Lütfen sadece rakam giriniz");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Adı: ");
                        string name = Console.ReadLine();
                        table[i, 1] = name;
                        break;

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Lütfen sadece metin giriniz");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Soyadı: ");
                        string surname = Console.ReadLine();
                        table[i, 2] = surname;
                        break;

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Lütfen sadece metin giriniz.");
                    }
                }
                double vize = 0;
                while (true)
                {
                    try
                    {
                        Console.Write("Vize Notu: ");
                        vize = double.Parse(Console.ReadLine());
                        table[i, 3] = vize.ToString();
                        //vize = int.Parse(table[i, 3]);
                        vizeNot[i] = vize;
                        if (vize >= 0 && vize <= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen sadece 1-100 arası not girişi yapınız.");
                        }


                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Lütfen rakam girişi yapınız."); ;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bir hata oluştu.");
                        continue;

                    }
                }
                double final = 0;
                
                while (true)
                {
                    try
                    {
                        Console.Write("Final notu: ");
                        final = double.Parse(Console.ReadLine());
                        table[i, 4] = final.ToString();
                        finalNot[i] = final;
                        if (final >= 0 && final <= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen sadece 1-100 arası not girişi yapınız.");

                        }

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Lütfen sadece rakam girişi yapınız.");
                    }
                    catch (Exception ex)
                    { Console.WriteLine("Bir hata oluştu"); }
                }
                double stdaverage = (vize * 0.4) + (final * 0.6);
                table[i, 5] = stdaverage.ToString();
                
                classaverage += stdaverage;

                if (stdaverage >= 85) table[i, 6] = "AA";
                else if (stdaverage >= 75) table[i, 6] = "BA";
                else if (stdaverage >= 60) table[i, 6] = "BB";
                else if (stdaverage >= 50) table[i, 6] = "CB";
                else if (stdaverage >= 40) table[i, 6] = "CC";
                else if (stdaverage >= 30) table[i, 6] = "DC";
                else if (stdaverage >= 20) table[i, 6] = "CC";
                else if (stdaverage >= 10) table[i, 6] = "FD";
                else if (stdaverage >= 0) table[i, 6] = "FF";
            }

            Console.WriteLine("\nÖğrenci Bilgileri: ");
            Console.WriteLine("\tNumara\t\tAd\t\tSoyad\t\tVize\t\tFinal\t\tOrtalama\t\tHarf Notu");

            for (int i = 0; i < student; i++)
            {
                Console.WriteLine($"{i + 1}\t{table[i, 0]}\t{table[i, 1]}\t{table[i, 2]}\t\t{table[i, 3]}\t\t\t{table[i, 4]}\t\t\t{table[i, 5]}\t\t\t{table[i, 6]}");

            }
            Console.WriteLine($"\nSınıf Ortalaması: {classaverage / student}");
            double maxVize = vizeNot[0];
            double minVize = vizeNot[0];
            double maxFinal = finalNot[0];
            double minFinal = finalNot[0];

            for (int i = 1; i < student; i++)
            {
                if (vizeNot[i] > maxVize)
                    maxVize = vizeNot[i];

                if (vizeNot[i] < minVize)
                    minVize = vizeNot[i];

                if (finalNot[i] > maxFinal)
                    maxFinal = finalNot[i];

                if (finalNot[i] < minFinal)
                    minFinal = finalNot[i];
            }

            Console.WriteLine($"En Yüksek Vize Notu: {maxVize}");
            Console.WriteLine($"En Düşük Vize Notu: {minVize}");
            Console.WriteLine($"En Yüksek Final Notu: {maxFinal}");
            Console.WriteLine($"En Düşük Final Notu: {minFinal}");
        }
    }
}
