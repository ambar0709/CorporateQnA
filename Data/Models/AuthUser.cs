using Microsoft.AspNetCore.Identity;

namespace CorporateQnA.Data.Models
{
    public class AuthUser:IdentityUser
    {
        public string Name { get; set; }
        public string JobProfile { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string ProfileImageUrl { get; set; }

        public int QuestionsAsked { get; set; }
        public int QuestionsAnswered { get; set; }
        public int QuestionsSolved { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
