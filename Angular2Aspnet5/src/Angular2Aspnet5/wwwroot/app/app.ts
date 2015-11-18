import {Component, View, Query} from 'angular2/angular2';

@Component({
    selector: 'app'
})
@View({
    template: `
    {{name}}
  `
})
export class App {
    name: string;
    constructor() {
        this.name = 'Alice';
    }
}