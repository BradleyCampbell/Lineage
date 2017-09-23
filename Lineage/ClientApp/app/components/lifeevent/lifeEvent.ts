import { EventType } from "./EventType";
import { IAddress } from "../address/address";
import { IPerson } from "../person/person";

export interface ILifeEvent {
    lifeEventId: string;
    occurredOn: Date;
    eventType: EventType;
    name: string;
    description: string;
    place: IAddress;
    participants: IPerson[];
}