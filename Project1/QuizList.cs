using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class QuizList
    {
        public List<string> questions;
        public List<string> correctAnswers;

        public QuizList()
        {
            questions = new List<string>
            {
            "What is Windows Forms in the context of .NET applications?",
            "Which of the following is used to declare a variable in C#?",
            "Which keyword is used to handle exceptions in C#?",
            "What is the default access modifier for a class in C#?",
            "Which event is triggered when a button is clicked in a Windows Forms application?",
            "What method is commonly used to display a message box in Windows Forms?",
            "How do you add a new control to a Windows Form in the designer view?",
            "What property of a TextBox control in Windows Forms determines its text content?",
            "Which method is called when a Windows Form is first loaded?",
            "Which of the following is NOT a data type in Microsoft Access?",
            "What is the purpose of a primary key in an Access database?",
            "How do you create a new query in Microsoft Access?",
            "Which Access object is used to display data in a tabular format?",
            "In Access, which type of relationship ensures referential integrity?",
            "Which SOLID principle states that a class should have only one reason to change?",
            "The Open/Closed Principle states that software entities should be open for extension but closed for what?",
            "Which principle suggests that derived classes must be substitutable for their base classes?",
            "What is the key idea of the Interface Segregation Principle?",
            "Which SOLID principle emphasizes the importance of designing systems so that high-level modules are not dependent on low-level modules?",
            "What is the primary purpose of the .NET framework in application development?"
            };

            correctAnswers = new List<string>
            {
            "A graphical user interface (GUI) framework for building desktop applications",
            "var",
            "try",
            "internal",
            "Click",
            "MessageBox.Show()",
            "Drag and drop from the toolbox",
            "Text",
            "Load()",
            "Text",
            "To create a unique identifier for each record",
            "Use the Query Design option",
            "Table",
            "One-to-Many",
            "Single Responsibility Principle",
            "Modification",
            "Liskov Substitution Principle",
            "Clients should not be forced to depend on interfaces they do not use.",
            "Dependency Inversion Principle",
            "Platform"
            };
        }
    }
}