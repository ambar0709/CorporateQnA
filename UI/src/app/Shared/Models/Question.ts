import { Category } from './Category';
export class Question {
  id: number;
  title: string;
  description: string;
  categoryId: number;
  userId: string;
  upvotes: number;
  views: number;
  createdOn: Date;
}
