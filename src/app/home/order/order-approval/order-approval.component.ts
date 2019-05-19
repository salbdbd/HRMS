import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { OrderViewModel } from '../../../models/order.view.model';
import { OrderService } from '../../../services/order.service';
import { NgbDateAdapter, NgbDateNativeAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { AppService } from '../../../app.service';

@Component({
  selector: 'app-order-approval',
  templateUrl: './order-approval.component.html',
  styleUrls: [
    '../../../../vendor/libs/ngx-toastr/ngx-toastr.scss',
  ],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
  encapsulation: ViewEncapsulation.None
})
export class OrderApprovalComponent implements OnInit {

  isRTL: boolean;

  searchKeys = ['customerName'];
  sortBy = 'orderNo';
  sortDesc = true;
  perPage = 10;

  filterVal = '';
  currentPage = 1;
  totalItems = 0;

  orders: OrderViewModel[] = [];
  originalOrders: OrderViewModel[] = [];

  constructor(private orderService: OrderService, private toastr: ToastrService, private appService: AppService) {
    appService.pageTitle = 'Order Approval';
  }

  ngOnInit() {
    this.loadData();
  }

  approve(id: number) {
    this.orderService.approve(id).subscribe(result => {
      if (result === true) {
        this.toastr.success('Order approved successfully');
        this.loadData();
      } else {
        this.toastr.error('Unable to approve the order!');
      }
    });
  }

  reject(id: number) {
    this.orderService.reject(id).subscribe(result => {
      if (result === true) {
        this.toastr.info('Order rejected successfully');
        this.loadData();
      } else {
        this.toastr.error('Unable to reject the order!');
      }
    });
  }

  changeStatus() {
    this.currentPage = 1;
    const data = this.filterStatu(this.originalOrders);
    this.totalItems = data.length;
    this.sort(data);
    this.orders = this.paginate(data);
  }

  filterStatu(data) {
    const filter = this.filterVal.toLowerCase();
    const keys = ['statusText'];
    return !filter ?
      data.slice(0) :
      data.filter(d => {
        return Object.keys(d)
          .filter(k => keys.includes(k))
          .map(k => String(d[k]))
          .join('|')
          .toLowerCase()
          .indexOf(filter) !== -1 || !filter;
      });
  }

  loadData() {

    this.orderService.orderApprove().subscribe(orders => {
      const data = orders as OrderViewModel[];
      this.originalOrders = data.slice(0);
      this.update();
    });
  }

  get totalPages() {
    return Math.ceil(this.totalItems / this.perPage);
  }

  update() {
    const data = this.filter(this.originalOrders);
    this.totalItems = data.length;
    this.sort(data);
    this.orders = this.paginate(data);
  }

  filter(data) {
    const filter = this.filterVal.toLowerCase();
    return !filter ?
      data.slice(0) :
      data.filter(d => {
        return Object.keys(d)
          .filter(k => this.searchKeys.includes(k))
          .map(k => String(d[k]))
          .join('|')
          .toLowerCase()
          .indexOf(filter) !== -1 || !filter;
      });
  }

  sort(data) {
    data.sort((a: any, b: any) => {
      a = typeof (a[this.sortBy]) === 'string' ? a[this.sortBy].toUpperCase() : a[this.sortBy];
      b = typeof (b[this.sortBy]) === 'string' ? b[this.sortBy].toUpperCase() : b[this.sortBy];

      if (a < b) { return this.sortDesc ? 1 : -1; }
      if (a > b) { return this.sortDesc ? -1 : 1; }
      return 0;
    });
  }

  paginate(data) {
    const perPage = parseInt(String(this.perPage), 10);
    const offset = (this.currentPage - 1) * perPage;

    return data.slice(offset, offset + perPage);
  }

  setSort(key) {
    if (this.sortBy !== key) {
      this.sortBy = key;
      this.sortDesc = false;
    } else {
      this.sortDesc = !this.sortDesc;
    }

    this.currentPage = 1;
    this.update();
  }
}
