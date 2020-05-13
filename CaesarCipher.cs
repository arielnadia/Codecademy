using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.Write("Enter your message: ");
      string originalMessage = Console.ReadLine().ToLower();
      char[] secretMessage = originalMessage.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      //string encrypted = Encrypt(secretMessage, 3);
      //static string Encrypt(array secretMessage, int key)
      //{
        for (int i = 0; i < secretMessage.Length; i++)
        {
          if (Char.IsLetter(secretMessage[i]))
          {
            char oldLetter = secretMessage[i];
            int oldLocation = Array.IndexOf(alphabet, oldLetter);
            int newLocation = (oldLocation + 3) % 26;
            char newLetter = alphabet[newLocation];
            encryptedMessage[i] = newLetter;
          } else
          {
            encryptedMessage[i] = secretMessage[i];
          }
        }
        string encrypted = String.Join("", encryptedMessage);
        Console.WriteLine(encrypted);
        //return encrypted;
      //}
      //static string Decrypt(array )
    }
  }
}
