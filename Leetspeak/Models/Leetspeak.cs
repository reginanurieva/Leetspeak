using System;
using System.Collections.Generic;

namespace Translator
{
  public class LeetspeakTranslator
  {
    public string Translating(string input)
    {
      List<char> inputList = new List<char>{};
      List<char> outputList = new List<char>{};

      for (int i = 0; i < input.Length; i ++)
      {
        inputList .Add(input[i]);
        if(inputList[i]== 'e' || inputList[i]== 'E')
        {
          outputList.Add('3');
        }
        else
        {
          outputList.Add(inputList[i]);
        }
      }
      string traslatedOutput = string.Join("",outputList.ToArray());
      return traslatedOutput;
    }
  }
}
