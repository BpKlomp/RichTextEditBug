namespace RichTextEditBug.Models
{
    public class TextObject
    {

        public string ComponentType { get; set; } = "Component1";
        public string Text { get; set; } = string.Empty;
        public int Amount { get; set; } = 0;
        public TextObject(string componentType, string text, int amount = 0)
        {
            ComponentType = componentType;
            Text = text;
            Amount = amount;
        }
        public TextObject() { }


    }
}
