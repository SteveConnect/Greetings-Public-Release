using EasyScintilla.Stylers;
using System.IO;
using System.Reflection;

namespace QuickNotes
{
    public class ExampleDisplay
    {
        private readonly string _textFile;

        public string Display { get; }

        public ScintillaStyler Styler { get; }

        public ExampleDisplay(string display, string textFile, ScintillaStyler styler)
        {
            _textFile = textFile;
            Display = display;
            Styler = styler;
        }

        public string ReadFile()
        {
            using (var file = Assembly.GetAssembly(GetType()).GetManifestResourceStream("QuickNotes.Templates." + _textFile))
            using (var reader = new StreamReader(file))
            {
                return reader.ReadToEnd();
            }
        }
    }
}