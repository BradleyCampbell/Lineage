import { Gender } from "./gender";
import { Relationship } from "./relationship";
import { ILifeEvent } from "../lifeevent/lifeEvent";
import { IAddress } from "../address/address";
import { IRelation } from "./Relation";

export interface IPerson {
    personId: string;
    title: string;
    firstName: string;
    lastName: string;
    suffix: string;
    maidenName: string;
    nickName: string;
    gender: Gender;
    birthDate: Date;
    deathDate: Date;
    relations: [IRelation];
    LifeEvents: [ILifeEvent];
    Addresses: [IAddress];
}