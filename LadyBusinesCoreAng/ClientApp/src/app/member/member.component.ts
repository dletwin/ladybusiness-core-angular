import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-member',
  templateUrl: './member.component.html',
  styleUrls: ['./member.component.css']
})
export class MemberComponent {

  public members: Member[];


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    const finalApi: string = (baseUrl + 'api/member');
    console.log(finalApi);

    http.get<Member[]>(baseUrl + 'api/member').subscribe(result => {
      this.members = result;
    }, error => console.error(error));
  }
}


interface Member {
  fname: string;
  nickname: string;
  summary: string;
  imagefile: string;
  specialguest: string;
}