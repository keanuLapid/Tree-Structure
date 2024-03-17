using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        bool exit = false;

    Home:
        if (!exit)
        {
            Console.WriteLine("Home");
            Console.WriteLine("a. Data Storage Technologies");
            Console.WriteLine("b. Computer Vision Techniques");
            Console.WriteLine("c. Close");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "a")
            {
                goto DataStorageTechnologies;
            }
            else if (userChoice == "b")
            {
                goto ComputerVisionTechniques;
            }
            else if (userChoice == "c")
            {
                exit = true;
                goto End;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                goto Home;
            }

            Console.WriteLine();
        }

    DataStorageTechnologies:
        Console.WriteLine("Data Storage Technologies");
        Console.WriteLine("a. Traditional");
        Console.WriteLine("b. Emerging");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto Traditional;
        }
        else if (userChoice == "b")
        {
            goto Emerging;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto DataStorageTechnologies;
        }

    Traditional:
        Console.WriteLine("Traditional");
        Console.WriteLine("a. Hard Disk Drives (HDD)");
        Console.WriteLine("b. Solid State Drives (SSD)");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Hard Disk Drives (HDD)");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Solid State Drives (SSD)");
        }
        else if (userChoice == "c")
        {
            goto DataStorageTechnologies;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Traditional;
        }
        Console.WriteLine();
        goto Traditional;

    Emerging:
        Console.WriteLine("Emerging");
        Console.WriteLine("a. NVMe (Non-Volatile Memory Express)");
        Console.WriteLine("b. Storage Class Memory (SCM)");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("NVMe (Non-Volatile Memory Express)");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Storage Class Memory (SCM)");
        }
        else if (userChoice == "c")
        {
            goto DataStorageTechnologies;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Emerging;
        }
        Console.WriteLine();
        goto Emerging;

    ComputerVisionTechniques:
        Console.WriteLine("Computer Vision Techniques");
        Console.WriteLine("a. Image Processing");
        Console.WriteLine("b. Object Detection");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto ImageProcessing;
        }
        else if (userChoice == "b")
        {
            goto ObjectDetection;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto ComputerVisionTechniques;
        }

    ImageProcessing:
        Console.WriteLine("Image Processing");
        Console.WriteLine("a. Filtering");
        Console.WriteLine("b. Edge Detection");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Filtering");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Edge Detection");
        }
        else if (userChoice == "c")
        {
            goto ComputerVisionTechniques;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto ImageProcessing;
        }
        Console.WriteLine();
        goto ImageProcessing;

    ObjectDetection:
        Console.WriteLine("Object Detection");
        Console.WriteLine("a. Haar Cascades");
        Console.WriteLine("b. Convolutional Neural Networks (CNN)");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Haar Cascades");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Convolutional Neural Networks (CNN)");
        }
        else if (userChoice == "c")
        {
            goto ComputerVisionTechniques;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto ObjectDetection;
        }
        Console.WriteLine();
        goto ObjectDetection;

    End:
        Console.WriteLine("Closing the program...");
    }
}