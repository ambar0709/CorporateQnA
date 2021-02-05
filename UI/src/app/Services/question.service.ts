import { Question } from './../Shared/Models/Question';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class QuestionService {
  constructor(private http: HttpClient) {}

  addQuestion(question: Question) {
    return this.http.post<Question>(
      `${environment.URL}/api/questions`,
      question
    );
  }
}
