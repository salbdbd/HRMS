import { Order } from './order.model';
import { OrderItem } from './order.item.model';

export class OrderViewModel extends Order {
    customerName: string;
    statusText: string;
    items: OrderItem[];
}
