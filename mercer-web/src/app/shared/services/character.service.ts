import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable()
export class CharacterService {

  apiUrl = environment.apiUrl;
  constructor(private httpClient: HttpClient) { }

  public getCharacterById(id: number) {
    this.httpClient.get(`${this.apiUrl}/character/${id}`);
  }
}
