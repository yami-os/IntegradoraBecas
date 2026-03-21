import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AdministradorModel } from "../models/AdministradorModel";

@Injectable({
  providedIn: 'root',
})
export class AdministradorService {
  private apiUrl = 'https://localhost:7282/api/Administrador';

  constructor(private http: HttpClient) {}

  get_Administrador() {
    return this.http.get<AdministradorModel[]>(this.apiUrl);
  }
}