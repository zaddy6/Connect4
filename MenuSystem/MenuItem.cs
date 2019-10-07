using System;

namespace MenuSystem
{
    public class MenuItem
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => _title = Validate(value, 1, 100, false);
        }
        
        public Func<string> CommandToExecute { get; set; }

        public static string Validate(string input, int min, int max, bool toUpper)
        {
            input = input.Trim();
            if (toUpper)
            {
                input.ToUpper();
            }

            if (input.Length < min || input.Length > max)
            {
                throw new ArgumentException("Incorrect String Length");
            }

            return input;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}