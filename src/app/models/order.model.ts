export class Order {
    id: number;
    orderNo: string;
    orderDate: Date;
    deliveryDate: Date;
    customerId: number;
    balance: number;
    address: string;
    total: number;
    discount: number;
    discAmount: number;
    vat: number;
    vatAmount: number;
    netPayable: number;
    receiveAmount: number;
    dueAmount: number;
    note: string;
    paymentTypeId: number;
    paymentRef: string;
    status: number;
}
