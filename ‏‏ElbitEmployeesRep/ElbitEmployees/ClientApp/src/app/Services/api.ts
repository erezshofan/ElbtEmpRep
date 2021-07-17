import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private url;

  public Employees;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
  }

  getAllEmployees(): Observable<any> {
    return this.http.get(this.url + 'api/Employee/GetEmployees');
  }

  deleteEmployee(emp): Observable<any> {
    return this.http.get(this.url + 'api/Employee/deleteEmployee/' + JSON.stringify(emp));
  }

  setEmployee(emp): Observable<any> {
    return this.http.get(this.url + 'api/Employee/SetEmployee/' + JSON.stringify(emp));
  }

  /*
    public Get<T>(postFixUrl: string): Promise<T> {
        return this.http.get(this.baseUrl + postFixUrl).map(res => {
            return res.json() as T;
        }).toPromise();
    }
    }

*/
    
    
}
