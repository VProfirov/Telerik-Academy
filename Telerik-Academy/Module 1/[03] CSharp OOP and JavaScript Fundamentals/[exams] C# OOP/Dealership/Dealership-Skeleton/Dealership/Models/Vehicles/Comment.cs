using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common;
using Dealership.Contracts;
using Dealership.Models.Custom_Validator;

namespace Dealership.Models.Vehicles
{
    class Comment:IComment
    {
        public Comment(string content)
        {
            CustomValidator.ValidateNull(content,Constants.CommentCannotBeNull);
            CustomValidator.ValidateStringRange(content,Constants.MinCommentLength,Constants.MaxCommentLength,Constants.NumberMustBeBetweenMinAndMax);
            this.Content = content;
        }
        public string Content { get; }
        public string Author { get; set; }
    }
}
