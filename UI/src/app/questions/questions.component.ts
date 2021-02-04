import { Component, OnInit } from '@angular/core';
import { faChevronUp, faEye } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.scss'],
})
export class QuestionsComponent implements OnInit {
  faChevronUp = faChevronUp;
  faEye = faEye;
  constructor() {}

  ngOnInit(): void {}
}
