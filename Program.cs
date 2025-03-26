using System;

class Program
{
    static void Main()
    {
        string[] Animals = { "Dog", "Cat", "Cow" };
        string[] Sounds = { "Ham! Ham!", "Miau!", "MUUUU!" };

        for(int i=0; i<Animals.Length; i++)
        {
            Console.WriteLine($"{Animals[i]} makes sound:  {Sounds[i]}");
        }
    }
}