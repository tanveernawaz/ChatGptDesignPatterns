using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    class EditorMemento
    {
        public string Content { get; private set; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }

    class Editor
    {
        public string Content { get; set; }

        public EditorMemento CreateMemento()
        {
            return new EditorMemento(Content);
        }

        public void Restore(EditorMemento memento)
        {
            Content = memento.Content;
        }
    }

    class History
    {
        private List<EditorMemento> mementos = new List<EditorMemento>();

        public void Push(EditorMemento memento)
        {
            mementos.Add(memento);
        }

        public EditorMemento Pop()
        {
            if (mementos.Count == 0)
                return null;
            var last = mementos.Last();
            mementos.Remove(last);
            return last;
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        var editor = new Editor();
    //        var history = new History();

    //        editor.Content = "Hello";
    //        history.Push(editor.CreateMemento());

    //        editor.Content = "Hello World";
    //        history.Push(editor.CreateMemento());

    //        editor.Content = "Hello World!";
    //        history.Push(editor.CreateMemento());

    //        editor.Content = "Hello World! How are you?";
    //        history.Push(editor.CreateMemento());

    //        editor.Restore(history.Pop());
    //        Console.WriteLine(editor.Content); // "Hello World! How are you?"

    //        editor.Restore(history.Pop());
    //        Console.WriteLine(editor.Content); // "Hello World!"

    //        editor.Restore(history.Pop());
    //        Console.WriteLine(editor.Content); // "Hello World"

    //        editor.Restore(history.Pop());
    //        Console.WriteLine(editor.Content); // "Hello"
    //    }
    //}

}
