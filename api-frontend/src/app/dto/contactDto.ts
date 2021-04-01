import { Guid } from 'guid-typescript';

export interface ContactDto {
    id: Guid;
    accountName: string;
    firstName: string;
    lastName: string;
    phone: string;
}