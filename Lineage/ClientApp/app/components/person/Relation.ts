import { IPerson } from "./person";
import { Relationship } from "./relationship";

export interface IRelation {
    relationship: Relationship;
    person: IPerson;
}