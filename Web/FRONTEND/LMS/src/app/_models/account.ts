import { Role } from "./role";

export class account{
    id : number;
    fname : string;
    mname : string;
    lname : string;
    photo? : string;
    email : string;
    gender : string;
    nationalID : string;
    phone_1 : string;
    phone_2? : string;
    relegion? : string;
    currentAddress? : string;
    permanentAddress? : string;
    passwordHash : string;
    role : Role;
    jwtToken? : string;

    natinality? : string;
    PDF_1? : string;
    PDF_2? : string;
    relationWithStudent? : string;

    addmitionDate? : Date;
    height? : string;
    weight? : string;
    bloodGroup? : string;
    addmitionNum? : string;

    /* Driver */
    licenseID? : string;


}