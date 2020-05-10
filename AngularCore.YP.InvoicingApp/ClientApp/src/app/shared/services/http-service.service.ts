import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { map, catchError } from "rxjs/operators";
import { Observable } from "rxjs";

@Injectable(
)
export class HttpService {
  private baseUrl: string;
  constructor(private _http: HttpClient) {
    this.baseUrl = document.getElementsByTagName('base')[0].href;
  }
  private handleError(error: Response) {
    return Observable.throw(error.statusText);
  }
  get(url: string): Observable<Object[]> {
    var data = this._http.get(this.baseUrl + url)
      .pipe(map((response) => {
        return <Object[]>response;
      })).pipe(catchError(this.handleError));
    return data;
  }
  post(url:string,data:any):Observable<any>{
    var obs = this._http.post(this.baseUrl+url,data)
    .pipe(map(response=>{
      return response;
    }))
    .pipe(catchError(this.handleError))
    return obs;
  }
}
