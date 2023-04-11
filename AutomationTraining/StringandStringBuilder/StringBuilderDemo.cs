using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining.StringandStringBuilder
{
    internal class StringBuilderDemo
    {
        StringBuilder sBuilder;
        public StringBuilderDemo(string initialText) 
        {
            if (string.IsNullOrEmpty(initialText))
            {
                throw new ArgumentNullException($"Inalid input provided. Cannot initialize String builder: {initialText}");
            }
            sBuilder = new StringBuilder(initialText);

        }
        internal string AppendString(string text)
        {
			    
            if(sBuilder != null)
            {
                if (string.IsNullOrEmpty(text)) { throw new ArgumentNullException($"Invalid Input provided:  {text}"); }
                else
                {
                    sBuilder.Append($" {text}");
                }
            }
            return sBuilder.ToString();
				
			
        }
    }
}
