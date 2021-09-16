using System;

namespace UserAuthClient.Web.Lib
{
    public class ComponentText
    {
        private string _Text { get; set; }
        public string Text {
            get => _Text??"";
            set
            {
                //if text is null or text is value or text equals value, nothing changed
                if (_Text==value || (_Text is not null && _Text.Equals(value))) return;
                _Text = value;
                OnPropertyChanged(_Text);
            } 
        }

        public Action<string> OnTextChange { get; set; } = text => { };

        public void OnPropertyChanged(string text)
        {
            OnTextChange(text);
        }
    }
}