import { Component, OnInit} from '@angular/core';
import { HttpClient } from '@angular/common/http';
interface Products{
      name:string;
      category:string;
      price:number;
      picture:string;
    }
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: false,
  styleUrl: './app.component.css'
})

export class AppComponent implements OnInit {
  title = 'Shopping';
  
 results: Products[] = [];
//  cart=[];
//  addToCart=function(item){
//   alert(item.name + " was added to cart for $" + item.price);
//   cart.push(item);
//  }
cart: any[] = [];

  addToCart(item: any): void {
    alert(`${item.name} was added to cart for $${item.price}`);
    this.cart.push(item);
  }
  constructor(private http:HttpClient){

  }
  ngOnInit(): void {
    
    this.http.get<Products[]>('https://localhost:7265/api/Products').subscribe(data => {
      this.results= data;
    })
  }
}
