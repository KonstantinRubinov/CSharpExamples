import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { NgRedux } from 'ng2-redux';
import { Observable } from 'rxjs';
import { Driver } from '../models/driver';

import { Store } from '../redux/store';
import { Router } from '@angular/router';

import { ActionType } from '../redux/action-type';
import { Action } from '../redux/action';
import { environment } from 'src/environments/environment';

const httpOptions = {
  headers: new HttpHeaders(
      {'Content-Type': 'application/json'}
  )
};
@Injectable({
  providedIn: 'root'
})
export class DriversService {
    private env=environment;

  public constructor(private http: HttpClient, private redux:NgRedux<Store>, private router: Router) { }






  public getAllDrivers(): void {
    let observable = this.http.get<Driver[]>(this.env.driversUrl);
    observable.subscribe(drivers=>{
        const action: Action={type:ActionType.GetAllDrivers, payload:drivers};
        this.redux.dispatch(action);
    });
  }

  public getOneDriver(id: string): Observable<Driver> {
      return this.http.get<Driver>(this.env.driversUrl + id);
  }



  public addDriver(driver: Driver): void {
      let observable = this.http.post<Driver>(this.env.driversUrl, driver, httpOptions);
      observable.subscribe(product=>{
          const action: Action={type:ActionType.AddDriver, payload:driver};
          this.redux.dispatch(action);
      });
  }



  public deleteDriver(driver: Driver): void {
      let observable = this.http.delete<void>(this.env.driversUrl + driver.id, httpOptions);
      observable.subscribe(driver=>{
          const action: Action={type:ActionType.DeleteDriver, payload:driver};
          this.redux.dispatch(action);
          this.router.navigate(["/drivers"]);
      });
  }
}
