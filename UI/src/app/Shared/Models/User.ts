export class User {
  Id: string;
  Email: string;
  Name: string;
  JobProfile: string;
  Department: string;
  Location: string;
  ProfileImageUrl: string;

  QuestionsAsked: Number;
  QuestionsAnswered: Number;
  QuestionsSolved: Number;
  Likes: Number;
  Dislikes: Number;

  constructor(userData) {
    this.Id = userData.id;
    this.Email = userData.email;
    this.Name = userData.name;
    this.JobProfile = userData.jobProfile;
    this.Department = userData.department;
    this.Location = userData.location;
    this.ProfileImageUrl = userData.profileImageUrl;
  }
}
