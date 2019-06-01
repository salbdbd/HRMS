import { Component, OnInit } from '@angular/core';
import { Pagination } from '../../../shared/paginate';

@Component({
  selector: 'app-encashment-payment',
  templateUrl: './encashment-payment.component.html',
  styleUrls: ['./encashment-payment.component.scss']
})
export class EncashmentPaymentComponent extends Pagination implements OnInit {

  constructor() {
    super();
  }
  title="Leave Encashment Payment"
  ngOnInit() {
    this.items=[];
    this.update();
  }

}
