using System.Text;
using Dealership.Common;
using Dealership.Contracts;
using Dealership.Models.Custom_Validator;

namespace Dealership.Models
{
    class Comment:IComment
    {
        private string author;

        public Comment(string content)
        {
            CustomValidator.ValidateNull(content,Constants.CommentCannotBeNull);
            CustomValidator.ValidateStringRange(content,Constants.MinCommentLength,Constants.MaxCommentLength,Constants.NumberMustBeBetweenMinAndMax);
            this.Content = content;
        }
        public string Content { get; }

        public string Author
        {
            get => this.author;
            set
            {
                CustomValidator.ValidateNull(this.author,Constants.UserCannotBeNull);
                this.author = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"    {Content}");
            builder.AppendLine($"      User: {Author}");
            return builder.ToString().TrimEnd();
        }
    }
}
