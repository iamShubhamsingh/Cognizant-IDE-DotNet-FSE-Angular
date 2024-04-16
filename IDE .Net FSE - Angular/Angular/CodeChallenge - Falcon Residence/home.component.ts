import { VariableAst } from '@angular/compiler';
import { Component, OnInit, Input,  } from '@angular/core';
import {Router} from '@angular/router';
import { Home } from '../home';
import { ActivatedRoute } from '@angular/router';
import { HomeService } from '../home.service';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
    
    flag = "1";
    homeArray: Array<any> = [];
    
  constructor(private homeService: HomeService,private router: Router,private _Activatedroute:ActivatedRoute) { }
  @Input() home:Home=new Home('','','',0);
  
  
  ngOnInit(): void {

    // fill the code
    this._Activatedroute.queryParams.subscribe(params => { this.flag = params['flag'] });
  }

  register(){
    //fill the code
    this.homeService.register(this.home);
  }

  search(){
    // fill the code
    this.homeArray = this.homeService.search(this.home.homeType, this.home.location);
  }
}
	 	  	  	 			  	   	 	
