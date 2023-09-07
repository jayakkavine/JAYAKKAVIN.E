import { Component } from '@angular/core';
import { FundserviceService } from '../fundservice.service';

@Component({
  selector: 'app-fundsdisplay',
  templateUrl: './fundsdisplay.component.html',
  styleUrls: ['./fundsdisplay.component.css']
})
export class FundsdisplayComponent  {
  page: number = 1;
  count: number = 0;
  tableSize: number = 20;
  tableSizes: any = [3, 6, 9, 12];
  constructor(private fundservice:FundserviceService){}
  public funddetails:any[]=[];
  ngOnInit():void{
    this.fund();
  }
  public fund():void{
    this.fundservice.displayfund().subscribe((result:any)=>
      {
        this.funddetails=result.slice(0,100);
        console.log(this.funddetails);
      }

      )
  }
  onTableDataChange(event: any) {
    this.page = event;
  }
  onTableSizeChange(event: any): void {
    this.tableSize = event.target.value;
    this.page = 1;
  }

}
