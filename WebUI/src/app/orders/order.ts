import { OrderItem } from "./orderItem";

export interface Order {
  id: number;
  number: string;
  date: Date;
  providerId: number;
  items: OrderItem[];
}
