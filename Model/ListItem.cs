namespace AppCahierText.Model
{
    public class ListItem
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}