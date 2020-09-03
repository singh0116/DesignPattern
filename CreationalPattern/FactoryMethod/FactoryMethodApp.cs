using CorePattern.Core;
using System;
using System.Collections.Generic;

namespace CreationalPattern.FactoryMethod
{
    public class FactoryMethodApp : IBubbleApp
    {
        public void Execute()
        {
            var documents = new List<Document> { new Resume(), new Report() };

            foreach (var document in documents)
            {
                Console.WriteLine(document + "--");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page);
                }
                Console.WriteLine();
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
