import { Component, Inject } from '@angular/core';
import { IEmployee } from '../../Entities/IEmployee';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';

import { ApiService } from '../../Services/api';


@Component({
  selector: 'app-empform-component',
  templateUrl: './empform.component.html'
})
export class EmpFormComponent {

  public employee = {} as IEmployee;
  public strSSN: string = '';
  public strFName: string = '';
  public strLName: string = '';
  public url;
  public isUpdated;

  public EmpId: number;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router, private route: ActivatedRoute, private apiService: ApiService) {
    this.url = baseUrl;
  }



  ngOnInit() {

    this.route.queryParams.subscribe(emp => {
      this.isUpdated = (emp.ssn != undefined && emp.ssn.length > 0);

      this.strSSN = emp.ssn;
      this.strFName = emp.fName;
      this.strLName = emp.lName;
    });
  }




  public saveNewEmp(): void {

    this.employee.SSN = this.strSSN;
    this.employee.FName = this.strFName;
    this.employee.LName = this.strLName;

    this.setNewEmployee(this.employee);
  }



  private setNewEmployee(newEmployee: IEmployee): void {
    this.apiService.setEmployee(newEmployee).subscribe(result => {
      this.apiService.Employees = result;
      this.router.navigate(['/']);
    }, error => console.error(error));

    /*
    this.http.get(this.url + 'api/Employee/SetEmployee/' + JSON.stringify(newEmployee)).subscribe(result => {
    console.log(result);
    this.router.navigate(['/']);
    }, error => console.error(error));
    */
  }

  

}


