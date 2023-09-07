import { Component, OnInit } from '@angular/core';
import { FundserviceService } from '../fundservice.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-funddetails',
  templateUrl: './funddetails.component.html',
  styleUrls: ['./funddetails.component.css']
})
export class FunddetailsComponent  {
  page: number = 1;
  count: number = 0;
  tableSize: number = 20;
  tableSizes: any = [3, 6, 9, 12];
  constructor(private fundservice:FundserviceService,private router:ActivatedRoute){}
  public schemeCode:number=this.router.snapshot.params['schemeCode']
  public spfund:any;
  ngOnInit():void{
    this.fund();
  }
  public fund(){
    this.fundservice.displayspfund(this.schemeCode
      ).subscribe(result=>this.spfund=result);

      
  }
  onTableDataChange(event: any) {
    this.page = event;
  }
  onTableSizeChange(event: any): void {
    this.tableSize = event.target.value;
    this.page = 1;
  }
}
