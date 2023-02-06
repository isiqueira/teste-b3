import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CdbRequestsService {

  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json; charset=utf-8'
    })
  };

  constructor(private http: HttpClient) {

   }

  calculaCdb(data:any): Observable<any> {
    return this.http.post<any>('https://localhost:7274/cdb', JSON.stringify(data), this.httpOptions );
  }

    

}
