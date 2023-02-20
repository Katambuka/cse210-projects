using System.Collections.Generic;

namespace Namespace
{
    class Scripture
    {
        public Scripture(Reference referenceParam, List<Word> textParam)
        {
            Reference = referenceParam;
            ScriptureText = textParam;
        }

        private Reference Reference { get; set; }
        private List<Word> ScriptureText { get; set; }

        public Reference GetReference()
        {
            return Reference;
        }

        public List<Word> GetScriptureText()
        {
            return ScriptureText;
        }
    }
}
