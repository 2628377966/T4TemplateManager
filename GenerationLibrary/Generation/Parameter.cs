﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Codenesium.GenerationLibrary.Generation
{
    [Serializable]
    public class Parameter
    {
        /// <summary>
        /// This function takes a new line delimeted set of = sign delimeted paramaters and returns a key,value dictionary
        /// It tries to ignore bad data so if you fail to pass a correct string you will get unusual results.
        /// 
        /// Example
        /// param1=value1
        /// param2=value2
        /// param3=value3
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static Dictionary<string,string> ParseParameters(string lines)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string[] parsedLines = lines.Trim().Split(Environment.NewLine.ToArray());
            foreach(string line in parsedLines)
            {
                if (line.Contains('='))
                {
                    string[] splitLines = line.Split('=');
                    if (splitLines.Length == 2)
                    {
                        parameters[splitLines[0]] = splitLines[1];
                    }
                }
            }
            return parameters;
        }

        public static List<Dictionary<string,string>> ParseMultiParametersPerLine(string lines)
        {
            List<Dictionary<string, string>> parametersList = new List<Dictionary<string, string>>();
            string[] parsedLines = lines.Trim().Split(Environment.NewLine.ToArray());
            foreach (string line in parsedLines)
            {
                if (line.Contains(','))
                {
                    string[] splitLines = line.Split(',');
                    foreach (string splitLine in splitLines)
                    {
                        parametersList.Add(ParseParameters(splitLine));
                    }
                }
            }
            return parametersList;
        }



        /// <summary>
        /// This function takes the text from a T4 template and parses out the parameters and return them as an empty dictionary.
        /// This function is flaky and will need to be reworked at some point.
        /// </summary>
        /// <param name="templateText"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ParseParametersFromTemplate(string templateText)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string[] parsedLines = templateText.Trim().Split(Environment.NewLine.ToArray());
            foreach (string templateLine in parsedLines)
            {
                if (templateLine.Trim().ToUpper().Contains("<#@ PARAMETER"))
                {
                    string [] attributes = templateLine.Split(' ');
                    
                    foreach(string attribute in attributes)
                    {
                        if(attribute.ToUpper().Contains("NAME="))
                        {
                            int namePos = attribute.ToUpper().IndexOf("NAME=");
                            if(namePos > -1)
                            {
                                int firstQuote = attribute.ToUpper().IndexOf('"',namePos);
                                int secondQuote = attribute.ToUpper().IndexOf('"',firstQuote+1);
                                if(firstQuote > -1 && secondQuote > -1)
                                {
                                    string nameValue = attribute.Substring(firstQuote+1,secondQuote-firstQuote-1);
                                    parameters[nameValue] = "";
                                }

                            }
                        }
                    }
                }
            }
            return parameters;
        }

    }
}
