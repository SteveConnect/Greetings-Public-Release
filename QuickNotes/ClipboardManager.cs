using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuickNotes
{
    /// <summary>
    ///
    /// </summary>
    public class ClipboardManager
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static ClipboardManager _instance = null;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static ClipboardManager Instance
        {
            get { return _instance ?? (_instance = new ClipboardManager()); }
        }

        /// <summary>
        /// The data file path
        /// </summary>
        private readonly string _dataFilePath;

        /// <summary>
        /// The document
        /// </summary>
        private readonly XDocument _document;

        /// <summary>
        /// The node name
        /// </summary>
        private const string NodeName = "CBT";

        /// <summary>
        /// Prevents a default instance of the <see cref="ClipboardManager"/> class from being created.
        /// </summary>
        private ClipboardManager()
        {
            _dataFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data.xml");
            _document = XDocument.Load(_dataFilePath);
        }

        /// <summary>
        /// Determines whether [is text exists] [the specified text].
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        ///   <c>true</c> if [is text exists] [the specified text]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsTextExists(string text)
        {
            var cbts = _document.Root.Descendants();

            return (from c in cbts where c.Value == text select c).Any();
        }

        /// <summary>
        /// Adds the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void AddText(string text)
        {
            text = text.Trim();

            if (IsTextExists(text)) return;

            var element = new XElement(NodeName) { Value = text };

            var rootElement = _document.Root;
            rootElement.AddFirst(element);
            _document.Save(_dataFilePath);
        }

        /// <summary>
        /// Updates the text.
        /// </summary>
        /// <param name="oldText">The old text.</param>
        /// <param name="newText">The new text.</param>
        public void UpdateText(string oldText, string newText)
        {
            oldText = oldText.Trim();
            newText = newText.Trim();

            if (!IsTextExists(oldText)) return;

            if (IsTextExists(newText))
            {
                DeleteText(oldText);
            }
            else
            {
                var element = (from e in _document.Root.Descendants() where e.Value == oldText select e).FirstOrDefault();
                element.Value = newText;
                _document.Save(_dataFilePath);
            }
        }

        /// <summary>
        /// Deletes the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void DeleteText(string text)
        {
            text = text.Trim();
            if (!IsTextExists(text)) return;

            var xElements = _document.Root.Descendants();
            var element = (from e in xElements where e.Value == text select e).FirstOrDefault();
            element.Remove();
            _document.Save(_dataFilePath);
        }

        /// <summary>
        /// Copies the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public bool CopyText(string text)
        {
            try
            {
                Clipboard.SetText(text);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets all texts.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllTexts()
        {
            var cbts = _document.Root.Descendants();
            return (from c in cbts select c.Value.Trim()).ToList();
        }
    }
}