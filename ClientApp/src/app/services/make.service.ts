import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { map } from "rxjs/operators";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class MakeService {
  httpOptions = {
    headers: new HttpHeaders({ "Content-Type": "application/json" }),
  };

  constructor(private http: HttpClient) {}

  getMakes() {
   return this.http.get("/api/makes", this.httpOptions).pipe(map((resp:[]) => resp));
  }
}

interface make {
  id: number;
  name: string;
}
