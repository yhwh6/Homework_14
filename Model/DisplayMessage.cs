namespace Homework_13.Model
{
    public class DisplayMessage : ViewModelBase
    {
        /// <summary>
        /// Showing message
        /// </summary>
        public string Visible
        {
            get
            {
                return visible;
            }
            set
            {
                if (visible != value)
                {
                    visible = value;
                    RaisePropertyChanged(nameof(this.Visible));
                }
            }
        }
        private string visible = "Visible";

        /// <summary>
        /// Message text
        /// </summary>
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (text != value)
                {
                    Visible = "Visible";
                    text = value;
                    RaisePropertyChanged(nameof(this.Text));
                }
            }
        }
        private string text;
    }
}
