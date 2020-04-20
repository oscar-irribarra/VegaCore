import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: "root",
})
export class VehicleService {
  httpOptions = {
    headers: new HttpHeaders({ "Content-Type": "application/json" }),
  };

  constructor(private http: HttpClient) {}

  getMakes() {
   return this.http.get("/api/makes", this.httpOptions).pipe(map((resp:[]) => resp));
  }

  getFeatures(){
    return this.http.get('/api/features', this.httpOptions).pipe(map((resp:[]) => resp));
  }
}

