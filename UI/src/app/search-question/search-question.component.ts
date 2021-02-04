import { Component, OnInit } from "@angular/core";
import { faSearch } from "@fortawesome/free-solid-svg-icons";

@Component({
  selector: "app-search-question",
  templateUrl: "./search-question.component.html",
  styleUrls: ["./search-question.component.scss"],
})
export class SearchQuestionComponent implements OnInit {
  faSearch = faSearch;

  constructor() {}

  ngOnInit(): void {}
}
