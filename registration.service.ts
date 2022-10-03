import { Injectable } from '@angular/core';
import{HttpClient, HttpClientModule, HttpErrorResponse, HttpHeaders} from '@angular/common/http';
import { catchError, Observable, throwError } from 'rxjs';
import { Registration } from 'src/Models/Registration';

@Injectable({
  providedIn: 'root'
})
export class RegisterationService {
  url:string="https://localhost:44311/api/registration";
  formData:Registration
  constructor(private http:HttpClient) { }
  httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };
  postuser(formData:Registration):Observable<any>
  {
    return this.http.post<any>(this.url,formData,this.httpOptions).pipe(catchError(this.HandleError));
    
  }
  HandleError(error:HttpErrorResponse){
    let errorMessage="";
    errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
    alert(errorMessage);
    return throwError(errorMessage);  
  }
}
