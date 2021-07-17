import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';

import { IEmployee } from '../../Entities/IEmployee';
import { ApiService } from '../../Services/api';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public employees: IEmployee[];
  public url;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router, private route: ActivatedRoute, private apiService: ApiService)
  {
    this.url = baseUrl;
  }


  ngOnInit() {
    if (this.apiService.Employees === undefined) {
      this.getEmployees();
    }
    else {
      //
    }
  }

  public updateEmp(emp): void {
    this.router.navigate(['/empform'], { queryParams: emp });
  }

  public addEmp(): void {
    this.router.navigate(['/empform']);
  }

  public deleteEmp(emp): void {
    this.apiService.deleteEmployee(emp).subscribe(result => {
      this.apiService.Employees = result;
    }, error => console.error(error));
  }

  public getEmployees() {
    this.apiService.getAllEmployees().subscribe(result => {
      this.apiService.Employees = result;
    }, error => console.error(error));
  }

  

}
