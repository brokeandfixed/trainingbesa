import { Injectable } from '@angular/core';
import { ContactDto } from './dto/contactDto';
import { CONTACTS } from './mock-data/mockContactDto';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ContactsService {

  private contactsUrl = 'http://localhost:33262/api/contacts';

  getContacts(): Observable<ContactDto[]> {
    const contacts = of(CONTACTS);
    return this.http.get<ContactDto[]>(this.contactsUrl);
  }

  constructor(private http: HttpClient) { }
}
