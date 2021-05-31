import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SimpleTeam } from './structure'; 
@Injectable({
  providedIn: 'root'
})
export class FootballService {

  constructor(private httpClient: HttpClient) { }

  public GetSimpleTeams(): Observable<SimpleTeam[]> { 
    return this.httpClient.get<SimpleTeam[]>('/api/Football/SimpleTeams');
  }
}
