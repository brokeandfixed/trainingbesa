import { ContactDto } from '../dto/contactDto';
import { Guid } from 'guid-typescript';

export const CONTACTS: ContactDto[] = [
    { id: Guid.create(), accountName: 'Premier Tech', firstName: 'Patricia', lastName: 'Tremblay', phone: '450 123-4567' },
    { id: Guid.create(), accountName: 'Horticulture', firstName: 'Helène', lastName: 'Artémis', phone: '462 231-4236' },
    { id: Guid.create(), accountName: 'Systèmes Automatises', firstName: 'Sophia', lastName: 'Atlante', phone: '520 366-7723' },
    { id: Guid.create(), accountName: 'Systèmes H20', firstName: 'Shellsea', lastName: 'Haha', phone: '534 177-3324' }
]