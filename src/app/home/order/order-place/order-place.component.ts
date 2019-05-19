
import { Component, ViewEncapsulation, ElementRef, ViewChild, OnInit } from '@angular/core';
import { NgbModal, NgbDateAdapter, NgbDateNativeAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { OrderItem } from '../../../models/order.item.model';
import { Order } from '../../../models/order.model';
import { debounceTime, distinctUntilChanged, map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { OrderService } from '../../../services/order.service';
import { NgBlockUI, BlockUI } from 'ng-block-ui';
import { Customer } from '../../../models/customer.model';
import { PaymentType } from '../../../models/payment.type.model';
import { AppService } from '../../../app.service';

@Component({
  selector: 'app-order-place',
  templateUrl: './order-place.component.html',
  styleUrls: [
    '../../../../vendor/libs/ngx-toastr/ngx-toastr.scss',
    '../../../../vendor/libs/ngx-sweetalert2/ngx-sweetalert2.scss',
    '../../../../vendor/libs/angular2-ladda/angular2-ladda.scss',
    '../../../../vendor/libs/spinkit/spinkit.scss',
    './order-place.component.scss'
  ],
  providers: [{ provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
  encapsulation: ViewEncapsulation.None
})
export class OrderPlaceComponent implements OnInit {

  @BlockUI() blockUIPage: NgBlockUI;
  @ViewChild('customer') private customerField: ElementRef;

  editable = false;
  processingText: string;

  searchModel: any;
  customerModel: any;

  order: Order;
  items: OrderItem[] = [];
  item: OrderItem = new OrderItem();

  selectedIndex = -1;
  searchCustomers: Customer[] = [];
  searchItems: OrderItem[] = [];

  paymentTypes: PaymentType[];

// tslint:disable-next-line: max-line-length
  constructor(private orderService: OrderService, private modalService: NgbModal, public toastr: ToastrService, private appService: AppService) {
    appService.pageTitle = 'Order Approval';
    this.newOrder();
    this.newItem();
    this.nextOrderNo();

    const orderId = sessionStorage.getItem('orderId');
    if (orderId) {
      sessionStorage.removeItem('orderId');
      this.editable = true;
      this.loadOrder(orderId);
    }
  }
  loadOrder(orderId) {
    this.orderService.getOrder(orderId).subscribe(data => {
      this.order = data;
      this.items = data.items;
      const customer = new Customer();
      customer.customerId = data.customerId;
      customer.name = data.customerName;
      this.customerModel = customer;
      this.order.orderDate = data.orderDate;
      this.order.deliveryDate = data.deliveryDate;
    });
  }

  ngOnInit(): void {
    this.customerField.nativeElement.focus();
    this.loadPaymentType();
  }

  loadPaymentType() {
    this.orderService.paymentType().subscribe(types => this.paymentTypes = types as PaymentType[]);
  }

  nextOrderNo() {
    this.orderService.nextOrderNo().subscribe(nextNo => {
      this.order.orderNo = nextNo.toString();
    });
  }

  addOrderItem() {
    this.modalService.dismissAll();
    this.item.discAmount = this.percentAmount(this.item.amount, this.item.discount);
    this.item.netAmount = this.item.amount - this.item.discAmount;

    if (this.items[this.selectedIndex]) {
      this.items[this.selectedIndex].itemCode = this.item.itemCode;
      this.items[this.selectedIndex].description = this.item.description;
      this.items[this.selectedIndex].qty = this.item.qty;
      this.items[this.selectedIndex].price = this.item.price;
      this.items[this.selectedIndex].amount = this.item.amount;
      this.items[this.selectedIndex].discount = this.item.discount;
      this.items[this.selectedIndex].discAmount = this.item.discAmount;
      this.items[this.selectedIndex].netAmount = this.item.netAmount;
    } else {
      this.items.push(this.item);
    }
    this.selectedIndex = -1;
    this.newItem();
    this.calculate();
  }

  percentAmount(amount: number, percent: number) {
    return (amount * percent) / 100;
  }

  calcPrice() {
    this.item.amount = this.item.qty * this.item.price;
  }

  editOrderItem(index: number, diag) {
    this.item = this.items[index];
    this.selectedIndex = index;
    this.open(diag);
  }

  addNextOrderItem() {

    this.item.discAmount = this.percentAmount(this.item.amount, this.item.discount);
    this.item.netAmount = this.item.amount - this.item.discAmount;

    if (this.items[this.selectedIndex]) {
      this.items[this.selectedIndex].itemCode = this.item.itemCode;
      this.items[this.selectedIndex].description = this.item.description;
      this.items[this.selectedIndex].qty = this.item.qty;
      this.items[this.selectedIndex].price = this.item.price;
      this.items[this.selectedIndex].amount = this.item.amount;
      this.items[this.selectedIndex].discount = this.item.discount;
      this.items[this.selectedIndex].discAmount = this.item.discAmount;
      this.items[this.selectedIndex].netAmount = this.item.netAmount;
    } else {
      this.items.push(this.item);
    }

    this.selectedIndex = -1;
    this.newItem();
    this.calculate();
  }

  removeOrderItem(index: number) {
    this.items.splice(index, 1);
    this.calculate();
  }

  calculate() {

    let total = 0;
    let discount = 0;
    let discAmount = 0;

    for (let i = 0; i < this.items.length; i++) {
      total += this.items[i].netAmount;
      discount += this.items[i].discount;
      discAmount += this.items[i].discAmount;
    }

    this.order.total = total;
    this.order.discount = discount;
    this.order.discAmount = discAmount;
    this.order.netPayable = total - discAmount;
    this.order.vat = 0;
    this.order.vatAmount = 0;
    this.order.receiveAmount = 0;
    this.order.dueAmount = 0;
    this.order.paymentTypeId = 1;
    this.searchModel = null;
  }

  cancelOrderItem() {
    this.modalService.dismissAll();
    this.newItem();
  }

  itemSelected(e) {
    this.item.itemCode = e.item.itemCode;
    this.item.description = e.item.description;
    this.item.price = e.item.price;
    this.item.amount = this.item.qty * this.item.price;
    this.item.discount = e.item.discount;
  }

  addItem(diag) {
    this.open(diag);
  }

  placeOrder(diag) {
    this.open(diag);
  }

  confirmOrder() {
    this.modalService.dismissAll();
    this.processingText = 'SUBMITTING...';
    this.blockUIPage.start();
    this.order.status = 0;

    this.orderService.place(this.order, this.items).subscribe(result => {
      if (result === true) {
        this.resetOrder();
        this.blockUIPage.stop();
        this.toastr.success('Order placed successfully');
      } else {
        this.blockUIPage.stop();
        this.toastr.error('Unable to place the order!');
      }
    });
  }

  draftOrder() {

    this.processingText = 'DRAFTING...';
    this.blockUIPage.start();
    this.order.status = -1;
    this.orderService.place(this.order, this.items).subscribe(result => {
      if (result === true) {
        this.resetOrder();
        this.blockUIPage.stop();
        this.toastr.info('Order drafted successfully');
      } else {
        this.blockUIPage.stop();
        this.toastr.error('Unable to draft the order!');
      }
    });
  }

  resetOrder() {
    this.items = [];
    this.newItem();
    this.newOrder();
    this.nextOrderNo();
    this.selectedIndex = -1;
    this.customerModel = null;
    this.customerField.nativeElement.focus();
  }
  private newOrder() {
    this.order = new Order();
    this.order.customerId = 0;
    this.order.total = 0;
    this.order.balance = 0;
    this.order.orderDate = new Date;
    this.order.deliveryDate = new Date;
  }

  private newItem() {
    this.item = new OrderItem();
    this.item.price = 0;
    this.item.qty = 0;
    this.item.amount = 0;
    this.item.discount = 0;
    this.item.discAmount = 0;
    this.item.netAmount = 0;
  }
  getItems(): OrderItem[] {

    this.orderService.orderItem().subscribe(data => {
      this.searchItems = data as OrderItem[];
    });
    return this.searchItems;
  }

  getCustomer(): Customer[] {
    this.orderService.customer().subscribe(data => {
      this.searchCustomers = data as Customer[];
    });
    this.order.customerId = 0;
    return this.searchCustomers;
  }

  open(content) {
    this.modalService.open(content);

  }

  searchItem = (text$: Observable<string>) =>
    text$.pipe(
      debounceTime(200),
      distinctUntilChanged(),
      map(term => term === '' ? []
        : this.getItems().filter(v => v.itemCode.toLowerCase().indexOf(term.toLowerCase()) > -1).slice(0, 10))
    )

  formatter = (x: { itemCode: string }) => x.itemCode;

  searchCustomer = (text$: Observable<string>) =>
    text$.pipe(
      debounceTime(200),
      distinctUntilChanged(),
      map(term => term === '' ? []
        : this.getCustomer().filter(v => v.name.toLowerCase().indexOf(term.toLowerCase()) > -1).slice(0, 10))
    )

  customerFormatter = (x: { name: string }) => x.name;

  customerSelected(e) {
    this.order.customerId = e.item.customerId;
    this.order.address = e.item.address;
    this.order.balance = e.item.balance;
  }
}
