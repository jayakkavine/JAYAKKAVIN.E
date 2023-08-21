import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css'],
})
export class ServersComponent {
  serverId: number = 1001;
  serverStatus: string = 'Offline';

  addNewServer: boolean = false;

  serverCreated: string = 'Not Yet';

  serverName: string = '';

  serverList =['SQl','Oracle', 'C#'];

  serverNumbers = [101, 102, 103];

  // onServerNameEntry(event:Event)
  // {
  //   console.log(event);
  //   this.serverName = (<HTMLInputElement>event.target).value;
  // }

  constructor() {
    setTimeout(() => {
      this.addNewServer = true;
    }, 5000);

    
  }

  getColor()
  {
    this.serverStatus = Math.random() > 0.5 ? 'Online' : 'Offline';
    return this.serverStatus == 'Online' ? 'green' : 'red';
  }


  onServerCreation() {
    this.serverCreated = 'Created';
    this.serverList.push(this.serverName);
  }

  getServerId() {
    return this.serverId;
  }

  getServerStatus() {
    return this.serverStatus;
  }
}
