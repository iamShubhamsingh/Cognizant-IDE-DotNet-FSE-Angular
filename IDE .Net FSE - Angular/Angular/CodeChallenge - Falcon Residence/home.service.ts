import { Injectable } from '@angular/core';
import { Home } from './home';
@Injectable({
  providedIn: 'root'
})
export class HomeService {
 homeList:Array<any>=[];
 newHomeList:Array<any>=[];

  constructor() { }

  register(obj:Home){
   // fill the code
   this.homeList.push(obj);
    
  }
   
search(searchHomeType:string,searchLocation:string){
  //fill the code
  for(let home of this.homeList)
  {
      if(home.homeType == searchHomeType && home.location == searchLocation)
      {
          this.newHomeList.push(home);
      }
  }
  return this.newHomeList;
}
  
}
