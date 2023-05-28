using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOoperations
{
    internal class CryptingFiles
    {
        private string _userInputPath = "";
        private string _userChoiceEncryptOrDecrypt;

        private void CryptFile()
        {
            try
            {
                File.Encrypt(_userInputPath);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The file was successfully encrypted!");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect file path is specified");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private void DeCryptFile()
        {
            try
            {
                File.Decrypt(_userInputPath);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The file was successfully decrypted!");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect file path is specified");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Hi, please enter the path to the file you would like to encrypt/decrypt  like that \"C:\\(path to file...)\"");
            _userInputPath = Console.ReadLine();
            Console.WriteLine();

            if (_userInputPath == null)
                Console.WriteLine("You did not specify the path to the file!");

            Console.WriteLine("now enter the action you want to perform with the file:    /    encrypt     /    decrypt    /");
            _userChoiceEncryptOrDecrypt = Console.ReadLine();
            Console.WriteLine();

            if (_userChoiceEncryptOrDecrypt.ToLower() == "encrypt")
                CryptFile();

            else if (_userChoiceEncryptOrDecrypt.ToLower() == "decrypt") 
                DeCryptFile();

            else
                Console.WriteLine("you entered an incorrect action");
        }
    }
}
