import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Order } from '../models/order.model';
import { OrderItem } from '../models/order.item.model';
import { OrderViewModel } from '../models/order.view.model';


@Injectable({
  providedIn: 'root'
})

export class OrderService {
  getOrder(orderId) {
    const orderFetchUrl = environment.apiUrl + '/order/fetch';
    const body = new HttpParams().set('orderId', orderId);
    return this.http.get<OrderViewModel>(orderFetchUrl, { params: body });
  }

  approve(id) {
    const orderApproveUrl = environment.apiUrl + '/order/approve';
    const body = new HttpParams().set('orderId', id);
    return this.http.post(orderApproveUrl, body);
  }

  reject(id) {
    const orderRejectlUrl = environment.apiUrl + '/order/reject';
    const body = new HttpParams().set('orderId', id);
    return this.http.post(orderRejectlUrl, body);
  }

  orderApprove() {
    const orderApproveUrl = environment.apiUrl + '/order/approvable';
    return this.http.get(orderApproveUrl);
  }

  customer() {
    const customerUrl = environment.apiUrl + '/order/customer';
    return this.http.get(customerUrl);
  }

  orderItem() {
    const itemsUrl = environment.apiUrl + '/order/items';
    return this.http.get(itemsUrl);
  }

  paymentType() {
    const methodUrl = environment.apiUrl + '/order/method';
    return this.http.get(methodUrl);
  }

  orders(fromDate: Date, toDate: Date, customerId: number) {
    const ordersUrl = environment.apiUrl + '/order/orders';
    const body = new HttpParams()
      .set('fromDate', fromDate.toLocaleDateString())
      .set('toDate', toDate.toLocaleDateString())
      .set('customerId', customerId.toString());

    return this.http.get(ordersUrl, { params: body });
  }


  constructor(private http: HttpClient) { }

  public nextOrderNo() {
    const nextUrl = environment.apiUrl + '/order/next';
    return this.http.get(nextUrl);
  }

  public place(order: Order, items: OrderItem[]) {
    const orderUrl = environment.apiUrl + '/order/place';
    const body = {
      ...order,
      Items: items
    };
    return this.http.post(orderUrl, body);
  }

}
