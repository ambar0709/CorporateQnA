import { Component, OnInit } from '@angular/core';
import {
  faExclamationCircle,
  faThumbsUp,
  faThumbsDown,
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-answers',
  templateUrl: './answers.component.html',
  styleUrls: ['./answers.component.scss'],
})
export class AnswersComponent implements OnInit {
  faExclamationCircle = faExclamationCircle;
  faThumbsUp = faThumbsUp;
  faThumbsDown = faThumbsDown;

  constructor() {}
  ngOnInit() {}
}
