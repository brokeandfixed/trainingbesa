import { Component, OnInit } from '@angular/core';
import { ContactDto } from '../dto/contactDto';
import { Guid } from 'guid-typescript';
import { CONTACTS } from '../mock-data/mockContactDto';
import { ContactsService } from '../contacts.service';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styleUrls: ['./contacts.component.css']
})
export class ContactsComponent implements OnInit {

  contacts: ContactDto[] = [];

  getContacts(): void {
    this.contactsService.getContacts()
      .subscribe(contacts => this.contacts = contacts);
  }

  constructor(private contactsService: ContactsService) { }

  ngOnInit(): void {
    this.getContacts();
  }

}
