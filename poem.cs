using System;
using System.Text;
using System.IO;

 partial class Program
{
    static void Main()
    {
        string filePath = "fet_poem.txt";

        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                // Каждая строка добавляется отдельным вызовом Write
                
                // Строка 1
                byte[] bytes1 = Encoding.UTF8.GetBytes("Когда я про горе свое говорил," + Environment.NewLine);
                fileStream.Write(bytes1, 0, bytes1.Length);
                
                // Строка 2
                byte[] bytes2 = Encoding.UTF8.GetBytes("С тобой опрометчиво слово слетало," + Environment.NewLine);
                fileStream.Write(bytes2, 0, bytes2.Length);
                
                // Строка 3
                byte[] bytes3 = Encoding.UTF8.GetBytes("Ты горько, ты горько рыдала," + Environment.NewLine);
                fileStream.Write(bytes3, 0, bytes3.Length);
                
                // Строка 4
                byte[] bytes4 = Encoding.UTF8.GetBytes("И небо земное мне стало." + Environment.NewLine);
                fileStream.Write(bytes4, 0, bytes4.Length);
            }

            Console.WriteLine("Стихотворение Афанасия Фета записано в файл построчно!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}