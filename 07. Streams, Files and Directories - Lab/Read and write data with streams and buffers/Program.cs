using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Read_and_write_data_with_streams_and_buffers
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new FileStream("TextFile1.txt", FileMode.OpenOrCreate);

            var result = string.Empty;

            // Създаваш буфер, който е масив с големина равна на парчетата, на които искаш да се прехвърля файлът.
            byte[] buffer = new byte[50];

            // Задаваш на стрйма, масива на буфера и така му казваш с каква големина ще бъдат всички парчето, които трябва да се прехвърлят
            // до цялото прехвърляне на файла. Задаваш ми от коя позиция да започне и каква част от буфера да прехвърли.

            while (true)
            {
                var totalBytesRead = stream.Read(buffer, 0, buffer.Length);

                // Когато последната част от файла е по-малка от големината на зададеното парче buffer, тогава за да добавим
                // в outout-a и ние без излишни символи и други, трябва да направим последната част да е голяма точно колкото 
                // са оставащите за прехвърляне байтове. Затова създаваме нов масив с дължината на оставащите байтове и
                // го пълним с тях. След което го добавяме към вече прехвърлените части в result.

                if (totalBytesRead < buffer.Length)
                {
                    
                    var lastPart = buffer.Take(totalBytesRead).ToArray();


                    // Вариант с for loop
                    //var lastPart = buffer[totalBytesRead];

                    //for (int i = 0; i < totalBytesRead; i++)
                    //{
                    //    lastPart[i] = buffer[i];
                    //}


                    result += Encoding.UTF8.GetString(buffer);

                    break;
                }

                // За да го прочетем като текст вместо, като байтове. ТОва става чрез Encoding.UTF8.GetString 
                // може да превърнем байт масив към стринг или обратното.

                result += Encoding.UTF8.GetString(buffer);

                

            }

        }
    }
}
