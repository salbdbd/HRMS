import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { OrderViewModel } from '../../../models/order.view.model';
import { OrderService } from '../../../services/order.service';
import { NgbDateAdapter, NgbDateNativeAdapter } from '@ng-bootstrap/ng-bootstrap';
import { Customer } from '../../../models/customer.model';
import { Observable } from 'rxjs';
import { debounceTime, distinctUntilChanged, map } from 'rxjs/operators';
import { Router } from '@angular/router';
import { AppService } from '../../../app.service';


@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss',
  '../../../../vendor/libs/ngx-sweetalert2/ngx-sweetalert2.scss'
],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
  encapsulation: ViewEncapsulation.None
})
export class OrderListComponent implements OnInit {

  isRTL: boolean;

  fromDate: Date;
  toDate: Date;
  customerId = 0;
  customerModel: Customer;

  // Options
  searchKeys = ['customerName'];
  sortBy = 'orderNo';
  sortDesc = true;
  perPage = 10;

  filterVal = '';
  currentPage = 1;
  totalItems = 0;

  orders: OrderViewModel[] = [];
  originalOrders: OrderViewModel[] = [];
  searchCustomers: Customer[] = [];

  constructor(private orderService: OrderService, private router: Router, private appService: AppService) {
    appService.pageTitle = 'Order List';
  }

  ngOnInit() {
    this.fromDate = new Date;
    this.toDate = new Date;
    this.loadData();
  }


  edit(orderId) {
    sessionStorage.setItem('orderId', orderId);
    this.router.navigate(['order/order-place']);

  }

  show() {
    if (!this.customerModel) {
      this.customerId = 0;
    }

    this.loadData();
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

    this.orderService.orders(this.fromDate, this.toDate, this.customerId).subscribe(orders => {
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

  getCustomer(): Customer[] {
    this.orderService.customer().subscribe(data => {
      this.searchCustomers = data as Customer[];
    });
    return this.searchCustomers;
  }

  searchCustomer = (text$: Observable<string>) =>
    text$.pipe(
      debounceTime(200),
      distinctUntilChanged(),
      map(term => term === '' ? []
        : this.getCustomer().filter(v => v.name.toLowerCase().indexOf(term.toLowerCase()) > -1).slice(0, 10))
    )

  customerFormatter = (x: { name: string }) => x.name;

  customerSelected(e) {
    this.customerId = e.item.customerId;
  }
}
