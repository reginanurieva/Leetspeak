using System;
using Translator;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Translator
{
  public class LeetspeakTranslator
  {
    public string Translating(string input)
    {
      Regex rx = new Regex(@"^[a-zA-Z]+$");
      List<char> inputList = new List<char>{};
      List<char> outputList = new List<char>{};
      Dictionary<char,char> charDictionary = new Dictionary<char,char>() {};
      charDictionary['e'] = '3';
      charDictionary['o'] = '0';
      charDictionary['t'] = '7';
      charDictionary['I'] = '1';
      charDictionary['E'] = '3';
      charDictionary['O'] = '0';
      charDictionary['T'] = '7';

      for(int i = 0; i < input.Length; i ++)
      {
        inputList.Add(input[i]);
        if(i > 1 && rx.IsMatch(inputList[i-1].ToString()) && (inputList[i] == 's' || inputList[i] == 'S'))
           {
             outputList.Add('z');
           }
           else if(charDictionary.ContainsKey(inputList[i]))
           {
             outputList.Add(charDictionary[inputList[i]]);
           }
           else
           {
             outputList.Add(inputList[i]);
           }
      }

      // for (int i = 0; i < input.Length; i ++)
      // {
      //   inputList .Add(input[i]);
      //   if(inputList[i]== 'e' || inputList[i]== 'E')
      //   {
      //     outputList.Add('3');
      //   }
      //   else if(inputList[i] == 'o' || inputList[i] == 'O')
      //   {
      //     outputList.Add('0');
      //   }
      //   else if(inputList[i] == 't' || inputList[i] == 'T')
      //   {
      //     outputList.Add('7');
      //   }
      //   else if(inputList[i] == 'I')
      //   {
      //     outputList.Add('1');
      //   }
      //   else if(i > 1 && rx.IsMatch(inputList[i-1].ToString()) && (inputList[i] == 's' || inputList[i] == 'S'))
      //   {
      //     outputList.Add('z');
      //   }
      //   else
      //   {
      //     outputList.Add(inputList[i]);
      //   }
      // }
      string traslatedOutput = string.Join("",outputList.ToArray());
      return traslatedOutput;
    }
  }
}

public class Program
{
  public static void Main()
  {
  Console.WriteLine("Enter a word or sentence to translate!");
  string wordToTranslate = Console.ReadLine();
  LeetspeakTranslator translatedSentence = new LeetspeakTranslator();
  Console.WriteLine(translatedSentence.Translating(wordToTranslate));
  }
}
