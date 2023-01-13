import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent {
  public imgRobot = 'https://firebasestorage.googleapis.com/v0/b/tech-website-59d72.appspot.com/o/images%2Ficons%2Frobot-96.png?alt=media&token=1ee33149-ecd8-44dd-a3a8-a1ef4e84613e';
  public imgConversation = 'https://firebasestorage.googleapis.com/v0/b/tech-website-59d72.appspot.com/o/images%2Ficons%2Fcommunication-96.png?alt=media&token=b4ab856d-f23e-428c-bc1c-30da67f95bd7';
  public imgClose = 'https://firebasestorage.googleapis.com/v0/b/tech-website-59d72.appspot.com/o/images%2Ficons%2Fclose-96-p2.png?alt=media&token=a1dde398-4aff-4d53-8176-684b6695e2ea';

  // Server communications
  public conversation: MessageSimple[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<MessageSimple[]>(baseUrl + 'message').subscribe(result => {

      console.log('result', result)
      this.conversation = result;
    }, error => console.error(error));
  }
}

type MessageSimple = Omit<Message, 'TransmitterId' | 'ReceiverId'> 

interface Message {
  TransmitterId: string;
  TransmitterName: string;
  ReceiverId: string;
  ReceiverName: string;
  Content: string;
  Timestamp: number;
}